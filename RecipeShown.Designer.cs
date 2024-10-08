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
            this.SuspendLayout();
            // 
            // InIngredlbl
            // 
            this.InIngredlbl.AutoSize = true;
            this.InIngredlbl.Location = new System.Drawing.Point(313, 199);
            this.InIngredlbl.Name = "InIngredlbl";
            this.InIngredlbl.Size = new System.Drawing.Size(115, 13);
            this.InIngredlbl.TabIndex = 0;
            this.InIngredlbl.Text = "Insert Ingredients here:";
            this.InIngredlbl.Click += new System.EventHandler(this.InIngredlbl_Click);
            // 
            // RecipeShown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InIngredlbl);
            this.Name = "RecipeShown";
            this.Text = "RecipeShown";
            this.Load += new System.EventHandler(this.RecipeShown_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InIngredlbl;
    }
}