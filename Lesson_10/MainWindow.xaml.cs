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

namespace Lesson_10
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

        private void bt_split_Click(object sender, RoutedEventArgs e)
        {
            SplitWords(tb_string.Text);
        }

        private void bt_revers_words_Click(object sender, RoutedEventArgs e)
        {
            ReversWords(tb_string_revers.Text);
        }

        void SplitWords (string Text)
        {
            lb_words.Items.Clear();
            string[] words = Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                lb_words.Items.Add(word);
            }
        }

        void ReversWords(string Text)
        {
            string[] words = Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var revWords = words.Reverse();
            string reversText=string.Empty;
            foreach (string word in revWords)
            {

                reversText = reversText + " " + word;
            }

            l_reversWords.Content=reversText;
        }
    }
}
