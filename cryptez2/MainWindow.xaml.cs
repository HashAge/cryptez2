using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cryptez2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btn.Click += btn_click;
            ces_btn.Click += switch_click;
            vig_btn.Click += switch_click;
            atb_btn.Click += switch_click;
            afn_btn.Click += switch_click;
        }
        private void switch_click(object sender, RoutedEventArgs e)
        {        
            if (ces_btn.IsChecked == true)
            {
                ces_tbx.Visibility = Visibility.Visible;
                vig_tbx.Visibility = Visibility.Hidden;
            }
            if (vig_btn.IsChecked == true)
            {
                vig_tbx.Visibility = Visibility.Visible;
                ces_tbx.Visibility = Visibility.Hidden;
            }
            if(ces_btn.IsChecked == false && vig_btn.IsChecked == false)
            {
                vig_tbx.Visibility = Visibility.Hidden;
                ces_tbx.Visibility = Visibility.Hidden;
            }
            if (afn_btn.IsChecked == true) afn_tbx_a.Visibility = afn_tbx_b.Visibility = Visibility.Visible;
            else afn_tbx_a.Visibility = afn_tbx_b.Visibility = Visibility.Hidden;

        }
        private void btn_click(object sender, RoutedEventArgs e)
        {
            
            Ciphers cip = new Ciphers();
            int afna = Convert.ToInt32(afn_tbx_a.Text);
            int afnb = Convert.ToInt32(afn_tbx_b.Text);
            string plain = pln_tbx.Text;
            plain = plain.ToLower().Replace(" ", "");
            string vigshift = vig_tbx.Text;
            vigshift = vigshift.ToLower().Replace(" ","");
            string cesshift = ces_tbx.Text;
            if (ces_btn.IsChecked == true) {
                if (ces_tbx.Text == "" || Int32.TryParse(cesshift, out int a) == false) MessageBox.Show("Enter a valid value!");
                else pln_tbx.Text = cip.cesaer_method(plain,Int32.Parse(cesshift)); }
            if(vig_btn.IsChecked == true)
            {
                if (vig_tbx.Text == "") MessageBox.Show("Enter something!");
                else pln_tbx.Text = cip.vigenere_method(plain.Trim(),vigshift.Trim());
            }
            if (atb_btn.IsChecked == true) pln_tbx.Text = cip.atbash_method(plain);
            if (bas_btn.IsChecked == true) pln_tbx.Text = cip.base32_method(plain);
            if (afn_btn.IsChecked == true) {               
            if (!int.TryParse(afn_tbx_a.Text, out int y) || afn_tbx_a.Text == "" || afn_tbx_b.Text == "") MessageBox.Show("Enter a valid value");
            else pln_tbx.Text = cip.affine_method(afna, afnb, plain);
            }
            //   if (vig_btn.IsChecked == true) pln_tbx.Text = cip.vigenere_method();
            //   if (bas_btn.IsChecked == true) pln_tbx.Text = cip.base32_method();
        }
    }
}
