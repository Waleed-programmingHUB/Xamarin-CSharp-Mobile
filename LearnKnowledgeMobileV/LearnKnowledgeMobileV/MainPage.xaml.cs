using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using Xamarin.Forms;

namespace LearnKnowledgeMobileV
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            if (getPluralRadioButton.IsFocused == true)
                    inputEntryBox.Text = "";
            
        }

        private void getAction_Clicked(object sender, EventArgs e)
        {
            // taking user input Text in Field
            if (getPluralRadioButton.IsChecked == true)
            {
                outputLabelAnswer.Text = $"Singular of {inputEntryBox2.Text}, Plural is {inputEntryBox2.Text.Pluralize()}";
            }

            try
            {
                // Taking a user input Number in Field
                int input1 = Convert.ToInt32(inputEntryBox.Text);
           
                if (numTowordRadioButton.IsChecked == true)
                {
                    outputLabelAnswer.Text = $"Number of {input1} is {input1.ToWords()}";
                    inputEntryBox2.Text = "";
                }

                if (numToromanRadioButton.IsChecked == true)
                {
                    outputLabelAnswer.Text = $"Roman of {input1} is {input1.ToRoman()}";
                    inputEntryBox2.Text = "";
                }
            }
            catch (Exception)
            {
                DisplayAlert("Error","Invalid Inputs??","Cancel");
            }
        }
    }
}
