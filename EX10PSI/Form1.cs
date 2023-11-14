using Microsoft.VisualBasic;

namespace EX10PSI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = Interaction.InputBox("Inserir password");

            if (password == "roberto")
            {
                MessageBox.Show("O acesso foi validado");
            }
            else
            {
                MessageBox.Show("O acesso foi negado");
            }
        }
    }
}