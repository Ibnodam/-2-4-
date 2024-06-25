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
#region
/// <summary>
/// Логика взаимодействия для MainWindow.xaml
/// </summary>

#endregion




namespace Лабораторная_2__4_семестр_
{


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Ball_Click(object sender, RoutedEventArgs e)
        {
            double radius = Convert.ToDouble(RadiusTextBox.Text);

            Ball ball = new Ball(radius);

            
            tb1.Text = $"Surfare area = {Math.Round(ball.CalculateSurfaceArea(),2)}; volume = {Math.Round(ball.CalculateVolume(), 2)}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(SideATextBox.Text);
            double b = Convert.ToDouble(SideBTextBox.Text);
            double c = Convert.ToDouble(SideCTextBox.Text);
            Parallelepiped par = new Parallelepiped(a,b,c);
            ParallelepipedResultsLabel.Content = $"Surface area = {Math.Round(par.CalculateSurfaceArea(),2)}; Volume = {Math.Round(par.CalculateVolume(),2)}.";
        }
    }

    // Интерфейс для вычисления площади поверхности и объема
    interface IShape
    {
        double CalculateSurfaceArea();
        double CalculateVolume();
    }

    // Класс Parallelepiped, реализующий интерфейс IShape
    class Parallelepiped : IShape
    {
        private double length;
        private double width;
        private double height;

        public Parallelepiped(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double CalculateSurfaceArea()
        {
            return 2 * (length * width + length * height + width * height);
        }

        public double CalculateVolume()
        {
            return length * width * height;
        }
    }

    // Класс Ball, реализующий интерфейс IShape
    class Ball : IShape
    {
        private double radius { get; set; }

        public Ball(double radius)
        {
            this.radius = radius;
        }

        public double CalculateSurfaceArea()
        {
            return (4 * Math.PI * radius * radius);
        }

        public double CalculateVolume()
        {
            return ((4 / 3) * Math.PI * radius * radius * radius);
        }
    }

  






}
