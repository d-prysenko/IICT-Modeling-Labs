using IICT_Modeling_Labs.View;

namespace IICT_Modeling_Labs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void task1_Click(object sender, EventArgs e)
        {
            Form form = new Task1Form();
            form.ShowDialog();
        }

        private void task2_Click(object sender, EventArgs e)
        {
            Form form = new Task2Form();
            form.ShowDialog();
        }

        private void task3_Click(object sender, EventArgs e)
        {
            Form form = new Task3Form();
            form.ShowDialog();
        }

        private void task4_Click(object sender, EventArgs e)
        {
            Form form = new Task4Form();
            form.ShowDialog();
        }

        private void task5_Click(object sender, EventArgs e)
        {
            Form form = new Task5Form();
            form.ShowDialog();
        }
    }
}