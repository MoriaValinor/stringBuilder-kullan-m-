# stringBuilder-kullanimi
Strin builder ile şifre oluşturma

 private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder yarat = new StringBuilder();
            Random rastgele = new Random();

            for (int i = 1; i <=8; i++)
            {
                int ascii = rastgele.Next(65,90) ;// 65 ile 97 sayı aralğı var bunu kullan. asci tablosundan daha sonra çekilip karaktere çevrilicek
                char karakter = Convert.ToChar(ascii);// karatere çevrildi 
                yarat.Append(karakter);
            }
            textBox1.Text = yarat.ToString();
        }
