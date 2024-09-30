namespace RecipeOrganizer
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Namelbl = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Ingredientstxt = new System.Windows.Forms.TextBox();
            this.Ingredientslbl = new System.Windows.Forms.Label();
            this.EnterIngredbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(256, 117);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(75, 13);
            this.Namelbl.TabIndex = 0;
            this.Namelbl.Text = "Recipe Name:";
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(353, 114);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(100, 20);
            this.Nametxt.TabIndex = 1;
            // 
            // Ingredientstxt
            // 
            this.Ingredientstxt.Location = new System.Drawing.Point(353, 161);
            this.Ingredientstxt.Name = "Ingredientstxt";
            this.Ingredientstxt.Size = new System.Drawing.Size(100, 20);
            this.Ingredientstxt.TabIndex = 3;
            // 
            // Ingredientslbl
            // 
            this.Ingredientslbl.AutoSize = true;
            this.Ingredientslbl.Location = new System.Drawing.Point(256, 164);
            this.Ingredientslbl.Name = "Ingredientslbl";
            this.Ingredientslbl.Size = new System.Drawing.Size(62, 13);
            this.Ingredientslbl.TabIndex = 2;
            this.Ingredientslbl.Text = "Ingredients:";
            // 
            // EnterIngredbtn
            // 
            this.EnterIngredbtn.Location = new System.Drawing.Point(367, 213);
            this.EnterIngredbtn.Name = "EnterIngredbtn";
            this.EnterIngredbtn.Size = new System.Drawing.Size(75, 23);
            this.EnterIngredbtn.TabIndex = 4;
            this.EnterIngredbtn.Text = "Enter";
            this.EnterIngredbtn.UseVisualStyleBackColor = true;
            this.EnterIngredbtn.Click += new System.EventHandler(this.EnterIngredbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnterIngredbtn);
            this.Controls.Add(this.Ingredientstxt);
            this.Controls.Add(this.Ingredientslbl);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.Namelbl);
            this.Name = "Form2";
            this.Text = "Enter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Ingredientstxt;
        private System.Windows.Forms.Label Ingredientslbl;
        private System.Windows.Forms.Button EnterIngredbtn;
    }
}