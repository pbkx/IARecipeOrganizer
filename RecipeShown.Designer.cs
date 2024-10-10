namespace RecipeOrganizer
{
    partial class RecipeShown
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
            this.InIngredlbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InIngredlbl
            // 
            this.InIngredlbl.AutoSize = true;
            this.InIngredlbl.Location = new System.Drawing.Point(388, 199);
            this.InIngredlbl.Name = "InIngredlbl";
            this.InIngredlbl.Size = new System.Drawing.Size(115, 13);
            this.InIngredlbl.TabIndex = 0;
            this.InIngredlbl.Text = "Insert Ingredients here:";
            this.InIngredlbl.Click += new System.EventHandler(this.InIngredlbl_Click);
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(388, 132);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(128, 13);
            this.Namelbl.TabIndex = 1;
            this.Namelbl.Text = "Insert Recipe Name here:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "RECIPE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingredients:";
            // 
            // RecipeShown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.InIngredlbl);
            this.Name = "RecipeShown";
            this.Text = "RecipeShown";
            this.Load += new System.EventHandler(this.RecipeShown_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InIngredlbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}