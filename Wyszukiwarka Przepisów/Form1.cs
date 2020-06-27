using FontAwesome.Sharp;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Wyszukiwarka_Przepisów
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private static readonly Color color = Color.FromArgb(191, 36, 109);

        private PanelManagingUtil managingUtil = PanelManagingUtil.getInstance();
        private Control[] panels;
        private static readonly string API = "51.83.135.15:12345";

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
            panels = new Control[] { appInf, search, favorite, cookidoo, contact, code };

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

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowPanel("O aplikacji", appInf, iconButton1);

        }

        private void ShowPanel(string title, Control componentToSee, IconButton iconButton)
        {
            ActivateButton(iconButton, color);
            IblTitleChildForm.Text = title;
            managingUtil.ShowControlElement(panels, componentToSee);
            visibleSearchedItems(false);
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            ShowPanel("O aplikacji", appInf, iconButton1);
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            ShowPanel("Wyszukiwarka", search, iconButton2);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ShowPanel("Cookido", cookidoo, iconButton4);
        }
        private void iconButton5_Click(object sender, EventArgs e)
        {
            ShowPanel("Kod aplikacji", code, iconButton5);
        }
        private void iconButton6_Click(object sender, EventArgs e)
        {
            ShowPanel("Kontakt", contact, iconButton6);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenRecipesList()
        {
            recipiesRepository.FindAll().ForEach(v => listBox1.Items.Add(v.toModel()));
        }

        Repository<string, Recipe> recipiesRepository = RecipeRepository.GetRepository();

        private void button1_Click_1(object sender, EventArgs e)
        {
            Search();
        }

        public void Search()
        {
            if (textBox1.Text == null || textBox1.Text.Equals(""))
            {
                MessageBox.Show("Pole nie może być puste.");
                return;
            }
            listBox1.Items.Clear();

            using (WebClient wc = new WebClient())
            {
                visibleSearchedItems(false);
                wc.Encoding = Encoding.UTF8;
                string url = $"http://{API}/?word=" + textBox1.Text;

                textBox1.Enabled = false;
                button1.Enabled = false;

                pictureBox5.Visible = true;
                wc.DownloadStringAsync(new Uri(url));
                wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(wc_GetDataFromBackEnd);
                
               
            }
        }

        void wc_GetDataFromBackEnd(object sender, DownloadStringCompletedEventArgs e)
        {
        try
        {
            string json = e.Result;
            JArray jObject = JArray.Parse(json);
            List<Recipe> recipes = new List<Recipe>();
            foreach (JObject i in jObject.Children())
            {
                var recipeBuilder = Recipe.GetBuilder()
                    .Id(i["id"].ToString())
                    .Title(i["title"].ToString())
                    .Portions(Convert.ToInt32(i["portions"].ToString()))
                    .Rating(Convert.ToDouble(i["rating"].ToString()))
                    .Difficulty(i["difficulty"].ToString())
                    .TotalTime(Convert.ToInt32(i["totaltime"].ToString()))
                    .Image(i["link"].ToString());

                foreach (var j in ((JArray)i["ingredients"]).Children())
                {
                    recipeBuilder.Ingredient(j.ToString());
                }

                recipes.Add(recipeBuilder.Build());
            }
            textBox1.Enabled = true;
            button1.Enabled = true;
            pictureBox5.Visible = false;
            if (recipes.Count == 0)
            {
                MessageBox.Show("Nie znaleziono żadnego przepisu.");
                return;
            }
            recipiesRepository.Clear();
            recipiesRepository.SaveAll(recipes);
            OpenRecipesList();
            textBox1.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd z połączeniem.");
                textBox1.Enabled = true;
                button1.Enabled = true;
                pictureBox5.Visible = false;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is RecipeModel model)
            {
                Recipe recipe = model.toRecipe();
                ratingItem.Text = recipe.GetRatingStars();
                titleItem.Text = recipe.Title;
                portionsItem.Text = recipe.Portions.ToString();
                difficultyItem.Text = recipe.GetDifficultyText();
                totaltimeItem.Text = recipe.GetTotalMinutesInText();
                pictureBox4.Image = recipe.Image;
                listBox2.Items.Clear();
                foreach (string item in recipe.Ingredients)
                {
                    listBox2.Items.Add(item);
                }
                visibleSearchedItems(true);
            }
        }

        private void visibleSearchedItems(bool visible)
        {
            ratingItem.Visible = visible;
            ratingLabel.Visible = visible;
            titleItem.Visible = visible;
            portionsItem.Visible = visible;
            difficultyItem.Visible = visible;
            totaltimeItem.Visible = visible;
            pictureBox4.Visible = visible;
            listBox2.Visible = visible;
            titleLabel.Visible = visible;
            portionLabel.Visible = visible;
            difficultyLabel.Visible = visible;
            totalTimeLabel.Visible = visible;
            ingredientsLabel.Visible = visible;
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(listBox1!=null)
                System.Diagnostics.Process.Start(((RecipeModel)listBox1.SelectedItem).GetLink());
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Wenusix/RecipeSeacher");
        }
    }
}
