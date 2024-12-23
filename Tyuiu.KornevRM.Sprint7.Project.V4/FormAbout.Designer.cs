namespace Tyuiu.KornevRM.Sprint7.Project.V4
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            textBoxAbout_KRM = new TextBox();
            pictureBoxIcon_KRM = new PictureBox();
            buttonOK_KRM = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon_KRM).BeginInit();
            SuspendLayout();
            // 
            // textBoxAbout_KRM
            // 
            textBoxAbout_KRM.BackColor = SystemColors.Control;
            textBoxAbout_KRM.BorderStyle = BorderStyle.None;
            textBoxAbout_KRM.Location = new Point(277, 17);
            textBoxAbout_KRM.Multiline = true;
            textBoxAbout_KRM.Name = "textBoxAbout_KRM";
            textBoxAbout_KRM.ReadOnly = true;
            textBoxAbout_KRM.Size = new Size(329, 334);
            textBoxAbout_KRM.TabIndex = 5;
            textBoxAbout_KRM.TabStop = false;
            textBoxAbout_KRM.Text = "                              Разработчик: \r\n                 Корнев Руслан Максимович\r\n                     ТИУ ВШЦТ ИСПб-24-1 \r\n                                    2024\r\n";
            // 
            // pictureBoxIcon_KRM
            // 
            pictureBoxIcon_KRM.Image = (Image)resources.GetObject("pictureBoxIcon_KRM.Image");
            pictureBoxIcon_KRM.Location = new Point(15, 17);
            pictureBoxIcon_KRM.Name = "pictureBoxIcon_KRM";
            pictureBoxIcon_KRM.Size = new Size(237, 271);
            pictureBoxIcon_KRM.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIcon_KRM.TabIndex = 4;
            pictureBoxIcon_KRM.TabStop = false;
            // 
            // buttonOK_KRM
            // 
            buttonOK_KRM.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK_KRM.Location = new Point(460, 357);
            buttonOK_KRM.Name = "buttonOK_KRM";
            buttonOK_KRM.Size = new Size(116, 43);
            buttonOK_KRM.TabIndex = 3;
            buttonOK_KRM.Text = "Ок";
            buttonOK_KRM.UseVisualStyleBackColor = true;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 417);
            Controls.Add(textBoxAbout_KRM);
            Controls.Add(pictureBoxIcon_KRM);
            Controls.Add(buttonOK_KRM);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormAbout";
            Text = "FormAbout";
            Load += FormAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon_KRM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAbout_KRM;
        private System.Windows.Forms.PictureBox pictureBoxIcon_KRM;
        private System.Windows.Forms.Button buttonOK_KRM;
    }

}