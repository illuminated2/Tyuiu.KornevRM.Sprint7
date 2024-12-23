using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KornevRM.Sprint7.Project.V4
{
    public partial class FormAddBook : Form
    {
        FormMain fmain;
        public FormAddBook(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void buttonAddNewBook_KRM_Click(object sender, EventArgs e)
        {
            fmain.dataGridViewMain_KRM.Rows.Add(textBoxBookArticle_KRM.Text, textBoxBookName_KRM.Text, textBoxBookAuthor_KRM.Text, textBoxBookYear_KRM.Text, textBoxBookGenre_KRM.Text, comboBoxIsBookNew_KRM.Text);
            fmain.buttonDeleteBook_KRM.Enabled = true;
            this.Close();
        }
    }

}
