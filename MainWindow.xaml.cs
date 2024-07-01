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

namespace wpfChess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Image selectedPiece;
        private bool isSelected = false;
        private Point clickPosition;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void WhitePawn1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            isSelected = true;
            
        }

        private void WhitePawn1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Grid.GetColumn(WhitePawn1);
            if (isSelected == true)
            {

            }

        }

        
    }
}