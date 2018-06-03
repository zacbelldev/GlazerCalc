using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GlazerCalc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //sliderOutput.Text = quantitySlider.Value.ToString();
        }



        //  heightTextBox
        //  widthTextBox
        //  quantitySlider
        //  colorComboBox
        //  dateOutput 
        //  areaOutput
        //  lengthOutput


        private void calcButton_Click(object sender, RoutedEventArgs e)
        {                                   
            if (heightTextBox.Text == "" || widthTextBox.Text == "")
            {
                errorMessage.Text = "Make sure your height is an Int or Double (e.g. 12 or 12.35) and that the field is not empty.";
            } else
            {
                double height = Convert.ToDouble(heightTextBox.Text);
                double width = Convert.ToDouble(widthTextBox.Text);
                var quantity = quantitySlider.Value;
                var color = colorComboBox.SelectedItem;
                var woodLength = 2 * (width + height) * 3.25;
                var glassArea = 2 * (width * height);
                dateOutput.Text = DateTime.Now.ToString();
                areaOutput.Text = glassArea.ToString();
                lengthOutput.Text = woodLength.ToString();
            }
        }







































        private void heightTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void widthTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void quantitySlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

        }
        private void colorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void dateOutput_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        private void areaOutput_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        private void lengthOutput_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void sliderOutput_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void errorMessage_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        //private async void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    MediaElement mediaElement = new MediaElement();
        //    var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
        //    Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream =
        //        await synth.SynthesizeTextToStreamAsync("Hello World!");
        //    mediaElement.SetSource(stream, stream.ContentType);
        //    mediaElement.Play();
        //}
    }
}
