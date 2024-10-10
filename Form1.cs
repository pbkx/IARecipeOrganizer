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
            PictureBox[] boxes = new PictureBox[6];
            boxes[0] = pictureBox1;
            boxes[1] = pictureBox2;
            boxes[2] = pictureBox3;
            boxes[3] = pictureBox4;
            boxes[4] = pictureBox5;
            boxes[5] = pictureBox6;
            for (int i = 6*pageNum; i < 6*pageNum+6; i++)
            {
                if (i>=recipes.Capacity) {
                    boxes[i].Image = Properties.Resources.Placeholder;
                    boxes[i].Refresh();
                    boxes[i].Visible = true;
                    //MessageBox.Show("worked");
                }
            }
            if (pageNum <= 0)
            {
                Leftbtn.Hide();
            }
            else { 
                Leftbtn.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static int getClickedRecipe()
        {
            return clickedRecipe;
        }
        public static int getPageNum()
        {
            return pageNum;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (recipes.Count>=1 && recipes[0] != null)
            {
                RecipeShown recipeshown = new RecipeShown();
                clickedRecipe = 0;
                recipeshown.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (recipes.Count >= 3 && recipes[2] != null)
            {
                RecipeShown recipeshown = new RecipeShown();
                clickedRecipe = 2;
                recipeshown.Show();
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (recipes.Count >= 4 && recipes[3] != null)
            {
                RecipeShown recipeshown = new RecipeShown();
                clickedRecipe = 3;
                recipeshown.Show();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (recipes.Count >= 2 && recipes[1] != null)
            {
                RecipeShown recipeshown = new RecipeShown();
                clickedRecipe = 1;
                recipeshown.Show();
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            foreach (Recipe item in recipes)
            {
                if (item.getName().Contains(text))
                {
                    Console.Write("this is in");
                }
            }
        }

        private void AddRecipebtn_Click(object sender, EventArgs e)
        {
            Form2 AddRecipe = new Form2();
            AddRecipe.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
    }
}
