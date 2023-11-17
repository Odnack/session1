namespace SportProducts
{
    partial class NewOrder
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
            this.label_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sumOrder = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(8, 7);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(106, 15);
            this.label_name.TabIndex = 27;
            this.label_name.Text = "Имя пользователя";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::SportProducts.Properties.Resources.logo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // sumOrder
            // 
            this.sumOrder.AutoSize = true;
            this.sumOrder.Location = new System.Drawing.Point(12, 168);
            this.sumOrder.Name = "sumOrder";
            this.sumOrder.Size = new System.Drawing.Size(86, 13);
            this.sumOrder.TabIndex = 28;
            this.sumOrder.Text = "Сумма заказа: ";
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(12, 195);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(89, 13);
            this.discountLabel.TabIndex = 29;
            this.discountLabel.Text = "Скидка заказа: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(11, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 39);
            this.button1.TabIndex = 30;
            this.button1.Text = "Выбрать пункт выдачи";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(261, 230);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.sumOrder);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NewOrder";
            this.Text = "NewOrder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label sumOrder;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Button button1;
    }
}