namespace Registro
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
            this.label2 = new System.Windows.Forms.Label();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.TbProduct = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DGBProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGBProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // TbPrice
            // 
            this.TbPrice.Location = new System.Drawing.Point(117, 41);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(100, 26);
            this.TbPrice.TabIndex = 2;
            // 
            // TbProduct
            // 
            this.TbProduct.Location = new System.Drawing.Point(117, 0);
            this.TbProduct.Name = "TbProduct";
            this.TbProduct.Size = new System.Drawing.Size(100, 26);
            this.TbProduct.TabIndex = 3;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(260, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(103, 39);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DGBProducts
            // 
            this.DGBProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBProducts.Location = new System.Drawing.Point(12, 96);
            this.DGBProducts.Name = "DGBProducts";
            this.DGBProducts.RowHeadersWidth = 62;
            this.DGBProducts.RowTemplate.Height = 28;
            this.DGBProducts.Size = new System.Drawing.Size(693, 328);
            this.DGBProducts.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGBProducts);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TbProduct);
            this.Controls.Add(this.TbPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGBProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.TextBox TbProduct;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView DGBProducts;
    }
}

