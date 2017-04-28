using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace WpfBasics
{
  /// <summary>
  /// Interaction logic for TextblockBeispiel.xaml
  /// </summary>
  public partial class TextblockBeispiel : Window
  {
    public TextblockBeispiel()
    {
      InitializeComponent();
    }

    private void NavClick(object sender, RoutedEventArgs e)
    {
      Process.Start(((Hyperlink)sender).NavigateUri.AbsoluteUri);
    }
  }
}
