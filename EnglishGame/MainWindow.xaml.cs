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
using System.IO;

namespace EnglishGame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            GetData();
            Zadan();
        }
        bool ChekRandom = true;
        List<Zadan> zadans = new List<Zadan>();
        string[] _Zero = null;
        string[] _One = null;
        int rec;
        int schets = 0;
        int poins = 0;
        string otvet = "";
        void GetData()
        {
            _Zero = File.ReadAllLines("Resources/TextFailedZeroTupe.txt", Encoding.GetEncoding(1251));
            _One = File.ReadAllLines("Resources/TextFailedOneTupe.txt", Encoding.GetEncoding(1251));
            var record_Save = Properties.Settings.Default.Record;
            rec = Convert.ToInt32(record_Save);
            Recod.Text = $"Record: {rec} points.";
            var d = File.ReadAllLines("Resources/ZadanText.txt", Encoding.GetEncoding(1251));
            int naz = 0;
            int schetz = 0;
            int kon = 0;
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i].Substring(0, 1) == "@")
                {
                    schetz++;
                    if (schetz == 2)
                        naz = i + 1;
                    if (schetz == 3)
                        kon = i;
                }
            }
            schetz = 0;
            foreach (string s in d)
            {
                schetz++;
                if (naz < schetz && kon >= schetz)
                {
                    string t = s.Substring(0, s.IndexOf('-'));
                    string v = s.Substring(s.IndexOf('-') + 1, s.LastIndexOf('-') - s.IndexOf('-') - 1);
                    string o = s.Substring(s.LastIndexOf('-') + 1, s.Length - 1 - s.LastIndexOf('-'));
                    zadans.Add(new Zadan(Convert.ToInt32(t), v, o));
                }
            }
            kollZadan = kon - naz;
            Coll.Text = $"Number of jobs: {kollZadan}";
        }
        int kollZadan;
       
        void Zadan()
        {
            Zadan z = null; Random rnd = new Random();
            if (ChekRandom)
            {
                 otvet = "";
                z = zadans[rnd.Next(0, zadans.Count)];
            }
            else
            {
                if(schets+1 == kollZadan)
                {
                    MessageBox.Show("Show the result to the teacher or select the random question mode.", "The questions are over", MessageBoxButton.OK,MessageBoxImage.Warning);
                    return;
                }
                z = zadans[schets];
            }
            
            string Zadanie = "";
            switch (z.Tip)
            {
                case 0:
                    Zadanie = "Insert the missing word.";//radiob
                    Radiobutton.Visibility = Visibility.Visible;
                    Vvod.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    Zadanie = "Choose the correct translation.";//radiob
                    Radiobutton.Visibility = Visibility.Visible;
                    Vvod.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    Zadanie = "Translate the word from Russian into English.";//vvod
                    Radiobutton.Visibility = Visibility.Hidden;
                    Vvod.Visibility = Visibility.Visible;
                    break;
                case 3:
                    Zadanie = "Insert the missing word.";//vvod
                    Radiobutton.Visibility = Visibility.Hidden;
                    Vvod.Visibility = Visibility.Visible;
                    break;
            }
            

            if(Radiobutton.Visibility == Visibility.Visible)
            {
                List<string> l = new List<string>();
                int num=0; 
                switch (z.Tip)
                {
                    case 0:
                        while (true)
                        {
                            num = rnd.Next(_Zero.Length);
                            if (!l.Contains(_Zero[num].ToLower()))
                                l.Add(_Zero[num].ToLower());
                            if (l.Count == 4)
                                break;
                        }
                        l[rnd.Next(l.Count)] = z.Otvet.ToLower();
                        
                        break;
                    case 1:
                        while (true)
                        {
                            num = rnd.Next(_One.Length);
                            if (!l.Contains(_One[num].ToLower()))
                                l.Add(_One[num].ToLower());
                            if (l.Count == 4)
                                break;
                        }
                        l[rnd.Next(l.Count)] = z.Otvet.ToLower();
                        break;
                }
                (R1.Parent as RadioButton).IsChecked = false;
                (R2.Parent as RadioButton).IsChecked = false;
                (R3.Parent as RadioButton).IsChecked = false;
                (R4.Parent as RadioButton).IsChecked = false;
                R1.Text = l[0];
                R2.Text = l[1];
                R3.Text = l[2];
                R4.Text = l[3];
                
            }
            
            schets++;
            Zadanie = $"{schets}: " + Zadanie;
            LBL_Syt.Text = Zadanie;
            LBL_Zadanie.Text = z.Vopros;
            otvet = z.Otvet.ToLower();
            Points.Content = $"Points: {poins}";
            Vvod.Text = "";
        }


        private void BTN_Go_Click(object sender, RoutedEventArgs e)
        {
            bool Win = false;
            foreach(var d in Radiobutton.Children)
            {
                RadioButton tb = new RadioButton();
                if (d.GetType() == tb.GetType())
                {
                    if((d as RadioButton).IsChecked == true)
                    {
                        string s = ((d as RadioButton).Content as TextBlock).Text;
                        if (otvet == s)
                            Win = true;
                    }
                }
            }
            if(Win == false)
            {
                if (otvet == Vvod.Text.ToLower())
                    Win = true;
            }

            if (Win)
            {
                MessageBox.Show("You won. Go to the next level.", "Victory!", MessageBoxButton.OK, MessageBoxImage.Information);
                poins++;
            }
            else
            {
                poins--;
                MessageBox.Show($"You lost. The correct answer is -{otvet}-.", "You lost.", MessageBoxButton.OK ,MessageBoxImage.Stop);
            }
            
            if(rec < poins)
            {
                Properties.Settings.Default.Record = poins.ToString();
                Properties.Settings.Default.Save();
                var record_Save = Properties.Settings.Default.Record;
                rec = Convert.ToInt32(record_Save);
            Recod.Text = $"Record: {rec} points.";
            }


            Zadan();

        }

      
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (RBOrder == null)
                return;
            poins = 0;
            schets = 0;
            if(RBOrder.IsChecked == true)
            {
                ChekRandom = false;
            }
            else
                ChekRandom = true;
            Zadan();

        }
    }
    
}
