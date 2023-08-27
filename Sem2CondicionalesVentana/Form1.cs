namespace Sem2CondicionalesVentana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //datos
            int num1 = int.Parse(txtnum1.Text);
            int num2 = int.Parse(txtnum2.Text);
            int num3 = int.Parse(txtnum3.Text);
            
            //calculo
            if (num1 > num2 && num1 > num3)
            {

                lblcalculo.Text = num1 + " es mayor ";
            }
            else if (num2 > num1 && num2 > num3)
            {

                lblcalculo.Text = num2 + " es mayor ";
            }
            else
            {
                lblcalculo.Text = num3 + " es mayor ";
            }


        }
        //se hizo un boton para limpiar los recuadros 
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnum1.Clear();
            txtnum2.Clear();
            txtnum3.Clear();
            lblcalculo.Text = string.Empty;
        }
    }
}