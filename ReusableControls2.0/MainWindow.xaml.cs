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

namespace ReusableControls2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly Random rnd = new Random();

        private ForTierCards cardsdata;

        public MainWindow()
        {
            InitializeComponent();
        }

        private static readonly IReadOnlyList<string> arr = new string[] { "basic", "pro", "enterprise", "super basic", "super Pro", "super Enterprise" };
        private static readonly IReadOnlyList<Brush> colors = new Brush[] { Brushes.Bisque, Brushes.Black, Brushes.Green, Brushes.BlueViolet, Brushes.DeepPink, Brushes.Crimson };
        private static readonly IReadOnlyList<string> words = new string[] { "bbbbbasic", "pro", "advanced", "super basic", "super Pro", "super Enterprise" };

        private void ReGenerate(int rows, int columns)
        {
            var cards = new ForTierCard[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    cards[i, j] = new ForTierCard()
                    {
                        Row = i,
                        Column = j,
                        Color = colors[rnd.Next(colors.Count)],
                        Description = words[rnd.Next(words.Count)],
                        SubType = arr[rnd.Next(arr.Count)]
                    };
                }
            }
            cardsdata.CardsArr = cards;
            DataContext = cardsdata;
        }

        private void GenerateClick(object sender, RoutedEventArgs e)
        {
            ReGenerate(1,1);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ReGenerate(0, 0);
        }
    }
}
