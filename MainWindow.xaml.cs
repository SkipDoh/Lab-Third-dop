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

namespace laba_3__2_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Point startPoint;
        private bool isDrawing = false;
        private bool isEditing = false;
        private bool isDeleting = false;


        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(Canvas);

            if (RadioButtonDraw.IsChecked == true)
            {
                isDrawing = true;
            }
            else if (RadioButtonEdit.IsChecked == true)
            {
                isEditing = true;
            }
            else if (RadioButtonDelete.IsChecked == true)
            {
                isDeleting = true;
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    Line line = new Line
                    {
                        Stroke = new SolidColorBrush((Color)ColorConverter.ConvertFromString((ColorComboBox.SelectedItem as ComboBoxItem).Content.ToString())),
                        StrokeThickness = SizeSlider.Value,
                        X1 = startPoint.X,
                        Y1 = startPoint.Y,
                        X2 = e.GetPosition(Canvas).X,
                        Y2 = e.GetPosition(Canvas).Y
                    };

                    Canvas.Children.Add(line);

                    startPoint = e.GetPosition(Canvas);
                }
            }
            else if (isEditing)
            {
                
            }
            else if (isDeleting)
            {
              
            }

        }
    }
}

