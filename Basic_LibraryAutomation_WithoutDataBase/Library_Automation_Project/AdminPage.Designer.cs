namespace Library_Automation_Project
{
    partial class AdminPage
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Authority = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofcreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_bookadd = new System.Windows.Forms.Button();
            this.txt_bookID = new System.Windows.Forms.TextBox();
            this.txt_bookgenre = new System.Windows.Forms.TextBox();
            this.btn_bookUpdate = new System.Windows.Forms.Button();
            this.txt_bookname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_bookpublisher = new System.Windows.Forms.TextBox();
            this.btn_BookClear = new System.Windows.Forms.Button();
            this.txt_bookwriter = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_deleteBook = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_bookSearch = new System.Windows.Forms.Button();
            this.btn_bookRefresh = new System.Windows.Forms.Button();
            this.txt_bookSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(316, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID : ";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(357, 300);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(290, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(271, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(220, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date of Creation : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(263, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(266, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Password : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(268, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Authority : ";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(357, 333);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 1;
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(357, 362);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(100, 20);
            this.txt_Surname.TabIndex = 1;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(357, 422);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(100, 20);
            this.txt_Username.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(357, 454);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(100, 20);
            this.txt_Password.TabIndex = 1;
            // 
            // txt_Authority
            // 
            this.txt_Authority.Location = new System.Drawing.Point(357, 484);
            this.txt_Authority.Name = "txt_Authority";
            this.txt_Authority.Size = new System.Drawing.Size(100, 20);
            this.txt_Authority.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(13, 300);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(190, 27);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(13, 352);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(190, 27);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(13, 408);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(190, 27);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(13, 459);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(190, 27);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.surname,
            this.dateofcreation,
            this.username,
            this.password,
            this.authority});
            this.dataGridView1.Location = new System.Drawing.Point(13, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(445, 226);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "NAME";
            this.name.Name = "name";
            // 
            // surname
            // 
            this.surname.HeaderText = "SURNAME";
            this.surname.Name = "surname";
            // 
            // dateofcreation
            // 
            this.dateofcreation.HeaderText = "DATE OF CREATİION";
            this.dateofcreation.Name = "dateofcreation";
            // 
            // username
            // 
            this.username.HeaderText = "USERNAME";
            this.username.Name = "username";
            // 
            // password
            // 
            this.password.HeaderText = "PASSWORD";
            this.password.Name = "password";
            // 
            // authority
            // 
            this.authority.HeaderText = "AUTHORITY";
            this.authority.Name = "authority";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(290, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "LİBRARY MEMBERS";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(357, 395);
            this.maskedTextBox1.Mask = "00/00/0000 90:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookID,
            this.bookname,
            this.writer,
            this.publisher,
            this.genre});
            this.dataGridView2.Location = new System.Drawing.Point(491, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(458, 226);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // bookID
            // 
            this.bookID.HeaderText = "BOOK ID";
            this.bookID.Name = "bookID";
            // 
            // bookname
            // 
            this.bookname.HeaderText = "NAME";
            this.bookname.Name = "bookname";
            // 
            // writer
            // 
            this.writer.HeaderText = "WRITER";
            this.writer.Name = "writer";
            // 
            // publisher
            // 
            this.publisher.HeaderText = "PUBLISHER";
            this.publisher.Name = "publisher";
            // 
            // genre
            // 
            this.genre.HeaderText = "GENRE";
            this.genre.Name = "genre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(740, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Book Genre : ";
            // 
            // btn_bookadd
            // 
            this.btn_bookadd.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bookadd.Location = new System.Drawing.Point(491, 300);
            this.btn_bookadd.Name = "btn_bookadd";
            this.btn_bookadd.Size = new System.Drawing.Size(190, 27);
            this.btn_bookadd.TabIndex = 2;
            this.btn_bookadd.Text = "Add";
            this.btn_bookadd.UseVisualStyleBackColor = true;
            this.btn_bookadd.Click += new System.EventHandler(this.btn_bookadd_Click);
            // 
            // txt_bookID
            // 
            this.txt_bookID.Location = new System.Drawing.Point(850, 300);
            this.txt_bookID.Name = "txt_bookID";
            this.txt_bookID.Size = new System.Drawing.Size(100, 20);
            this.txt_bookID.TabIndex = 1;
            // 
            // txt_bookgenre
            // 
            this.txt_bookgenre.Location = new System.Drawing.Point(850, 424);
            this.txt_bookgenre.Name = "txt_bookgenre";
            this.txt_bookgenre.Size = new System.Drawing.Size(100, 20);
            this.txt_bookgenre.TabIndex = 1;
            // 
            // btn_bookUpdate
            // 
            this.btn_bookUpdate.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bookUpdate.Location = new System.Drawing.Point(491, 408);
            this.btn_bookUpdate.Name = "btn_bookUpdate";
            this.btn_bookUpdate.Size = new System.Drawing.Size(190, 27);
            this.btn_bookUpdate.TabIndex = 2;
            this.btn_bookUpdate.Text = "Update";
            this.btn_bookUpdate.UseVisualStyleBackColor = true;
            this.btn_bookUpdate.Click += new System.EventHandler(this.btn_bookUpdate_Click);
            // 
            // txt_bookname
            // 
            this.txt_bookname.Location = new System.Drawing.Point(850, 333);
            this.txt_bookname.Name = "txt_bookname";
            this.txt_bookname.Size = new System.Drawing.Size(100, 20);
            this.txt_bookname.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(716, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Book Publisher : ";
            // 
            // txt_bookpublisher
            // 
            this.txt_bookpublisher.Location = new System.Drawing.Point(850, 394);
            this.txt_bookpublisher.Name = "txt_bookpublisher";
            this.txt_bookpublisher.Size = new System.Drawing.Size(100, 20);
            this.txt_bookpublisher.TabIndex = 1;
            // 
            // btn_BookClear
            // 
            this.btn_BookClear.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BookClear.Location = new System.Drawing.Point(491, 459);
            this.btn_BookClear.Name = "btn_BookClear";
            this.btn_BookClear.Size = new System.Drawing.Size(190, 27);
            this.btn_BookClear.TabIndex = 2;
            this.btn_BookClear.Text = "Clear";
            this.btn_BookClear.UseVisualStyleBackColor = true;
            this.btn_BookClear.Click += new System.EventHandler(this.btn_BookClear_Click);
            // 
            // txt_bookwriter
            // 
            this.txt_bookwriter.Location = new System.Drawing.Point(850, 362);
            this.txt_bookwriter.Name = "txt_bookwriter";
            this.txt_bookwriter.Size = new System.Drawing.Size(100, 20);
            this.txt_bookwriter.TabIndex = 1;
            this.txt_bookwriter.TextChanged += new System.EventHandler(this.txt_bookwriter_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(736, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Book Writer :";
            // 
            // btn_deleteBook
            // 
            this.btn_deleteBook.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteBook.Location = new System.Drawing.Point(491, 352);
            this.btn_deleteBook.Name = "btn_deleteBook";
            this.btn_deleteBook.Size = new System.Drawing.Size(190, 27);
            this.btn_deleteBook.TabIndex = 2;
            this.btn_deleteBook.Text = "Delete";
            this.btn_deleteBook.UseVisualStyleBackColor = true;
            this.btn_deleteBook.Click += new System.EventHandler(this.btn_deleteBook_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(740, 332);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "Book Name : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(765, 299);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Book ID :";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(768, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "LİBRARY BOOKS";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Search.Location = new System.Drawing.Point(13, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(94, 3);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(109, 23);
            this.txt_Search.TabIndex = 8;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_refresh.Location = new System.Drawing.Point(218, 3);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(66, 25);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_bookSearch
            // 
            this.btn_bookSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bookSearch.Location = new System.Drawing.Point(491, 1);
            this.btn_bookSearch.Name = "btn_bookSearch";
            this.btn_bookSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_bookSearch.TabIndex = 7;
            this.btn_bookSearch.Text = "Search";
            this.btn_bookSearch.UseVisualStyleBackColor = true;
            this.btn_bookSearch.Click += new System.EventHandler(this.btn_bookSearch_Click);
            // 
            // btn_bookRefresh
            // 
            this.btn_bookRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bookRefresh.Location = new System.Drawing.Point(696, 1);
            this.btn_bookRefresh.Name = "btn_bookRefresh";
            this.btn_bookRefresh.Size = new System.Drawing.Size(66, 25);
            this.btn_bookRefresh.TabIndex = 7;
            this.btn_bookRefresh.Text = "Refresh";
            this.btn_bookRefresh.UseVisualStyleBackColor = true;
            this.btn_bookRefresh.Click += new System.EventHandler(this.btn_bookRefresh_Click);
            // 
            // txt_bookSearch
            // 
            this.txt_bookSearch.Location = new System.Drawing.Point(572, 1);
            this.txt_bookSearch.Multiline = true;
            this.txt_bookSearch.Name = "txt_bookSearch";
            this.txt_bookSearch.Size = new System.Drawing.Size(109, 23);
            this.txt_bookSearch.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(850, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_bookSearch);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_bookRefresh);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_bookSearch);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_deleteBook);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_bookwriter);
            this.Controls.Add(this.txt_Surname);
            this.Controls.Add(this.btn_BookClear);
            this.Controls.Add(this.txt_bookpublisher);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_bookname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_bookUpdate);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_bookgenre);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_Authority);
            this.Controls.Add(this.txt_bookID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_bookadd);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label7);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Searh";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Authority;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofcreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn authority;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookname;
        private System.Windows.Forms.DataGridViewTextBoxColumn writer;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_bookadd;
        private System.Windows.Forms.TextBox txt_bookID;
        private System.Windows.Forms.TextBox txt_bookgenre;
        private System.Windows.Forms.Button btn_bookUpdate;
        private System.Windows.Forms.TextBox txt_bookname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_bookpublisher;
        private System.Windows.Forms.Button btn_BookClear;
        private System.Windows.Forms.TextBox txt_bookwriter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_deleteBook;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_bookSearch;
        private System.Windows.Forms.Button btn_bookRefresh;
        private System.Windows.Forms.TextBox txt_bookSearch;
        private System.Windows.Forms.Button button1;
    }
}