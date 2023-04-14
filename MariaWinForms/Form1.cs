namespace MariaWinForms
{
    public partial class Form1 : Form
    {
        private int _symbols = 0;
        public Form1()
        {
            InitializeComponent();
            CountLabel.Text = _counter.ToString();
            MessageBox.Show(
                "Мария",
                "Имя",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                //_symbols += MessageBox.Length
                );

            MessageBox.Show(
                "13",
                "Возраст",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                //_symbols += MessageBox.Length
                );

            MessageBox.Show(
                "kfjghktdgjhjtkf",
                $"Среднее количество символов - {_symbols / 3}",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                //_symbols += MessageBox.Length
                );
        }

        private int _counter = 4;

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void CounterButton_Click(object sender, EventArgs e)
        {
            if (_counter > 0) _counter--;
            else MessageBox.Show("Error");
            CountLabel.Text = _counter.ToString();
        }

    }
}
