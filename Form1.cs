using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

        


    /*
    public void updateBoxes()
    {
        List<PictureBox> boxes = new List<PictureBox>();

        for (int i = 1; i <= recipes.Count; i++)
        {
            pictureBox1.Visible = false;
        }
        //TODO: FIX THIS TO UPDATE ALL PICTUREBOXES
    }
    */
        private void Form1_Load(object sender, EventArgs e)
        {

            
            if (pageNum <= 0)
            {
                Leftbtn.Hide();
            }
            else 
            { 
                Leftbtn.Show();
            }
            

            this.CenterToScreen();
            this.SetControls();
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
                    MessageBox.Show("you fatty");
                }
            }
            //MessageBox.Show(text);
        }
     
        public void AddRecipe(Recipe r)
        {
            recipes.Add(r);

            bool pic_one = recipes.Count.Equals(1);
            bool pic_two = recipes.Count.Equals(2);
            bool pic_three = recipes.Count.Equals(3);
            bool pic_four = recipes.Count.Equals(4);
            bool pic_five = recipes.Count.Equals(5);
            bool pic_six = recipes.Count.Equals(6);

            if (pic_one)
            {
                MessageBox.Show("it worked");
            }

            this.pictureBox1.Visible = true;
            this.pictureBox2.Visible = pic_two;
            this.pictureBox3.Visible = pic_three;
            this.pictureBox4.Visible = pic_four;
            this.pictureBox5.Visible = pic_five;
            this.pictureBox6.Visible = pic_six;
        }



        private void recipeShow(int box)
        {
            try 
            {

                RecipeShown show = new RecipeShown();
                clickedRecipe = box;
                show.Show();
            }
            catch
            {
            
            }   
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
