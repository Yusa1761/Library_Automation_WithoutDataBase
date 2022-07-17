namespace Library_Automation_Project
{
    partial class MemberPage
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
            this.btn_memberSearch = new System.Windows.Forms.Button();
            this.txt_searchMP = new System.Windows.Forms.TextBox();
            this.btn_memberRefresh = new System.Windows.Forms.Button();
            this.booklist_member = new System.Windows.Forms.DataGridView();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookwriter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookpublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookgenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booklist_member)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_memberSearch
            // 
            this.btn_memberSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_memberSearch.Location = new System.Drawing.Point(23, 27);
            this.btn_memberSearch.Name = "btn_memberSearch";
            this.btn_memberSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_memberSearch.TabIndex = 0;
            this.btn_memberSearch.Text = "Search";
            this.btn_memberSearch.UseVisualStyleBackColor = true;
            this.btn_memberSearch.Click += new System.EventHandler(this.btn_memberSearch_Click);
            // 
            // txt_searchMP
            // 
            this.txt_searchMP.Location = new System.Drawing.Point(104, 27);
            this.txt_searchMP.Multiline = true;
            this.txt_searchMP.Name = "txt_searchMP";
            this.txt_searchMP.Size = new System.Drawing.Size(124, 23);
            this.txt_searchMP.TabIndex = 1;
            // 
            // btn_memberRefresh
            // 
            this.btn_memberRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_memberRefresh.Location = new System.Drawing.Point(234, 27);
            this.btn_memberRefresh.Name = "btn_memberRefresh";
            this.btn_memberRefresh.Size = new System.Drawing.Size(78, 23);
            this.btn_memberRefresh.TabIndex = 0;
            this.btn_memberRefresh.Text = "Refresh";
            this.btn_memberRefresh.UseVisualStyleBackColor = true;
            this.btn_memberRefresh.Click += new System.EventHandler(this.btn_memberRefresh_Click);
            // 
            // booklist_member
            // 
            this.booklist_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booklist_member.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookID,
            this.bookname,
            this.bookwriter,
            this.bookpublisher,
            this.bookgenre});
            this.booklist_member.Location = new System.Drawing.Point(23, 56);
            this.booklist_member.Name = "booklist_member";
            this.booklist_member.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booklist_member.Size = new System.Drawing.Size(643, 323);
            this.booklist_member.TabIndex = 2;
            // 
            // bookID
            // 
            this.bookID.HeaderText = "BOOK ID";
            this.bookID.Name = "bookID";
            this.bookID.Width = 120;
            // 
            // bookname
            // 
            this.bookname.HeaderText = "BOOK NAME";
            this.bookname.Name = "bookname";
            this.bookname.Width = 120;
            // 
            // bookwriter
            // 
            this.bookwriter.HeaderText = "BOOK WRITER";
            this.bookwriter.Name = "bookwriter";
            this.bookwriter.Width = 120;
            // 
            // bookpublisher
            // 
            this.bookpublisher.HeaderText = "BOOK PUBLISHER";
            this.bookpublisher.Name = "bookpublisher";
            this.bookpublisher.Width = 120;
            // 
            // bookgenre
            // 
            this.bookgenre.HeaderText = "BOOK GENRE";
            this.bookgenre.Name = "bookgenre";
            this.bookgenre.Width = 120;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(536, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(480, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "LİBRARY BOOKS";
            // 
            // MemberPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.booklist_member);
            this.Controls.Add(this.txt_searchMP);
            this.Controls.Add(this.btn_memberRefresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_memberSearch);
            this.Name = "MemberPage";
            this.Text = "MemberPage";
            this.Load += new System.EventHandler(this.MemberPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booklist_member)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_memberSearch;
        private System.Windows.Forms.TextBox txt_searchMP;
        private System.Windows.Forms.Button btn_memberRefresh;
        private System.Windows.Forms.DataGridView booklist_member;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookname;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookwriter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookpublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookgenre;
        private System.Windows.Forms.Label label10;
    }
}