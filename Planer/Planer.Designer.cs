namespace Planer
{
    partial class Planer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.planerGrid = new System.Windows.Forms.DataGridView();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.send = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.usersBox = new System.Windows.Forms.TextBox();
            this.toBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.completedBox = new System.Windows.Forms.CheckBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.planerCompletedGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SendEmailBtn = new System.Windows.Forms.Button();
            this.delPplBtn = new System.Windows.Forms.Button();
            this.changePplBtn = new System.Windows.Forms.Button();
            this.clearPplBtn = new System.Windows.Forms.Button();
            this.addPplBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.PeoplesGrid = new System.Windows.Forms.DataGridView();
            this.nameofperson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ReportYear5 = new System.Windows.Forms.Label();
            this.ReportYear4 = new System.Windows.Forms.Label();
            this.ReportYear3 = new System.Windows.Forms.Label();
            this.ReportYear2 = new System.Windows.Forms.Label();
            this.ReportYear1 = new System.Windows.Forms.Label();
            this.Report5 = new System.Windows.Forms.Label();
            this.Report4 = new System.Windows.Forms.Label();
            this.Report3 = new System.Windows.Forms.Label();
            this.Report2 = new System.Windows.Forms.Label();
            this.Report1 = new System.Windows.Forms.Label();
            this.reportGrid = new System.Windows.Forms.DataGridView();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.emailpass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emaillogin = new System.Windows.Forms.TextBox();
            this.ChangeThemeButton = new System.Windows.Forms.Button();
            this.planerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.planerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planerCompletedGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeoplesGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportGrid)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // planerGrid
            // 
            this.planerGrid.AllowUserToAddRows = false;
            this.planerGrid.AllowUserToDeleteRows = false;
            this.planerGrid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.planerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.deadline,
            this.responsible,
            this.send,
            this.completed});
            this.planerGrid.Location = new System.Drawing.Point(10, 6);
            this.planerGrid.Name = "planerGrid";
            this.planerGrid.ReadOnly = true;
            this.planerGrid.Size = new System.Drawing.Size(776, 169);
            this.planerGrid.TabIndex = 0;
            this.planerGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.planerGrid_CellClick);
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.HeaderText = "Вид документа";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // deadline
            // 
            this.deadline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.deadline.DefaultCellStyle = dataGridViewCellStyle4;
            this.deadline.HeaderText = "Срок подачи";
            this.deadline.Name = "deadline";
            this.deadline.ReadOnly = true;
            // 
            // responsible
            // 
            this.responsible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.responsible.HeaderText = "Ответственные за подготовку";
            this.responsible.Name = "responsible";
            this.responsible.ReadOnly = true;
            // 
            // send
            // 
            this.send.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.send.HeaderText = "Куда подается";
            this.send.Name = "send";
            this.send.ReadOnly = true;
            // 
            // completed
            // 
            this.completed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.completed.HeaderText = "Отметка о выполнении";
            this.completed.Name = "completed";
            this.completed.ReadOnly = true;
            this.completed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.Location = new System.Drawing.Point(626, 527);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(153, 37);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Очистить";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вид документа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Срок подачи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ответственные за подготовку";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Куда подается";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Отметка о выполнении";
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(265, 372);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(514, 20);
            this.typeBox.TabIndex = 11;
            // 
            // usersBox
            // 
            this.usersBox.Location = new System.Drawing.Point(265, 433);
            this.usersBox.Name = "usersBox";
            this.usersBox.Size = new System.Drawing.Size(514, 20);
            this.usersBox.TabIndex = 12;
            // 
            // toBox
            // 
            this.toBox.Location = new System.Drawing.Point(265, 465);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(514, 20);
            this.toBox.TabIndex = 13;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(265, 399);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(514, 20);
            this.dateBox.TabIndex = 14;
            // 
            // completedBox
            // 
            this.completedBox.AutoSize = true;
            this.completedBox.Location = new System.Drawing.Point(265, 498);
            this.completedBox.Name = "completedBox";
            this.completedBox.Size = new System.Drawing.Size(15, 14);
            this.completedBox.TabIndex = 15;
            this.completedBox.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(10, 527);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(174, 37);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.changeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeBtn.Location = new System.Drawing.Point(190, 527);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(174, 37);
            this.changeBtn.TabIndex = 17;
            this.changeBtn.Text = "Изменить";
            this.changeBtn.UseVisualStyleBackColor = false;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delBtn.Location = new System.Drawing.Point(370, 527);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(174, 37);
            this.delBtn.TabIndex = 18;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // planerCompletedGrid
            // 
            this.planerCompletedGrid.AllowUserToAddRows = false;
            this.planerCompletedGrid.AllowUserToDeleteRows = false;
            this.planerCompletedGrid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.planerCompletedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planerCompletedGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.planerCompletedGrid.Location = new System.Drawing.Point(10, 181);
            this.planerCompletedGrid.Name = "planerCompletedGrid";
            this.planerCompletedGrid.ReadOnly = true;
            this.planerCompletedGrid.Size = new System.Drawing.Size(776, 171);
            this.planerCompletedGrid.TabIndex = 19;
            this.planerCompletedGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.planerCompletedGrid_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Вид документа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn2.HeaderText = "Срок подачи";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Ответственные за подготовку";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Куда подается";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Отметка о выполнении";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-3, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 648);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.planerGrid);
            this.tabPage1.Controls.Add(this.planerCompletedGrid);
            this.tabPage1.Controls.Add(this.delBtn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.changeBtn);
            this.tabPage1.Controls.Add(this.clearBtn);
            this.tabPage1.Controls.Add(this.addBtn);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.completedBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dateBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.toBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.usersBox);
            this.tabPage1.Controls.Add(this.typeBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Документы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SendEmailBtn);
            this.tabPage2.Controls.Add(this.delPplBtn);
            this.tabPage2.Controls.Add(this.changePplBtn);
            this.tabPage2.Controls.Add(this.clearPplBtn);
            this.tabPage2.Controls.Add(this.addPplBtn);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.emailBox);
            this.tabPage2.Controls.Add(this.nameBox);
            this.tabPage2.Controls.Add(this.PeoplesGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Контакты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SendEmailBtn
            // 
            this.SendEmailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SendEmailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendEmailBtn.Location = new System.Drawing.Point(283, 577);
            this.SendEmailBtn.Name = "SendEmailBtn";
            this.SendEmailBtn.Size = new System.Drawing.Size(174, 37);
            this.SendEmailBtn.TabIndex = 25;
            this.SendEmailBtn.Text = "Отправить Email";
            this.SendEmailBtn.UseVisualStyleBackColor = false;
            this.SendEmailBtn.Click += new System.EventHandler(this.SendEmailBtn_Click);
            // 
            // delPplBtn
            // 
            this.delPplBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.delPplBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delPplBtn.Location = new System.Drawing.Point(371, 494);
            this.delPplBtn.Name = "delPplBtn";
            this.delPplBtn.Size = new System.Drawing.Size(174, 37);
            this.delPplBtn.TabIndex = 24;
            this.delPplBtn.Text = "Удалить";
            this.delPplBtn.UseVisualStyleBackColor = false;
            this.delPplBtn.Click += new System.EventHandler(this.delPplBtn_Click);
            // 
            // changePplBtn
            // 
            this.changePplBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.changePplBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePplBtn.Location = new System.Drawing.Point(191, 494);
            this.changePplBtn.Name = "changePplBtn";
            this.changePplBtn.Size = new System.Drawing.Size(174, 37);
            this.changePplBtn.TabIndex = 23;
            this.changePplBtn.Text = "Изменить";
            this.changePplBtn.UseVisualStyleBackColor = false;
            this.changePplBtn.Click += new System.EventHandler(this.changePplBtn_Click);
            // 
            // clearPplBtn
            // 
            this.clearPplBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clearPplBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearPplBtn.Location = new System.Drawing.Point(627, 494);
            this.clearPplBtn.Name = "clearPplBtn";
            this.clearPplBtn.Size = new System.Drawing.Size(153, 37);
            this.clearPplBtn.TabIndex = 21;
            this.clearPplBtn.Text = "Очистить";
            this.clearPplBtn.UseVisualStyleBackColor = false;
            this.clearPplBtn.Click += new System.EventHandler(this.clearPplBtn_Click);
            // 
            // addPplBtn
            // 
            this.addPplBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addPplBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPplBtn.Location = new System.Drawing.Point(11, 494);
            this.addPplBtn.Name = "addPplBtn";
            this.addPplBtn.Size = new System.Drawing.Size(174, 37);
            this.addPplBtn.TabIndex = 22;
            this.addPplBtn.Text = "Добавить";
            this.addPplBtn.UseVisualStyleBackColor = false;
            this.addPplBtn.Click += new System.EventHandler(this.addPplBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Имя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(7, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Email";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(107, 468);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(528, 20);
            this.emailBox.TabIndex = 16;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(107, 435);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(528, 20);
            this.nameBox.TabIndex = 15;
            // 
            // PeoplesGrid
            // 
            this.PeoplesGrid.AllowUserToAddRows = false;
            this.PeoplesGrid.AllowUserToDeleteRows = false;
            this.PeoplesGrid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.PeoplesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeoplesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameofperson,
            this.personemail});
            this.PeoplesGrid.Location = new System.Drawing.Point(11, 6);
            this.PeoplesGrid.Name = "PeoplesGrid";
            this.PeoplesGrid.ReadOnly = true;
            this.PeoplesGrid.Size = new System.Drawing.Size(776, 413);
            this.PeoplesGrid.TabIndex = 1;
            this.PeoplesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PeoplesGrid_CellClick);
            // 
            // nameofperson
            // 
            this.nameofperson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameofperson.HeaderText = "Имя";
            this.nameofperson.Name = "nameofperson";
            this.nameofperson.ReadOnly = true;
            // 
            // personemail
            // 
            this.personemail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.NullValue = null;
            this.personemail.DefaultCellStyle = dataGridViewCellStyle6;
            this.personemail.HeaderText = "Email";
            this.personemail.Name = "personemail";
            this.personemail.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ReportYear5);
            this.tabPage3.Controls.Add(this.ReportYear4);
            this.tabPage3.Controls.Add(this.ReportYear3);
            this.tabPage3.Controls.Add(this.ReportYear2);
            this.tabPage3.Controls.Add(this.ReportYear1);
            this.tabPage3.Controls.Add(this.Report5);
            this.tabPage3.Controls.Add(this.Report4);
            this.tabPage3.Controls.Add(this.Report3);
            this.tabPage3.Controls.Add(this.Report2);
            this.tabPage3.Controls.Add(this.Report1);
            this.tabPage3.Controls.Add(this.reportGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(797, 622);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отчёт";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ReportYear5
            // 
            this.ReportYear5.AutoSize = true;
            this.ReportYear5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ReportYear5.Location = new System.Drawing.Point(459, 391);
            this.ReportYear5.Name = "ReportYear5";
            this.ReportYear5.Size = new System.Drawing.Size(207, 20);
            this.ReportYear5.TabIndex = 15;
            this.ReportYear5.Text = "Удалено записей (за год):";
            // 
            // ReportYear4
            // 
            this.ReportYear4.AutoSize = true;
            this.ReportYear4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ReportYear4.Location = new System.Drawing.Point(459, 351);
            this.ReportYear4.Name = "ReportYear4";
            this.ReportYear4.Size = new System.Drawing.Size(267, 20);
            this.ReportYear4.TabIndex = 14;
            this.ReportYear4.Text = "Невыполненных записей (за год): ";
            // 
            // ReportYear3
            // 
            this.ReportYear3.AutoSize = true;
            this.ReportYear3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ReportYear3.Location = new System.Drawing.Point(459, 311);
            this.ReportYear3.Name = "ReportYear3";
            this.ReportYear3.Size = new System.Drawing.Size(248, 20);
            this.ReportYear3.TabIndex = 13;
            this.ReportYear3.Text = "Выполненных записей (за год): ";
            // 
            // ReportYear2
            // 
            this.ReportYear2.AutoSize = true;
            this.ReportYear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ReportYear2.Location = new System.Drawing.Point(459, 271);
            this.ReportYear2.Name = "ReportYear2";
            this.ReportYear2.Size = new System.Drawing.Size(215, 20);
            this.ReportYear2.TabIndex = 12;
            this.ReportYear2.Text = "Изменено записей (за год):";
            // 
            // ReportYear1
            // 
            this.ReportYear1.AutoSize = true;
            this.ReportYear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ReportYear1.Location = new System.Drawing.Point(459, 233);
            this.ReportYear1.Name = "ReportYear1";
            this.ReportYear1.Size = new System.Drawing.Size(229, 20);
            this.ReportYear1.TabIndex = 11;
            this.ReportYear1.Text = "Добавлено записей (за год): ";
            // 
            // Report5
            // 
            this.Report5.AutoSize = true;
            this.Report5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Report5.Location = new System.Drawing.Point(459, 164);
            this.Report5.Name = "Report5";
            this.Report5.Size = new System.Drawing.Size(201, 20);
            this.Report5.TabIndex = 10;
            this.Report5.Text = "Удалено записей (всего):";
            // 
            // Report4
            // 
            this.Report4.AutoSize = true;
            this.Report4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Report4.Location = new System.Drawing.Point(459, 124);
            this.Report4.Name = "Report4";
            this.Report4.Size = new System.Drawing.Size(296, 20);
            this.Report4.TabIndex = 9;
            this.Report4.Text = "Выполненных с нарушениями (всего): ";
            // 
            // Report3
            // 
            this.Report3.AutoSize = true;
            this.Report3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Report3.Location = new System.Drawing.Point(459, 84);
            this.Report3.Name = "Report3";
            this.Report3.Size = new System.Drawing.Size(242, 20);
            this.Report3.TabIndex = 5;
            this.Report3.Text = "Выполненных записей (всего): ";
            // 
            // Report2
            // 
            this.Report2.AutoSize = true;
            this.Report2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Report2.Location = new System.Drawing.Point(459, 44);
            this.Report2.Name = "Report2";
            this.Report2.Size = new System.Drawing.Size(209, 20);
            this.Report2.TabIndex = 4;
            this.Report2.Text = "Изменено записей (всего):";
            // 
            // Report1
            // 
            this.Report1.AutoSize = true;
            this.Report1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Report1.Location = new System.Drawing.Point(459, 6);
            this.Report1.Name = "Report1";
            this.Report1.Size = new System.Drawing.Size(223, 20);
            this.Report1.TabIndex = 3;
            this.Report1.Text = "Добавлено записей (всего): ";
            // 
            // reportGrid
            // 
            this.reportGrid.AllowUserToAddRows = false;
            this.reportGrid.AllowUserToDeleteRows = false;
            this.reportGrid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.reportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action,
            this.TypeOfDoc,
            this.DateOfAction});
            this.reportGrid.Location = new System.Drawing.Point(6, 6);
            this.reportGrid.Name = "reportGrid";
            this.reportGrid.ReadOnly = true;
            this.reportGrid.Size = new System.Drawing.Size(429, 608);
            this.reportGrid.TabIndex = 2;
            // 
            // Action
            // 
            this.Action.HeaderText = "Действие";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 150;
            // 
            // TypeOfDoc
            // 
            this.TypeOfDoc.HeaderText = "Вид документа";
            this.TypeOfDoc.Name = "TypeOfDoc";
            this.TypeOfDoc.ReadOnly = true;
            this.TypeOfDoc.Width = 135;
            // 
            // DateOfAction
            // 
            this.DateOfAction.HeaderText = "Дата";
            this.DateOfAction.Name = "DateOfAction";
            this.DateOfAction.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.emailpass);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.emaillogin);
            this.tabPage4.Controls.Add(this.ChangeThemeButton);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(797, 622);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Настройки";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Пароль";
            // 
            // emailpass
            // 
            this.emailpass.Location = new System.Drawing.Point(112, 169);
            this.emailpass.Name = "emailpass";
            this.emailpass.Size = new System.Drawing.Size(528, 20);
            this.emailpass.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Email";
            // 
            // emaillogin
            // 
            this.emaillogin.Location = new System.Drawing.Point(112, 130);
            this.emaillogin.Name = "emaillogin";
            this.emaillogin.Size = new System.Drawing.Size(528, 20);
            this.emaillogin.TabIndex = 23;
            // 
            // ChangeThemeButton
            // 
            this.ChangeThemeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ChangeThemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeThemeButton.Location = new System.Drawing.Point(11, 6);
            this.ChangeThemeButton.Name = "ChangeThemeButton";
            this.ChangeThemeButton.Size = new System.Drawing.Size(174, 37);
            this.ChangeThemeButton.TabIndex = 21;
            this.ChangeThemeButton.Text = "Сменить тему";
            this.ChangeThemeButton.UseVisualStyleBackColor = false;
            this.ChangeThemeButton.Click += new System.EventHandler(this.changeTheme_Click);
            // 
            // Planer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 646);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Planer";
            this.Text = "Планировщик";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Planer_Closing);
            this.Load += new System.EventHandler(this.Planer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planerCompletedGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeoplesGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportGrid)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView planerGrid;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox usersBox;
        private System.Windows.Forms.TextBox toBox;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.CheckBox completedBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.DataGridView planerCompletedGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsible;
        private System.Windows.Forms.DataGridViewTextBoxColumn send;
        private System.Windows.Forms.DataGridViewCheckBoxColumn completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView PeoplesGrid;
        private System.Windows.Forms.Button SendEmailBtn;
        private System.Windows.Forms.Button delPplBtn;
        private System.Windows.Forms.Button changePplBtn;
        private System.Windows.Forms.Button clearPplBtn;
        private System.Windows.Forms.Button addPplBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofperson;
        private System.Windows.Forms.DataGridViewTextBoxColumn personemail;
        private System.Windows.Forms.Label Report3;
        private System.Windows.Forms.Label Report2;
        private System.Windows.Forms.Label Report1;
        private System.Windows.Forms.DataGridView reportGrid;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emaillogin;
        private System.Windows.Forms.Button ChangeThemeButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emailpass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfAction;
        private System.Windows.Forms.BindingSource planerBindingSource;
        private System.Windows.Forms.Label ReportYear5;
        private System.Windows.Forms.Label ReportYear4;
        private System.Windows.Forms.Label ReportYear3;
        private System.Windows.Forms.Label ReportYear2;
        private System.Windows.Forms.Label ReportYear1;
        private System.Windows.Forms.Label Report5;
        private System.Windows.Forms.Label Report4;
    }
}

