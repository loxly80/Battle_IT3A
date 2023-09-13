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

namespace Battle_IT3A
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private Unit player1;
    private Unit player2;

    public MainWindow()
    {
      InitializeComponent();
      player1 = new Unit(500, 20);
      player1.HitBox = new Rectangle();
      player1.HitBox.Width = 40;
      player1.HitBox.Height = 80;
      player1.HitBox.Margin = new Thickness()
      player2 = new Unit(500, 20);
    }
  }
}
