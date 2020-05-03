using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Speech.Tts;
using Android.Views;
using Android.Widget;
using DependencyServiceOrnek.Servisler;

namespace DependencyServiceOrnek.Droid.Servisler
{
    public class MetniSeseCevirmeServisi : Java.Lang.Object, IMetniSeseCevirmeServisi, TextToSpeech.IOnInitListener
    {
        TextToSpeech metninSesi;
        string sonMetin;

        public void OnInit([GeneratedEnum] OperationResult status)
        {
            if (status == OperationResult.Success)
            {
                if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                    metninSesi.Speak(sonMetin, QueueMode.Flush, null, null); //burası çalışıyor
                else
                {
//#pragma warning disable 0618
                    metninSesi.Speak(sonMetin, QueueMode.Flush, null);
//#pragma warning restore 0618
                }
                sonMetin = null;
            }
        }

        public void SeseDonustur(string metin)
        {
            if (metninSesi == null)
            {
                sonMetin = metin;
                metninSesi = new TextToSpeech(Application.Context, this); //burası çalışıyor
            }
            else
            {
                if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                    metninSesi.Speak(metin, QueueMode.Flush, null, null);
                else
                {
//#pragma warning disable 0618
                    metninSesi.Speak(metin, QueueMode.Flush, null);
//#pragma warning restore 0618
                }
            }
        }
    }
}