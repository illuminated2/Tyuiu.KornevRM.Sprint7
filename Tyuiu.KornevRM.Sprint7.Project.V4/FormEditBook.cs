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
    public partial class FormEditBook : Form
    {
        FormMain fmain;
        public FormEditBook(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void buttonEditNewBook_KRM_Click(object sender, EventArgs e)
        {
            int a = fmain.dataGridViewMain_KRM.CurrentRow.Index;
            fmain.dataGridViewMain_KRM.Rows[a].Cells[0].Value = textBoxBookArticle_KRM.Text;
            fmain.dataGridViewMain_KRM.Rows[a].Cells[1].Value = textBoxBookName_KRM.Text;
            fmain.dataGridViewMain_KRM.Rows[a].Cells[2].Value = textBoxBookAuthor_KRM.Text;
            fmain.dataGridViewMain_KRM.Rows[a].Cells[3].Value = textBoxBookYear_KRM.Text;
            fmain.dataGridViewMain_KRM.Rows[a].Cells[4].Value = textBoxBookGenre_KRM.Text;
            fmain.dataGridViewMain_KRM.Rows[a].Cells[5].Value = comboBoxIsBookNew_KRM.Text;

            this.Close();
        }
    }

}
