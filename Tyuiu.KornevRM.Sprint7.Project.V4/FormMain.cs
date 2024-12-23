using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KornevRM.Sprint7.Project.V4.Lib;

namespace Tyuiu.KornevRM.Sprint7.Project.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void groupBoxInfo_KRM_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxBookButtons_KRM_Enter(object sender, EventArgs e)
        {

        }
        public static string[,] LoadFromFileData(string filePath)
        {
            string FileData = File.ReadAllText(filePath);

            FileData = FileData.Replace('\n', '\r');
            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }
            return arrayValues;
        }

        private void buttonOpenBookBase_KRM_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KRM.ShowDialog();
            openFilePath = openFileDialogTask_KRM.FileName;

            string[,] arrayValues = new string[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            arrayValues = ds.GetBase(openFilePath);
            buttonBooks_KRM.Enabled = true;
            buttonDeleteBook_KRM.Enabled = true;
            buttonChangeBook_KRM.Enabled = true;
        }

        private void buttonBooks_KRM_Click(object sender, EventArgs e)
        {
            dataGridViewMain_KRM.ColumnCount = columns;
            dataGridViewMain_KRM.RowCount = rows;

            dataGridViewMain_KRM.Columns[0].HeaderText = "Артикул";
            dataGridViewMain_KRM.Columns[1].HeaderText = "Название";
            dataGridViewMain_KRM.Columns[2].HeaderText = "Автор";
            dataGridViewMain_KRM.Columns[3].HeaderText = "Год издания";
            dataGridViewMain_KRM.Columns[4].HeaderText = "Жанр";
            dataGridViewMain_KRM.Columns[5].HeaderText = "Новое издание";
            dataGridViewMain_KRM.Columns[6].HeaderText = "Аннотация";

            dataGridViewMain_KRM.Columns[0].Width = 50;
            dataGridViewMain_KRM.Columns[1].Width = 200;
            dataGridViewMain_KRM.Columns[2].Width = 100;
            dataGridViewMain_KRM.Columns[3].Width = 50;
            dataGridViewMain_KRM.Columns[4].Width = 60;
            dataGridViewMain_KRM.Columns[5].Width = 50;
            dataGridViewMain_KRM.Columns[6].Width = 300;


            dataGridViewMain_KRM.Rows[0].ReadOnly = true;
            dataGridViewMain_KRM.Columns[0].ReadOnly = true;

            string[,] arrayValues = new string[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewMain_KRM.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetBase(openFilePath);
            buttonDeleteBook_KRM.Visible = true;
            buttonChangeBook_KRM.Visible = true;
            buttonFindBook_KRM.Visible = true;
            buttonAddBook_KRM.Visible = true;
        }

        private void buttonDeleteBook_KRM_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMain_KRM.CurrentRow.Index >= 0)
                {
                    int a = dataGridViewMain_KRM.CurrentRow.Index;
                    dataGridViewMain_KRM.Rows.Remove(dataGridViewMain_KRM.Rows[a]);
                    if (dataGridViewMain_KRM.Rows.Count == 1)
                    {
                        dataGridViewMain_KRM.Rows.Clear();
                    }
                }
                if (dataGridViewMain_KRM.Rows.Count <= 1)
                {
                    buttonDeleteBook_KRM.Enabled = false;
                    buttonChangeBook_KRM.Enabled = false;
                }
                if (dataGridViewMain_KRM.Rows.Count > 1)
                {
                    buttonDeleteBook_KRM.Enabled = true;
                }
                buttonBooks_KRM.Enabled = false;

            }
            catch
            {
                MessageBox.Show("Ошибка при удалении книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddBook_KRM_Click(object sender, EventArgs e)
        {
            FormAddBook formAddBook = new FormAddBook(this);
            formAddBook.ShowDialog();
            buttonBooks_KRM.Enabled = false;
        }

        private void buttonChangeBook_KRM_Click(object sender, EventArgs e)
        {
            try
            {
                int a = dataGridViewMain_KRM.CurrentRow.Index;
                FormEditBook fed = new FormEditBook(this);
                fed.textBoxBookArticle_KRM.Text = dataGridViewMain_KRM.Rows[a].Cells[0].Value.ToString();
                fed.textBoxBookName_KRM.Text = dataGridViewMain_KRM.Rows[a].Cells[1].Value.ToString();
                fed.textBoxBookAuthor_KRM.Text = dataGridViewMain_KRM.Rows[a].Cells[2].Value.ToString();
                fed.textBoxBookYear_KRM.Text = dataGridViewMain_KRM.Rows[a].Cells[3].Value.ToString();
                fed.textBoxBookGenre_KRM.Text = dataGridViewMain_KRM.Rows[a].Cells[4].Value.ToString();
                fed.comboBoxIsBookNew_KRM.Text = dataGridViewMain_KRM.Rows[a].Cells[5].Value.ToString();

                fed.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка при редактировании книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFindBook_KRM_Click(object sender, EventArgs e)
        {
            FormSearchBook formSearchBook = new FormSearchBook(this);
            formSearchBook.ShowDialog();
        }

        private void buttonInfo_KRM_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonAddUser_KRM_Click(object sender, EventArgs e)
        {
            FormAddUser formAddUser = new FormAddUser(this);
            formAddUser.ShowDialog();
            buttonUsersBase_KRM.Enabled = false;
        }

        private void buttonUsersBase_KRM_Click(object sender, EventArgs e)
        {
            dataGridViewMain_KRM.ColumnCount = columns;
            dataGridViewMain_KRM.RowCount = rows;

            dataGridViewMain_KRM.Columns[0].HeaderText = "Номер билета";
            dataGridViewMain_KRM.Columns[1].HeaderText = "ФИО";
            dataGridViewMain_KRM.Columns[2].HeaderText = "Адрес";
            dataGridViewMain_KRM.Columns[3].HeaderText = "Номер телефона";
            dataGridViewMain_KRM.Columns[4].HeaderText = "Артикул книги";
            dataGridViewMain_KRM.Columns[5].HeaderText = "Дата получения";
            dataGridViewMain_KRM.Columns[6].HeaderText = "Дата возврата";

            dataGridViewMain_KRM.Columns[0].Width = 50;
            dataGridViewMain_KRM.Columns[1].Width = 200;
            dataGridViewMain_KRM.Columns[2].Width = 300;
            dataGridViewMain_KRM.Columns[3].Width = 200;
            dataGridViewMain_KRM.Columns[4].Width = 60;
            dataGridViewMain_KRM.Columns[5].Width = 100;
            dataGridViewMain_KRM.Columns[6].Width = 100;


            dataGridViewMain_KRM.Rows[0].ReadOnly = true;
            dataGridViewMain_KRM.Columns[0].ReadOnly = true;

            string[,] arrayValues = new string[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewMain_KRM.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetBase(openFilePath);
            buttonDeleteUser_KRM.Visible = true;
            buttonChangeUser_KRM.Visible = true;
            buttonAddUser_KRM.Visible = true;
            ToolStripMenuItemEditUsers_KRM.Enabled = true;
            buttonSaveUserBase_KRM.Enabled = true;
            ToolStripMenuItemEditUsers_KRM.Enabled = true;
        }

        private void buttonDeleteUser_KRM_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMain_KRM.CurrentRow.Index >= 0)
                {
                    int a = dataGridViewMain_KRM.CurrentRow.Index;
                    dataGridViewMain_KRM.Rows.Remove(dataGridViewMain_KRM.Rows[a]);
                    if (dataGridViewMain_KRM.Rows.Count == 1)
                    {
                        dataGridViewMain_KRM.Rows.Clear();
                    }
                }
                if (dataGridViewMain_KRM.Rows.Count <= 1)
                {
                    buttonDeleteBook_KRM.Enabled = false;
                    buttonChangeBook_KRM.Enabled = false;
                    buttonFindBook_KRM.Enabled = false;
                }
                if (dataGridViewMain_KRM.Rows.Count > 1)
                {
                    buttonDeleteBook_KRM.Enabled = true;
                }
                buttonBooks_KRM.Enabled = false;
                buttonBooks_KRM.Text = dataGridViewMain_KRM.Rows.Count.ToString();

            }
            catch
            {
                MessageBox.Show("Ошибка при удалении книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSaveUserBase_KRM_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_KRM.FileName = "UsersBase.csv";
            saveFileDialogTask_KRM.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_KRM.ShowDialog();

            string path = saveFileDialogTask_KRM.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;

            if (FileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewMain_KRM.RowCount;
            int columns = dataGridViewMain_KRM.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewMain_KRM.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewMain_KRM.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void ToolStripMenuItemSaveUser_KRM_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_KRM.FileName = "UsersBase.csv";
            saveFileDialogTask_KRM.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_KRM.ShowDialog();

            string path = saveFileDialogTask_KRM.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;

            if (FileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewMain_KRM.RowCount;
            int columns = dataGridViewMain_KRM.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewMain_KRM.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewMain_KRM.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenUserBase_KRM_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KRM.ShowDialog();
            openFilePath = openFileDialogTask_KRM.FileName;

            string[,] arrayValues = new string[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            arrayValues = ds.GetBase(openFilePath);
            buttonUsersBase_KRM.Enabled = true;
            buttonDeleteUser_KRM.Enabled = true;
            buttonChangeUser_KRM.Enabled = true;
            buttonBooks_KRM.Enabled = false;
            buttonAddBook_KRM.Visible = false;
            buttonChangeBook_KRM.Visible = false;
            buttonDeleteBook_KRM.Visible = false;
            buttonFindBook_KRM.Visible = false;

            ToolStripMenuItemFile_KRM.Enabled = false;
            ToolStripMenuItemEditBooks_KRM.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }

}
