namespace Aula_29_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Biblioteca b=new Biblioteca();
            b.genero=comboBoxGenero.Text;
            b.dias=int.Parse(comboBoxDias.Text);
            b.valorpdias=5;

            if (b.dias==3)
             {
                b.dias = 3;
             listBox1.Items.Add("Gênero do filme: " + b.genero);
            listBox1.Items.Add("Quantidade de Dias: " + b.dias);
            listBox1.Items.Add("Valor total: "+b.valorpdias +",00");

            }
            else if (b.dias >3)
            {
                b.porcentagem = (b.dias * 0.5) + b.valorpdias;

                listBox1.Items.Add("Gênero do Filme: " + b.genero);
                listBox1.Items.Add("Quantidade de dias: " + b.dias);
                listBox1.Items.Add("Valor Total: " + b.porcentagem);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}