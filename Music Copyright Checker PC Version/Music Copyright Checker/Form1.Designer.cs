namespace Music_Copyright_Checker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Animator_Slider = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Animator_Logo = new System.Windows.Forms.Timer(this.components);
            this.exit = new System.Windows.Forms.PictureBox();
            this.Animator_Wave = new System.Windows.Forms.Timer(this.components);
            this.Animator_Gradient = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.authPanel = new Music_Copyright_Checker.GradientPanel();
            this.reg = new System.Windows.Forms.Button();
            this.stat_auth = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.auth = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new Music_Copyright_Checker.GradientPanel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gradientPanel1 = new Music_Copyright_Checker.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseFile = new System.Windows.Forms.Button();
            this.url = new System.Windows.Forms.TextBox();
            this.statMusic = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.AnimWave = new System.Windows.Forms.PictureBox();
            this.profilePanel = new Music_Copyright_Checker.GradientPanel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.changePass = new System.Windows.Forms.Button();
            this.newPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.changeUsername = new System.Windows.Forms.Button();
            this.oldPass = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.gradientPanel2 = new Music_Copyright_Checker.GradientPanel();
            this.username = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Slider = new Music_Copyright_Checker.GradientPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panSlider1 = new NAudio.Gui.PanSlider();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.authPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimWave)).BeginInit();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.Slider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Animator_Slider
            // 
            this.Animator_Slider.Interval = 10;
            this.Animator_Slider.Tick += new System.EventHandler(this.Animator_Slider_Begin_Tick);
            // 
            // Animator_Logo
            // 
            this.Animator_Logo.Interval = 10;
            this.Animator_Logo.Tick += new System.EventHandler(this.Animator_Logo_Tick);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(537, 0);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(66, 10);
            this.exit.TabIndex = 2;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exit_MouseDown);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            this.exit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.exit_MouseUp);
            // 
            // Animator_Wave
            // 
            this.Animator_Wave.Interval = 20;
            this.Animator_Wave.Tick += new System.EventHandler(this.Animator_Wave_Tick);
            // 
            // Animator_Gradient
            // 
            this.Animator_Gradient.Enabled = true;
            this.Animator_Gradient.Tick += new System.EventHandler(this.Animator_Gradient_Tick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(606, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(1, 1);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(37, 25);
            this.webBrowser1.TabIndex = 25;
            this.webBrowser1.Visible = false;
            // 
            // authPanel
            // 
            this.authPanel.Angle = 0F;
            this.authPanel.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(55)))));
            this.authPanel.Controls.Add(this.pictureBox2);
            this.authPanel.Controls.Add(this.auth);
            this.authPanel.Controls.Add(this.pass);
            this.authPanel.Controls.Add(this.login);
            this.authPanel.Controls.Add(this.pictureBox1);
            this.authPanel.Controls.Add(this.stat_auth);
            this.authPanel.Controls.Add(this.reg);
            this.authPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.authPanel.Location = new System.Drawing.Point(50, 112);
            this.authPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authPanel.Name = "authPanel";
            this.authPanel.Size = new System.Drawing.Size(603, 854);
            this.authPanel.TabIndex = 1;
            this.authPanel.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.authPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuthPanel_MouseDown);
            // 
            // reg
            // 
            this.reg.BackColor = System.Drawing.Color.Transparent;
            this.reg.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.reg.FlatAppearance.BorderSize = 0;
            this.reg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.reg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg.ForeColor = System.Drawing.Color.White;
            this.reg.Location = new System.Drawing.Point(171, 786);
            this.reg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(261, 37);
            this.reg.TabIndex = 13;
            this.reg.Text = "Зарегистрироваться";
            this.reg.UseVisualStyleBackColor = false;
            this.reg.Click += new System.EventHandler(this.reg_Click);
            this.reg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reg_MouseDown);
            this.reg.MouseEnter += new System.EventHandler(this.reg_MouseEnter);
            this.reg.MouseLeave += new System.EventHandler(this.reg_MouseLeave);
            this.reg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.reg_MouseUp);
            // 
            // stat_auth
            // 
            this.stat_auth.BackColor = System.Drawing.Color.Transparent;
            this.stat_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stat_auth.ForeColor = System.Drawing.Color.White;
            this.stat_auth.Location = new System.Drawing.Point(72, 569);
            this.stat_auth.Name = "stat_auth";
            this.stat_auth.Size = new System.Drawing.Size(468, 31);
            this.stat_auth.TabIndex = 12;
            this.stat_auth.Text = "Введите данные";
            this.stat_auth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stat_auth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stat_auth_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Music_Copyright_Checker.Properties.Resources.logo_withoutname_white;
            this.pictureBox2.Location = new System.Drawing.Point(44, 107);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(514, 295);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // auth
            // 
            this.auth.BackColor = System.Drawing.Color.Transparent;
            this.auth.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.auth.FlatAppearance.BorderSize = 0;
            this.auth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.auth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.auth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auth.ForeColor = System.Drawing.Color.White;
            this.auth.Location = new System.Drawing.Point(185, 743);
            this.auth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.auth.Name = "auth";
            this.auth.Size = new System.Drawing.Size(231, 37);
            this.auth.TabIndex = 10;
            this.auth.Text = "Авторизоваться";
            this.auth.UseVisualStyleBackColor = false;
            this.auth.Click += new System.EventHandler(this.auth_Click);
            this.auth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.auth_MouseDown);
            this.auth.MouseEnter += new System.EventHandler(this.auth_MouseEnter);
            this.auth.MouseLeave += new System.EventHandler(this.auth_MouseLeave);
            this.auth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.auth_MouseUp);
            // 
            // pass
            // 
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass.ForeColor = System.Drawing.Color.Gray;
            this.pass.Location = new System.Drawing.Point(160, 649);
            this.pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(292, 29);
            this.pass.TabIndex = 9;
            this.pass.Text = "Пароль";
            this.pass.Enter += new System.EventHandler(this.pass_Enter);
            this.pass.Leave += new System.EventHandler(this.pass_Leave);
            // 
            // login
            // 
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.ForeColor = System.Drawing.Color.Gray;
            this.login.Location = new System.Drawing.Point(160, 603);
            this.login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(292, 29);
            this.login.TabIndex = 8;
            this.login.Text = "Псевдоним";
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            this.login.Enter += new System.EventHandler(this.login_Enter);
            this.login.Leave += new System.EventHandler(this.login_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Music_Copyright_Checker.Properties.Resources.logo__name_white;
            this.pictureBox1.Location = new System.Drawing.Point(44, 400);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // mainPanel
            // 
            this.mainPanel.Angle = 90F;
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(55)))));
            this.mainPanel.Controls.Add(this.panSlider1);
            this.mainPanel.Controls.Add(this.pictureBox7);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.button2);
            this.mainPanel.Controls.Add(this.check);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.chooseFile);
            this.mainPanel.Controls.Add(this.url);
            this.mainPanel.Controls.Add(this.statMusic);
            this.mainPanel.Controls.Add(this.Logo);
            this.mainPanel.Controls.Add(this.AnimWave);
            this.mainPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainPanel.Location = new System.Drawing.Point(15, 26);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(603, 882);
            this.mainPanel.TabIndex = 3;
            this.mainPanel.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Music_Copyright_Checker.Properties.Resources.Profile;
            this.pictureBox7.Location = new System.Drawing.Point(283, 0);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(37, 42);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(283, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "или";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button2.ForeColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(178, 481);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 33);
            this.button2.TabIndex = 21;
            this.button2.Text = "Начать запись";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // check
            // 
            this.check.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check.ForeColor = System.Drawing.Color.White;
            this.check.Location = new System.Drawing.Point(140, 513);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(323, 50);
            this.check.TabIndex = 19;
            this.check.Text = "Провести анализ";
            this.check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.check.Visible = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            this.check.MouseDown += new System.Windows.Forms.MouseEventHandler(this.check_MouseDown);
            this.check.MouseEnter += new System.EventHandler(this.check_MouseEnter);
            this.check.MouseLeave += new System.EventHandler(this.check_MouseLeave);
            this.check.MouseUp += new System.Windows.Forms.MouseEventHandler(this.check_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.gradientPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 566);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 306);
            this.panel1.TabIndex = 18;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(55)))));
            this.flowLayoutPanel1.BackgroundImage = global::Music_Copyright_Checker.Properties.Resources.Copyright_200px;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(603, 295);
            this.flowLayoutPanel1.TabIndex = 18;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 270.1F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.ForeColor = System.Drawing.Color.Black;
            this.gradientPanel1.Location = new System.Drawing.Point(-1, 17);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(604, 10);
            this.gradientPanel1.TabIndex = 17;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(55)))));
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(283, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "или";
            // 
            // chooseFile
            // 
            this.chooseFile.BackColor = System.Drawing.Color.White;
            this.chooseFile.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.chooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.chooseFile.ForeColor = System.Drawing.Color.Gray;
            this.chooseFile.Location = new System.Drawing.Point(178, 425);
            this.chooseFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(246, 33);
            this.chooseFile.TabIndex = 15;
            this.chooseFile.Text = "Выберите файл";
            this.chooseFile.UseVisualStyleBackColor = false;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // url
            // 
            this.url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.url.Enabled = false;
            this.url.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.url.ForeColor = System.Drawing.Color.Gray;
            this.url.Location = new System.Drawing.Point(178, 369);
            this.url.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.url.Multiline = true;
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(246, 33);
            this.url.TabIndex = 14;
            this.url.Text = "Введите URL";
            this.url.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.url.TextChanged += new System.EventHandler(this.url_TextChanged);
            this.url.Enter += new System.EventHandler(this.url_Enter);
            this.url.Leave += new System.EventHandler(this.url_Leave);
            // 
            // statMusic
            // 
            this.statMusic.BackColor = System.Drawing.Color.Transparent;
            this.statMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.statMusic.ForeColor = System.Drawing.Color.White;
            this.statMusic.Location = new System.Drawing.Point(178, 326);
            this.statMusic.Name = "statMusic";
            this.statMusic.Size = new System.Drawing.Size(246, 42);
            this.statMusic.TabIndex = 13;
            this.statMusic.Text = "Выбор музыкальной композиции";
            this.statMusic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statMusic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.statMusic_MouseDown);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Image = global::Music_Copyright_Checker.Properties.Resources.logo_withoutname_white;
            this.Logo.Location = new System.Drawing.Point(201, 78);
            this.Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(199, 199);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 11;
            this.Logo.TabStop = false;
            this.Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Logo_MouseDown);
            // 
            // AnimWave
            // 
            this.AnimWave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AnimWave.Location = new System.Drawing.Point(8, 181);
            this.AnimWave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnimWave.Name = "AnimWave";
            this.AnimWave.Size = new System.Drawing.Size(579, 238);
            this.AnimWave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AnimWave.TabIndex = 12;
            this.AnimWave.TabStop = false;
            this.AnimWave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnimWave_MouseDown);
            // 
            // profilePanel
            // 
            this.profilePanel.Angle = 90F;
            this.profilePanel.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.profilePanel.Controls.Add(this.pictureBox6);
            this.profilePanel.Controls.Add(this.pictureBox8);
            this.profilePanel.Controls.Add(this.panel2);
            this.profilePanel.Controls.Add(this.gradientPanel2);
            this.profilePanel.Controls.Add(this.username);
            this.profilePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.profilePanel.Location = new System.Drawing.Point(585, 14);
            this.profilePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(603, 875);
            this.profilePanel.TabIndex = 24;
            this.profilePanel.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(55)))));
            this.profilePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.profilePanel_MouseDown);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Image = global::Music_Copyright_Checker.Properties.Resources.logo_withoutname_white;
            this.pictureBox8.Location = new System.Drawing.Point(280, 0);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(42, 42);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 21;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.changePass);
            this.panel2.Controls.Add(this.newPass);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.changeUsername);
            this.panel2.Controls.Add(this.oldPass);
            this.panel2.Controls.Add(this.usernameTextbox);
            this.panel2.Location = new System.Drawing.Point(0, 283);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 622);
            this.panel2.TabIndex = 20;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(229, 482);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 37);
            this.button3.TabIndex = 20;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // changePass
            // 
            this.changePass.BackColor = System.Drawing.Color.Transparent;
            this.changePass.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.changePass.FlatAppearance.BorderSize = 0;
            this.changePass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changePass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.changePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePass.ForeColor = System.Drawing.Color.White;
            this.changePass.Location = new System.Drawing.Point(185, 219);
            this.changePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(231, 37);
            this.changePass.TabIndex = 18;
            this.changePass.Text = "Сменить";
            this.changePass.UseVisualStyleBackColor = false;
            // 
            // newPass
            // 
            this.newPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPass.ForeColor = System.Drawing.Color.Gray;
            this.newPass.Location = new System.Drawing.Point(155, 185);
            this.newPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPass.Multiline = true;
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(292, 29);
            this.newPass.TabIndex = 17;
            this.newPass.Text = "Новый пароль";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(468, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Настройки профиля";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeUsername
            // 
            this.changeUsername.BackColor = System.Drawing.Color.Transparent;
            this.changeUsername.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.changeUsername.FlatAppearance.BorderSize = 0;
            this.changeUsername.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changeUsername.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.changeUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeUsername.ForeColor = System.Drawing.Color.White;
            this.changeUsername.Location = new System.Drawing.Point(185, 86);
            this.changeUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeUsername.Name = "changeUsername";
            this.changeUsername.Size = new System.Drawing.Size(231, 37);
            this.changeUsername.TabIndex = 15;
            this.changeUsername.Text = "Сменить";
            this.changeUsername.UseVisualStyleBackColor = false;
            this.changeUsername.Click += new System.EventHandler(this.changeUsername_Click);
            // 
            // oldPass
            // 
            this.oldPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPass.ForeColor = System.Drawing.Color.Gray;
            this.oldPass.Location = new System.Drawing.Point(155, 149);
            this.oldPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oldPass.Multiline = true;
            this.oldPass.Name = "oldPass";
            this.oldPass.Size = new System.Drawing.Size(292, 29);
            this.oldPass.TabIndex = 14;
            this.oldPass.Text = "Старый пароль";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextbox.ForeColor = System.Drawing.Color.Gray;
            this.usernameTextbox.Location = new System.Drawing.Point(155, 50);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTextbox.Multiline = true;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(292, 29);
            this.usernameTextbox.TabIndex = 13;
            this.usernameTextbox.Text = "Псевдоним";
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = 270.1F;
            this.gradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel2.BottomColor = System.Drawing.Color.Transparent;
            this.gradientPanel2.ForeColor = System.Drawing.Color.Black;
            this.gradientPanel2.Location = new System.Drawing.Point(-1, 262);
            this.gradientPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(604, 21);
            this.gradientPanel2.TabIndex = 19;
            this.gradientPanel2.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(55)))));
            this.gradientPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gradientPanel2_MouseDown);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(0, 201);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(603, 54);
            this.username.TabIndex = 1;
            this.username.Text = "@noname";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.username.MouseDown += new System.Windows.Forms.MouseEventHandler(this.username_MouseDown);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Music_Copyright_Checker.Properties.Resources.Profile;
            this.pictureBox6.Location = new System.Drawing.Point(0, 78);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(603, 121);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseDown);
            // 
            // Slider
            // 
            this.Slider.Angle = 34F;
            this.Slider.BackColor = System.Drawing.Color.Transparent;
            this.Slider.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(55)))));
            this.Slider.Controls.Add(this.pictureBox5);
            this.Slider.Controls.Add(this.pictureBox4);
            this.Slider.Controls.Add(this.pictureBox3);
            this.Slider.Location = new System.Drawing.Point(12, 857);
            this.Slider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(605, 875);
            this.Slider.TabIndex = 4;
            this.Slider.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.Slider.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Music_Copyright_Checker.Properties.Resources.arrow2;
            this.pictureBox5.Location = new System.Drawing.Point(-44, 89);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(709, 133);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Music_Copyright_Checker.Properties.Resources.arrow;
            this.pictureBox4.Location = new System.Drawing.Point(-47, 673);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(712, 133);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Music_Copyright_Checker.Properties.Resources.arrow;
            this.pictureBox3.Location = new System.Drawing.Point(0, 378);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(943, 133);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panSlider1
            // 
            this.panSlider1.Location = new System.Drawing.Point(6, 47);
            this.panSlider1.Name = "panSlider1";
            this.panSlider1.Pan = 0F;
            this.panSlider1.Size = new System.Drawing.Size(104, 16);
            this.panSlider1.TabIndex = 24;
            this.panSlider1.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.Color.Gray;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(25, 313);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(553, 144);
            this.listBox1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(66, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(468, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "История запросов";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(603, 882);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.Slider);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.authPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Copyright Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.authPanel.ResumeLayout(false);
            this.authPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimWave)).EndInit();
            this.profilePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.Slider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Animator_Slider;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label username;
        private GradientPanel profilePanel;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button changePass;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button changeUsername;
        private System.Windows.Forms.TextBox oldPass;
        private System.Windows.Forms.TextBox usernameTextbox;
        private GradientPanel gradientPanel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer Animator_Logo;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button auth;
        private GradientPanel authPanel;
        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.Label stat_auth;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer Animator_Wave;
        private System.Windows.Forms.Label statMusic;
        private GradientPanel mainPanel;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label check;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chooseFile;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox AnimWave;
        private System.Windows.Forms.Timer Animator_Gradient;
        private GradientPanel Slider;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private NAudio.Gui.PanSlider panSlider1;
    }
}

