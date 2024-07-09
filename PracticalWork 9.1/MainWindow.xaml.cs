
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticalWork_9._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
        }
        public string[] SplitText(string text)
        {
            string[] words = text.Split(" ");

            foreach (string w in words)
            {
                Console.WriteLine(w);
            }
            return words;
        }
        public string Reverse(string reverseText)
        {
            var words = SplitText(reverseText);
            string reversedText = string.Join(" ", words.Reverse());
            return reversedText;
        }
        private void SplitText_Click(object sender, RoutedEventArgs e) 
        {
            string input = inputTextBox.Text;

            outputListBox.Items.Clear();

            foreach (string word in SplitText(input)) 
            {
                outputListBox.Items.Add(word);
            }

        }
        private void Reverse_Click(object sender, RoutedEventArgs e) 
        {
            string sentence  = inputSentenceTextBox.Text;

            string reversed = Reverse(sentence);

            outputLabel.Content = reversed;
        }
    }
}