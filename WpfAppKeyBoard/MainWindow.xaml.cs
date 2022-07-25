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
            //this.AddHandler(Button.Click, new RoutedEventHandler(DoSomething));
            btn_finish.IsEnabled = false;
        }
        public class KeyHandler
        {
            public List<Button> buttons;
            
            public KeyHandler()
            {
                buttons = new List<Button>();
            }
        }
        
        private void DoSomething(object sender, RoutedEventArgs e)
        {foreach(var item in keyHandler.buttons)
            if (e.OriginalSource == item)
            { txt_enter.Text += item.Content.ToString(); }
            //else if (e.OriginalSource == btn2)
            //{ }
            //else if (e.OriginalSource == btn3)
            //{ }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txt_enter.Text += btn1.Content.ToString();
        }
        
        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            while(txt_dificult.Text==null)
            {
                btn_start.IsEnabled=false;
            }
            if (txt_dificult.Text.Length>0)
            {
                int num;
                num =Convert.ToInt32(txt_dificult.Text);
            switch(num)
                {
                    case 1:
                        {
                            txt_given.Text = null;
                            for (int i=0;i< keyHandler.buttons.Count/10;i++)
                           {
                             txt_given.Text += keyHandler.buttons[i].Content;
                                keyHandler.buttons.Reverse();
                           }

                        }
                        break;
                
                case 2:
                        {
                            txt_given.Text = null;
                            for (int i = 0; i < keyHandler.buttons.Count / 9; i++)
                             {
                                txt_given.Text += keyHandler.buttons[i].Content;
                                keyHandler.buttons.Reverse();
                            }

                        }
                         break;
                    case 3:
                        {
                            txt_given.Text = null;
                            for (int i = 0; i < keyHandler.buttons.Count / 8; i++)
                            {
                                txt_given.Text += keyHandler.buttons[i].Content;
                                keyHandler.buttons.Reverse();
                            }

                        }
                        break;
                    case 4:
                        {
                            txt_given.Text = null;
                            for (int i = 0; i < keyHandler.buttons.Count / 7; i++)
                            {
                                txt_given.Text += keyHandler.buttons[i].Content;
                                keyHandler.buttons.Reverse();
                            }

                        }
                        break;
                    case 5:
                        {
                            txt_given.Text = null;
                            for (int i = 0; i < keyHandler.buttons.Count / 6; i++)
                            {
                                txt_given.Text += keyHandler.buttons[i].Content;
                                keyHandler.buttons.Reverse();
                            }

                        }
                        break;
                    case 6:
                        {
                            txt_given.Text = null;
                            for (int i = 0; i < keyHandler.buttons.Count / 5; i++)
                            {
                                txt_given.Text += keyHandler.buttons[i].Content;
                                keyHandler.buttons.Reverse();
                            }

                        }
                        break;
                    case 7:
                        {
                            txt_given.Text = null;
                            for (int i = 0; i < keyHandler.buttons.Count / 4; i++)
                            {
                                txt_given.Text += keyHandler.buttons[i].Content;
                                keyHandler.buttons.Reverse();
                            }

                        }
                        break;
                    case 8:
                        {
                            txt_given.Text = null;
                            for (int i = 0; i < keyHandler.buttons.Count / 3; i++)
                            {
                                txt_given.Text += keyHandler.buttons[i].Content;
                                keyHandler.buttons.Reverse();
                            }

                        }
                        break;
                    case 9:
                        {
                            txt_given.Text = null;
                            for (int i = 0; i < keyHandler.buttons.Count / 2; i++)
                            {
                                txt_given.Text += keyHandler.buttons[i].Content;
                                keyHandler.buttons.Reverse();
                            }

                        }
                        break;
                    case 10:
                        {
                            txt_given.Text = null;
                            for (int i = 0; i < keyHandler.buttons.Count ; i++)
                            {
                                txt_given.Text += keyHandler.buttons[i].Content;
                                keyHandler.buttons.Reverse();
                            }

                        }
                        break;
                }
                btn_finish.IsEnabled = true;

            }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txt_dificult.Text =((int)slider.Value).ToString();
        }

        private void btn_finish_Click(object sender, RoutedEventArgs e)
        {

        }
    } 
}
