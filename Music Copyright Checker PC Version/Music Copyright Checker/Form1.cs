using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MCE;
using Music_Copyright_Checker.Properties;
using SqlDB;

namespace Music_Copyright_Checker
{
    public partial class Form1 : Form
    {
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();

        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;
        const uint DOSIZE = 0xF008;
        Sql SQL = new Sql();

        public Form1()
        {
            InitializeComponent();
        }

        //
        //Function
        //

        private static void SetDoubleBuffered(Control c)
        {
            if (SystemInformation.TerminalServerSession)
                return;
            PropertyInfo aProp = typeof(Control).GetProperty("DoubleBuffered",
            BindingFlags.NonPublic |
            BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        private void ChangePanel(Panel currPanel)
        {
            if(currPanel != mainPanel) mainPanel.Visible = false;
            if (currPanel != authPanel) authPanel.Visible = false;
            if (currPanel != profilePanel) profilePanel.Visible = false;

            currPanel.Location = new Point(0, 10);
            currPanel.Size = new Size(603, 873);
            currPanel.Visible = true;
        }

        Panel globalSlider;
        Panel ShownPanel;
        private void StartSlider(GradientPanel slider, Panel showpan)
        {
            isShown = false;
            slider.Size = new Size(1000, 1000);
            slider.Visible = true;
            slider.Location = new Point(-slider.Width, 0);
            slider.BringToFront();
            exit.BringToFront();
            Random rnd = new Random();
            slider.Angle = rnd.Next(0,360);
            slider.Invalidate();

            globalSlider = slider;
            ShownPanel = showpan;
            Animator_Slider.Enabled = true;
        }

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        private void PlayMusic(string url)
        {
            wplayer.controls.stop();
            wplayer.URL = url;
            wplayer.controls.play();
        }

        private void StopMusic()
        {
            wplayer.controls.stop();
        }

        //
        //Designer
        //

        private void login_Enter(object sender, EventArgs e)
        {
            if (login.Text == "Псевдоним")
            {
                login.Text = "";
                login.ForeColor = Color.Black;
                login.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void login_Leave(object sender, EventArgs e)
        {
            if (login.Text == "")
            {
                login.Text = "Псевдоним";
                login.ForeColor = Color.Gray;
                login.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Пароль")
            {
                pass.Text = "";
                pass.ForeColor = Color.Black;
                pass.TextAlign = HorizontalAlignment.Center;
                pass.PasswordChar = '•';
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.Text = "Пароль";
                pass.ForeColor = Color.Gray;
                pass.TextAlign = HorizontalAlignment.Left;
                pass.PasswordChar = '\0';

            }
        }

        private void load_History(ListBox listBox) 
        {
            listBox.Items.Clear();
            foreach (var row in SQL.GetHistory())
                listBox.Items.Add($"{row[2]} - {row[3]}. {row[7]}");
        }
        
        private void auth_Click(object sender, EventArgs e)
        {
            try
            {
                
                SQL.ConnectDB();
                if (SQL.Authorize(login.Text, pass.Text))
                {
                   
                    stat_auth.Text = "Успех";
                    StartSlider(Slider, mainPanel);
                    username.Text = "@" + SQL.GlobalUsermame.ToUpper();
                    load_History(listBox1);
                }
                else
                {
                    stat_auth.Text = "Введены неверные данные";

                }
                SQL.CloseDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.HelpLink, "Ошибка авторизации");
            }
        }

        float currentAngle = 0;
        float speedGradient = 0;
        bool isRight = false;
        Random rnd = new Random();
        private void Animator_Gradient_Tick(object sender, EventArgs e)
        {
            speedGradient = Math.Abs(currentAngle - authPanel.Angle) / 45f;

            if (authPanel.Angle < 0)
                authPanel.Angle = 360 - Math.Abs(authPanel.Angle);

            if (authPanel.Angle > 360)
                authPanel.Angle = authPanel.Angle - 360;

            if ((currentAngle - 40 < authPanel.Angle) && (currentAngle + 40 > authPanel.Angle))
            {
                currentAngle = rnd.Next(0, 360);
                if (rnd.Next(0, 2) == 0)
                    isRight = false;
                else
                    isRight = true;
            }

            if (isRight)
            {
                authPanel.Angle += speedGradient;
            }
            else
            {
                authPanel.Angle -= speedGradient;

            }
            if (authPanel.Angle % 45 == 0)
            {
                authPanel.Angle += 0.1f;
            }
            authPanel.Invalidate();
        }

        Bitmap WaveAnimBimap;
        private void Form1_Load(object sender, EventArgs e)
        {
            SetDoubleBuffered(authPanel);
            SetDoubleBuffered(mainPanel);
            SetDoubleBuffered(profilePanel);

            SetDoubleBuffered(Slider);

            exit.BackColor = Color.FromArgb(180, 192, 0, 0);
            AnimWave.Image = new Bitmap(579, 238);
            gAnimWave = Graphics.FromImage(AnimWave.Image);
            var ms = new MemoryStream();
            Resources.full_anim.Save(ms, ImageFormat.Png);
            WaveAnimBimap = new Bitmap(ms);
            ChangePanel(authPanel);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            authPanel.Focus();


        }



        private void auth_MouseDown(object sender, MouseEventArgs e)
        {
            auth.ForeColor = Color.Gray;
        }

        private void auth_MouseUp(object sender, MouseEventArgs e)
        {
            auth.ForeColor = Color.Silver;

        }

        private void login_TextChanged(object sender, EventArgs e)
        {
            stat_auth.Text = "Введите данные";
        }

        private void reg_MouseDown(object sender, MouseEventArgs e)
        {
            reg.ForeColor = Color.Gray;

        }

        private void reg_MouseUp(object sender, MouseEventArgs e)
        {
            reg.ForeColor = Color.Silver;

        }

        private void reg_Click(object sender, EventArgs e)
        {
            try
            {
                Sql SQL = new Sql();
                SQL.ConnectDB();
                if (SQL.CreateNewAccount(login.Text, pass.Text))
                {
                    stat_auth.Text = "Успех";
                    StartSlider(Slider, profilePanel);
                    username.Text = "@" + SQL.GlobalUsermame.ToUpper();

                }
                else
                {
                    stat_auth.Text = "Данный логин уже существует";

                }
                SQL.CloseDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.HelpLink, "Ошибка регистрации");
            }
        }



        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }

        private void AuthPanel_MouseDown(object sender, MouseEventArgs e)
        {
            authPanel.Focus();

            Form1_MouseDown(null, null);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            authPanel.Focus();

            Form1_MouseDown(null, null);

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            authPanel.Focus();

            Form1_MouseDown(null, null);

        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.BackColor = Color.FromArgb(180, 192, 0, 0);
        }

        private void exit_MouseDown(object sender, MouseEventArgs e)
        {
            exit.BackColor = Color.Maroon;
        }

        private void exit_MouseUp(object sender, MouseEventArgs e)
        {
            exit.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stat_auth_MouseDown(object sender, MouseEventArgs e)
        {
            authPanel.Focus();

            Form1_MouseDown(null, null);
        }

        private void auth_MouseEnter(object sender, EventArgs e)
        {
            auth.ForeColor = Color.Silver;

        }

        private void auth_MouseLeave(object sender, EventArgs e)
        {
            auth.ForeColor = Color.White;

        }

        private void reg_MouseEnter(object sender, EventArgs e)
        {
            reg.ForeColor = Color.Silver;

        }

        private void reg_MouseLeave(object sender, EventArgs e)
        {
            reg.ForeColor = Color.White;

        }

        int currentFrame = 0;
        Graphics gAnimWave;
        int waitWave = 0;
        private void Animator_Wave_Tick(object sender, EventArgs e)
        {
            
            if (currentFrame == 30) { currentFrame = 0; waitWave = 0; }
            waitWave++;
            if (waitWave > 20)
            {
                currentFrame++;
                gAnimWave.Clear(Color.Transparent);

                gAnimWave.DrawImage(WaveAnimBimap, new Rectangle(0, 0, 579, 238), 0, (currentFrame - 1) * 476, 1158, 476, GraphicsUnit.Pixel);
                AnimWave.Invalidate();
                GC.Collect();
            }
        }

        bool Inward = true;
        int wait = 100;
        int Speed = 0;
        private void Animator_Logo_Tick(object sender, EventArgs e)
        {
            wait++;
            if (Logo.Size.Width < 8)
            {
                Inward = false;
                if (wait > 50)
                {
                    Logo.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                    wait = 0;
                    Logo.Size = new Size(1, Logo.Size.Height);
                }
            }

            if (Logo.Size.Width >= 200)
            {
                Inward = true;
                if (wait > 50)
                {
                    wait = 0;
                }
            }
            if (Inward) Speed = 4;

            if (!Inward)
                Speed = (int)(4 * (2 - ((float)Logo.Size.Width / 100f)) + 2);


            if (Speed % 2 != 0)
                Speed++;


            if ((Inward) && (wait > 10))
                Logo.Size = new Size(Logo.Size.Width - Speed, Logo.Size.Height);


            if ((!Inward) && (wait > 10))
                Logo.Size = new Size(Logo.Size.Width + Speed, Logo.Size.Height);


            Logo.Location = new Point((mainPanel.Width - Logo.Size.Width) / 2, Logo.Location.Y);
        }

        bool isShown = false;
        int speedSlider = 0;
        private void Animator_Slider_Begin_Tick(object sender, EventArgs e)
        {
            speedSlider =15  + (int)(70 * ((float)(Math.Abs(globalSlider.Location.X)) / (float)(globalSlider.Height)));

            globalSlider.Location = new Point(globalSlider.Location.X + speedSlider, globalSlider.Location.Y);

            if (globalSlider.Location.X >= 0 && isShown == false)
            {
                globalSlider.Location = new Point(0, globalSlider.Location.Y);
                ChangePanel(ShownPanel);
                isShown = true;
            }

            if (globalSlider.Location.X > globalSlider.Width)
            {
                globalSlider.Visible = false;
                Animator_Slider.Enabled = false;
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mainPanel.Focus();

            Form1_MouseDown(null, null);
        }

        private void Logo_MouseDown(object sender, MouseEventArgs e)
        {
            mainPanel.Focus();

            Form1_MouseDown(null, null);
        }

        private void AnimWave_MouseDown(object sender, MouseEventArgs e)
        {
            mainPanel.Focus();

            Form1_MouseDown(null, null);
        }

        private void statMusic_MouseDown(object sender, MouseEventArgs e)
        {
            mainPanel.Focus();

            Form1_MouseDown(null, null);
        }

        private void url_Enter(object sender, EventArgs e)
        {
            if (url.Text == "Введите URL")
            {
                url.Text = "";
                url.ForeColor = Color.Black;
            }
        }

        private void url_Leave(object sender, EventArgs e)
        {
            if (url.Text == "")
            {
                url.Text = "Введите URL";
                url.ForeColor = Color.Gray;
            }
        }

        Composition temp_comp;
        private void chooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            openFileDialog1.Filter = "Звуковые файлы | *.mp3; *.m4a; *.wav; *.wma; *.ogg ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Animator_Logo.Enabled = true;
                Animator_Wave.Enabled = true;
                temp_comp = MusicChecker.GetCompositionData(openFileDialog1.FileName);
                PageParser.Start(webBrowser1, temp_comp, Result);
            }


        }
        
        public void Result(bool result)
        {
            Animator_Logo.Enabled = false;
            Animator_Wave.Enabled = false;
            Logo.Size = new Size(199, 199);
            Graphics g = Graphics.FromImage(AnimWave.Image);
            Logo.Location = new Point((mainPanel.Width - Logo.Size.Width) / 2, Logo.Location.Y);
            g.Clear(Color.Transparent);
            AnimWave.Invalidate();

            string lic = result ? "The composition has copyright" : "The composition has no copyright";
            MessageBox.Show(lic);

            SQL.AddHistory(temp_comp.title, temp_comp.artist, temp_comp.album, temp_comp.release_date, temp_comp.apple_music_url, lic);

            load_History(listBox1);
        }

        private void url_TextChanged(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void check_MouseDown(object sender, MouseEventArgs e)
        {
            check.ForeColor = Color.Gray;
        }

        private void check_MouseUp(object sender, MouseEventArgs e)
        {
            check.ForeColor = Color.Silver;
        }

        private void check_MouseEnter(object sender, EventArgs e)
        {
            check.ForeColor = Color.Silver;
        }

        private void check_MouseLeave(object sender, EventArgs e)
        {
            check.ForeColor = Color.White;

        }

        private void check_Click(object sender, EventArgs e)
        {

        }

        private void profilePanel_MouseDown(object sender, MouseEventArgs e)
        {
            profilePanel.Focus();

            Form1_MouseDown(null, null);
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            profilePanel.Focus();

            Form1_MouseDown(null, null);
        }

        private void username_MouseDown(object sender, MouseEventArgs e)
        {
            profilePanel.Focus();

            Form1_MouseDown(null, null);
        }

        private void gradientPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            profilePanel.Focus();

            Form1_MouseDown(null, null);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            profilePanel.Focus();

            Form1_MouseDown(null, null);
        }

        private void changeUsername_Click(object sender, EventArgs e)
        {
            SQL.ConnectDB();

            SQL.ChangeUsername(usernameTextbox.Text);
            SQL.CloseDB();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            StartSlider(Slider, profilePanel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartSlider(Slider, authPanel);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            StartSlider(Slider, mainPanel);
        }
    }
}
