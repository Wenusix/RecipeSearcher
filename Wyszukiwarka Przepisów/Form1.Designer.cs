namespace Wyszukiwarka_Przepisów
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel panelTitleBar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.appInf = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.Panel();
            this.titleItem = new System.Windows.Forms.Label();
            this.difficultyItem = new System.Windows.Forms.Label();
            this.portionsItem = new System.Windows.Forms.Label();
            this.ratingItem = new System.Windows.Forms.Label();
            this.totaltimeItem = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.portionLabel = new System.Windows.Forms.Label();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.favorite = new System.Windows.Forms.Panel();
            this.cookidoo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.contact = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            panelTitleBar = new System.Windows.Forms.Panel();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.appInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.search.SuspendLayout();
            this.cookidoo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.contact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            panelTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelTitleBar.Controls.Add(this.IblTitleChildForm);
            panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            panelTitleBar.Location = new System.Drawing.Point(175, 0);
            panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            panelTitleBar.Size = new System.Drawing.Size(645, 41);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // IblTitleChildForm
            // 
            this.IblTitleChildForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IblTitleChildForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IblTitleChildForm.Location = new System.Drawing.Point(40, 9);
            this.IblTitleChildForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IblTitleChildForm.Name = "IblTitleChildForm";
            this.IblTitleChildForm.Size = new System.Drawing.Size(80, 19);
            this.IblTitleChildForm.TabIndex = 1;
            this.IblTitleChildForm.Text = "O aplikacji";
            this.IblTitleChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IblTitleChildForm.Click += new System.EventHandler(this.IblTitleChildForm_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.iconCurrentChildForm.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconCurrentChildForm.IconSize = 21;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(15, 8);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(21, 21);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelMenu.Controls.Add(this.iconButton7);
            this.panelMenu.Controls.Add(this.iconButton6);
            this.panelMenu.Controls.Add(this.iconButton5);
            this.panelMenu.Controls.Add(this.iconButton4);
            this.panelMenu.Controls.Add(this.iconButton3);
            this.panelMenu.Controls.Add(this.iconButton2);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(175, 440);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconButton7
            // 
            this.iconButton7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButton7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton7.IconColor = System.Drawing.Color.White;
            this.iconButton7.IconSize = 25;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton7.Location = new System.Drawing.Point(20, 390);
            this.iconButton7.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Rotation = 0D;
            this.iconButton7.Size = new System.Drawing.Size(133, 34);
            this.iconButton7.TabIndex = 7;
            this.iconButton7.Text = "Zamkniij";
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = false;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // iconButton6
            // 
            this.iconButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButton6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton6.IconColor = System.Drawing.Color.White;
            this.iconButton6.IconSize = 25;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton6.Location = new System.Drawing.Point(20, 301);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Rotation = 0D;
            this.iconButton6.Size = new System.Drawing.Size(133, 34);
            this.iconButton6.TabIndex = 6;
            this.iconButton6.Text = "Kontakt";
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = false;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButton5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconSize = 25;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton5.Location = new System.Drawing.Point(20, 345);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Rotation = 0D;
            this.iconButton5.Size = new System.Drawing.Size(133, 34);
            this.iconButton5.TabIndex = 5;
            this.iconButton5.Text = "Kod aplikacji";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButton4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Ravelry;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconSize = 25;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton4.Location = new System.Drawing.Point(20, 255);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Rotation = 0D;
            this.iconButton4.Size = new System.Drawing.Size(133, 34);
            this.iconButton4.TabIndex = 4;
            this.iconButton4.Text = "Cookidoo";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconSize = 25;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton3.Location = new System.Drawing.Point(20, 210);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(133, 34);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.Text = "Ulubione";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconSize = 25;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton2.Location = new System.Drawing.Point(20, 163);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(133, 34);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "Wyszukiwanie";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton1.Location = new System.Drawing.Point(20, 119);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(133, 34);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "O aplikacji";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(175, 101);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = global::Wyszukiwarka_Przepisów.Properties.Resources.Apka_Wyszukiwarka;
            this.pictureBox1.Image = global::Wyszukiwarka_Przepisów.Properties.Resources.Apka_Wyszukiwarka;
            this.pictureBox1.InitialImage = global::Wyszukiwarka_Przepisów.Properties.Resources.Apka_Wyszukiwarka;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(175, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 399);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(102)))), ((int)(((byte)(34)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(187, 430);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 10);
            this.panel2.TabIndex = 3;
            // 
            // appInf
            // 
            this.appInf.AutoSize = true;
            this.appInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.appInf.Controls.Add(this.label1);
            this.appInf.Controls.Add(this.pictureBox2);
            this.appInf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appInf.Location = new System.Drawing.Point(0, 0);
            this.appInf.Name = "appInf";
            this.appInf.Size = new System.Drawing.Size(820, 440);
            this.appInf.TabIndex = 4;
            this.appInf.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(259, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 260);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Image = global::Wyszukiwarka_Przepisów.Properties.Resources.Meditation;
            this.pictureBox2.Location = new System.Drawing.Point(-17, -215);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1000, 760);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.search.Controls.Add(this.pictureBox4);
            this.search.Controls.Add(this.label5);
            this.search.Controls.Add(this.titleItem);
            this.search.Controls.Add(this.difficultyItem);
            this.search.Controls.Add(this.portionsItem);
            this.search.Controls.Add(this.ratingItem);
            this.search.Controls.Add(this.totaltimeItem);
            this.search.Controls.Add(this.listBox2);
            this.search.Controls.Add(this.ingredientsLabel);
            this.search.Controls.Add(this.difficultyLabel);
            this.search.Controls.Add(this.portionLabel);
            this.search.Controls.Add(this.totalTimeLabel);
            this.search.Controls.Add(this.ratingLabel);
            this.search.Controls.Add(this.titleLabel);
            this.search.Controls.Add(this.listBox1);
            this.search.Controls.Add(this.label4);
            this.search.Controls.Add(this.button1);
            this.search.Controls.Add(this.textBox1);
            this.search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search.Location = new System.Drawing.Point(0, 0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(820, 440);
            this.search.TabIndex = 5;
            this.search.Visible = false;
            // 
            // titleItem
            // 
            this.titleItem.AutoSize = true;
            this.titleItem.Location = new System.Drawing.Point(640, 119);
            this.titleItem.Name = "titleItem";
            this.titleItem.Size = new System.Drawing.Size(51, 13);
            this.titleItem.TabIndex = 15;
            this.titleItem.Text = "{titleItem}";
            // 
            // difficultyItem
            // 
            this.difficultyItem.AutoSize = true;
            this.difficultyItem.Location = new System.Drawing.Point(641, 203);
            this.difficultyItem.Name = "difficultyItem";
            this.difficultyItem.Size = new System.Drawing.Size(73, 13);
            this.difficultyItem.TabIndex = 14;
            this.difficultyItem.Text = "{difficultyItem}";
            // 
            // portionsItem
            // 
            this.portionsItem.AutoSize = true;
            this.portionsItem.Location = new System.Drawing.Point(640, 184);
            this.portionsItem.Name = "portionsItem";
            this.portionsItem.Size = new System.Drawing.Size(72, 13);
            this.portionsItem.TabIndex = 13;
            this.portionsItem.Text = "{portionsItem}";
            // 
            // ratingItem
            // 
            this.ratingItem.AutoSize = true;
            this.ratingItem.Location = new System.Drawing.Point(640, 138);
            this.ratingItem.Name = "ratingItem";
            this.ratingItem.Size = new System.Drawing.Size(61, 13);
            this.ratingItem.TabIndex = 12;
            this.ratingItem.Text = "{ratingItem}";
            // 
            // totaltimeItem
            // 
            this.totaltimeItem.AutoSize = true;
            this.totaltimeItem.Location = new System.Drawing.Point(640, 163);
            this.totaltimeItem.Name = "totaltimeItem";
            this.totaltimeItem.Size = new System.Drawing.Size(74, 13);
            this.totaltimeItem.TabIndex = 11;
            this.totaltimeItem.Text = "{totaltimeItem}";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(262, 313);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(253, 95);
            this.listBox2.TabIndex = 10;
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Location = new System.Drawing.Point(198, 313);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(55, 13);
            this.ingredientsLabel.TabIndex = 9;
            this.ingredientsLabel.Text = "Składniki:";
            this.ingredientsLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(530, 203);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(90, 13);
            this.difficultyLabel.TabIndex = 8;
            this.difficultyLabel.Text = "Poziom trudności:";
            // 
            // portionLabel
            // 
            this.portionLabel.AutoSize = true;
            this.portionLabel.Location = new System.Drawing.Point(530, 184);
            this.portionLabel.Name = "portionLabel";
            this.portionLabel.Size = new System.Drawing.Size(40, 13);
            this.portionLabel.TabIndex = 7;
            this.portionLabel.Text = "Porcje:";
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Location = new System.Drawing.Point(530, 163);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(104, 13);
            this.totalTimeLabel.TabIndex = 6;
            this.totalTimeLabel.Text = "Czas przygotowania:";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(530, 140);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(42, 13);
            this.ratingLabel.TabIndex = 5;
            this.ratingLabel.Text = "Ocena:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(530, 119);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(35, 13);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Tytuł:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(262, 116);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 173);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(259, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Wpisz produkt spożywczy:\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(262, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(404, 20);
            this.textBox1.TabIndex = 0;
            // 
            // favorite
            // 
            this.favorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.favorite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favorite.Location = new System.Drawing.Point(0, 0);
            this.favorite.Name = "favorite";
            this.favorite.Size = new System.Drawing.Size(820, 440);
            this.favorite.TabIndex = 6;
            this.favorite.Visible = false;
            // 
            // cookidoo
            // 
            this.cookidoo.AutoSize = true;
            this.cookidoo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cookidoo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.cookidoo.Controls.Add(this.label3);
            this.cookidoo.Controls.Add(this.pictureBox3);
            this.cookidoo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cookidoo.Location = new System.Drawing.Point(0, 0);
            this.cookidoo.Name = "cookidoo";
            this.cookidoo.Size = new System.Drawing.Size(820, 440);
            this.cookidoo.TabIndex = 7;
            this.cookidoo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(245, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(517, 167);
            this.label3.TabIndex = 1;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Wyszukiwarka_Przepisów.Properties.Resources.cookidoo11;
            this.pictureBox3.Location = new System.Drawing.Point(109, 299);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(801, 157);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // contact
            // 
            this.contact.BackColor = System.Drawing.Color.AntiqueWhite;
            this.contact.Controls.Add(this.label2);
            this.contact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contact.Location = new System.Drawing.Point(0, 0);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(820, 440);
            this.contact.TabIndex = 8;
            this.contact.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(340, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 192);
            this.label2.TabIndex = 0;
            this.label2.Text = "\r\nChętnie odpowiem na pytania.\r\nZachęcam do dzielenia się opiniami.\r\n\r\n\r\nZaprasza" +
    "m do kontaktu drogą e-mail:\r\n\r\nmartynabakula09@gmail.com\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // code
            // 
            this.code.BackColor = System.Drawing.SystemColors.Info;
            this.code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.code.Location = new System.Drawing.Point(0, 0);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(820, 440);
            this.code.TabIndex = 9;
            this.code.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Wyniki:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(533, 255);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(181, 133);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 440);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.search);
            this.Controls.Add(this.appInf);
            this.Controls.Add(this.code);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.cookidoo);
            this.Controls.Add(this.favorite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.appInf.ResumeLayout(false);
            this.appInf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.search.ResumeLayout(false);
            this.search.PerformLayout();
            this.cookidoo.ResumeLayout(false);
            this.cookidoo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.contact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label IblTitleChildForm;
        private FontAwesome.Sharp.IconButton iconButton7;
        private System.Windows.Forms.Panel appInf;
        private System.Windows.Forms.Panel search;
        private System.Windows.Forms.Panel favorite;
        private System.Windows.Forms.Panel cookidoo;
        private System.Windows.Forms.Panel contact;
        private System.Windows.Forms.Panel code;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label portionLabel;
        private System.Windows.Forms.Label totalTimeLabel;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.Label difficultyItem;
        private System.Windows.Forms.Label portionsItem;
        private System.Windows.Forms.Label ratingItem;
        private System.Windows.Forms.Label totaltimeItem;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label titleItem;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
    }
}

