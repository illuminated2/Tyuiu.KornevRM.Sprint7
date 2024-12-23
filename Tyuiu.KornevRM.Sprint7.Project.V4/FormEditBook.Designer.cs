namespace Tyuiu.KornevRM.Sprint7.Project.V4
{
    partial class FormEditBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditBook));
            this.buttonEditNewBook_KRM = new System.Windows.Forms.Button();
            this.labelIsBookNew_KRM = new System.Windows.Forms.Label();
            this.labelGenre_KRM = new System.Windows.Forms.Label();
            this.labelYear_KRM = new System.Windows.Forms.Label();
            this.labelAuthor_KRM = new System.Windows.Forms.Label();
            this.labelBook_Name = new System.Windows.Forms.Label();
            this.labelArticle_KRM = new System.Windows.Forms.Label();
            this.comboBoxIsBookNew_KRM = new System.Windows.Forms.ComboBox();
            this.textBoxBookGenre_KRM = new System.Windows.Forms.TextBox();
            this.textBoxBookYear_KRM = new System.Windows.Forms.TextBox();
            this.textBoxBookAuthor_KRM = new System.Windows.Forms.TextBox();
            this.textBoxBookName_KRM = new System.Windows.Forms.TextBox();
            this.textBoxBookArticle_KRM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEditNewBook_KRM
            // 
            this.buttonEditNewBook_KRM.Location = new System.Drawing.Point(240, 167);
            this.buttonEditNewBook_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditNewBook_KRM.Name = "buttonEditNewBook_KRM";
            this.buttonEditNewBook_KRM.Size = new System.Drawing.Size(110, 34);
            this.buttonEditNewBook_KRM.TabIndex = 39;
            this.buttonEditNewBook_KRM.Text = "Редактировать";
            this.buttonEditNewBook_KRM.UseVisualStyleBackColor = true;
            this.buttonEditNewBook_KRM.Click += new System.EventHandler(this.buttonEditNewBook_KRM_Click);
            // 
            // labelIsBookNew_KRM
            // 
            this.labelIsBookNew_KRM.AutoSize = true;
            this.labelIsBookNew_KRM.BackColor = System.Drawing.Color.Transparent;
            this.labelIsBookNew_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIsBookNew_KRM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelIsBookNew_KRM.Location = new System.Drawing.Point(249, 123);
            this.labelIsBookNew_KRM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIsBookNew_KRM.Name = "labelIsBookNew_KRM";
            this.labelIsBookNew_KRM.Size = new System.Drawing.Size(101, 13);
            this.labelIsBookNew_KRM.TabIndex = 37;
            this.labelIsBookNew_KRM.Text = "Новое издание:";
            // 
            // labelGenre_KRM
            // 
            this.labelGenre_KRM.AutoSize = true;
            this.labelGenre_KRM.BackColor = System.Drawing.Color.Transparent;
            this.labelGenre_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenre_KRM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGenre_KRM.Location = new System.Drawing.Point(304, 67);
            this.labelGenre_KRM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGenre_KRM.Name = "labelGenre_KRM";
            this.labelGenre_KRM.Size = new System.Drawing.Size(44, 13);
            this.labelGenre_KRM.TabIndex = 36;
            this.labelGenre_KRM.Text = "Жанр:";
            // 
            // labelYear_KRM
            // 
            this.labelYear_KRM.AutoSize = true;
            this.labelYear_KRM.BackColor = System.Drawing.Color.Transparent;
            this.labelYear_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear_KRM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelYear_KRM.Location = new System.Drawing.Point(41, 121);
            this.labelYear_KRM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelYear_KRM.Name = "labelYear_KRM";
            this.labelYear_KRM.Size = new System.Drawing.Size(86, 13);
            this.labelYear_KRM.TabIndex = 35;
            this.labelYear_KRM.Text = "Год выпуска:";
            // 
            // labelAuthor_KRM
            // 
            this.labelAuthor_KRM.AutoSize = true;
            this.labelAuthor_KRM.BackColor = System.Drawing.Color.Transparent;
            this.labelAuthor_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthor_KRM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAuthor_KRM.Location = new System.Drawing.Point(62, 71);
            this.labelAuthor_KRM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAuthor_KRM.Name = "labelAuthor_KRM";
            this.labelAuthor_KRM.Size = new System.Drawing.Size(46, 13);
            this.labelAuthor_KRM.TabIndex = 34;
            this.labelAuthor_KRM.Text = "Автор:";
            // 
            // labelBook_Name
            // 
            this.labelBook_Name.AutoSize = true;
            this.labelBook_Name.BackColor = System.Drawing.Color.Transparent;
            this.labelBook_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBook_Name.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBook_Name.Location = new System.Drawing.Point(281, 14);
            this.labelBook_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBook_Name.Name = "labelBook_Name";
            this.labelBook_Name.Size = new System.Drawing.Size(69, 13);
            this.labelBook_Name.TabIndex = 33;
            this.labelBook_Name.Text = "Название:";
            // 
            // labelArticle_KRM
            // 
            this.labelArticle_KRM.AutoSize = true;
            this.labelArticle_KRM.BackColor = System.Drawing.Color.Transparent;
            this.labelArticle_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArticle_KRM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelArticle_KRM.Location = new System.Drawing.Point(47, 18);
            this.labelArticle_KRM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelArticle_KRM.Name = "labelArticle_KRM";
            this.labelArticle_KRM.Size = new System.Drawing.Size(59, 13);
            this.labelArticle_KRM.TabIndex = 32;
            this.labelArticle_KRM.Text = "Артикул:";
            // 
            // comboBoxIsBookNew_KRM
            // 
            this.comboBoxIsBookNew_KRM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIsBookNew_KRM.FormattingEnabled = true;
            this.comboBoxIsBookNew_KRM.Items.AddRange(new object[] {
        "да",
        "нет"});
            this.comboBoxIsBookNew_KRM.Location = new System.Drawing.Point(352, 119);
            this.comboBoxIsBookNew_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxIsBookNew_KRM.Name = "comboBoxIsBookNew_KRM";
            this.comboBoxIsBookNew_KRM.Size = new System.Drawing.Size(166, 21);
            this.comboBoxIsBookNew_KRM.TabIndex = 31;
            this.comboBoxIsBookNew_KRM.TabStop = false;
            // 
            // textBoxBookGenre_KRM
            // 
            this.textBoxBookGenre_KRM.Location = new System.Drawing.Point(352, 64);
            this.textBoxBookGenre_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookGenre_KRM.Name = "textBoxBookGenre_KRM";
            this.textBoxBookGenre_KRM.Size = new System.Drawing.Size(166, 20);
            this.textBoxBookGenre_KRM.TabIndex = 26;
            // 
            // textBoxBookYear_KRM
            // 
            this.textBoxBookYear_KRM.Location = new System.Drawing.Point(131, 116);
            this.textBoxBookYear_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookYear_KRM.Name = "textBoxBookYear_KRM";
            this.textBoxBookYear_KRM.Size = new System.Drawing.Size(118, 20);
            this.textBoxBookYear_KRM.TabIndex = 27;
            // 
            // textBoxBookAuthor_KRM
            // 
            this.textBoxBookAuthor_KRM.Location = new System.Drawing.Point(112, 68);
            this.textBoxBookAuthor_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookAuthor_KRM.Name = "textBoxBookAuthor_KRM";
            this.textBoxBookAuthor_KRM.Size = new System.Drawing.Size(137, 20);
            this.textBoxBookAuthor_KRM.TabIndex = 28;
            // 
            // textBoxBookName_KRM
            // 
            this.textBoxBookName_KRM.Location = new System.Drawing.Point(351, 11);
            this.textBoxBookName_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookName_KRM.Name = "textBoxBookName_KRM";
            this.textBoxBookName_KRM.Size = new System.Drawing.Size(166, 20);
            this.textBoxBookName_KRM.TabIndex = 29;
            // 
            // textBoxBookArticle_KRM
            // 
            this.textBoxBookArticle_KRM.Location = new System.Drawing.Point(110, 16);
            this.textBoxBookArticle_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookArticle_KRM.Name = "textBoxBookArticle_KRM";
            this.textBoxBookArticle_KRM.Size = new System.Drawing.Size(139, 20);
            this.textBoxBookArticle_KRM.TabIndex = 30;
            // 
            // FormEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 222);
            this.Controls.Add(this.buttonEditNewBook_KRM);
            this.Controls.Add(this.labelIsBookNew_KRM);
            this.Controls.Add(this.labelGenre_KRM);
            this.Controls.Add(this.labelYear_KRM);
            this.Controls.Add(this.labelAuthor_KRM);
            this.Controls.Add(this.labelBook_Name);
            this.Controls.Add(this.labelArticle_KRM);
            this.Controls.Add(this.comboBoxIsBookNew_KRM);
            this.Controls.Add(this.textBoxBookGenre_KRM);
            this.Controls.Add(this.textBoxBookYear_KRM);
            this.Controls.Add(this.textBoxBookAuthor_KRM);
            this.Controls.Add(this.textBoxBookName_KRM);
            this.Controls.Add(this.textBoxBookArticle_KRM);
            this.Name = "FormEditBook";
            this.Text = "Редактирование книги";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditNewBook_KRM;
        private System.Windows.Forms.Label labelIsBookNew_KRM;
        private System.Windows.Forms.Label labelGenre_KRM;
        private System.Windows.Forms.Label labelYear_KRM;
        private System.Windows.Forms.Label labelAuthor_KRM;
        private System.Windows.Forms.Label labelBook_Name;
        private System.Windows.Forms.Label labelArticle_KRM;
        public System.Windows.Forms.ComboBox comboBoxIsBookNew_KRM;
        public System.Windows.Forms.TextBox textBoxBookGenre_KRM;
        public System.Windows.Forms.TextBox textBoxBookYear_KRM;
        public System.Windows.Forms.TextBox textBoxBookAuthor_KRM;
        public System.Windows.Forms.TextBox textBoxBookName_KRM;
        public System.Windows.Forms.TextBox textBoxBookArticle_KRM;
    }

}