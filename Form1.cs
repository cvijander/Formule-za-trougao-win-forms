namespace Formule_za_trougao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Obim trougla");
            comboBox1.Items.Add("Povrsina trougla");
            comboBox1.Items.Add("Vrsta trougla");
            comboBox1.Text = "Vrsta trougla";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  MessageBox.Show(comboBox1.SelectedIndex.ToString());
            if (txtStranicaA.Text.Length > 0 && txtStranicaB.Text.Length > 0 && txtStranicaC.Text.Length > 0)
            {
                try
                {
                    double a = double.Parse(txtStranicaA.Text);
                    double b = double.Parse(txtStranicaB.Text);
                    double c = double.Parse(txtStranicaC.Text);
                    Trougao t = new Trougao(a, b, c);
                    if (comboBox1.SelectedIndex == 0)
                    {
                        txtResenje.Text = "Obim: " + t.Obim();
                    }
                    else if (comboBox1.SelectedIndex == 1)
                        txtResenje.Text = "Povrsina: " + t.Povrsina();
                    else
                        txtResenje.Text = t.Vrsta();
                }
                catch (Exception m)
                {
                    MessageBox.Show("Stranice trouglova moraju biti brojevi " + m.Message);
                }
            }
        }
    }
}