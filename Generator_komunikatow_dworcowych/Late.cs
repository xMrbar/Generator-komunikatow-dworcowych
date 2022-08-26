using System.IO;
using System.Threading;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Media;
using Windows.ApplicationModel.VoiceCommands;

namespace Generator
{
    static class Late
    {
        public static string Komunikat(string początek, string relacja, string torIPeron, string godziny, string rezerwacja)
        {
            return początek + relacja + torIPeron + rezerwacja + godziny + ".";
        }

        public static string KomunikatLate(string początek, string relacja, string torIPeron, string godziny, string rezerwacja)
        {
            return początek + relacja + godziny + torIPeron + rezerwacja + ". Za opóźnienie pociągu przepraszamy.";
        }
    }

    static class Gadanie
    {
        public static void Syntezator(string początek, string relacja, string torIPeron, string godziny, Generator_komunikatów_dworcowych.komunikaty current, bool ifLate, string NazwaGongu, string rezerwacja, bool isGongOn, int glosnosc)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = glosnosc;

            if (isGongOn)
            {
                OdtworzGong(NazwaGongu);
            }

            if (!ifLate)
            {
                synth.Speak(Late.Komunikat(początek, relacja, torIPeron, godziny, rezerwacja));
            }
            else
            {
                synth.Speak(Late.KomunikatLate(początek, relacja, torIPeron, godziny, rezerwacja));
            }

            synth.Dispose();

            ButtonEnabled(current);
        }
        
        public static void SyntezatorBezPostoju(Generator_komunikatów_dworcowych.komunikaty current, string NazwaGongu, bool isGongOn, int glosnosc)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = glosnosc;

            if (isGongOn)
            {
                OdtworzGong(NazwaGongu);
            }

            synth.Speak("Uwaga! Przez stację przejedzie pociąg, bez zatrzymania! Prosimy zachować ostrożność i odsunąć się od krawędzi peronu!");

            synth.Dispose();

            ButtonEnabled(current);
        }
       
        public static void TestowyDzwiekGongu(Generator_komunikatów_dworcowych.komunikaty current, string NazwaGongu)
        {
            OdtworzGong(NazwaGongu);

            ButtonEnabled(current);
        }

        private static Stream GongSet(string NazwaGongu)
        {
            if (NazwaGongu == "GONG 1")
            {
                return GeneratorKomunikatów.Properties.Resources.gong_wroclaw;
            }
            else if (NazwaGongu == "GONG 2")
            {
                return GeneratorKomunikatów.Properties.Resources.gong1;
            }
            else if (NazwaGongu == "GONG 3")
            {
                return GeneratorKomunikatów.Properties.Resources.gong2;
            }
            else
            {
                return GeneratorKomunikatów.Properties.Resources.gong_torun;
            }
        }

        private static void OdtworzGong(string NazwaGongu)
        {
            Stream s = GongSet(NazwaGongu);

            SoundPlayer player = new SoundPlayer(s);

            player.PlaySync();
        }

        public static void TMP()
        {

        }

        private static void ButtonEnabled (Generator_komunikatów_dworcowych.komunikaty current)
        {
            MethodInvoker changeState = delegate ()
            {
                current.dźwiękButton.Enabled = true;
                current.dzwiekTestButton.Enabled = true;
            };

            if (current.InvokeRequired)
            {
                current.Invoke(changeState);
            }
            else
            {
                changeState();
            }
        }
    }

    static class Wielowatkowosc
    {
        public static void NewThread(string początek, string relacja, string torIPeron, string godziny, Generator_komunikatów_dworcowych.komunikaty current, bool ifLate, string NazwaGongu, string rezerwacja, bool isGongOn, int glosnosc)
        {
            Thread watekZapowiedziGlownej = new Thread(() => Gadanie.Syntezator(początek, relacja, torIPeron, godziny, current, ifLate, NazwaGongu, rezerwacja, isGongOn, glosnosc));
            watekZapowiedziGlownej.Start();
        }

        public static void NewThread1(Generator_komunikatów_dworcowych.komunikaty current, string NazwaGongu, bool isGongOn, int glosnosc)
        {
            Thread watekZapowiedziBezPostoju = new Thread(() => Gadanie.SyntezatorBezPostoju(current, NazwaGongu, isGongOn, glosnosc));
            watekZapowiedziBezPostoju.Start();
        }

        public static void NewThread2(Generator_komunikatów_dworcowych.komunikaty current, string NazwaGongu)
        {
            Thread watekSprawdzeniaDzwiekuGongu = new Thread(() => Gadanie.TestowyDzwiekGongu(current, NazwaGongu));
            watekSprawdzeniaDzwiekuGongu.Start();
        }
    }
}
