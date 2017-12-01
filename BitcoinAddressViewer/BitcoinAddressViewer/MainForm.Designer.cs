namespace BitcoinAddressViewer
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPageBCH = new System.Windows.Forms.TabPage();
            this.dataGridViewBCH = new System.Windows.Forms.DataGridView();
            this.buttonRefreshBCH = new System.Windows.Forms.Button();
            this.labelFinalBalanceBCH = new System.Windows.Forms.Label();
            this.labelBCH = new System.Windows.Forms.Label();
            this.tabPageBTC = new System.Windows.Forms.TabPage();
            this.dataGridViewBTC = new System.Windows.Forms.DataGridView();
            this.buttonRefreshBTC = new System.Windows.Forms.Button();
            this.labelFinalBalanceBTC = new System.Windows.Forms.Label();
            this.labelBTC = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageBCH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBCH)).BeginInit();
            this.tabPageBTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBTC)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageBCH
            // 
            this.tabPageBCH.Controls.Add(this.dataGridViewBCH);
            this.tabPageBCH.Controls.Add(this.buttonRefreshBCH);
            this.tabPageBCH.Controls.Add(this.labelFinalBalanceBCH);
            this.tabPageBCH.Controls.Add(this.labelBCH);
            this.tabPageBCH.Location = new System.Drawing.Point(8, 39);
            this.tabPageBCH.Name = "tabPageBCH";
            this.tabPageBCH.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBCH.Size = new System.Drawing.Size(1238, 682);
            this.tabPageBCH.TabIndex = 1;
            this.tabPageBCH.Text = "Bitcoin Cash";
            this.tabPageBCH.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBCH
            // 
            this.dataGridViewBCH.AllowUserToAddRows = false;
            this.dataGridViewBCH.AllowUserToDeleteRows = false;
            this.dataGridViewBCH.AllowUserToOrderColumns = true;
            this.dataGridViewBCH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBCH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBCH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBCH.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBCH.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBCH.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewBCH.EnableHeadersVisualStyles = false;
            this.dataGridViewBCH.Location = new System.Drawing.Point(6, 70);
            this.dataGridViewBCH.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewBCH.MultiSelect = false;
            this.dataGridViewBCH.Name = "dataGridViewBCH";
            this.dataGridViewBCH.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBCH.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBCH.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewBCH.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBCH.RowTemplate.Height = 23;
            this.dataGridViewBCH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBCH.Size = new System.Drawing.Size(1226, 606);
            this.dataGridViewBCH.TabIndex = 59;
            // 
            // buttonRefreshBCH
            // 
            this.buttonRefreshBCH.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRefreshBCH.Location = new System.Drawing.Point(418, 10);
            this.buttonRefreshBCH.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefreshBCH.Name = "buttonRefreshBCH";
            this.buttonRefreshBCH.Size = new System.Drawing.Size(135, 50);
            this.buttonRefreshBCH.TabIndex = 58;
            this.buttonRefreshBCH.Text = "Refresh";
            this.buttonRefreshBCH.UseVisualStyleBackColor = true;
            this.buttonRefreshBCH.Click += new System.EventHandler(this.ButtonRefreshBCH_Click);
            // 
            // labelFinalBalanceBCH
            // 
            this.labelFinalBalanceBCH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFinalBalanceBCH.AutoSize = true;
            this.labelFinalBalanceBCH.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFinalBalanceBCH.Location = new System.Drawing.Point(118, 17);
            this.labelFinalBalanceBCH.Name = "labelFinalBalanceBCH";
            this.labelFinalBalanceBCH.Size = new System.Drawing.Size(253, 33);
            this.labelFinalBalanceBCH.TabIndex = 57;
            this.labelFinalBalanceBCH.Text = "00000.00000000";
            // 
            // labelBCH
            // 
            this.labelBCH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBCH.AutoSize = true;
            this.labelBCH.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBCH.Location = new System.Drawing.Point(6, 17);
            this.labelBCH.Name = "labelBCH";
            this.labelBCH.Size = new System.Drawing.Size(66, 33);
            this.labelBCH.TabIndex = 56;
            this.labelBCH.Text = "BCH";
            // 
            // tabPageBTC
            // 
            this.tabPageBTC.Controls.Add(this.dataGridViewBTC);
            this.tabPageBTC.Controls.Add(this.buttonRefreshBTC);
            this.tabPageBTC.Controls.Add(this.labelFinalBalanceBTC);
            this.tabPageBTC.Controls.Add(this.labelBTC);
            this.tabPageBTC.Location = new System.Drawing.Point(8, 39);
            this.tabPageBTC.Name = "tabPageBTC";
            this.tabPageBTC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBTC.Size = new System.Drawing.Size(1821, 1339);
            this.tabPageBTC.TabIndex = 0;
            this.tabPageBTC.Text = "Bitcoin";
            this.tabPageBTC.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBTC
            // 
            this.dataGridViewBTC.AllowUserToAddRows = false;
            this.dataGridViewBTC.AllowUserToDeleteRows = false;
            this.dataGridViewBTC.AllowUserToOrderColumns = true;
            this.dataGridViewBTC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBTC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBTC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewBTC.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBTC.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewBTC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewBTC.EnableHeadersVisualStyles = false;
            this.dataGridViewBTC.Location = new System.Drawing.Point(6, 68);
            this.dataGridViewBTC.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewBTC.MultiSelect = false;
            this.dataGridViewBTC.Name = "dataGridViewBTC";
            this.dataGridViewBTC.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBTC.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewBTC.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewBTC.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewBTC.RowTemplate.Height = 23;
            this.dataGridViewBTC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBTC.Size = new System.Drawing.Size(1809, 1263);
            this.dataGridViewBTC.TabIndex = 63;
            // 
            // buttonRefreshBTC
            // 
            this.buttonRefreshBTC.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRefreshBTC.Location = new System.Drawing.Point(418, 8);
            this.buttonRefreshBTC.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefreshBTC.Name = "buttonRefreshBTC";
            this.buttonRefreshBTC.Size = new System.Drawing.Size(135, 50);
            this.buttonRefreshBTC.TabIndex = 62;
            this.buttonRefreshBTC.Text = "Refresh";
            this.buttonRefreshBTC.UseVisualStyleBackColor = true;
            this.buttonRefreshBTC.Click += new System.EventHandler(this.ButtonRefreshBTC_Click);
            // 
            // labelFinalBalanceBTC
            // 
            this.labelFinalBalanceBTC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFinalBalanceBTC.AutoSize = true;
            this.labelFinalBalanceBTC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFinalBalanceBTC.Location = new System.Drawing.Point(118, 15);
            this.labelFinalBalanceBTC.Name = "labelFinalBalanceBTC";
            this.labelFinalBalanceBTC.Size = new System.Drawing.Size(253, 33);
            this.labelFinalBalanceBTC.TabIndex = 61;
            this.labelFinalBalanceBTC.Text = "00000.00000000";
            // 
            // labelBTC
            // 
            this.labelBTC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBTC.AutoSize = true;
            this.labelBTC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBTC.Location = new System.Drawing.Point(6, 15);
            this.labelBTC.Name = "labelBTC";
            this.labelBTC.Size = new System.Drawing.Size(66, 33);
            this.labelBTC.TabIndex = 60;
            this.labelBTC.Text = "BTC";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageBTC);
            this.tabControl.Controls.Add(this.tabPageBCH);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1254, 729);
            this.tabControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1254, 729);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitcoin Address Viewer";
            this.tabPageBCH.ResumeLayout(false);
            this.tabPageBCH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBCH)).EndInit();
            this.tabPageBTC.ResumeLayout(false);
            this.tabPageBTC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBTC)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageBCH;
        private System.Windows.Forms.TabPage tabPageBTC;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.DataGridView dataGridViewBCH;
        private System.Windows.Forms.Button buttonRefreshBCH;
        private System.Windows.Forms.Label labelFinalBalanceBCH;
        private System.Windows.Forms.Label labelBCH;
        private System.Windows.Forms.DataGridView dataGridViewBTC;
        private System.Windows.Forms.Button buttonRefreshBTC;
        private System.Windows.Forms.Label labelFinalBalanceBTC;
        private System.Windows.Forms.Label labelBTC;
    }
}

