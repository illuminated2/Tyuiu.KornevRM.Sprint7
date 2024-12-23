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
    public partial class FormEditUser : Form
    {
        FormMain fmain;
        public FormEditUser(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void buttonEditUser_KRM_Click(object sender, EventArgs e)
        {
            int a = fmain.dataGridViewMain_KRM.CurrentRow.Index;
            fmain.dataGridViewMain_KRM.Rows[a].Cells[0].Value = textBoxUserID_KRM.Text;
            fmain.dataGridViewMain_KRM.Rows[a].Cells[1].Value = textBoxUserName_KRM.Text;
            fmain.dataGridViewMain_KRM.Rows[a].Cells[2].Value = textBoxUserAddress_KRM.Text;
            fmain.dataGridViewMain_KRM.Rows[a].Cells[3].Value = textBoxUserPhone_KRM.Text;
            fmain.dataGridViewMain_KRM.Rows[a].Cells[4].Value = textBoxUserBookArticle_KRM.Text;
            fmain.dataGridViewMain_KRM.Rows[a].Cells[5].Value = textBoxUserGetBookDate_KRM.Text;
            fmain.dataGridViewMain_KRM.Rows[a].Cells[6].Value = textBoxBookUserReturnBookDate_KRM.Text;
            this.Close();

        }
    }

}
