using System;
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
    public partial class Form2 : Form
    {
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public Form2()
        {
            InitializeComponent();
        }

        private void EnterIngredbtn_Click(object sender, EventArgs e)
        {
            Recipe recipe = new Recipe(Nametxt.Text, Ingredientstxt.Text);
            Form1 og = new Form1();
            og.AddRecipe(recipe);
            this.Close();
        }


    }
}
