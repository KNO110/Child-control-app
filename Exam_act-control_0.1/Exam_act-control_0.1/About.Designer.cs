namespace Exam_act_control_0._1
{
    partial class About
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
            dataGridView1 = new DataGridView();
            nightPanel1 = new ReaLTaiizor.Controls.NightPanel();
            nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            crownDockPanel1 = new ReaLTaiizor.Docking.Crown.CrownDockPanel();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            lostLabel1 = new ReaLTaiizor.Controls.LostLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            nightPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(23, 24, 40);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(785, 412);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            nightPanel1.Size = new Size(782, 29);
            nightPanel1.TabIndex = 2;
            // 
            // nightLabel1
            // 
            nightLabel1.AutoSize = true;
            nightLabel1.BackColor = Color.Transparent;
            nightLabel1.Font = new Font("Segoe UI", 9F);
            nightLabel1.ForeColor = Color.White;
            nightLabel1.Location = new Point(3, 3);
            nightLabel1.Name = "nightLabel1";
            nightLabel1.Size = new Size(68, 20);
            nightLabel1.TabIndex = 3;
            nightLabel1.Text = "About us";
            nightLabel1.Click += nightLabel1_Click;
            // 
            // crownDockPanel1
            // 
            crownDockPanel1.BackColor = Color.FromArgb(60, 63, 65);
            crownDockPanel1.Location = new Point(399, 449);
            crownDockPanel1.Name = "crownDockPanel1";
            crownDockPanel1.Size = new Size(8, 22);
            crownDockPanel1.TabIndex = 3;
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 4F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Arial", 11F);
            cyberButton1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(12, 214);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(162, 62);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 4;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "О нас";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
            cyberButton1.Click += cyberButton1_Click_1;
            // 
            // lostLabel1
            // 
            lostLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lostLabel1.BackColor = Color.FromArgb(45, 45, 48);
            lostLabel1.BackgroundImageLayout = ImageLayout.None;
            lostLabel1.ForeColor = Color.White;
            lostLabel1.Location = new Point(3, 35);
            lostLabel1.Name = "lostLabel1";
            lostLabel1.Size = new Size(776, 28);
            lostLabel1.TabIndex = 5;
            lostLabel1.Text = "На данной странице вы можете узнать информацию про нас";
            lostLabel1.Click += lostLabel1_Click;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            ClientSize = new Size(800, 450);
            Controls.Add(lostLabel1);
            Controls.Add(cyberButton1);
            Controls.Add(crownDockPanel1);
            Controls.Add(nightPanel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "About";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            nightPanel1.ResumeLayout(false);
            nightPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.NightPanel nightPanel1;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private ReaLTaiizor.Docking.Crown.CrownDockPanel crownDockPanel1;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private ReaLTaiizor.Controls.LostLabel lostLabel1;
    }
}
