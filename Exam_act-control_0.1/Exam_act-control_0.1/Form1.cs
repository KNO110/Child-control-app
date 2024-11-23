namespace Exam_act_control_0._1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        bool menuExpand = false;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel4 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            button_menu = new PictureBox();
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            bt_Main = new Button();
            menuContainer = new Panel();
            bt_User = new Button();
            button4 = new Button();
            bt_Settings = new Button();
            Activity = new Button();
            panel3 = new Panel();
            bt_About = new Button();
            Menu_transition = new System.Windows.Forms.Timer(components);
            sidebar_transition = new System.Windows.Forms.Timer(components);
            pnlContent = new Panel();
            crownContextMenuStrip1 = new ReaLTaiizor.Controls.CrownContextMenuStrip();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)button_menu).BeginInit();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            menuContainer.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button_menu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 48);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.Location = new Point(230, 48);
            panel4.Name = "panel4";
            panel4.Size = new Size(499, 367);
            panel4.TabIndex = 3;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.Transparent;
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = false;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(591, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            nightControlBox1.Click += nightControlBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(42, 17);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 2;
            label1.Text = "Test-0.1";
            label1.Click += label1_Click;
            // 
            // button_menu
            // 
            button_menu.Image = (Image)resources.GetObject("button_menu.Image");
            button_menu.Location = new Point(4, 8);
            button_menu.Name = "button_menu";
            button_menu.Size = new Size(32, 32);
            button_menu.SizeMode = PictureBoxSizeMode.StretchImage;
            button_menu.TabIndex = 1;
            button_menu.TabStop = false;
            button_menu.Click += pictureBox1_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(23, 24, 29);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(menuContainer);
            sidebar.Controls.Add(panel3);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 48);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(228, 452);
            sidebar.TabIndex = 1;
            sidebar.Paint += sidebar_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(bt_Main);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 48);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // bt_Main
            // 
            bt_Main.BackColor = Color.FromArgb(23, 24, 29);
            bt_Main.BackgroundImageLayout = ImageLayout.None;
            bt_Main.FlatStyle = FlatStyle.Popup;
            bt_Main.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bt_Main.ForeColor = Color.White;
            bt_Main.Image = (Image)resources.GetObject("bt_Main.Image");
            bt_Main.ImageAlign = ContentAlignment.MiddleLeft;
            bt_Main.Location = new Point(0, 3);
            bt_Main.Name = "bt_Main";
            bt_Main.Padding = new Padding(5, 0, 0, 0);
            bt_Main.RightToLeft = RightToLeft.No;
            bt_Main.Size = new Size(215, 42);
            bt_Main.TabIndex = 2;
            bt_Main.Text = "Main";
            bt_Main.UseVisualStyleBackColor = false;
            bt_Main.Click += button1_Click;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(23, 24, 29);
            menuContainer.Controls.Add(bt_User);
            menuContainer.Controls.Add(button4);
            menuContainer.Controls.Add(bt_Settings);
            menuContainer.Controls.Add(Activity);
            menuContainer.Location = new Point(0, 54);
            menuContainer.Margin = new Padding(0);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(221, 153);
            menuContainer.TabIndex = 3;
            menuContainer.Paint += panel2_Paint;
            // 
            // bt_User
            // 
            bt_User.BackColor = Color.FromArgb(23, 24, 29);
            bt_User.BackgroundImageLayout = ImageLayout.None;
            bt_User.FlatStyle = FlatStyle.Popup;
            bt_User.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bt_User.ForeColor = Color.White;
            bt_User.Image = (Image)resources.GetObject("bt_User.Image");
            bt_User.ImageAlign = ContentAlignment.MiddleLeft;
            bt_User.Location = new Point(3, 96);
            bt_User.Name = "bt_User";
            bt_User.Padding = new Padding(5, 0, 0, 0);
            bt_User.RightToLeft = RightToLeft.No;
            bt_User.Size = new Size(215, 45);
            bt_User.TabIndex = 2;
            bt_User.Text = "User";
            bt_User.UseVisualStyleBackColor = false;
            bt_User.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(23, 24, 29);
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(4, 99);
            button4.Name = "button4";
            button4.Padding = new Padding(5, 0, 0, 0);
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(215, 42);
            button4.TabIndex = 2;
            button4.Text = "Settings";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button1_Click;
            // 
            // bt_Settings
            // 
            bt_Settings.BackColor = Color.FromArgb(23, 24, 29);
            bt_Settings.BackgroundImageLayout = ImageLayout.None;
            bt_Settings.FlatStyle = FlatStyle.Popup;
            bt_Settings.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bt_Settings.ForeColor = Color.White;
            bt_Settings.Image = (Image)resources.GetObject("bt_Settings.Image");
            bt_Settings.ImageAlign = ContentAlignment.MiddleLeft;
            bt_Settings.Location = new Point(3, 51);
            bt_Settings.Margin = new Padding(0);
            bt_Settings.Name = "bt_Settings";
            bt_Settings.Padding = new Padding(5, 0, 0, 0);
            bt_Settings.RightToLeft = RightToLeft.No;
            bt_Settings.Size = new Size(215, 42);
            bt_Settings.TabIndex = 2;
            bt_Settings.Text = "Log";
            bt_Settings.UseVisualStyleBackColor = false;
            bt_Settings.Click += button1_Click;
            // 
            // Activity
            // 
            Activity.BackColor = Color.FromArgb(23, 24, 29);
            Activity.BackgroundImageLayout = ImageLayout.None;
            Activity.FlatStyle = FlatStyle.Popup;
            Activity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Activity.ForeColor = Color.White;
            Activity.Image = (Image)resources.GetObject("Activity.Image");
            Activity.ImageAlign = ContentAlignment.MiddleLeft;
            Activity.Location = new Point(3, 3);
            Activity.Name = "Activity";
            Activity.Padding = new Padding(5, 0, 0, 0);
            Activity.RightToLeft = RightToLeft.No;
            Activity.Size = new Size(215, 42);
            Activity.TabIndex = 2;
            Activity.Text = "Activity";
            Activity.UseVisualStyleBackColor = false;
            Activity.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(bt_About);
            panel3.Location = new Point(3, 210);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 48);
            panel3.TabIndex = 3;
            panel3.Paint += panel2_Paint;
            // 
            // bt_About
            // 
            bt_About.Anchor = AnchorStyles.Bottom;
            bt_About.BackColor = Color.FromArgb(23, 24, 29);
            bt_About.BackgroundImageLayout = ImageLayout.None;
            bt_About.FlatStyle = FlatStyle.Popup;
            bt_About.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bt_About.ForeColor = Color.White;
            bt_About.Image = (Image)resources.GetObject("bt_About.Image");
            bt_About.ImageAlign = ContentAlignment.MiddleLeft;
            bt_About.Location = new Point(0, 3);
            bt_About.Name = "bt_About";
            bt_About.Padding = new Padding(5, 0, 0, 0);
            bt_About.RightToLeft = RightToLeft.No;
            bt_About.Size = new Size(215, 42);
            bt_About.TabIndex = 2;
            bt_About.Text = "About";
            bt_About.UseVisualStyleBackColor = false;
            bt_About.Click += button1_Click;
            // 
            // Menu_transition
            // 
            Menu_transition.Interval = 10;
            Menu_transition.Tick += Menu_transition_Tick;
            // 
            // sidebar_transition
            // 
            sidebar_transition.Interval = 10;
            sidebar_transition.Tick += sidebar_transition_Tick;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(23, 24, 40);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(228, 48);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(502, 452);
            pnlContent.TabIndex = 3;
            // 
            // crownContextMenuStrip1
            // 
            crownContextMenuStrip1.BackColor = Color.FromArgb(60, 63, 65);
            crownContextMenuStrip1.ForeColor = Color.FromArgb(220, 220, 220);
            crownContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            crownContextMenuStrip1.Name = "crownContextMenuStrip1";
            crownContextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(730, 500);
            Controls.Add(pnlContent);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            TransparencyKey = Color.Purple;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)button_menu).EndInit();
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panel1;
        private PictureBox button_menu;
        private Label label1;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebar_transition.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel sidebar;
        private Button bt_Main;
        private Panel panel2;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear(); // Очищаем pnlContent от предыдущих контролов

            if (sender == Activity)
            {
                Menu_transition.Start();
            }
            if (sender == bt_About)
            {
                About s = new About();
                s.TopLevel = false;
                pnlContent.Controls.Add(s);
                s.BringToFront();
                s.Show();
            }
            if (sender == bt_Main)
            {
                form_Main p = new form_Main();
                p.TopLevel = false;
                p.Size = pnlContent.Size; // Установка размеров формы равными размерам pnlContent
                p.Location = new Point(0, 0); // Установка позиции формы в верхний левый угол pnlContent
                pnlContent.Controls.Add(p);
                p.BringToFront();
                p.Show();
            }
            if (sender == bt_Settings)
            {
                form_Log p = new form_Log();
                p.TopLevel = false;
                p.Size = pnlContent.Size; // Установка размеров формы равными размерам pnlContent
                p.Location = new Point(0, 0); // Установка позиции формы в верхний левый угол pnlContent
                pnlContent.Controls.Add(p);
                p.BringToFront();
                p.Show();
            }
        }

        private Panel menuContainer;
        private Button Activity;
        private Button bt_Settings;
        private System.Windows.Forms.Timer Menu_transition;
        private System.ComponentModel.IContainer components;

        private void Menu_transition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 145)
                {
                    Menu_transition.Stop();
                    menuExpand = true;

                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 50)
                {
                    Menu_transition.Stop();
                    menuExpand = false;
                }
            }
        }

        private System.Windows.Forms.Timer sidebar_transition;

        private void HideText()
        {
            bt_Main.Text = "";
            bt_About.Text = "";
            Activity.Text = "";
            bt_Settings.Text = "";
            bt_User.Text = "";
        }

        // Метод для показа текста
        private void ShowText()
        {
            bt_Main.Text = "Main";
            bt_About.Text = "About";
            Activity.Text = "Activity";
            bt_Settings.Text = "Settings";
            bt_User.Text = "User";
        }

        bool sidebarExpand = true;
        private void sidebar_transition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 60)
                {
                    sidebarExpand = false;
                    sidebar_transition.Stop();
                    HideText();
                    bt_Main.Width = sidebar.Width;
                    bt_About.Width = sidebar.Width;
                    Activity.Width = sidebar.Width;
                    bt_Settings.Width = sidebar.Width;
                    bt_User.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 230)
                {
                    sidebarExpand = true;
                    sidebar_transition.Stop();
                    ShowText();
                    bt_Main.Width = sidebar.Width;
                    bt_About.Width = sidebar.Width;
                    Activity.Width = sidebar.Width;
                    bt_Settings.Width = sidebar.Width;
                    bt_User.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private Panel panel3;
        private Button bt_About;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private Panel panel4;
        private Panel pnlContent;
        private ReaLTaiizor.Controls.CrownContextMenuStrip crownContextMenuStrip1;

        private void nightControlBox1_Click(object sender, EventArgs e)
        {

        }

        private Button bt_User;
        private Button button4;
    }
}
