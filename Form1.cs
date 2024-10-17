using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeOrganizer
{
    public partial class Form1 : Form
    {
        public static ArrayList recipes = new ArrayList();
        public static int clickedRecipe;
        public static int pageNum=0;
        public Form1()
        {
            InitializeComponent();
        }

        public void AddRecipe(Recipe r)
        {
            recipes.Add(r);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (pageNum <= 0)
            {
                Leftbtn.Hide();
            }
            else { 
                Leftbtn.Show();
            }
        }
    
        //Takes the text entered in the search bar
        private void getSearch()
        {
            String text = txtSearch.Text.Trim();
            foreach (Recipe r in recipes)
            {
                if (text.Equals(r.getName()))
                {
                    MessageBox.Show("you fatty");
                }
            }
            //MessageBox.Show(text);
        }

        public void updateBoxes()
        {
            List<PictureBox> boxes = new List<PictureBox>();
            
            for (int i = 1; i <= recipes.Count; i++)
            {
                pictureBox1.Visible = true;
            }
            //TODO: FIX THIS TO UPDATE ALL PICTUREBOXES
        }

        //Opens add recipe form
        private void AddRecipebtn_Click(object sender, EventArgs e)
        {
            Form2 AddRecipe = new Form2();
            AddRecipe.Show();
        }

        //Picture box clicker driver codes
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (recipes.Count >= 1 + pageNum * 6 && recipes[0] != null)
            {
                RecipeShown recipeshown = new RecipeShown();
                clickedRecipe = 0;
                recipeshown.Show();
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (recipes.Count >= 2 + pageNum * 6 && recipes[1] != null)
            {
                RecipeShown recipeshown = new RecipeShown();
                clickedRecipe = 1;
                recipeshown.Show();
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (recipes.Count >= 3 + pageNum * 6 && recipes[2] != null)
            {
                RecipeShown recipeshown = new RecipeShown();
                clickedRecipe = 2;
                recipeshown.Show();
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (recipes.Count >= 4 + pageNum * 6 && recipes[3] != null)
            {
                RecipeShown recipeshown = new RecipeShown();
                clickedRecipe = 3;
                recipeshown.Show();
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (recipes.Count >= 5 + pageNum * 6 && recipes[4] != null)
            {
                RecipeShown recipeshown = new RecipeShown();
                clickedRecipe = 4;
                recipeshown.Show();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (recipes.Count >= 6 + pageNum * 6 && recipes[5] != null)
            {
                RecipeShown recipeshown = new RecipeShown();
                clickedRecipe = 5;
                recipeshown.Show();
            }
        }

        //Page button drivers
        private void Rightbtn_Click(object sender, EventArgs e)
        {
            pageNum++;
            this.Form1_Load(sender, e);
        }

        private void Leftbtn_Click(object sender, EventArgs e)
        {
            pageNum--;
            this.Form1_Load(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.getSearch();
        }



        //Unknown
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

 
    }
}
