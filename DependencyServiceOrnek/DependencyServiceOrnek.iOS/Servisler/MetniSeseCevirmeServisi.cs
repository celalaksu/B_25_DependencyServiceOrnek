using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVFoundation;
using DependencyServiceOrnek.Servisler;
using Foundation;
using UIKit;

namespace DependencyServiceOrnek.iOS.Servisler
{
    public class MetniSeseCevirmeServisi : IMetniSeseCevirmeServisi
    {
        public void SeseDonustur(string metin)
        {
            var metinSesi = new AVSpeechSynthesizer();
            metinSesi.SpeakUtterance(new AVSpeechUtterance(metin)
            {
                Rate = AVSpeechUtterance.DefaultSpeechRate,
                Voice = AVSpeechSynthesisVoice.FromLanguage("tr-TR"),
                Volume = .5f,
                PitchMultiplier = 1.0f
            });
        }
    }
}