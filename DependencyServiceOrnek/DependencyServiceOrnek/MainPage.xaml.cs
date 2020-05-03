using DependencyServiceOrnek.Servisler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DependencyServiceOrnek
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void MetniSeseDonustur(object sender, EventArgs e)
        {
            if (metin.Text == null)
            {
                DisplayAlert("Metin yok", "Lütfen metin giriniz.", "Tamam");
                return;
            }

            IMetniSeseCevirmeServisi tts = DependencyService.Resolve<IMetniSeseCevirmeServisi>();

            tts.SeseDonustur(metin.Text);
        }
    }
}
