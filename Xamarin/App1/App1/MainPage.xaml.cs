using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var contact = await Contacts.PickContactAsync();
                if (contact == null)
                    return;
                var info = new StringBuilder();
                info.AppendLine(contact.Id);
                info.AppendLine(contact.NamePrefix);
                info.AppendLine(contact.GivenName);
                info.AppendLine(contact.MiddleName);
                info.AppendLine(contact.FamilyName);
                info.AppendLine(contact.NameSuffix);
                info.AppendLine(contact.DisplayName);
                info.AppendLine(contact.Phones.FirstOrDefault()?.PhoneNumber ?? string.Empty);
                info.AppendLine(contact.Emails.FirstOrDefault()?.EmailAddress ?? string.Empty);
                LabelInfo.Text = info.ToString();
            }
            catch(Exception)
            {

            }
        }

    }
}
