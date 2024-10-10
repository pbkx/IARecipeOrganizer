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
    public partial class RecipeShown : Form
    {
        public RecipeShown()
        {
            InitializeComponent();
        }

        private void RecipeShown_Load(object sender, EventArgs e)
        {
            Recipe current = (Recipe)Form1.recipes[index: (Form1.clickedRecipe+Form1.pageNum*6)];
            InIngredlbl.Text = current.getIngredients();
            Namelbl.Text = current.getName();
        }

        private void InIngredlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
