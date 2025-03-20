namespace WinFormsPelda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gomb_Click(object sender, EventArgs e)
        {
            try
            {
                var szam1 = Convert.ToInt32(textBoxSzam1.Text);
                var szam2 = Convert.ToInt32(textBoxSzam2.Text);
                var eredmeny = szam1 / szam2;

                labelEredmeny.Text = eredmeny.ToString();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("A szám 2 értéke nem lehet nulla!");
            }
            catch (FormatException) {
                MessageBox.Show("A mezõkbe számot kell írni");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

     
    }
}
