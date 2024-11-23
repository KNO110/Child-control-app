namespace Exam_act_control_0._1
{
    partial class form_Log
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
            pnl_Main = new ReaLTaiizor.Controls.NightPanel();
            listBox1 = new ListBox();
            nightPanel1 = new ReaLTaiizor.Controls.NightPanel();
            nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            pnl_Main.SuspendLayout();
            nightPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Main
            // 
            pnl_Main.Controls.Add(listBox1);
            pnl_Main.Controls.Add(nightPanel1);
            pnl_Main.Dock = DockStyle.Fill;
            pnl_Main.ForeColor = Color.FromArgb(23, 24, 40);
            pnl_Main.LeftSideColor = Color.FromArgb(23, 24, 40);
            pnl_Main.Location = new Point(0, 0);
            pnl_Main.Name = "pnl_Main";
            pnl_Main.RightSideColor = Color.FromArgb(23, 24, 40);
            pnl_Main.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Right;
            pnl_Main.Size = new Size(800, 450);
            pnl_Main.TabIndex = 1;
            pnl_Main.Paint += pnl_Main_Paint;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveCaption;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 404);
            listBox1.TabIndex = 4;
            // 
            // nightPanel1
            // 
            nightPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nightPanel1.Controls.Add(nightLabel1);
            nightPanel1.ForeColor = Color.FromArgb(23, 24, 29);
            nightPanel1.LeftSideColor = Color.FromArgb(23, 24, 29);
            nightPanel1.Location = new Point(0, 0);
            nightPanel1.Name = "nightPanel1";
            nightPanel1.RightSideColor = Color.FromArgb(23, 24, 29);
            nightPanel1.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Right;
            nightPanel1.Size = new Size(800, 31);
            nightPanel1.TabIndex = 3;
            // 
            // nightLabel1
            // 
            nightLabel1.AutoSize = true;
            nightLabel1.BackColor = Color.Transparent;
            nightLabel1.Font = new Font("Segoe UI", 9F);
            nightLabel1.ForeColor = Color.White;
            nightLabel1.Location = new Point(3, 3);
            nightLabel1.Name = "nightLabel1";
            nightLabel1.Size = new Size(40, 20);
            nightLabel1.TabIndex = 3;
            nightLabel1.Text = "Logs";
            // 
            // form_Log
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_Main);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_Log";
            Text = "form_Log";
            pnl_Main.ResumeLayout(false);
            nightPanel1.ResumeLayout(false);
            nightPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.NightPanel pnl_Main;
        private ReaLTaiizor.Controls.NightPanel nightPanel1;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private ListBox listBox1;
    }
}