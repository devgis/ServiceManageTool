namespace LNS.ServicesManageTool
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvServiceList = new System.Windows.Forms.DataGridView();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStart = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btStartAll = new System.Windows.Forms.Button();
            this.btStopAll = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbServerName = new System.Windows.Forms.TextBox();
            this.nuDBPort = new System.Windows.Forms.NumericUpDown();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbUserPassword = new System.Windows.Forms.TextBox();
            this.tbDBName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceList)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDBPort)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "服务管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvServiceList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 497);
            this.panel2.TabIndex = 1;
            // 
            // dgvServiceList
            // 
            this.dgvServiceList.AllowUserToAddRows = false;
            this.dgvServiceList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServiceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceName,
            this.ServiceState,
            this.ColStart});
            this.dgvServiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServiceList.Location = new System.Drawing.Point(0, 0);
            this.dgvServiceList.Name = "dgvServiceList";
            this.dgvServiceList.ReadOnly = true;
            this.dgvServiceList.RowTemplate.Height = 23;
            this.dgvServiceList.Size = new System.Drawing.Size(770, 497);
            this.dgvServiceList.TabIndex = 0;
            this.dgvServiceList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceList_CellClick);
            // 
            // ServiceName
            // 
            this.ServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServiceName.HeaderText = "服务名称";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            // 
            // ServiceState
            // 
            this.ServiceState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServiceState.HeaderText = "服务状态";
            this.ServiceState.Name = "ServiceState";
            this.ServiceState.ReadOnly = true;
            // 
            // ColStart
            // 
            this.ColStart.HeaderText = "操作";
            this.ColStart.Name = "ColStart";
            this.ColStart.ReadOnly = true;
            this.ColStart.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 33);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btStartAll, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btStopAll, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 33);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btStartAll
            // 
            this.btStartAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btStartAll.Location = new System.Drawing.Point(553, 3);
            this.btStartAll.Name = "btStartAll";
            this.btStartAll.Size = new System.Drawing.Size(94, 27);
            this.btStartAll.TabIndex = 0;
            this.btStartAll.Text = "全部启动";
            this.btStartAll.UseVisualStyleBackColor = true;
            this.btStartAll.Click += new System.EventHandler(this.btStartAll_Click);
            // 
            // btStopAll
            // 
            this.btStopAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btStopAll.Location = new System.Drawing.Point(653, 3);
            this.btStopAll.Name = "btStopAll";
            this.btStopAll.Size = new System.Drawing.Size(94, 27);
            this.btStopAll.TabIndex = 1;
            this.btStopAll.Text = "全部停止";
            this.btStopAll.UseVisualStyleBackColor = true;
            this.btStopAll.Click += new System.EventHandler(this.btStopAll_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "数据库配置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(770, 501);
            this.panel4.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.tbServerName, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.nuDBPort, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.tbUserName, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tbUserPassword, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.tbDBName, 1, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(770, 501);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库服务地址（IP地址或主机名）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "数据库名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "端口";
            // 
            // tbServerName
            // 
            this.tbServerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbServerName.Location = new System.Drawing.Point(23, 148);
            this.tbServerName.MaxLength = 256;
            this.tbServerName.Name = "tbServerName";
            this.tbServerName.Size = new System.Drawing.Size(724, 21);
            this.tbServerName.TabIndex = 0;
            // 
            // nuDBPort
            // 
            this.nuDBPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nuDBPort.Location = new System.Drawing.Point(23, 348);
            this.nuDBPort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nuDBPort.Name = "nuDBPort";
            this.nuDBPort.Size = new System.Drawing.Size(724, 21);
            this.nuDBPort.TabIndex = 4;
            this.nuDBPort.Value = new decimal(new int[] {
            5432,
            0,
            0,
            0});
            // 
            // tbUserName
            // 
            this.tbUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUserName.Location = new System.Drawing.Point(23, 198);
            this.tbUserName.MaxLength = 256;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(724, 21);
            this.tbUserName.TabIndex = 1;
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUserPassword.Location = new System.Drawing.Point(23, 248);
            this.tbUserPassword.MaxLength = 256;
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.Size = new System.Drawing.Size(724, 21);
            this.tbUserPassword.TabIndex = 2;
            // 
            // tbDBName
            // 
            this.tbDBName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDBName.Location = new System.Drawing.Point(23, 298);
            this.tbDBName.MaxLength = 256;
            this.tbDBName.Name = "tbDBName";
            this.tbDBName.Size = new System.Drawing.Size(724, 21);
            this.tbDBName.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 504);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 29);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btSave, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(770, 29);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSave.Location = new System.Drawing.Point(313, 3);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(144, 23);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "保存(&S)";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "服务管理工具";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDBPort)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btStartAll;
        private System.Windows.Forms.Button btStopAll;
        private System.Windows.Forms.DataGridView dgvServiceList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceState;
        private System.Windows.Forms.DataGridViewButtonColumn ColStart;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbServerName;
        private System.Windows.Forms.NumericUpDown nuDBPort;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbUserPassword;
        private System.Windows.Forms.TextBox tbDBName;
    }
}