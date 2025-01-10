namespace IICT_Modeling_Labs
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
            tableOfNumbers = new Components.Table();
            formsPlot1 = new ScottPlot.FormsPlot();
            label6 = new Label();
            a = new Label();
            b = new Label();
            SuspendLayout();
            // 
            // tableOfNumbers
            // 
            tableOfNumbers.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableOfNumbers.ColumnCount = 5;
            tableOfNumbers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableOfNumbers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableOfNumbers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableOfNumbers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableOfNumbers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableOfNumbers.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tableOfNumbers.Location = new Point(33, 97);
            tableOfNumbers.Name = "tableOfNumbers";
            tableOfNumbers.RowCount = 11;
            tableOfNumbers.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableOfNumbers.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableOfNumbers.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableOfNumbers.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableOfNumbers.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableOfNumbers.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableOfNumbers.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableOfNumbers.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableOfNumbers.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableOfNumbers.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableOfNumbers.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableOfNumbers.Size = new Size(832, 263);
            tableOfNumbers.TabIndex = 2;
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new Point(108, 366);
            formsPlot1.Margin = new Padding(4, 3, 4, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(776, 353);
            formsPlot1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(33, 9);
            label6.Name = "label6";
            label6.Size = new Size(384, 85);
            label6.TabIndex = 9;
            label6.Text = "Лабораторная №4\r\n\r\nВычислительный эксперимент. \r\nИдентификация модели, линейной относительно параметров, \r\nметодом наименьших квадратов ";
            // 
            // a
            // 
            a.AutoSize = true;
            a.Location = new Point(33, 391);
            a.Name = "a";
            a.Size = new Size(27, 15);
            a.TabIndex = 10;
            a.Text = "a = ";
            // 
            // b
            // 
            b.AutoSize = true;
            b.Location = new Point(33, 422);
            b.Name = "b";
            b.Size = new Size(28, 15);
            b.TabIndex = 11;
            b.Text = "b = ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 721);
            Controls.Add(b);
            Controls.Add(a);
            Controls.Add(label6);
            Controls.Add(formsPlot1);
            Controls.Add(tableOfNumbers);
            Name = "MainForm";
            Text = "Лабораторная №4";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Components.Table tableOfNumbers;
        private ScottPlot.FormsPlot formsPlot1;
        private Label label6;
        private Label a;
        private Label b;
    }
}