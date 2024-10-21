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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(115, 105);
            this.Namelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(123, 22);
            this.Namelbl.TabIndex = 0;
            this.Namelbl.Text = "Recipe Name:";
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(116, 131);
            this.Nametxt.Margin = new System.Windows.Forms.Padding(4);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(250, 22);
            this.Nametxt.TabIndex = 1;
            // 
            // Ingredientstxt
            // 
            this.Ingredientstxt.Location = new System.Drawing.Point(119, 209);
            this.Ingredientstxt.Margin = new System.Windows.Forms.Padding(4);
            this.Ingredientstxt.Name = "Ingredientstxt";
            this.Ingredientstxt.Size = new System.Drawing.Size(247, 22);
            this.Ingredientstxt.TabIndex = 3;
            // 
            // Ingredientslbl
            // 
            this.Ingredientslbl.AutoSize = true;
            this.Ingredientslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingredientslbl.Location = new System.Drawing.Point(115, 183);
            this.Ingredientslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ingredientslbl.Name = "Ingredientslbl";
            this.Ingredientslbl.Size = new System.Drawing.Size(103, 22);
            this.Ingredientslbl.TabIndex = 2;
            this.Ingredientslbl.Text = "Ingredients:";
            // 
            // EnterIngredbtn
            // 
            this.EnterIngredbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterIngredbtn.Location = new System.Drawing.Point(119, 426);
            this.EnterIngredbtn.Margin = new System.Windows.Forms.Padding(4);
            this.EnterIngredbtn.Name = "EnterIngredbtn";
            this.EnterIngredbtn.Size = new System.Drawing.Size(274, 42);
            this.EnterIngredbtn.TabIndex = 4;
            this.EnterIngredbtn.Text = "Enter";
            this.EnterIngredbtn.UseVisualStyleBackColor = true;
            this.EnterIngredbtn.Click += new System.EventHandler(this.EnterIngredbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add New Recipe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Photo:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterIngredbtn);
            this.Controls.Add(this.Ingredientstxt);
            this.Controls.Add(this.Ingredientslbl);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.Namelbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Enter";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Ingredientstxt;
        private System.Windows.Forms.Label Ingredientslbl;
        private System.Windows.Forms.Button EnterIngredbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}