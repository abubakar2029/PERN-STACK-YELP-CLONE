namespace School_Managment_Sytem
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DeleteID = new System.Windows.Forms.TextBox();
            this.Display = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Uage = new System.Windows.Forms.TextBox();
            this.Uname = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.GridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert 10 Students";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "DELETE Specific ID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteID
            // 
            this.DeleteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteID.Location = new System.Drawing.Point(274, 90);
            this.DeleteID.Name = "DeleteID";
            this.DeleteID.Size = new System.Drawing.Size(100, 34);
            this.DeleteID.TabIndex = 2;
            this.DeleteID.TextChanged += new System.EventHandler(this.DeleteID_TextChanged);
            // 
            // Display
            // 
            this.Display.AccessibleName = "Display";
            this.Display.Location = new System.Drawing.Point(83, 146);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(151, 46);
            this.Display.TabIndex = 3;
            this.Display.Text = "Show All Data";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.DisplayRecords);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(83, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "Update A Record";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Update);
            // 
            // Uage
            // 
            this.Uage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uage.Location = new System.Drawing.Point(568, 214);
            this.Uage.Name = "Uage";
            this.Uage.Size = new System.Drawing.Size(100, 34);
            this.Uage.TabIndex = 5;
            // 
            // Uname
            // 
            this.Uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uname.Location = new System.Drawing.Point(430, 212);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(100, 34);
            this.Uname.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(296, 214);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 34);
            this.textBox4.TabIndex = 7;
            // 
            // GridView
            // 
            this.GridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridView.Location = new System.Drawing.Point(0, 272);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidth = 51;
            this.GridView.RowTemplate.Height = 24;
            this.GridView.Size = new System.Drawing.Size(748, 560);
            this.GridView.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 840);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Uname);
            this.Controls.Add(this.Uage);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.DeleteID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Click += new System.EventHandler(this.DisplayRecords);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox DeleteID;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Uage;
        private System.Windows.Forms.TextBox Uname;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView GridView;
    }
}