using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;

namespace LNS.ServicesManageTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region 事件
        private void Main_Load(object sender, EventArgs e)
        {
            WaitForm.ShowWaite(PublicDim.WaitString);
            //加载服务列表
            LoadServiceList();
            WaitForm.InvokCloseWait(this);
            //加载配置信息
            try
            {
                LoadDBConfig();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,
                PublicDim.SystemCatpion, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btStartAll_Click(object sender, EventArgs e)
        {
            WaitForm.ShowWaite(PublicDim.WaitString);
            int iCount = 0;
            foreach (DataGridViewRow dgvr in dgvServiceList.Rows)
            {
                if (PublicDim.StartService(dgvr.Cells["ServiceName"].Value.ToString()))
                {
                    iCount++;
                    dgvr.Cells["ServiceState"].Value = PublicDim.StartCatpion;
                    dgvr.Cells["ColStart"].Value = PublicDim.StopCatpion;
                }
            }
            WaitForm.InvokCloseWait(this);
            MessageBox.Show(String.Format("已成功启动{0}项服务！", iCount), 
                PublicDim.SystemCatpion, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btStopAll_Click(object sender, EventArgs e)
        {
            WaitForm.ShowWaite(PublicDim.WaitString);
            int iCount = 0;
            foreach (DataGridViewRow dgvr in dgvServiceList.Rows)
            {
                if (!String.IsNullOrEmpty(dgvr.Cells["ServiceName"].Value as String))
                {
                    if (PublicDim.StopService(dgvr.Cells["ServiceName"].Value.ToString()))
                    {
                        iCount++;
                        dgvr.Cells["ServiceState"].Value = PublicDim.StopCatpion;
                        dgvr.Cells["ColStart"].Value = PublicDim.StartCatpion;
                    }
                }
            }
            WaitForm.InvokCloseWait(this);
            MessageBox.Show(
                String.Format("已成功停止{0}项服务！", iCount)
                , PublicDim.SystemCatpion
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }

        private void dgvServiceList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvServiceList.Columns[e.ColumnIndex].Name.Equals("ColStart"))
            {
                if (!String.IsNullOrEmpty(dgvServiceList.Rows[e.RowIndex].Cells["ServiceName"].Value as String))
                {
                    if (PublicDim.StartCatpion.Equals(dgvServiceList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as String))
                    {
                        if (PublicDim.StartService(dgvServiceList.Rows[e.RowIndex].Cells["ServiceName"].Value as String))
                        {
                            dgvServiceList.Rows[e.RowIndex].Cells["ServiceState"].Value = PublicDim.StartCatpion;
                            dgvServiceList.Rows[e.RowIndex].Cells["ColStart"].Value = PublicDim.StopCatpion;
                            MessageBox.Show(
                                String.Format("启动服务{0}成功！", dgvServiceList.Rows[e.RowIndex].Cells["ServiceName"].Value as String)
                                , PublicDim.SystemCatpion
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(
                                String.Format("启动服务{0}失败！", dgvServiceList.Rows[e.RowIndex].Cells["ServiceName"].Value as String)
                                , PublicDim.SystemCatpion
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (PublicDim.StopService(dgvServiceList.Rows[e.RowIndex].Cells["ServiceName"].Value as String))
                        {
                            dgvServiceList.Rows[e.RowIndex].Cells["ServiceState"].Value = PublicDim.StopCatpion;
                            dgvServiceList.Rows[e.RowIndex].Cells["ColStart"].Value = PublicDim.StartCatpion;
                            MessageBox.Show(
                                String.Format("停止服务{0}成功！", dgvServiceList.Rows[e.RowIndex].Cells["ServiceName"].Value as String)
                                , PublicDim.SystemCatpion
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(
                                String.Format("停止服务{0}失败！", dgvServiceList.Rows[e.RowIndex].Cells["ServiceName"].Value as String)
                                , PublicDim.SystemCatpion
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                        }
                    }
                }
                
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (SaveDBConfig())
            {
                MessageBox.Show("数据库配置信息保存成功！",
                PublicDim.SystemCatpion, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 通用方法
        private void LoadServiceList()
        {
            dgvServiceList.Rows.Clear();

            //检索计算机上的所有服务
            ServiceController[] MyServices = ServiceController.GetServices();

            //将服务的名称添加到ListBox中
            foreach (ServiceController sc in MyServices)
            {
                if (!String.IsNullOrEmpty(sc.ServiceName) && sc.ServiceName.StartsWith("LNS"))
                {
                    int j = dgvServiceList.Rows.Add();
                    dgvServiceList.Rows[j].Cells["ServiceName"].Value = sc.ServiceName;

                    if (sc.Status == ServiceControllerStatus.Running)
                    {
                        dgvServiceList.Rows[j].Cells["ServiceState"].Value = PublicDim.StartCatpion;
                        dgvServiceList.Rows[j].Cells["ColStart"].Value = PublicDim.StopCatpion;
                    }
                    else
                    {
                        dgvServiceList.Rows[j].Cells["ServiceState"].Value = PublicDim.StopCatpion;
                        dgvServiceList.Rows[j].Cells["ColStart"].Value = PublicDim.StartCatpion;
                    }
                }
            }
        }

        private void LoadDBConfig()
        {
            tbServerName.Text = SystemDBConfig.GetConfigData("Host", "localhost");
            tbUserName.Text = SystemDBConfig.GetConfigData("UserID", String.Empty);
            tbUserPassword.Text = SystemDBConfig.GetConfigData("Password", String.Empty);
            tbDBName.Text = SystemDBConfig.GetConfigData("DataBase", String.Empty);
            try
            {
                nuDBPort.Value = Convert.ToDecimal(SystemDBConfig.GetConfigData("Port", 5432));
            }
            catch
            {
                nuDBPort.Value = 0;
            }
        }

        private bool SaveDBConfig()
        {
            if(String.IsNullOrEmpty(tbServerName.Text.Trim()))
            {
                MessageBox.Show("数据库服务地址不能为空!", 
                PublicDim.SystemCatpion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbServerName.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(tbUserName.Text.Trim()))
            {
                MessageBox.Show("用户名不能为空!",
                PublicDim.SystemCatpion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUserName.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(tbUserPassword.Text.Trim()))
            {
                MessageBox.Show("密码不能为空!",
                PublicDim.SystemCatpion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUserPassword.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(tbDBName.Text.Trim()))
            {
                MessageBox.Show("数据库名称不能为空!",
                PublicDim.SystemCatpion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbDBName.Focus();
                return false;
            }

            SystemDBConfig.WriteConfigData("Host", tbServerName.Text);
            SystemDBConfig.WriteConfigData("UserID", tbUserName.Text);
            SystemDBConfig.WriteConfigData("Password",tbUserPassword.Text);
            SystemDBConfig.WriteConfigData("DataBase",tbDBName.Text);
            SystemDBConfig.WriteConfigData("Port", nuDBPort.Value.ToString());
            return true;
        }
        #endregion
    }
}
