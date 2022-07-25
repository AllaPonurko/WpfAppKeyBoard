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

namespace WpfAppKeyBoard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        KeyHandler keyHandler = new KeyHandler();
        public MainWindow()
        {
            InitializeComponent();
       
            keyHandler.buttons.Add(btn0);
            keyHandler.buttons.Add(btn1);
            keyHandler.buttons.Add(btn2);
            keyHandler.buttons.Add(btn3);
            keyHandler.buttons.Add(btn4);
            keyHandler.buttons.Add(btn5);
            keyHandler.buttons.Add(btn6);
            keyHandler.buttons.Add(btn7);
            keyHandler.buttons.Add(btn8);
            keyHandler.buttons.Add(btn9);
            keyHandler.buttons.Add(btna);
            keyHandler.buttons.Add(btnb);
            keyHandler.buttons.Add(btnc);
            keyHandler.buttons.Add(btnd);
            keyHandler.buttons.Add(btne);
            keyHandler.buttons.Add(btnf);
            keyHandler.buttons.Add(btng);
            keyHandler.buttons.Add(btnh);
            keyHandler.buttons.Add(btnj);
            keyHandler.buttons.Add(btnk);
            keyHandler.buttons.Add(btnl);
            keyHandler.buttons.Add(btnm);
            keyHandler.buttons.Add(btnn);
            keyHandler.buttons.Add(btno);
            keyHandler.buttons.Add(btnp);
            keyHandler.buttons.Add(btnq);
            keyHandler.buttons.Add(btnr);
            keyHandler.buttons.Add(btns);
            keyHandler.buttons.Add(btnt);
            keyHandler.buttons.Add(btnu);
            keyHandler.buttons.Add(btnx);
            keyHandler.buttons.Add(btny);
            keyHandler.buttons.Add(btnw);
            keyHandler.buttons.Add(btnv);
            keyHandler.buttons.Add(btnSign1);
            keyHandler.buttons.Add(btnSign2);
            keyHandler.buttons.Add(btnSign3);
            keyHandler.buttons.Add(btnSign4);
            keyHandler.buttons.Add(btnSign5);
            keyHandler.buttons.Add(btnSign6);
            keyHandler.buttons.Add(btnSign7);
            keyHandler.buttons.Add(btnSlash);
            keyHandler.buttons.Add(btnSpace);
            keyHandler.buttons.Add(btnSubstruction);
            keyHandler.buttons.Add(btn_);
        }
        public class KeyHandler
        {
            public List<Button> buttons;
            
            public KeyHandler()
            {
                buttons = new List<Button>();
            }
        }
        private void Button_Click()
        {
            foreach(var item in keyHandler.buttons)
            {
              if(sign)
                {
                    txt_given.Text = item.Content.ToString();
                }
            }
        }
        bool sign = false;
        private void btn__Click(object sender, RoutedEventArgs e)
        {
            sign = true;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            sign = true;
        }

        
    } 
}
