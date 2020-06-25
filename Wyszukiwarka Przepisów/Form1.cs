using FontAwesome.Sharp;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Wyszukiwarka_Przepisów
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private struct RGBColors
        {
            public static Color color = Color.FromArgb(191, 36, 109);

        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {

                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(249, 163, 26);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;


            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(239, 102, 34);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {

            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //appInfoPanel.Controls.Add(childForm);
            // appInfoPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            IblTitleChildForm.Text = childForm.Text;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset1();
        }
        private void Reset1()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.InfoCircle;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            // appInfoPanel.Text = "InfoCircle";
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset1();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            IblTitleChildForm.Text = "O aplikacji";
            appInf.Visible = true;
            search.Visible = false;
            favorite.Visible = false;
            cookidoo.Visible = false;
            contact.Visible = false;
            code.Visible = false;



        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            IblTitleChildForm.Text = "Wyszukiwarka";
            appInf.Visible = false;
            search.Visible = true;
            favorite.Visible = false;
            cookidoo.Visible = false;
            contact.Visible = false;
            code.Visible = false;
        }


        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            IblTitleChildForm.Text = "Ulubione";
            appInf.Visible = false;
            search.Visible = false;
            favorite.Visible = true;
            cookidoo.Visible = false;
            contact.Visible = false;
            code.Visible = false;

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            IblTitleChildForm.Text = "Cookidoo";
            appInf.Visible = false;
            search.Visible = false;
            favorite.Visible = false;
            cookidoo.Visible = true;
            contact.Visible = false;
            code.Visible = false;

        }


        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            IblTitleChildForm.Text = "Kod aplikacji";

            IblTitleChildForm.Text = "Kontakt";
            appInf.Visible = false;
            search.Visible = false;
            favorite.Visible = false;
            cookidoo.Visible = false;
            contact.Visible = false;
            code.Visible = true;
        }
        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            IblTitleChildForm.Text = "Kontakt";
            appInf.Visible = false;
            search.Visible = false;
            favorite.Visible = false;
            cookidoo.Visible = false;
            contact.Visible = true;
            code.Visible = false;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IblTitleChildForm_Click(object sender, EventArgs e)
        {

        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("http://192.168.1.19:8080/?word=" + textBox1.Text);
                Debug.WriteLine(json);
            }
        }
    }
}
