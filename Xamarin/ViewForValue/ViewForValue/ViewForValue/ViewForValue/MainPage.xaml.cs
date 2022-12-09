using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace ViewForValue
{
    public partial class MainPage : ContentPage
    {
        DateTime _triggerTime;

        public MainPage()
        {
            InitializeComponent();

            //Checkbox
            CheckBox newCheckBox = new CheckBox { IsChecked = false, HorizontalOptions = LayoutOptions.Center };
            newCheckBox.SetBinding(CheckBox.IsCheckedProperty, new Binding("IsChecked", source: showPudzian));
            checkBoxTwo.SetBinding(CheckBox.IsCheckedProperty, new Binding("IsChecked", source: showPudzian));
            layout.Children.Add(newCheckBox);

            //Stepper
            stepperLabel.SetBinding(Label.FontSizeProperty, new Binding("Value", source: stepper));
            stepperLabel.SetBinding(Label.TextProperty, new Binding("Value", source: stepper));

            //DatePicker
            timeLabel.BindingContext = timePicker;

            timeLabelTwo.BindingContext = timePicker;
            timeLabelTwo.SetBinding(Label.TextProperty, "Date", BindingMode.Default, null, "{0:MMMM dd, yyyy}");

            timeLabelThree.BindingContext = timePicker;
            timeLabelThree.SetBinding(Label.TextProperty, "Date", BindingMode.Default, null, "Today is {0:dddd, dd MMM yyyy}");

            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
        }

        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            Recalculate();
        }

        void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
            Recalculate();
        }

        void Recalculate()
        {
            TimeSpan timeSpan = endDatePicker.Date - startDatePicker.Date + (includeSwitch.IsToggled ? TimeSpan.FromDays(1) : TimeSpan.Zero);
            resultLabel.Text = String.Format("{0} day{1} between dates", timeSpan.Days, timeSpan.Days == 1 ? "" : "s");
        }

        private void changeFontSize(object sender, ValueChangedEventArgs e)
        {
            double value = slider.Value;
            label1.FontSize = value;
            label2.Text = String.Format("Wartość czcionki: {0}", value);
        }

        private void changeTheme(object sender, ToggledEventArgs e)
        {
            bool isSwitched = switch1.IsToggled;

            if (isSwitched == true)
                layout.BackgroundColor = Color.LightGreen;
            else
                layout.BackgroundColor = Color.White;
        }

        private void imageVisible(object sender, ToggledEventArgs e)
        {
            bool visibility = switch2.IsToggled;

            if (visibility == true)
                obrazek.IsVisible = true;
            else
                obrazek.IsVisible = false;
        }

        private void turnOffSwitching(object sender, ToggledEventArgs e)
        {
            bool switching = switch3.IsToggled;

            if (switching == false)
            {
                switch1.IsEnabled = false;
                switch2.IsEnabled = false;
            }
            else
            {
                switch1.IsEnabled = true;
                switch2.IsEnabled = true;
            }
        }

        bool OnTimerTick()
        {
            if (_switch.IsToggled && DateTime.Now >= _triggerTime)
            {
                _switch.IsToggled = false;
                DisplayAlert("Timer Alert", "' Czas upłynął", "OK");
            }
            return true;
        }

        void OnTimePickerPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            if (args.PropertyName == "Time")
            {
                SetTriggerTime();
            }
        }

        void OnSwitchToggledTime(object sender, ToggledEventArgs args)
        {
            SetTriggerTime();
        }

        void SetTriggerTime()
        {
            if (_switch.IsToggled)
            {
                _triggerTime = DateTime.Today + _timePicker.Time;
                if (_triggerTime < DateTime.Now)
                {
                    _triggerTime += TimeSpan.FromDays(1);
                }
            }
        }
    }
}

