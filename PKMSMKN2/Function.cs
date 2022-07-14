using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMSMKN2
{
    class Function
    {
        public static string ToMD5(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }

        public static void cekAngka(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf(',') > -1))
                e.Handled = true;
        }

        public static void addNominal(System.Windows.Forms.TextBox Textbox)
        {
            int indexLama = Textbox.SelectionStart,
                angkaLama = Textbox.TextLength;
            if (angkaLama > 1)
            {
                Textbox.Text = Textbox.Text.Equals("") ? "" : string.Format("{0:#,##0}", Convert.ToInt64(System.Text.RegularExpressions.Regex.Replace(Textbox.Text, @"\W", "")));
                int angkaBaru = Textbox.TextLength, indexBaru = angkaBaru - angkaLama;
                Textbox.SelectionStart = indexLama + indexBaru;
            }
        }
    }
}