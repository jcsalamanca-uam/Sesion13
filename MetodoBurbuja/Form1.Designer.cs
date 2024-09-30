namespace MetodoBurbuja
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbNumber = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LbNumeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un numero";
            // 
            // TbNumber
            // 
            this.TbNumber.Location = new System.Drawing.Point(211, 22);
            this.TbNumber.Name = "TbNumber";
            this.TbNumber.Size = new System.Drawing.Size(100, 26);
            this.TbNumber.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(359, 25);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(106, 37);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LbNumeros
            // 
            this.LbNumeros.FormattingEnabled = true;
            this.LbNumeros.ItemHeight = 20;
            this.LbNumeros.Location = new System.Drawing.Point(37, 84);
            this.LbNumeros.Name = "LbNumeros";
            this.LbNumeros.Size = new System.Drawing.Size(313, 204);
            this.LbNumeros.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbNumeros);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TbNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Metodo de burbuja";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbNumber;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ListBox LbNumeros;
    }
}

