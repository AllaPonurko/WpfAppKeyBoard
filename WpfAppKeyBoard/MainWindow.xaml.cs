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
using System.Windows.Threading;

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
            btnStart.IsEnabled = false;
            txt_enter.IsEnabled = false;
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
                Random rand = new Random();
            switch(num)
                {
                    case 0:
                        {
                            txt_given.Text = null;
                            for (int i = 0; i < 20; i++)
                            {if (i == 4 || i == 7 || i == 10 || i == 13 || i == 16)
                                    txt_given.Text += " ";
                            else
                                {
                                    int n = rand.Next(11, keyHandler.buttons.Count - 20);
                                    txt_given.Text += keyHandler.buttons[n].Content;
                                }

                            }
                        }
                        break;
                    case 1:
                        {
                            txt_given.Text = null;
                            for (int i=0;i< 20; i++)
                           {
                                int n = rand.Next(0, keyHandler.buttons.Count - 1);
                             txt_given.Text += keyHandler.buttons[n].Content;
                                keyHandler.buttons.Reverse();
                           }

                        }
                        break;
                
                case 2:
                        {
                            txt_given.Text = null;
                            for (int i = 0; i < 30; i++)
                             {
                                int n = rand.Next(0, keyHandler.buttons.Count - 1);
                                txt_given.Text += keyHandler.buttons[n].Content;
                                keyHandler.buttons.Reverse();
                            }

                        }
                         break;
                    case 3:
                        {
                            txt_given.Text = null;
                            for (int i = 0; i < 35; i++)
                            {
                                int n = rand.Next(0, keyHandler.buttons.Count - 1);
                                txt_given.Text += keyHandler.buttons[n].Content;
                                keyHandler.buttons.Reverse();
                            }

                        }
                        break;
                    case 4:
                        {
                            txt_given.Text = null;
                            for (int i = 0; i < 40; i++)
                            {
                                int n = rand.Next(0, keyHandler.buttons.Count - 1);
                                txt_given.Text += keyHandler.buttons[n].Content;
                                keyHandler.buttons.Reverse();
                            }

                        }
                        break;
                    case 5:
                        {
                            txt_given.Text = null;
                            for (int i = 0; i<45; i++)
                            {
                                int n = rand.Next(0, keyHandler.buttons.Count - 1);
                                txt_given.Text += keyHandler.buttons[n].Content;
                                keyHandler.buttons.Reverse();
                            }

                        }
                        break;
                    case 6:
                        {
                            txt_given.Text = null;
                            for (int i = 0; i < 50; i++)
                            {
                                int n = rand.Next(0, keyHandler.buttons.Count - 1);
                                txt_given.Text += keyHandler.buttons[n].Content;
                                keyHandler.buttons.Reverse();
                            }

                        }
                        break;
                    case 7:
                        {
                            txt_given.Text = null;
                            for (int i = 0; i < 55; i++)
                            {
                                int n = rand.Next(0, keyHandler.buttons.Count - 1);
                                txt_given.Text += keyHandler.buttons[n].Content;
                                keyHandler.buttons.Reverse();
                            }

                        }
                        break;
                    case 8:
                        {
                            txt_given.Text = null;
                            for (int i = 0; i < 60; i++)
                            {
                                int n = rand.Next(0, keyHandler.buttons.Count - 1);
                                txt_given.Text += keyHandler.buttons[n].Content;
                                keyHandler.buttons.Reverse();
                            }

                        }
                        break;
                    case 9:
                        {
                            txt_given.Text = null;
                            for (int i = 0; i <65; i++)
                            {
                                int n = rand.Next(0, keyHandler.buttons.Count - 1);
                                txt_given.Text += keyHandler.buttons[n].Content;
                                keyHandler.buttons.Reverse();
                            }

                        }
                        break;
                    case 10:
                        {
                            txt_given.Text = null;
                            for (int i = 0; i < 70; i++)
                            {
                                int n = rand.Next(0, keyHandler.buttons.Count - 1);
                                txt_given.Text += keyHandler.buttons[n].Content;
                                keyHandler.buttons.Reverse();
                            }

                        }
                        break;
                }
                btnStart.IsEnabled = true; 

            }
        }
          
            
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txt_dificult.Text =((int)slider.Value).ToString();
        }
        DispatcherTimer timer = new DispatcherTimer();
        DateTime timeStart = new DateTime();
        DateTime timeFinish = new DateTime();
        private void btn_finish_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();

        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            txt_enter.IsEnabled = true;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            timeStart = DateTime.Now;
            btn_finish.IsEnabled = true;
        }
        void timer_Tick(object sender, EventArgs e)
        {
            timeFinish = DateTime.Now;
            txtTime.Text = ((int)(timeFinish - timeStart).TotalSeconds).ToString();
            /*DateTime.Now.ToLongTimeString();*/

        }
    } 
}
