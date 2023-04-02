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
    }
}