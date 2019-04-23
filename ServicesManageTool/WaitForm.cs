using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Drawing2D;

namespace LNS.ServicesManageTool
{
    public partial class WaitForm : Form
    {
        public delegate void ShowProgressDelegete();

        private static WaitForm frm = null;
        private static Thread th;

        private WaitForm()
        {
            InitializeComponent();
            this.lblMsg.Text = _title;
            this.lbl_Msg.Text = _msg;
            //this.pan_Msg.Visible = !String.IsNullOrEmpty(lbl_Msg.Text);
        }
        
        private static string title = "数据处理中，请耐心等待……";
        private static string _title  = title;
        private string _msg = string.Empty;

        /// <summary>
        /// 显示
        /// </summary>
        public static void ShowWaite()
        {
            th = new Thread(new ThreadStart(WaitForm.ShowProgress));
            th.Start();
            while (th.ThreadState != ThreadState.Running)
            {  
            }
        }

        /// <summary>
        /// 显示(自定义标题)
        /// </summary>
        /// <param name="title"></param>
        public static void ShowWaite(string title)
        {
            _title = title;
            th = new Thread(new ThreadStart(WaitForm.ShowProgress));
            th.Start();
            while (th.ThreadState != ThreadState.Running)
            {
                MessageBox.Show(Enum.GetName(typeof(ThreadState), th.ThreadState));
            }
            //MessageBox.Show(Enum.GetName(typeof(ThreadState), th.ThreadState));
        }

        /// <summary>
        /// 关闭等待
        /// </summary>
        /// <param name="frmMain"></param>
        public static void InvokCloseWait(Form frmMain)
        {
            frmMain.Invoke(new ShowProgressDelegete(WaitForm.CloseProgress));
        }

        /// <summary>
        /// 改变动态消息
        /// </summary>
        /// <param name="frmMain"></param>
        /// <param name="msg"></param>
        public static void ChangeMsg(Form frmMain, string msg)
        {
            if (!(frm == null || frm.IsDisposed))
            {
                frm._msg = msg;
                frmMain.Invoke(new ShowProgressDelegete(WaitForm.ChangeLbl));
            }
            
        }


        //改变消息方法(当一个显示的操作周期很长时使用)
        private static void ChangeLbl()
        {
            while (frm == null)//如果窗体还没有实例化，等待实例化
            {
                th.Join();
            }
            if (!(frm == null || frm.IsDisposed))
            {
                frm.lbl_Msg.Text = frm._msg;
            }
        }

        //显示等待方法
        private static void ShowProgress()
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new WaitForm();
                frm.ShowDialog();
            }
            else
            {
                frm.ShowDialog();
            }
        }

        //关闭等待方法
        private static void CloseProgress()
        {
            /*
             * 问题：
             * 主线程瞬间执行完毕，子线程虽然已经启动，
             * 但是还没来得及实例化frm，主线程就调用此方法,此时毫无意义，
             * 而调用了此方法之后，没有终止子线程，子线程又把frm实例化给showdialog，
             * 此时丫的就悲催了，无线等待，永远不会关闭了，
             * 解决办法：
             * 把子线程实例提取出来，关闭方法改为终止子线程，
             * 直接枪毙了它，让他丫的给我嚣张，（别忘了初始化）
             */ 
            ////[Method 2012-12-21 11:00:02][Bug Method]
            //if (!(frm == null || frm.IsDisposed))
            //{
            //    frm.Close();
            //}

            //[Method Method 2012-12-23 9:00:25]
            if (th.ThreadState == ThreadState.Running)
            {
                th.Abort();
                th.Join();
                Initialize();//初始化
            }
        }

        //初始化
        private static void Initialize()
        {
            frm = null;
            th = null;
            _title = title;
        }

        private void lbl_Msg_TextChanged(object sender, EventArgs e)
        {
            pan_Msg.Visible = !String.IsNullOrEmpty(lbl_Msg.Text);
        }

        private void WaitForm_Paint(object sender, PaintEventArgs e)
        {
            this.Region = null;
            GetRoundedRectPath();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Region = null;
            GetRoundedRectPath();
        }
        private void GetRoundedRectPath()
        {
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            Rectangle arcRect = new Rectangle(rect.Location, new Size(25, 25));
            GraphicsPath path = new GraphicsPath();
            // 左上角 
            path.AddArc(arcRect, 180, 90);
            // 右上角 
            arcRect.X = rect.Right - 25;
            path.AddArc(arcRect, 270, 90);
            // 右下角 
            arcRect.Y = rect.Bottom - 25;
            path.AddArc(arcRect, 0, 90);
            // 左下角 
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }

    }
}
