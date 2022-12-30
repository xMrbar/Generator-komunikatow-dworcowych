using System;
using System.Threading;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Threading;
using System.Runtime.Versioning;

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

        public static string KomunikatLate(string początek, string relacja, string torIPeron, string godziny, string rezerwacja, string PSO)
        {
            if (!PSO.Equals("Odjedzie"))
            {
                return początek + relacja + godziny + torIPeron + rezerwacja + ". Za opóźnienie pociągu przepraszamy.";
            }
            else
            {
                return początek + relacja + godziny + torIPeron + rezerwacja + ". Prosimy zachować ostrożność i nie zbliżać się do krawędzi peronu.";
            }
        }
    }

    [SupportedOSPlatform("windows")]
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
                    synth.Speak(Late.KomunikatLate(początek, relacja, torIPeron, godziny, rezerwacja, PSO));
                }
            }
            catch
            {

            }
            finally
            {
                try
                {
                    synth.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Błąd 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    current.ButtonDisabled();
                    ButtonEnabled(current);
                }
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

    [SupportedOSPlatform("windows")]
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
                #region testy
                //"C:/Users/Bar/source/repos/Generator/Generator_komunikatow_dworcowych/Resources/gong-wroclaw.wav"

                //Uri uri = new Uri("../Resources/gong-wroclaw.wav", UriKind.Relative);

                /*                var file = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "gong-wroclaw.wav");
                                Uri uri = new Uri(file);*/
                /*                StreamResourceInfo ri = System.Windows.Application.GetResourceStream(uri);
                                Stream data = ri.Stream;*/
                /*Uri uri = new Uri($"{System.Windows.Forms.Application.StartupPath}/voice/gong-wroclaw.wav");*/

                //GeneratorKomunikatów.Properties.Resources.gong_wroclaw
                /*                String fileName1 = Path.Combine(fileName, "gong-wroclaw.wav");

                                if (tablicaZapisu[0] == 0)
                                {
                                    tablicaZapisu[0] = 1;

                                    Stream s = GeneratorKomunikatów.Properties.Resources.gong_wroclaw;

                                    Directory.CreateDirectory(fileName1);
                                    var fileStream = File.Create(fileName1);

                                    s.Seek(0, SeekOrigin.Begin);
                                    s.CopyTo(fileStream);

                                    s.Close();
                                    fileStream.Close();
                                }*/

                //Uri uri = new Uri(fileName1);

                //Uri uri = new Uri("pack://application:,,,/voice/gong-wroclaw.wav");

                //string file = "gong-wroclaw.wav";
                // var assembly = System.Reflection.Assembly.GetExecutingAssembly().ToString();
                //String fileName = Path.Combine(assembly, "gong-wroclaw.wav");

                //Uri uri = new Uri("ms-appx:///voice/gong-torun.wav");

                //var a = new Assembly.GetManifestResourceStream("gong-wroclaw.wav");
                #endregion

                var file = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Voice", "gong-wroclaw.wav");
                Uri uri = new Uri(file);

                return uri;
            }
            else if (NazwaGongu == "GONG 2")
            {
                var file = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Voice", "gong1.wav");
                Uri uri = new Uri(file);

                return uri;
            }
            else if (NazwaGongu == "GONG 3")
            {
                var file = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Voice", "gong2.wav");
                Uri uri = new Uri(file);

                return uri;
            }
            else
            {
                var file = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Voice", "gong-torun.wav");
                Uri uri = new Uri(file);

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

            Dispatcher.ExitAllFrames();
        }

        public static void ButtonEnabled(Generator_komunikatów_dworcowych.komunikaty current)
        {
            current.dźwiękButton.Enabled = true;
            current.dzwiekTestButton.Enabled = true;
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
}
