namespace MW_Error_Renamer
{
    public partial class ErrorWindow : Form
    {
        public ErrorWindow(string labelText = "OOPS!")
        {
            InitializeComponent();
            ErrorIcon.Image = SystemIcons.Error.ToBitmap();
            MainLabel.Text = labelText;
        }

        private void GiveUpButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("just Google the error code ffs");
        }
    }
}
