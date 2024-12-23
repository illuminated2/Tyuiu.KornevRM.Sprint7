namespace Tyuiu.KornevRM.Sprint7.Project.V4
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelData_KRM = new Panel();
            groupBoxData_KRM = new GroupBox();
            groupBoxInfo_KRM = new GroupBox();
            dataGridViewMain_KRM = new DataGridView();
            splitterData_KRM = new Splitter();
            panelButtons_KRM = new Panel();
            groupBoxButtons_KRM = new GroupBox();
            groupBoxUsersButtons_KRM = new GroupBox();
            buttonChangeUser_KRM = new Button();
            buttonUsersBase_KRM = new Button();
            buttonDeleteUser_KRM = new Button();
            buttonAddUser_KRM = new Button();
            groupBoxBookButtons_KRM = new GroupBox();
            buttonBooks_KRM = new Button();
            buttonChangeBook_KRM = new Button();
            buttonFindBook_KRM = new Button();
            buttonDeleteBook_KRM = new Button();
            buttonAddBook_KRM = new Button();
            panelIcons_KRM = new Panel();
            groupBoxIcons_KRM = new GroupBox();
            buttonSaveUserBase_KRM = new Button();
            buttonInfo_KRM = new Button();
            buttonOpenBookBase_KRM = new Button();
            menuStripMainMenu_KRM = new MenuStrip();
            ToolStripMenuItemFile_KRM = new ToolStripMenuItem();
            toolStripMenuItemOpen_KRM = new ToolStripMenuItem();
            ToolStripMenuItemSave_KRM = new ToolStripMenuItem();
            ToolStripMenuItemEdit_KRM = new ToolStripMenuItem();
            ToolStripMenuItemEditBooks_KRM = new ToolStripMenuItem();
            ToolStripMenuItemEditUsers_KRM = new ToolStripMenuItem();
            ToolStripMenuItemEditDebtors_KRM = new ToolStripMenuItem();
            ToolStripMenuItemInfo_KRM = new ToolStripMenuItem();
            ToolStripMenuItemAbout_KRM = new ToolStripMenuItem();
            ToolStripMenuItemInstruction_KRM = new ToolStripMenuItem();
            toolTipButton_KRM = new ToolTip(components);
            openFileDialogTask_KRM = new OpenFileDialog();
            saveFileDialogTask_KRM = new SaveFileDialog();
            panelData_KRM.SuspendLayout();
            groupBoxData_KRM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain_KRM).BeginInit();
            panelButtons_KRM.SuspendLayout();
            groupBoxButtons_KRM.SuspendLayout();
            groupBoxUsersButtons_KRM.SuspendLayout();
            groupBoxBookButtons_KRM.SuspendLayout();
            panelIcons_KRM.SuspendLayout();
            groupBoxIcons_KRM.SuspendLayout();
            menuStripMainMenu_KRM.SuspendLayout();
            SuspendLayout();
            // 
            // panelData_KRM
            // 
            panelData_KRM.Controls.Add(groupBoxData_KRM);
            panelData_KRM.Dock = DockStyle.Fill;
            panelData_KRM.Location = new Point(332, 115);
            panelData_KRM.Name = "panelData_KRM";
            panelData_KRM.Size = new Size(735, 662);
            panelData_KRM.TabIndex = 9;
            // 
            // groupBoxData_KRM
            // 
            groupBoxData_KRM.Controls.Add(groupBoxInfo_KRM);
            groupBoxData_KRM.Controls.Add(dataGridViewMain_KRM);
            groupBoxData_KRM.Dock = DockStyle.Fill;
            groupBoxData_KRM.Location = new Point(0, 0);
            groupBoxData_KRM.Name = "groupBoxData_KRM";
            groupBoxData_KRM.Size = new Size(735, 662);
            groupBoxData_KRM.TabIndex = 0;
            groupBoxData_KRM.TabStop = false;
            // 
            // groupBoxInfo_KRM
            // 
            groupBoxInfo_KRM.Dock = DockStyle.Fill;
            groupBoxInfo_KRM.Location = new Point(3, 586);
            groupBoxInfo_KRM.Name = "groupBoxInfo_KRM";
            groupBoxInfo_KRM.Size = new Size(729, 73);
            groupBoxInfo_KRM.TabIndex = 1;
            groupBoxInfo_KRM.TabStop = false;
            groupBoxInfo_KRM.Text = "Дополнительная информация";
            groupBoxInfo_KRM.Enter += groupBoxInfo_KRM_Enter;
            // 
            // dataGridViewMain_KRM
            // 
            dataGridViewMain_KRM.AllowUserToAddRows = false;
            dataGridViewMain_KRM.AllowUserToDeleteRows = false;
            dataGridViewMain_KRM.AllowUserToResizeColumns = false;
            dataGridViewMain_KRM.AllowUserToResizeRows = false;
            dataGridViewMain_KRM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewMain_KRM.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMain_KRM.Dock = DockStyle.Top;
            dataGridViewMain_KRM.Location = new Point(3, 23);
            dataGridViewMain_KRM.Name = "dataGridViewMain_KRM";
            dataGridViewMain_KRM.ReadOnly = true;
            dataGridViewMain_KRM.RowHeadersVisible = false;
            dataGridViewMain_KRM.RowHeadersWidth = 51;
            dataGridViewMain_KRM.RowTemplate.Height = 24;
            dataGridViewMain_KRM.Size = new Size(729, 563);
            dataGridViewMain_KRM.TabIndex = 0;
            // 
            // splitterData_KRM
            // 
            splitterData_KRM.Location = new Point(321, 115);
            splitterData_KRM.Name = "splitterData_KRM";
            splitterData_KRM.Size = new Size(11, 662);
            splitterData_KRM.TabIndex = 8;
            splitterData_KRM.TabStop = false;
            // 
            // panelButtons_KRM
            // 
            panelButtons_KRM.Controls.Add(groupBoxButtons_KRM);
            panelButtons_KRM.Dock = DockStyle.Left;
            panelButtons_KRM.Location = new Point(0, 115);
            panelButtons_KRM.Name = "panelButtons_KRM";
            panelButtons_KRM.Size = new Size(321, 662);
            panelButtons_KRM.TabIndex = 7;
            // 
            // groupBoxButtons_KRM
            // 
            groupBoxButtons_KRM.Controls.Add(groupBoxUsersButtons_KRM);
            groupBoxButtons_KRM.Controls.Add(groupBoxBookButtons_KRM);
            groupBoxButtons_KRM.Dock = DockStyle.Fill;
            groupBoxButtons_KRM.Location = new Point(0, 0);
            groupBoxButtons_KRM.Name = "groupBoxButtons_KRM";
            groupBoxButtons_KRM.Size = new Size(321, 662);
            groupBoxButtons_KRM.TabIndex = 0;
            groupBoxButtons_KRM.TabStop = false;
            // 
            // groupBoxUsersButtons_KRM
            // 
            groupBoxUsersButtons_KRM.Controls.Add(buttonChangeUser_KRM);
            groupBoxUsersButtons_KRM.Controls.Add(buttonUsersBase_KRM);
            groupBoxUsersButtons_KRM.Controls.Add(buttonDeleteUser_KRM);
            groupBoxUsersButtons_KRM.Controls.Add(buttonAddUser_KRM);
            groupBoxUsersButtons_KRM.Dock = DockStyle.Fill;
            groupBoxUsersButtons_KRM.Location = new Point(3, 354);
            groupBoxUsersButtons_KRM.Name = "groupBoxUsersButtons_KRM";
            groupBoxUsersButtons_KRM.Size = new Size(315, 305);
            groupBoxUsersButtons_KRM.TabIndex = 2;
            groupBoxUsersButtons_KRM.TabStop = false;
            groupBoxUsersButtons_KRM.Text = "Работа с базой читателей";
            // 
            // buttonChangeUser_KRM
            // 
            buttonChangeUser_KRM.Location = new Point(163, 117);
            buttonChangeUser_KRM.Name = "buttonChangeUser_KRM";
            buttonChangeUser_KRM.Size = new Size(119, 55);
            buttonChangeUser_KRM.TabIndex = 8;
            buttonChangeUser_KRM.Text = "Изменить данные читателя";
            buttonChangeUser_KRM.UseVisualStyleBackColor = true;
            buttonChangeUser_KRM.Visible = false;
            // 
            // buttonUsersBase_KRM
            // 
            buttonUsersBase_KRM.Enabled = false;
            buttonUsersBase_KRM.Location = new Point(77, 48);
            buttonUsersBase_KRM.Name = "buttonUsersBase_KRM";
            buttonUsersBase_KRM.Size = new Size(159, 40);
            buttonUsersBase_KRM.TabIndex = 0;
            buttonUsersBase_KRM.Text = "База Читателей";
            buttonUsersBase_KRM.UseVisualStyleBackColor = true;
            buttonUsersBase_KRM.Click += buttonUsersBase_KRM_Click;
            // 
            // buttonDeleteUser_KRM
            // 
            buttonDeleteUser_KRM.Location = new Point(105, 194);
            buttonDeleteUser_KRM.Name = "buttonDeleteUser_KRM";
            buttonDeleteUser_KRM.Size = new Size(119, 55);
            buttonDeleteUser_KRM.TabIndex = 6;
            buttonDeleteUser_KRM.Text = "Удалить читателя";
            buttonDeleteUser_KRM.UseVisualStyleBackColor = true;
            buttonDeleteUser_KRM.Visible = false;
            buttonDeleteUser_KRM.Click += buttonDeleteUser_KRM_Click;
            // 
            // buttonAddUser_KRM
            // 
            buttonAddUser_KRM.Location = new Point(35, 117);
            buttonAddUser_KRM.Name = "buttonAddUser_KRM";
            buttonAddUser_KRM.Size = new Size(123, 55);
            buttonAddUser_KRM.TabIndex = 5;
            buttonAddUser_KRM.Text = "Добавить читателя";
            buttonAddUser_KRM.UseVisualStyleBackColor = true;
            buttonAddUser_KRM.Visible = false;
            buttonAddUser_KRM.Click += buttonAddUser_KRM_Click;
            // 
            // groupBoxBookButtons_KRM
            // 
            groupBoxBookButtons_KRM.Controls.Add(buttonBooks_KRM);
            groupBoxBookButtons_KRM.Controls.Add(buttonChangeBook_KRM);
            groupBoxBookButtons_KRM.Controls.Add(buttonFindBook_KRM);
            groupBoxBookButtons_KRM.Controls.Add(buttonDeleteBook_KRM);
            groupBoxBookButtons_KRM.Controls.Add(buttonAddBook_KRM);
            groupBoxBookButtons_KRM.Dock = DockStyle.Top;
            groupBoxBookButtons_KRM.Location = new Point(3, 23);
            groupBoxBookButtons_KRM.Name = "groupBoxBookButtons_KRM";
            groupBoxBookButtons_KRM.Size = new Size(315, 331);
            groupBoxBookButtons_KRM.TabIndex = 1;
            groupBoxBookButtons_KRM.TabStop = false;
            groupBoxBookButtons_KRM.Text = "Работа с базой книг";
            groupBoxBookButtons_KRM.Enter += groupBoxBookButtons_KRM_Enter;
            // 
            // buttonBooks_KRM
            // 
            buttonBooks_KRM.Enabled = false;
            buttonBooks_KRM.Location = new Point(77, 65);
            buttonBooks_KRM.Name = "buttonBooks_KRM";
            buttonBooks_KRM.Size = new Size(159, 40);
            buttonBooks_KRM.TabIndex = 0;
            buttonBooks_KRM.Text = "База книг";
            buttonBooks_KRM.UseVisualStyleBackColor = true;
            buttonBooks_KRM.Click += buttonBooks_KRM_Click;
            // 
            // buttonChangeBook_KRM
            // 
            buttonChangeBook_KRM.Location = new Point(163, 142);
            buttonChangeBook_KRM.Name = "buttonChangeBook_KRM";
            buttonChangeBook_KRM.Size = new Size(119, 55);
            buttonChangeBook_KRM.TabIndex = 4;
            buttonChangeBook_KRM.Text = "Изменить книгу";
            buttonChangeBook_KRM.UseVisualStyleBackColor = true;
            buttonChangeBook_KRM.Visible = false;
            buttonChangeBook_KRM.Click += buttonChangeBook_KRM_Click;
            // 
            // buttonFindBook_KRM
            // 
            buttonFindBook_KRM.Location = new Point(35, 203);
            buttonFindBook_KRM.Name = "buttonFindBook_KRM";
            buttonFindBook_KRM.Size = new Size(123, 49);
            buttonFindBook_KRM.TabIndex = 3;
            buttonFindBook_KRM.Text = "Найти книгу";
            buttonFindBook_KRM.UseVisualStyleBackColor = true;
            buttonFindBook_KRM.Visible = false;
            buttonFindBook_KRM.Click += buttonFindBook_KRM_Click;
            // 
            // buttonDeleteBook_KRM
            // 
            buttonDeleteBook_KRM.Location = new Point(163, 203);
            buttonDeleteBook_KRM.Name = "buttonDeleteBook_KRM";
            buttonDeleteBook_KRM.Size = new Size(119, 49);
            buttonDeleteBook_KRM.TabIndex = 2;
            buttonDeleteBook_KRM.Text = "Удалить книгу";
            buttonDeleteBook_KRM.UseVisualStyleBackColor = true;
            buttonDeleteBook_KRM.Visible = false;
            buttonDeleteBook_KRM.Click += buttonDeleteBook_KRM_Click;
            // 
            // buttonAddBook_KRM
            // 
            buttonAddBook_KRM.Location = new Point(35, 142);
            buttonAddBook_KRM.Name = "buttonAddBook_KRM";
            buttonAddBook_KRM.Size = new Size(123, 55);
            buttonAddBook_KRM.TabIndex = 1;
            buttonAddBook_KRM.Text = "Добавить книгу";
            buttonAddBook_KRM.UseVisualStyleBackColor = true;
            buttonAddBook_KRM.Visible = false;
            buttonAddBook_KRM.Click += buttonAddBook_KRM_Click;
            // 
            // panelIcons_KRM
            // 
            panelIcons_KRM.Controls.Add(groupBoxIcons_KRM);
            panelIcons_KRM.Dock = DockStyle.Top;
            panelIcons_KRM.Location = new Point(0, 30);
            panelIcons_KRM.Name = "panelIcons_KRM";
            panelIcons_KRM.Size = new Size(1067, 85);
            panelIcons_KRM.TabIndex = 6;
            // 
            // groupBoxIcons_KRM
            // 
            groupBoxIcons_KRM.BackColor = SystemColors.Control;
            groupBoxIcons_KRM.BackgroundImageLayout = ImageLayout.Stretch;
            groupBoxIcons_KRM.Controls.Add(buttonSaveUserBase_KRM);
            groupBoxIcons_KRM.Controls.Add(buttonInfo_KRM);
            groupBoxIcons_KRM.Controls.Add(buttonOpenBookBase_KRM);
            groupBoxIcons_KRM.Dock = DockStyle.Fill;
            groupBoxIcons_KRM.Location = new Point(0, 0);
            groupBoxIcons_KRM.Name = "groupBoxIcons_KRM";
            groupBoxIcons_KRM.Size = new Size(1067, 85);
            groupBoxIcons_KRM.TabIndex = 0;
            groupBoxIcons_KRM.TabStop = false;
            // 
            // buttonSaveUserBase_KRM
            // 
            buttonSaveUserBase_KRM.Location = new Point(445, 14);
            buttonSaveUserBase_KRM.Name = "buttonSaveUserBase_KRM";
            buttonSaveUserBase_KRM.Size = new Size(160, 68);
            buttonSaveUserBase_KRM.TabIndex = 0;
            buttonSaveUserBase_KRM.Text = "Сохранение";
            buttonSaveUserBase_KRM.UseVisualStyleBackColor = true;
            buttonSaveUserBase_KRM.Click += buttonSaveUserBase_KRM_Click;
            // 
            // buttonInfo_KRM
            // 
            buttonInfo_KRM.Location = new Point(930, 11);
            buttonInfo_KRM.Name = "buttonInfo_KRM";
            buttonInfo_KRM.Size = new Size(122, 68);
            buttonInfo_KRM.TabIndex = 0;
            buttonInfo_KRM.Text = "О разработчике";
            buttonInfo_KRM.UseVisualStyleBackColor = true;
            buttonInfo_KRM.Click += buttonInfo_KRM_Click;
            // 
            // buttonOpenBookBase_KRM
            // 
            buttonOpenBookBase_KRM.ForeColor = SystemColors.ControlText;
            buttonOpenBookBase_KRM.Location = new Point(37, 11);
            buttonOpenBookBase_KRM.Name = "buttonOpenBookBase_KRM";
            buttonOpenBookBase_KRM.Size = new Size(96, 68);
            buttonOpenBookBase_KRM.TabIndex = 0;
            buttonOpenBookBase_KRM.Text = "Открыть";
            buttonOpenBookBase_KRM.UseVisualStyleBackColor = true;
            buttonOpenBookBase_KRM.Click += buttonOpenBookBase_KRM_Click;
            // 
            // menuStripMainMenu_KRM
            // 
            menuStripMainMenu_KRM.BackColor = SystemColors.AppWorkspace;
            menuStripMainMenu_KRM.BackgroundImageLayout = ImageLayout.Stretch;
            menuStripMainMenu_KRM.ImageScalingSize = new Size(20, 20);
            menuStripMainMenu_KRM.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemFile_KRM, ToolStripMenuItemEdit_KRM, ToolStripMenuItemInfo_KRM });
            menuStripMainMenu_KRM.Location = new Point(0, 0);
            menuStripMainMenu_KRM.Name = "menuStripMainMenu_KRM";
            menuStripMainMenu_KRM.Padding = new Padding(5, 3, 0, 3);
            menuStripMainMenu_KRM.Size = new Size(1067, 30);
            menuStripMainMenu_KRM.TabIndex = 5;
            // 
            // ToolStripMenuItemFile_KRM
            // 
            ToolStripMenuItemFile_KRM.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemOpen_KRM, ToolStripMenuItemSave_KRM });
            ToolStripMenuItemFile_KRM.Name = "ToolStripMenuItemFile_KRM";
            ToolStripMenuItemFile_KRM.Size = new Size(59, 24);
            ToolStripMenuItemFile_KRM.Text = "Файл";
            // 
            // toolStripMenuItemOpen_KRM
            // 
            toolStripMenuItemOpen_KRM.Name = "toolStripMenuItemOpen_KRM";
            toolStripMenuItemOpen_KRM.Size = new Size(257, 26);
            toolStripMenuItemOpen_KRM.Text = "Открыть базу данных";
            // 
            // ToolStripMenuItemSave_KRM
            // 
            ToolStripMenuItemSave_KRM.Name = "ToolStripMenuItemSave_KRM";
            ToolStripMenuItemSave_KRM.Size = new Size(257, 26);
            ToolStripMenuItemSave_KRM.Text = "Сохранить базу данных";
            // 
            // ToolStripMenuItemEdit_KRM
            // 
            ToolStripMenuItemEdit_KRM.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemEditBooks_KRM, ToolStripMenuItemEditUsers_KRM, ToolStripMenuItemEditDebtors_KRM });
            ToolStripMenuItemEdit_KRM.Name = "ToolStripMenuItemEdit_KRM";
            ToolStripMenuItemEdit_KRM.Size = new Size(74, 24);
            ToolStripMenuItemEdit_KRM.Text = "Правка";
            // 
            // ToolStripMenuItemEditBooks_KRM
            // 
            ToolStripMenuItemEditBooks_KRM.Enabled = false;
            ToolStripMenuItemEditBooks_KRM.Name = "ToolStripMenuItemEditBooks_KRM";
            ToolStripMenuItemEditBooks_KRM.Size = new Size(225, 26);
            ToolStripMenuItemEditBooks_KRM.Text = "Правка книг";
            // 
            // ToolStripMenuItemEditUsers_KRM
            // 
            ToolStripMenuItemEditUsers_KRM.Enabled = false;
            ToolStripMenuItemEditUsers_KRM.Name = "ToolStripMenuItemEditUsers_KRM";
            ToolStripMenuItemEditUsers_KRM.Size = new Size(225, 26);
            ToolStripMenuItemEditUsers_KRM.Text = "Правка читателей";
            // 
            // ToolStripMenuItemEditDebtors_KRM
            // 
            ToolStripMenuItemEditDebtors_KRM.Enabled = false;
            ToolStripMenuItemEditDebtors_KRM.Name = "ToolStripMenuItemEditDebtors_KRM";
            ToolStripMenuItemEditDebtors_KRM.Size = new Size(225, 26);
            ToolStripMenuItemEditDebtors_KRM.Text = "Правка должников";
            // 
            // ToolStripMenuItemInfo_KRM
            // 
            ToolStripMenuItemInfo_KRM.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemAbout_KRM, ToolStripMenuItemInstruction_KRM });
            ToolStripMenuItemInfo_KRM.Name = "ToolStripMenuItemInfo_KRM";
            ToolStripMenuItemInfo_KRM.Size = new Size(81, 24);
            ToolStripMenuItemInfo_KRM.Text = "Справка";
            // 
            // ToolStripMenuItemAbout_KRM
            // 
            ToolStripMenuItemAbout_KRM.Name = "ToolStripMenuItemAbout_KRM";
            ToolStripMenuItemAbout_KRM.Size = new Size(187, 26);
            ToolStripMenuItemAbout_KRM.Text = "О программе";
            // 
            // ToolStripMenuItemInstruction_KRM
            // 
            ToolStripMenuItemInstruction_KRM.Name = "ToolStripMenuItemInstruction_KRM";
            ToolStripMenuItemInstruction_KRM.Size = new Size(187, 26);
            ToolStripMenuItemInstruction_KRM.Text = "Руководство ";
            // 
            // toolTipButton_KRM
            // 
            toolTipButton_KRM.IsBalloon = true;
            toolTipButton_KRM.Tag = "";
            toolTipButton_KRM.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton_KRM.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogTask_KRM
            // 
            openFileDialogTask_KRM.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 777);
            Controls.Add(panelData_KRM);
            Controls.Add(splitterData_KRM);
            Controls.Add(panelButtons_KRM);
            Controls.Add(panelIcons_KRM);
            Controls.Add(menuStripMainMenu_KRM);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMain";
            Text = "Библиотека";
            Load += FormMain_Load;
            panelData_KRM.ResumeLayout(false);
            groupBoxData_KRM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain_KRM).EndInit();
            panelButtons_KRM.ResumeLayout(false);
            groupBoxButtons_KRM.ResumeLayout(false);
            groupBoxUsersButtons_KRM.ResumeLayout(false);
            groupBoxBookButtons_KRM.ResumeLayout(false);
            panelIcons_KRM.ResumeLayout(false);
            groupBoxIcons_KRM.ResumeLayout(false);
            menuStripMainMenu_KRM.ResumeLayout(false);
            menuStripMainMenu_KRM.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelData_KRM;
        private System.Windows.Forms.GroupBox groupBoxData_KRM;
        private System.Windows.Forms.GroupBox groupBoxInfo_KRM;
        public System.Windows.Forms.DataGridView dataGridViewMain_KRM;
        private System.Windows.Forms.Splitter splitterData_KRM;
        private System.Windows.Forms.Panel panelButtons_KRM;
        private System.Windows.Forms.GroupBox groupBoxButtons_KRM;
        private System.Windows.Forms.GroupBox groupBoxUsersButtons_KRM;
        private System.Windows.Forms.Button buttonChangeUser_KRM;
        private System.Windows.Forms.Button buttonUsersBase_KRM;
        private System.Windows.Forms.Button buttonDeleteUser_KRM;
        private System.Windows.Forms.Button buttonAddUser_KRM;
        private System.Windows.Forms.GroupBox groupBoxBookButtons_KRM;
        private System.Windows.Forms.Button buttonChangeBook_KRM;
        private System.Windows.Forms.Button buttonFindBook_KRM;
        public System.Windows.Forms.Button buttonDeleteBook_KRM;
        private System.Windows.Forms.Button buttonAddBook_KRM;
        private System.Windows.Forms.Button buttonBooks_KRM;
        private System.Windows.Forms.Panel panelIcons_KRM;
        private System.Windows.Forms.GroupBox groupBoxIcons_KRM;
        private System.Windows.Forms.Button buttonSaveUserBase_KRM;
        private System.Windows.Forms.Button buttonInfo_KRM;
        private System.Windows.Forms.Button buttonOpenBookBase_KRM;
        private System.Windows.Forms.MenuStrip menuStripMainMenu_KRM;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile_KRM;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen_KRM;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSave_KRM;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEdit_KRM;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditBooks_KRM;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditUsers_KRM;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditDebtors_KRM;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInfo_KRM;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout_KRM;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInstruction_KRM;
        private System.Windows.Forms.ToolTip toolTipButton_KRM;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KRM;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask_KRM;
    }

}