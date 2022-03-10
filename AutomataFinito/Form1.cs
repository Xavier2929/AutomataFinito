namespace AutomataFinito
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private Logica log = new Logica();

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log = new Logica(textBox1.Text);
            switch (log.pos)
            {
                case 0:
                    lbl0.BackColor = Color.Green;

                    break;

                case 1:
                    lbl1.BackColor = Color.Green;

                    break;

                case 2:
                    lbl2.BackColor = Color.Green;

                    break;

                case 3:
                    lbl3.BackColor = Color.Green;

                    break;

                case 4:
                    lbl0.BackColor = Color.Red;

                    break;
            }
        }

        private void pcQ3_Click(object sender, EventArgs e)
        {
        }
    }
}