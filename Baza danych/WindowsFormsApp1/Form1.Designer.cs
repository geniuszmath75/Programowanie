namespace WindowsFormsApp1
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Take = new System.Windows.Forms.Button();
            this.Skip = new System.Windows.Forms.Button();
            this.Join = new System.Windows.Forms.Button();
            this.Concat = new System.Windows.Forms.Button();
            this.Union = new System.Windows.Forms.Button();
            this.Distinct = new System.Windows.Forms.Button();
            this.Except = new System.Windows.Forms.Button();
            this.Intersect = new System.Windows.Forms.Button();
            this.OrderBy = new System.Windows.Forms.Button();
            this.OrderByDescending = new System.Windows.Forms.Button();
            this.SelectMany = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 168);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wyświetl dane";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Dodaj dane";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(59, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "Zmień dane";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(59, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "Usuń dane";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Take
            // 
            this.Take.Location = new System.Drawing.Point(235, 222);
            this.Take.Name = "Take";
            this.Take.Size = new System.Drawing.Size(105, 41);
            this.Take.TabIndex = 5;
            this.Take.Text = "Zapytanie \'take\'";
            this.Take.UseVisualStyleBackColor = true;
            this.Take.Click += new System.EventHandler(this.Take_Click);
            // 
            // Skip
            // 
            this.Skip.Location = new System.Drawing.Point(235, 269);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(105, 48);
            this.Skip.TabIndex = 6;
            this.Skip.Text = "Zapytanie \'skip\'";
            this.Skip.UseVisualStyleBackColor = true;
            this.Skip.Click += new System.EventHandler(this.Skip_Click);
            // 
            // Join
            // 
            this.Join.Location = new System.Drawing.Point(235, 323);
            this.Join.Name = "Join";
            this.Join.Size = new System.Drawing.Size(105, 39);
            this.Join.TabIndex = 7;
            this.Join.Text = "Zapytanie \'join\'";
            this.Join.UseVisualStyleBackColor = true;
            this.Join.Click += new System.EventHandler(this.Join_Click);
            // 
            // Concat
            // 
            this.Concat.Location = new System.Drawing.Point(235, 368);
            this.Concat.Name = "Concat";
            this.Concat.Size = new System.Drawing.Size(105, 42);
            this.Concat.TabIndex = 8;
            this.Concat.Text = "Zapytanie \'concat\'";
            this.Concat.UseVisualStyleBackColor = true;
            this.Concat.Click += new System.EventHandler(this.Concat_Click);
            // 
            // Union
            // 
            this.Union.Location = new System.Drawing.Point(388, 222);
            this.Union.Name = "Union";
            this.Union.Size = new System.Drawing.Size(95, 41);
            this.Union.TabIndex = 9;
            this.Union.Text = "Zapytanie \'union\'";
            this.Union.UseVisualStyleBackColor = true;
            this.Union.Click += new System.EventHandler(this.Union_Click);
            // 
            // Distinct
            // 
            this.Distinct.Location = new System.Drawing.Point(388, 270);
            this.Distinct.Name = "Distinct";
            this.Distinct.Size = new System.Drawing.Size(95, 47);
            this.Distinct.TabIndex = 10;
            this.Distinct.Text = "Zapytanie \'distinct\'";
            this.Distinct.UseVisualStyleBackColor = true;
            this.Distinct.Click += new System.EventHandler(this.Distinct_Click);
            // 
            // Except
            // 
            this.Except.Location = new System.Drawing.Point(388, 323);
            this.Except.Name = "Except";
            this.Except.Size = new System.Drawing.Size(95, 45);
            this.Except.TabIndex = 11;
            this.Except.Text = "Zapytanie \'except\'";
            this.Except.UseVisualStyleBackColor = true;
            this.Except.Click += new System.EventHandler(this.Except_Click);
            // 
            // Intersect
            // 
            this.Intersect.Location = new System.Drawing.Point(388, 371);
            this.Intersect.Name = "Intersect";
            this.Intersect.Size = new System.Drawing.Size(95, 48);
            this.Intersect.TabIndex = 12;
            this.Intersect.Text = "Zapytanie \'intersect\'";
            this.Intersect.UseVisualStyleBackColor = true;
            this.Intersect.Click += new System.EventHandler(this.Intersect_Click);
            // 
            // OrderBy
            // 
            this.OrderBy.Location = new System.Drawing.Point(513, 222);
            this.OrderBy.Name = "OrderBy";
            this.OrderBy.Size = new System.Drawing.Size(97, 41);
            this.OrderBy.TabIndex = 13;
            this.OrderBy.Text = "OrderBy";
            this.OrderBy.UseVisualStyleBackColor = true;
            this.OrderBy.Click += new System.EventHandler(this.OrderBy_Click);
            // 
            // OrderByDescending
            // 
            this.OrderByDescending.Location = new System.Drawing.Point(513, 270);
            this.OrderByDescending.Name = "OrderByDescending";
            this.OrderByDescending.Size = new System.Drawing.Size(97, 47);
            this.OrderByDescending.TabIndex = 14;
            this.OrderByDescending.Text = "OrderByDescending";
            this.OrderByDescending.UseVisualStyleBackColor = true;
            this.OrderByDescending.Click += new System.EventHandler(this.OrderByDescending_Click);
            // 
            // SelectMany
            // 
            this.SelectMany.Location = new System.Drawing.Point(513, 323);
            this.SelectMany.Name = "SelectMany";
            this.SelectMany.Size = new System.Drawing.Size(97, 43);
            this.SelectMany.TabIndex = 15;
            this.SelectMany.Text = "Zapytanie \'selectmany\'";
            this.SelectMany.UseVisualStyleBackColor = true;
            this.SelectMany.Click += new System.EventHandler(this.SelectMany_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(808, 422);
            this.Controls.Add(this.SelectMany);
            this.Controls.Add(this.OrderByDescending);
            this.Controls.Add(this.OrderBy);
            this.Controls.Add(this.Intersect);
            this.Controls.Add(this.Except);
            this.Controls.Add(this.Distinct);
            this.Controls.Add(this.Union);
            this.Controls.Add(this.Concat);
            this.Controls.Add(this.Join);
            this.Controls.Add(this.Skip);
            this.Controls.Add(this.Take);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Take;
        private System.Windows.Forms.Button Skip;
        private System.Windows.Forms.Button Join;
        private System.Windows.Forms.Button Concat;
        private System.Windows.Forms.Button Union;
        private System.Windows.Forms.Button Distinct;
        private System.Windows.Forms.Button Except;
        private System.Windows.Forms.Button Intersect;
        private System.Windows.Forms.Button OrderBy;
        private System.Windows.Forms.Button OrderByDescending;
        private System.Windows.Forms.Button SelectMany;
    }
}

