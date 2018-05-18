namespace Simple_Test_Application
{
    partial class User_Check_AV_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Check_AV_Book));
            this.listView1 = new System.Windows.Forms.ListView();
            this.BookId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WriterName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PublishYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantityOfBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CatagoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AvaliableBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.back = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_searchby = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BookId,
            this.BookName,
            this.WriterName,
            this.PublishYear,
            this.QuantityOfBook,
            this.CatagoryName,
            this.AvaliableBook});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(5, 104);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(705, 278);
            this.listView1.TabIndex = 127;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // BookId
            // 
            this.BookId.Text = "BookId";
            // 
            // BookName
            // 
            this.BookName.Text = "BookName";
            this.BookName.Width = 145;
            // 
            // WriterName
            // 
            this.WriterName.Text = "WriterName";
            this.WriterName.Width = 127;
            // 
            // PublishYear
            // 
            this.PublishYear.Text = "PublishYear";
            this.PublishYear.Width = 97;
            // 
            // QuantityOfBook
            // 
            this.QuantityOfBook.Text = "Quantity";
            this.QuantityOfBook.Width = 91;
            // 
            // CatagoryName
            // 
            this.CatagoryName.Text = "Catagory";
            this.CatagoryName.Width = 94;
            // 
            // AvaliableBook
            // 
            this.AvaliableBook.Text = "Avaliable";
            this.AvaliableBook.Width = 80;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(392, 388);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(63, 27);
            this.back.TabIndex = 128;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(334, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 134;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(599, 50);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(63, 27);
            this.butCancel.TabIndex = 133;
            this.butCancel.Text = "cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(505, 50);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(63, 27);
            this.button9.TabIndex = 132;
            this.button9.Text = "ok";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 131;
            this.label2.Text = "Enter";
            // 
            // cb_searchby
            // 
            this.cb_searchby.AllowDrop = true;
            this.cb_searchby.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_searchby.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_searchby.CausesValidation = false;
            this.cb_searchby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_searchby.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_searchby.FormattingEnabled = true;
            this.cb_searchby.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_searchby.Items.AddRange(new object[] {
            "AvaliableBook",
            "BookId",
            "BookName",
            "CatagoryName",
            "WriterName"});
            this.cb_searchby.Location = new System.Drawing.Point(91, 50);
            this.cb_searchby.Margin = new System.Windows.Forms.Padding(4);
            this.cb_searchby.MaxDropDownItems = 5;
            this.cb_searchby.Name = "cb_searchby";
            this.cb_searchby.Size = new System.Drawing.Size(185, 27);
            this.cb_searchby.Sorted = true;
            this.cb_searchby.TabIndex = 130;
            this.cb_searchby.SelectedIndexChanged += new System.EventHandler(this.cb_searchby_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 129;
            this.label1.Text = "Search By";
            // 
            // User_Check_AV_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 463);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_searchby);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.listView1);
            this.Name = "User_Check_AV_Book";
            this.Text = "User_Check_AV_Book";
            this.Load += new System.EventHandler(this.User_Check_AV_Book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader BookId;
        private System.Windows.Forms.ColumnHeader BookName;
        private System.Windows.Forms.ColumnHeader WriterName;
        private System.Windows.Forms.ColumnHeader PublishYear;
        private System.Windows.Forms.ColumnHeader QuantityOfBook;
        private System.Windows.Forms.ColumnHeader CatagoryName;
        private System.Windows.Forms.ColumnHeader AvaliableBook;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cb_searchby;
        private System.Windows.Forms.Label label1;
    }
}