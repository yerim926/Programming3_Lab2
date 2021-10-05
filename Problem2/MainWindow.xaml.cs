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

namespace Problem2
{
    public class MyTestClass
    {
        public string getUpperCase(string a)
        {
            return a.ToUpper();
        }

        public int getLength(string a)
        {
            return a.Length;
        }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public MyTestClass c = new MyTestClass();
        
        public delegate string MyFunc1(string arg);

        public delegate int MyFunc2(string arg);


        //handler method for click on left button
        private void leftButton_onClick(object sender, RoutedEventArgs e)
        {
            MyFunc1 aDel;

            aDel = c.getUpperCase;

            //The argument to be passed to the wrapped method is
            //saved in variable theWord.
            string theWord = textbox1.Text;


            string sUpper;
            
            sUpper = aDel.Invoke(theWord);

            textblock1.Text = sUpper;
        }

        //handler method for click on right button
        private void rightButton_onClick(object sender, RoutedEventArgs e)
        {
            MyFunc2 bDel;

            bDel = c.getLength;

            string theWord = textbox1.Text;

            int sLength;
            
            sLength = bDel(theWord);


            textblock1.Text = Convert.ToString(sLength);

        }
    }

}
