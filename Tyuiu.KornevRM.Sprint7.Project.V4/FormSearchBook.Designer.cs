namespace Tyuiu.KornevRM.Sprint7.Project.V4
{
    partial class FormSearchBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchBook));
            this.buttonAddNewBook_KRM = new System.Windows.Forms.Button();
            this.labelIsBookNew_KRM = new System.Windows.Forms.Label();
            this.labelArticle_KRM = new System.Windows.Forms.Label();
            this.comboBoxIsBookNew_KRM = new System.Windows.Forms.ComboBox();
            this.textBoxBookSearch_KRM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddNewBook_KRM
            // 
            this.buttonAddNewBook_KRM.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAddNewBook_KRM.Location = new System.Drawing.Point(116, 199);
            this.buttonAddNewBook_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddNewBook_KRM.Name = "buttonAddNewBook_KRM";
            this.buttonAddNewBook_KRM.Size = new System.Drawing.Size(110, 34);
            this.buttonAddNewBook_KRM.TabIndex = 29;
            this.buttonAddNewBook_KRM.Text = "Найти";
            this.buttonAddNewBook_KRM.UseVisualStyleBackColor = false;
            this.buttonAddNewBook_KRM.Click += new System.EventHandler(this.buttonAddNewBook_KRM_Click);
            // 
            // labelIsBookNew_KRM
            // 
            this.labelIsBookNew_KRM.AutoSize = true;
            this.labelIsBookNew_KRM.BackColor = System.Drawing.Color.Transparent;
            this.labelIsBookNew_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIsBookNew_KRM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelIsBookNew_KRM.Location = new System.Drawing.Point(44, 124);
            this.labelIsBookNew_KRM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIsBookNew_KRM.Name = "labelIsBookNew_KRM";
            this.labelIsBookNew_KRM.Size = new System.Drawing.Size(54, 13);
            this.labelIsBookNew_KRM.TabIndex = 28;
            this.labelIsBookNew_KRM.Text = "Искать:";
            this.labelIsBookNew_KRM.Click += new System.EventHandler(this.labelIsBookNew_GKU_Click);
            // 
            // labelArticle_KRM
            // 
            this.labelArticle_KRM.AutoSize = true;
            this.labelArticle_KRM.BackColor = System.Drawing.Color.Transparent;
            this.labelArticle_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArticle_KRM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelArticle_KRM.Location = new System.Drawing.Point(32, 60);
            this.labelArticle_KRM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelArticle_KRM.Name = "labelArticle_KRM";
            this.labelArticle_KRM.Size = new System.Drawing.Size(66, 13);
            this.labelArticle_KRM.TabIndex = 27;
            this.labelArticle_KRM.Text = "Поиск по:";
            // 
            // comboBoxIsBookNew_KRM
            // 
            this.comboBoxIsBookNew_KRM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIsBookNew_KRM.FormattingEnabled = true;
            this.comboBoxIsBookNew_KRM.Items.AddRange(new object[] {
         "артикулу",
         "названию",
         "автору",
         "дате издания",
         "жанру",
         "аннотации"});
            this.comboBoxIsBookNew_KRM.Location = new System.Drawing.Point(102, 57);
            this.comboBoxIsBookNew_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxIsBookNew_KRM.Name = "comboBoxIsBookNew_KRM";
            this.comboBoxIsBookNew_KRM.Size = new System.Drawing.Size(166, 21);
            this.comboBoxIsBookNew_KRM.TabIndex = 26;
            this.comboBoxIsBookNew_KRM.TabStop = false;
            // 
            // textBoxBookSearch_KRM
            // 
            this.textBoxBookSearch_KRM.Location = new System.Drawing.Point(102, 121);
            this.textBoxBookSearch_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookSearch_KRM.Name = "textBoxBookSearch_KRM";
            this.textBoxBookSearch_KRM.Size = new System.Drawing.Size(166, 20);
            this.textBoxBookSearch_KRM.TabIndex = 25;
            this.textBoxBookSearch_KRM.TextChanged += new System.EventHandler(this.textBoxBookSearch_GKU_TextChanged);
            // 
            // FormSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(341, 268);
            this.Controls.Add(this.buttonAddNewBook_KRM);
            this.Controls.Add(this.labelIsBookNew_KRM);
            this.Controls.Add(this.labelArticle_KRM);
            this.Controls.Add(this.comboBoxIsBookNew_KRM);
            this.Controls.Add(this.textBoxBookSearch_KRM);
            this.Name = "FormSearchBook";
            this.Text = "Найти книгу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNewBook_KRM;
        private System.Windows.Forms.Label labelIsBookNew_KRM;
        private System.Windows.Forms.Label labelArticle_KRM;
        private System.Windows.Forms.ComboBox comboBoxIsBookNew_KRM;
        private System.Windows.Forms.TextBox textBoxBookSearch_KRM;
    }

}