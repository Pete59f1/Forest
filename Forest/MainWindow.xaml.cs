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
using Interface;
using Game;

namespace Forest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ISubscriber
    {
        MyGame game;
        public MainWindow()
        {
            InitializeComponent();
        }

        //Observer
        public void Update(IPublisher publisher)
        {
            
        }
        //Observer

        private void BtnNewGame_Click(object sender, RoutedEventArgs e)
        {
            game = new MyGame();
            game.RegisterSubscriber(this);
            btnNewGame.IsEnabled = false;
            lblPlayer1.IsEnabled = true;
            lblPlayer2.IsEnabled = true;
            lblPlayer3.IsEnabled = true;
            lblPlayer4.IsEnabled = true;
        }
    }
}
