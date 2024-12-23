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
    public partial class FormAddUser : Form
    {
        FormMain fmain;
        public FormAddUser(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void labelReturnDate_GKU_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddNewUser_KRM_Click(object sender, EventArgs e)
        {
            fmain.dataGridViewMain_KRM.Rows.Add(textBoxUserID_KRM.Text, textBoxUserName_KRM.Text, textBoxUserAddress_KRM.Text, textBoxUserPhone_KRM.Text, textBoxUserBookArticle_KRM.Text, textBoxUserGetBookDate_KRM.Text, textBoxBookUserReturnBookDate_KRM.Text);

            this.Close();
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {

        }
    }

}
