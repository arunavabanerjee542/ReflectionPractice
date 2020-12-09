namespace ReflectionPractice
{
    partial class methodbox
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
            this.LABEL1 = new System.Windows.Forms.Label();
            this.classbox = new System.Windows.Forms.TextBox();
            this.searchbox = new System.Windows.Forms.Button();
            this.METHODS = new System.Windows.Forms.ListBox();
            this.constructors = new System.Windows.Forms.ListBox();
            this.properties = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LABEL1
            // 
            this.LABEL1.AutoSize = true;
            this.LABEL1.Location = new System.Drawing.Point(90, 25);
            this.LABEL1.Name = "LABEL1";
            this.LABEL1.Size = new System.Drawing.Size(75, 13);
            this.LABEL1.TabIndex = 0;
            this.LABEL1.Text = "CLASS NAME";
            // 
            // classbox
            // 
            this.classbox.Location = new System.Drawing.Point(180, 22);
            this.classbox.Name = "classbox";
            this.classbox.Size = new System.Drawing.Size(256, 20);
            this.classbox.TabIndex = 1;
            this.classbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(504, 12);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(128, 44);
            this.searchbox.TabIndex = 2;
            this.searchbox.Text = "SEARCH";
            this.searchbox.UseVisualStyleBackColor = true;
            this.searchbox.Click += new System.EventHandler(this.searchbox_Click);
            // 
            // METHODS
            // 
            this.METHODS.FormattingEnabled = true;
            this.METHODS.Location = new System.Drawing.Point(12, 109);
            this.METHODS.Name = "METHODS";
            this.METHODS.Size = new System.Drawing.Size(242, 329);
            this.METHODS.TabIndex = 3;
            // 
            // constructors
            // 
            this.constructors.FormattingEnabled = true;
            this.constructors.Location = new System.Drawing.Point(277, 109);
            this.constructors.Name = "constructors";
            this.constructors.Size = new System.Drawing.Size(251, 329);
            this.constructors.TabIndex = 4;
            // 
            // properties
            // 
            this.properties.FormattingEnabled = true;
            this.properties.Location = new System.Drawing.Point(548, 109);
            this.properties.Name = "properties";
            this.properties.Size = new System.Drawing.Size(240, 329);
            this.properties.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "METHODS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CONSTRUCTORS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PROPERTIES";
            // 
            // methodbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.properties);
            this.Controls.Add(this.constructors);
            this.Controls.Add(this.METHODS);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.classbox);
            this.Controls.Add(this.LABEL1);
            this.Name = "methodbox";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABEL1;
        private System.Windows.Forms.TextBox classbox;
        private System.Windows.Forms.Button searchbox;
        private System.Windows.Forms.ListBox METHODS;
        private System.Windows.Forms.ListBox constructors;
        private System.Windows.Forms.ListBox properties;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

