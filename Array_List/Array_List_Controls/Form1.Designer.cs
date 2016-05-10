namespace Array_List_Controls
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnsort = new System.Windows.Forms.Button();
            this.btnisfixedsize = new System.Windows.Forms.Button();
            this.btncount = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncontains = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ad Soyad";
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(105, 12);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(145, 20);
            this.txtadsoyad.TabIndex = 16;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(24, 218);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 15;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnsort
            // 
            this.btnsort.Location = new System.Drawing.Point(24, 187);
            this.btnsort.Name = "btnsort";
            this.btnsort.Size = new System.Drawing.Size(75, 23);
            this.btnsort.TabIndex = 14;
            this.btnsort.Text = "Sort";
            this.btnsort.UseVisualStyleBackColor = true;
            this.btnsort.Click += new System.EventHandler(this.btnsort_Click);
            // 
            // btnisfixedsize
            // 
            this.btnisfixedsize.Location = new System.Drawing.Point(24, 156);
            this.btnisfixedsize.Name = "btnisfixedsize";
            this.btnisfixedsize.Size = new System.Drawing.Size(75, 23);
            this.btnisfixedsize.TabIndex = 13;
            this.btnisfixedsize.Text = "IsFixedSize";
            this.btnisfixedsize.UseVisualStyleBackColor = true;
            this.btnisfixedsize.Click += new System.EventHandler(this.btnisfixedsize_Click);
            // 
            // btncount
            // 
            this.btncount.Location = new System.Drawing.Point(24, 125);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(75, 23);
            this.btncount.TabIndex = 12;
            this.btncount.Text = "Count";
            this.btncount.UseVisualStyleBackColor = true;
            this.btncount.Click += new System.EventHandler(this.btncount_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(24, 94);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 11;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(24, 63);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 10;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(115, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 238);
            this.listBox1.TabIndex = 9;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(24, 248);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 18;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncontains
            // 
            this.btncontains.Location = new System.Drawing.Point(24, 277);
            this.btncontains.Name = "btncontains";
            this.btncontains.Size = new System.Drawing.Size(75, 23);
            this.btncontains.TabIndex = 19;
            this.btncontains.Text = "Contains";
            this.btncontains.UseVisualStyleBackColor = true;
            this.btncontains.Click += new System.EventHandler(this.btncontains_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 328);
            this.Controls.Add(this.btncontains);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.btnsort);
            this.Controls.Add(this.btnisfixedsize);
            this.Controls.Add(this.btncount);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnsort;
        private System.Windows.Forms.Button btnisfixedsize;
        private System.Windows.Forms.Button btncount;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncontains;
    }
}

