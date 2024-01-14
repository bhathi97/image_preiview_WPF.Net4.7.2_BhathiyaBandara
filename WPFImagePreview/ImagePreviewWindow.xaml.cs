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
using System.Windows.Shapes;

namespace WPFImagePreview
{
    /// <summary>
    /// Interaction logic for ImagePreviewWindow.xaml
    /// </summary>
    public partial class ImagePreviewWindow : Window
    {
        public ImagePreviewWindow()
        {
            InitializeComponent();
        }

        // When the window is loaded, lets initializes transformation objects
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Initialize a TransformGroup to combine multiple transformations
            TransformGroup transformGroup = new TransformGroup();

            // Create individual transformations
            ScaleTransform scaleTransform = new ScaleTransform();
            RotateTransform rotateTransform = new RotateTransform();
            TranslateTransform translateTransform = new TranslateTransform();

            // Add individual transformations to the TransformGroup
            transformGroup.Children.Add(scaleTransform);
            transformGroup.Children.Add(rotateTransform);
            transformGroup.Children.Add(translateTransform);

            // Assign the TransformGroup to the ImgPreview element
            ImgPreview.RenderTransform = transformGroup;
        }

        //Move with mouse pointer
        private Point origin;
        private Point start;
        private void ImgPreview_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (ImgPreview.Source != null)
                {
                    if (!ImgPreview.IsMouseCaptured) return;
                    //Retrieve the TranslateTransform from the RenderTransform of ImgPreview
                    var translateTransform = (TranslateTransform)((TransformGroup)ImgPreview.RenderTransform).Children.First(c => c is TranslateTransform);
                    //Only move inside the border
                    Vector v = start - e.GetPosition(border);
                    translateTransform.X = origin.X - v.X;
                    translateTransform.Y = origin.Y - v.Y;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ImgPreview_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ImgPreview.Cursor = Cursors.Hand;
            try
            {
                if (ImgPreview.Source != null)
                {
                    //Capture the mouse inside the image
                    ImgPreview.CaptureMouse();
                    //Retrieve the TranslateTransform from the RenderTransform of ImgPreview
                    var translateTransform = (TranslateTransform)((TransformGroup)ImgPreview.RenderTransform).Children.First(c => c is TranslateTransform);
                    //Record the starting position of the mouse click and the current translation
                    start = e.GetPosition(border);
                    origin = new Point(translateTransform.X, translateTransform.Y);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ImgPreview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ImgPreview.Cursor = Cursors.Arrow;
            try
            {
                if (ImgPreview.Source != null)
                {
                    //Release the Image from the Mouse Pointer 
                    ImgPreview.ReleaseMouseCapture();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnZoomIn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ImgPreview.Source != null)
                {
                    //Retrieve the ScaleTransform from the RenderTransform of ImgPreview
                    var transform = (ScaleTransform)((TransformGroup)ImgPreview.RenderTransform).Children.First(c => c is ScaleTransform);

                    transform.ScaleX += 0.2;
                    transform.ScaleY += 0.2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnZoomOut_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ImgPreview.Source != null)
                {
                    //Retrieve the ScaleTransform from the RenderTransform of ImgPreview
                    var transform = (ScaleTransform)((TransformGroup)ImgPreview.RenderTransform).Children.First(c => c is ScaleTransform);
                    transform.ScaleX -= 0.2;
                    transform.ScaleY -= 0.2;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRotate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ImgPreview.Source != null)
                {
                    //Retrieve the RotateTransform from the RenderTransform of ImgPreview
                    var transform = (RotateTransform)((TransformGroup)ImgPreview.RenderTransform).Children.First(c => c is RotateTransform);
                    double centerX = ImgPreview.ActualWidth / 2;
                    double centerY = ImgPreview.ActualHeight / 2;

                    transform.CenterX = centerX;
                    transform.CenterY = centerY;
                    transform.Angle += 90;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
