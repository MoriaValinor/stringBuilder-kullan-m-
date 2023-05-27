using System.Text;

namespace STRINGBUILDER_ile_ŞİFRE_OLUŞTURMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder yarat = new StringBuilder();
            Random rastgele = new Random();

            for (int i=1; i <=10; i++)
            {
                int ascii=rastgele.Next(65,90);
                char karakter = Convert.ToChar(ascii);
                yarat.Append(karakter);
            }
            textBox1.Text= yarat.ToString();

        }
    }
}