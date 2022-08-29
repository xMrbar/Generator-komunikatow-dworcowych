using System;
using System.Threading;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Threading;
using System.Windows.Media.Animation;

namespace Generator
{
    static class Late
    {
        public static string Komunikat(string początek, string relacja, string torIPeron, string godziny, string rezerwacja, string PSO, string naszaStacja)
        {
            if (PSO != "Odjedzie" && (naszaStacja != "Końcowa"))
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
        public void Syntezator(string początek, string relacja, string torIPeron, string godziny, Generator_komunikatów_dworcowych.komunikaty current, bool ifLate, string rezerwacja, int glosnosc, string PSO, string naszaStacja, SpeechSynthesizer synth)
        {
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
            catch
            {

            }
            finally
            {
                synth.Dispose();

                current.ButtonDisabled();
                ButtonEnabled(current);
            }
        }

        public void SyntezatorBezPostoju(Generator_komunikatów_dworcowych.komunikaty current, int glosnosc, SpeechSynthesizer synth)
        {
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
            }
        }


        public static void ButtonEnabled(Generator_komunikatów_dworcowych.komunikaty current)
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
        public Thread threadSyntezator;
        public MediaPlayer c;
        public SpeechSynthesizer synth;

        public void NewThread(string początek, string relacja, string torIPeron, string godziny, Generator_komunikatów_dworcowych.komunikaty current, bool ifLate, string NazwaGongu, string rezerwacja, bool isGongOn, int glosnosc, string PSO, string naszaStacja, int glosnoscGongu)
        {
            synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = glosnosc;

            threadSyntezator = new Thread(() => gadanie.Syntezator(początek, relacja, torIPeron, godziny, current, ifLate, rezerwacja, glosnosc, PSO, naszaStacja, synth));

            if (isGongOn)
            {
                OdtworzGong(NazwaGongu, glosnoscGongu, current);
            }

            threadSyntezator.Start();
            //gadanie.Syntezator(początek, relacja, torIPeron, godziny, current, ifLate, rezerwacja, glosnosc, PSO, naszaStacja, synth);
        }

        public void NewThread1(Generator_komunikatów_dworcowych.komunikaty current, string NazwaGongu, bool isGongOn, int glosnosc, int glosnoscGongu)
        {
            synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = glosnosc;

            threadSyntezator = new Thread(() => gadanie.SyntezatorBezPostoju(current, glosnosc, synth));

            if (isGongOn)
            {
                OdtworzGong(NazwaGongu, glosnoscGongu, current);
            }

            threadSyntezator.Start();
            //gadanie.SyntezatorBezPostoju(current, glosnosc, synth);
        }

        public void NewThread2(Generator_komunikatów_dworcowych.komunikaty current, string NazwaGongu, int glosnoscGongu)
        {
            OdtworzGong(NazwaGongu, glosnoscGongu, current);

            ButtonEnabled(current);
        }

        private Uri GongSet(string NazwaGongu)
        {
            if (NazwaGongu == "GONG 1")
            {
                Uri uri = new Uri($"{System.Windows.Forms.Application.StartupPath}/voice/gong-wroclaw.wav");
                return uri;
            }
            else if (NazwaGongu == "GONG 2")
            {
                Uri uri = new Uri($"{System.Windows.Forms.Application.StartupPath}/voice/gong1.wav");
                return uri;
            }
            else if (NazwaGongu == "GONG 3")
            {
                Uri uri = new Uri($"{System.Windows.Forms.Application.StartupPath}/voice/gong2.wav");
                return uri;
            }
            else
            {
                Uri uri = new Uri($"{System.Windows.Forms.Application.StartupPath}/voice/gong-torun.wav");
                return uri;
            }
        }

        private void OdtworzGong(string NazwaGongu, int glosnoscGongu, Generator_komunikatów_dworcowych.komunikaty current)
        {
            Uri uri = GongSet(NazwaGongu);

            c = new MediaPlayer();

            c.MediaEnded += Zamknij;

            double volume = glosnoscGongu / 100.0;
            c.Volume = volume;

            c.Open(uri);
            c.Play();

            Dispatcher.Run();
        }

        private void Zamknij(object sender, EventArgs e)
        {
            c.Close();

            GC.Collect();

            //System.Windows.Forms.MessageBox.Show("Wiadomosc testowa!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Dispatcher.ExitAllFrames();
        }

        public static void ButtonEnabled(Generator_komunikatów_dworcowych.komunikaty current)
        {
            current.dźwiękButton.Enabled = true;
            current.dzwiekTestButton.Enabled = true;
        }
    }

/*    public static void ButtonEnabled(Generator_komunikatów_dworcowych.komunikaty current)
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
    }*/
}
