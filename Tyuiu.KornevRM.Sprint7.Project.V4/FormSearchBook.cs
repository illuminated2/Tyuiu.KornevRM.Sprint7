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
    public partial class FormSearchBook : Form
    {
        FormMain fmain;
        public FormSearchBook(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void textBoxBookSearch_GKU_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelIsBookNew_GKU_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddNewBook_KRM_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < fmain.dataGridViewMain_KRM.RowCount; i++)
                {
                    fmain.dataGridViewMain_KRM.Rows[i].Selected = false;
                    for (int j = comboBoxIsBookNew_KRM.SelectedIndex; j < fmain.dataGridViewMain_KRM.ColumnCount; j++)
                        if (fmain.dataGridViewMain_KRM.Rows[i].Cells[j].Value != null)
                            if (fmain.dataGridViewMain_KRM.Rows[i].Cells[j].Value.ToString().Contains(textBoxBookSearch_KRM.Text))
                            {
                                fmain.dataGridViewMain_KRM.Rows[i].Selected = true;
                                break;
                            }
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка при поиске книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
