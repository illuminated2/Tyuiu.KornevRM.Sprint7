namespace Tyuiu.KornevRM.Sprint7.Project.V4
{
    partial class FormEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditUser));
            this.textBoxUserGetBookDate_KRM = new System.Windows.Forms.TextBox();
            this.buttonEditUser_KRM = new System.Windows.Forms.Button();
            this.labelReturnDate_KRM = new System.Windows.Forms.Label();
            this.labelGetDate_KRM = new System.Windows.Forms.Label();
            this.labelUserBookArticle_KRM = new System.Windows.Forms.Label();
            this.labelPhone_KRM = new System.Windows.Forms.Label();
            this.labelAddress_KRM = new System.Windows.Forms.Label();
            this.labelName_KRM = new System.Windows.Forms.Label();
            this.labelID_KRM = new System.Windows.Forms.Label();
            this.textBoxBookUserReturnBookDate_KRM = new System.Windows.Forms.TextBox();
            this.textBoxUserBookArticle_KRM = new System.Windows.Forms.TextBox();
            this.textBoxUserPhone_KRM = new System.Windows.Forms.TextBox();
            this.textBoxUserAddress_KRM = new System.Windows.Forms.TextBox();
            this.textBoxUserName_KRM = new System.Windows.Forms.TextBox();
            this.textBoxUserID_KRM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxUserGetBookDate_KRM
            // 
            this.textBoxUserGetBookDate_KRM.Location = new System.Drawing.Point(117, 257);
            this.textBoxUserGetBookDate_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserGetBookDate_KRM.Name = "textBoxUserGetBookDate_KRM";
            this.textBoxUserGetBookDate_KRM.Size = new System.Drawing.Size(166, 20);
            this.textBoxUserGetBookDate_KRM.TabIndex = 55;
            // 
            // buttonEditUser_KRM
            // 
            this.buttonEditUser_KRM.Location = new System.Drawing.Point(94, 346);
            this.buttonEditUser_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditUser_KRM.Name = "buttonEditUser_KRM";
            this.buttonEditUser_KRM.Size = new System.Drawing.Size(110, 34);
            this.buttonEditUser_KRM.TabIndex = 54;
            this.buttonEditUser_KRM.Text = "Добавить";
            this.buttonEditUser_KRM.UseVisualStyleBackColor = true;
            this.buttonEditUser_KRM.Click += new System.EventHandler(this.buttonEditUser_KRM_Click);
            // 
            // labelReturnDate_KRM
            // 
            this.labelReturnDate_KRM.AutoSize = true;
            this.labelReturnDate_KRM.BackColor = System.Drawing.Color.Transparent;
            this.labelReturnDate_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReturnDate_KRM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelReturnDate_KRM.Location = new System.Drawing.Point(13, 309);
            this.labelReturnDate_KRM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReturnDate_KRM.Name = "labelReturnDate_KRM";
            this.labelReturnDate_KRM.Size = new System.Drawing.Size(100, 13);
            this.labelReturnDate_KRM.TabIndex = 53;
            this.labelReturnDate_KRM.Text = "Дата возврата:";
            // 
            // labelGetDate_KRM
            // 
            this.labelGetDate_KRM.AutoSize = true;
            this.labelGetDate_KRM.BackColor = System.Drawing.Color.Transparent;
            this.labelGetDate_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGetDate_KRM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGetDate_KRM.Location = new System.Drawing.Point(7, 260);
            this.labelGetDate_KRM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGetDate_KRM.Name = "labelGetDate_KRM";
            this.labelGetDate_KRM.Size = new System.Drawing.Size(106, 13);
            this.labelGetDate_KRM.TabIndex = 52;
            this.labelGetDate_KRM.Text = "Дата получения:";
            // 
            // labelUserBookArticle_KRM
            // 
            this.labelUserBookArticle_KRM.AutoSize = true;
            this.labelUserBookArticle_KRM.BackColor = System.Drawing.Color.Transparent;
            this.labelUserBookArticle_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserBookArticle_KRM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUserBookArticle_KRM.Location = new System.Drawing.Point(16, 208);
            this.labelUserBookArticle_KRM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserBookArticle_KRM.Name = "labelUserBookArticle_KRM";
            this.labelUserBookArticle_KRM.Size = new System.Drawing.Size(97, 13);
            this.labelUserBookArticle_KRM.TabIndex = 51;
            this.labelUserBookArticle_KRM.Text = "Артикул книги:";
            // 
            // labelPhone_KRM
            // 
            this.labelPhone_KRM.AutoSize = true;
            this.labelPhone_KRM.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone_KRM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPhone_KRM.Location = new System.Drawing.Point(2, 157);
            this.labelPhone_KRM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhone_KRM.Name = "labelPhone_KRM";
            this.labelPhone_KRM.Size = new System.Drawing.Size(111, 13);
            this.labelPhone_KRM.TabIndex = 50;
            this.labelPhone_KRM.Text = "Номер телефона:";
            // 
            // labelAddress_KRM
            // 
            this.labelAddress_KRM.AutoSize = true;
            this.labelAddress_KRM.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress_KRM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAddress_KRM.Location = new System.Drawing.Point(66, 107);
            this.labelAddress_KRM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress_KRM.Name = "labelAddress_KRM";
            this.labelAddress_KRM.Size = new System.Drawing.Size(47, 13);
            this.labelAddress_KRM.TabIndex = 49;
            this.labelAddress_KRM.Text = "Адрес:";
            // 
            // labelName_KRM
            // 
            this.labelName_KRM.AutoSize = true;
            this.labelName_KRM.BackColor = System.Drawing.Color.Transparent;
            this.labelName_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName_KRM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelName_KRM.Location = new System.Drawing.Point(72, 62);
            this.labelName_KRM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName_KRM.Name = "labelName_KRM";
            this.labelName_KRM.Size = new System.Drawing.Size(41, 13);
            this.labelName_KRM.TabIndex = 48;
            this.labelName_KRM.Text = "ФИО:";
            // 
            // labelID_KRM
            // 
            this.labelID_KRM.AutoSize = true;
            this.labelID_KRM.BackColor = System.Drawing.Color.Transparent;
            this.labelID_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID_KRM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelID_KRM.Location = new System.Drawing.Point(18, 23);
            this.labelID_KRM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID_KRM.Name = "labelID_KRM";
            this.labelID_KRM.Size = new System.Drawing.Size(95, 13);
            this.labelID_KRM.TabIndex = 47;
            this.labelID_KRM.Text = "Номер билета:";
            // 
            // textBoxBookUserReturnBookDate_KRM
            // 
            this.textBoxBookUserReturnBookDate_KRM.Location = new System.Drawing.Point(117, 306);
            this.textBoxBookUserReturnBookDate_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookUserReturnBookDate_KRM.Name = "textBoxBookUserReturnBookDate_KRM";
            this.textBoxBookUserReturnBookDate_KRM.Size = new System.Drawing.Size(166, 20);
            this.textBoxBookUserReturnBookDate_KRM.TabIndex = 41;
            // 
            // textBoxUserBookArticle_KRM
            // 
            this.textBoxUserBookArticle_KRM.Location = new System.Drawing.Point(117, 205);
            this.textBoxUserBookArticle_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserBookArticle_KRM.Name = "textBoxUserBookArticle_KRM";
            this.textBoxUserBookArticle_KRM.Size = new System.Drawing.Size(166, 20);
            this.textBoxUserBookArticle_KRM.TabIndex = 42;
            // 
            // textBoxUserPhone_KRM
            // 
            this.textBoxUserPhone_KRM.Location = new System.Drawing.Point(117, 154);
            this.textBoxUserPhone_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserPhone_KRM.Name = "textBoxUserPhone_KRM";
            this.textBoxUserPhone_KRM.Size = new System.Drawing.Size(166, 20);
            this.textBoxUserPhone_KRM.TabIndex = 43;
            // 
            // textBoxUserAddress_KRM
            // 
            this.textBoxUserAddress_KRM.Location = new System.Drawing.Point(117, 104);
            this.textBoxUserAddress_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserAddress_KRM.Name = "textBoxUserAddress_KRM";
            this.textBoxUserAddress_KRM.Size = new System.Drawing.Size(166, 20);
            this.textBoxUserAddress_KRM.TabIndex = 44;
            // 
            // textBoxUserName_KRM
            // 
            this.textBoxUserName_KRM.Location = new System.Drawing.Point(117, 59);
            this.textBoxUserName_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserName_KRM.Name = "textBoxUserName_KRM";
            this.textBoxUserName_KRM.Size = new System.Drawing.Size(166, 20);
            this.textBoxUserName_KRM.TabIndex = 45;
            // 
            // textBoxUserID_KRM
            // 
            this.textBoxUserID_KRM.Location = new System.Drawing.Point(117, 20);
            this.textBoxUserID_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserID_KRM.Name = "textBoxUserID_KRM";
            this.textBoxUserID_KRM.Size = new System.Drawing.Size(166, 20);
            this.textBoxUserID_KRM.TabIndex = 46;
            // 
            // FormEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(307, 450);
            this.Controls.Add(this.textBoxUserGetBookDate_KRM);
            this.Controls.Add(this.buttonEditUser_KRM);
            this.Controls.Add(this.labelReturnDate_KRM);
            this.Controls.Add(this.labelGetDate_KRM);
            this.Controls.Add(this.labelUserBookArticle_KRM);
            this.Controls.Add(this.labelPhone_KRM);
            this.Controls.Add(this.labelAddress_KRM);
            this.Controls.Add(this.labelName_KRM);
            this.Controls.Add(this.labelID_KRM);
            this.Controls.Add(this.textBoxBookUserReturnBookDate_KRM);
            this.Controls.Add(this.textBoxUserBookArticle_KRM);
            this.Controls.Add(this.textBoxUserPhone_KRM);
            this.Controls.Add(this.textBoxUserAddress_KRM);
            this.Controls.Add(this.textBoxUserName_KRM);
            this.Controls.Add(this.textBoxUserID_KRM);
            this.Name = "FormEditUser";
            this.Text = "Редактировать читателя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserGetBookDate_KRM;
        private System.Windows.Forms.Button buttonEditUser_KRM;
        private System.Windows.Forms.Label labelReturnDate_KRM;
        private System.Windows.Forms.Label labelGetDate_KRM;
        private System.Windows.Forms.Label labelUserBookArticle_KRM;
        private System.Windows.Forms.Label labelPhone_KRM;
        private System.Windows.Forms.Label labelAddress_KRM;
        private System.Windows.Forms.Label labelName_KRM;
        private System.Windows.Forms.Label labelID_KRM;
        private System.Windows.Forms.TextBox textBoxBookUserReturnBookDate_KRM;
        private System.Windows.Forms.TextBox textBoxUserBookArticle_KRM;
        private System.Windows.Forms.TextBox textBoxUserPhone_KRM;
        private System.Windows.Forms.TextBox textBoxUserAddress_KRM;
        private System.Windows.Forms.TextBox textBoxUserName_KRM;
        private System.Windows.Forms.TextBox textBoxUserID_KRM;
    }

}