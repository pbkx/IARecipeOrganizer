using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public static List<PictureBox> boxes = new List<PictureBox>();
        public static int pageNum=0;

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

        


    
        public void updateBoxes()
        {
            foreach (PictureBox b in boxes)
            {
                b.Visible = false;
                b.Enabled = false;
            }

            for (int i = 0; i < Math.Min(6, recipes.Count); i++)
            {
                boxes[i].Visible = true;
                boxes[i].Enabled = true;
            }
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            boxes.Add(this.pictureBox1);
            boxes.Add(this.pictureBox2);
            boxes.Add(this.pictureBox3);
            boxes.Add(this.pictureBox4);
            boxes.Add(this.pictureBox5);
            boxes.Add(this.pictureBox6);

            if (pageNum <= 0)
            {
                Leftbtn.Hide();
            }
            else 
            { 
                Leftbtn.Show();
            }
            

            this.CenterToScreen();
            //this.SetControls();
            this.updateBoxes();
        }

        private void SetControls()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;   
   
            this.pictureBox1.Enabled = false;
            this.pictureBox2.Enabled = false;
            this.pictureBox3.Enabled = false;
            this.pictureBox4.Enabled = false;
            this.pictureBox5.Enabled = false;
            this.pictureBox6.Enabled = false;
        }



        private void getSearch()
        {
            String text = txtSearch.Text.Trim();
            foreach (Recipe r in recipes)
            {
                if (text.Equals(r.getName()))
                {
                    MessageBox.Show("Recipe Found! Recipe number " + (recipes.IndexOf(r) + 1));
                }
            }
            //MessageBox.Show(text);
        }
     
        public void AddRecipe(Recipe r)
        {
            recipes.Add(r);
            this.updateBoxes();
        }



        private void recipeShow(int box)
        {
            RecipeShown show = new RecipeShown();
            clickedRecipe = box;
            show.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.getSearch();
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

        private void AddRecipebtn_Click(object sender, EventArgs e)
        {
            Form2 AddRecipe = new Form2();
            AddRecipe.Show();
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
