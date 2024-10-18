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
        public Form1()
        {
            InitializeComponent();
        }

        public static ArrayList recipes = new ArrayList();
        public static int clickedRecipe;
        public static int pageNum=0;


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
                pictureBox1.Visible = false;
            }
            //TODO: FIX THIS TO UPDATE ALL PICTUREBOXES
        }

        private void recipeShow(int box)
        {
            RecipeShown show = new RecipeShown();
            clickedRecipe = box;
            show.Show();
        }

        //Picture box clicker driver codes
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.recipeShow(0);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.recipeShow(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.recipeShow(2);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.recipeShow(3);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.recipeShow(4);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.recipeShow(5);
        }

        //Page button drivers
        private void AddRecipebtn_Click(object sender, EventArgs e)
        {
            Form2 AddRecipe = new Form2();
            AddRecipe.Show();
        }
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
