using System.IO;
using System.Threading;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Media;
using Windows.ApplicationModel.VoiceCommands;
using System.Windows;
using System;

namespace Generator
{
    static class Late
    {
        public static string Komunikat(string początek, string relacja, string torIPeron, string godziny, string rezerwacja, string PSO, string naszaStacja)
        {
            if(PSO != "Odjedzie" && (naszaStacja != "Końcowa"))
            {
                return początek + relacja + torIPeron + rezerwacja + godziny + ".";
            }
            else
            {
                return początek + relacja + torIPeron + rezerwacja + godziny;
            }
            
        }

        public static string KomunikatLate(string początek, string relacja, string torIPeron, string godziny, string rezerwacja)
        {
            return początek + relacja + godziny + torIPeron + rezerwacja + ". Za opóźnienie pociągu przepraszamy.";
        }
    }

    class Gadanie
    {
        public SpeechSynthesizer synth;
        public Stream s;
        public SoundPlayer player;

        public void Syntezator(string początek, string relacja, string torIPeron, string godziny, Generator_komunikatów_dworcowych.komunikaty current, bool ifLate, string NazwaGongu, string rezerwacja, bool isGongOn, int glosnosc, string PSO, string naszaStacja)
        {
            synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = glosnosc;

            if (isGongOn)
            {
                OdtworzGong(NazwaGongu);
            }

            ButtonEnabled1(current);

            try
            {
                if (!ifLate)
                {
                    synth.Speak(Late.Komunikat(początek, relacja, torIPeron, godziny, rezerwacja, PSO, naszaStacja));
                }
                else
                {
                    synth.Speak(Late.KomunikatLate(początek, relacja, torIPeron, godziny, rezerwacja));
                }
            }
            catch (System.OperationCanceledException)
            {

            }
            catch (System.ObjectDisposedException)
            {

            }
            finally
            {
                synth.Dispose();

                current.ButtonDisabled();
                ButtonEnabled(current);
            }
        }
        
        public void SyntezatorBezPostoju(Generator_komunikatów_dworcowych.komunikaty current, string NazwaGongu, bool isGongOn, int glosnosc)
        {
            synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = glosnosc;

            if (isGongOn)
            {
                OdtworzGong(NazwaGongu);
            }

            ButtonEnabled1(current);

            try
            {
                synth.Speak("Uwaga! Przez stację przejedzie pociąg, bez zatrzymania! Prosimy zachować ostrożność i odsunąć się od krawędzi peronu!");
            }
            catch (System.OperationCanceledException)
            {

            }
            finally
            {
                synth.Dispose();

                current.ButtonDisabled();
                ButtonEnabled(current);
                current.ButtonDisabled();
            }
        }
       
        public void TestowyDzwiekGongu(Generator_komunikatów_dworcowych.komunikaty current, string NazwaGongu)
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

        private void OdtworzGong(string NazwaGongu)
        {
            s = GongSet(NazwaGongu);

            player = new SoundPlayer(s);

            player.PlaySync();

            player.Dispose();
        }

        public void ZatrzymajGong()
        {
            player.Stop();
        }

        public static void ButtonEnabled (Generator_komunikatów_dworcowych.komunikaty current)
        {
            MethodInvoker changeState = delegate ()
            {
                current.dźwiękButton.Enabled = true;
                current.dzwiekTestButton.Enabled = true;
            };

            if (current.InvokeRequired)
            {
                try
                {
                    current.Invoke(changeState);
                }
                catch (ObjectDisposedException)
                {

                }
            }
            else
            {
                changeState();
            }
        }

        public static void ButtonEnabled1(Generator_komunikatów_dworcowych.komunikaty current)
        {
            MethodInvoker changeState = delegate ()
            {
                current.zatrzymajModulator.Enabled = true;
                current.anulujSyntezator.Enabled = true;
            };

            if (current.InvokeRequired)
            {
                try
                {
                    current.Invoke(changeState);
                }
                catch (ObjectDisposedException)
                {

                }
            }
            else
            {
                changeState();
            }
        }

        public static void ButtonEnabled2(Generator_komunikatów_dworcowych.komunikaty current)
        {
            MethodInvoker changeState = delegate ()
            {
                current.wznowSyntezator.Enabled = true;
            };

            if (current.InvokeRequired)
            {
                try
                {
                    current.Invoke(changeState);
                }
                catch (ObjectDisposedException)
                {

                }
            }
            else
            {
                changeState();
            }
        }
    }

    class Wielowatkowosc
    {
        public Gadanie gadanie = new Gadanie();

        public void NewThread(string początek, string relacja, string torIPeron, string godziny, Generator_komunikatów_dworcowych.komunikaty current, bool ifLate, string NazwaGongu, string rezerwacja, bool isGongOn, int glosnosc, string PSO, string naszaStacja)
        {
            Thread watekZapowiedziGlownej = new Thread(() => gadanie.Syntezator(początek, relacja, torIPeron, godziny, current, ifLate, NazwaGongu, rezerwacja, isGongOn, glosnosc, PSO, naszaStacja));
            watekZapowiedziGlownej.Start();
        }

        public void NewThread1(Generator_komunikatów_dworcowych.komunikaty current, string NazwaGongu, bool isGongOn, int glosnosc)
        {
            Thread watekZapowiedziBezPostoju = new Thread(() => gadanie.SyntezatorBezPostoju(current, NazwaGongu, isGongOn, glosnosc));
            watekZapowiedziBezPostoju.Start();
        }

        public void NewThread2(Generator_komunikatów_dworcowych.komunikaty current, string NazwaGongu)
        {
            Thread watekSprawdzeniaDzwiekuGongu = new Thread(() => gadanie.TestowyDzwiekGongu(current, NazwaGongu));
            watekSprawdzeniaDzwiekuGongu.Start();
        }
    }
}
