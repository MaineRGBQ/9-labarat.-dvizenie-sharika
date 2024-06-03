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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PointAnimation animation = new PointAnimation();
            animation.From = new Point(0.3, 0.3);
            animation.To = new Point(0.7, 0.7);
            animation.Duration = TimeSpan.FromSeconds(2);
            animation.AutoReverse = true;
            animation.RepeatBehavior = RepeatBehavior.Forever;

            Storyboard.SetTargetName(animation, "radialGradientBrush");
            Storyboard.SetTargetProperty(animation, new PropertyPath(RadialGradientBrush.GradientOriginProperty));

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(animation);

            storyboard.Begin(this);
        }
    }
}
