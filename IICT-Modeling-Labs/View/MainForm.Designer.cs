п»їnamespace IICT_Modeling_Labs
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.task1 = new System.Windows.Forms.Button();
            this.task2 = new System.Windows.Forms.Button();
            this.task3 = new System.Windows.Forms.Button();
            this.task4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // task1
            // 
            this.task1.Location = new System.Drawing.Point(272, 51);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(232, 37);
            this.task1.TabIndex = 0;
            this.task1.Text = "Р—Р°РґР°РЅРёРµ 1";
            this.task1.UseVisualStyleBackColor = true;
            this.task1.Click += new System.EventHandler(this.task1_Click);
            // 
            // task2
            // 
            this.task2.Location = new System.Drawing.Point(272, 125);
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(232, 37);
            this.task2.TabIndex = 1;
            this.task2.Text = "Р—Р°РґР°РЅРёРµ 2";
            this.task2.UseVisualStyleBackColor = true;
            this.task2.Click += new System.EventHandler(this.task2_Click);
            // 
            // task3
            // 
            this.task3.Location = new System.Drawing.Point(272, 200);
            this.task3.Name = "task3";
            this.task3.Size = new System.Drawing.Size(232, 37);
            this.task3.TabIndex = 2;
            this.task3.Text = "Р—Р°РґР°РЅРёРµ 3";
            this.task3.UseVisualStyleBackColor = true;
            this.task3.Click += new System.EventHandler(this.task3_Click);
            // 
            // task4
            // 
            this.task4.Location = new System.Drawing.Point(272, 274);
            this.task4.Name = "task4";
            this.task4.Size = new System.Drawing.Size(232, 37);
            this.task4.TabIndex = 3;
            this.task4.Text = "Р—Р°РґР°РЅРёРµ 4";
            this.task4.UseVisualStyleBackColor = true;
            this.task4.Click += new System.EventHandler(this.task4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 535);
            this.Controls.Add(this.task4);
            this.Controls.Add(this.task3);
            this.Controls.Add(this.task2);
            this.Controls.Add(this.task1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button task1;
        private Button task2;
        private Button task3;
        private Button task4;
    }
}