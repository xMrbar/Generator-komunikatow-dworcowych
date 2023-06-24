using System;
using System.Threading;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Threading;
using System.Runtime.Versioning;
using System.IO;
using NAudio.Wave;
//using Windows.Media.SpeechSynthesis;

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

        public static string KomunikatLate(string początek, string relacja, string torIPeron, string godziny, string rezerwacja, string PSO, string naszaStacja, bool czyCzas)
        {
            if(PSO.Equals("Przyjedzie") && !naszaStacja.Equals("Początkowa") && !czyCzas)
            {
                return początek + relacja + godziny + torIPeron + ".";
            }
            else if (!PSO.Equals("Odjedzie"))
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
        public void Syntezator(string początek, string relacja, string torIPeron, string godziny, Generator_komunikatów_dworcowych.komunikaty current, bool ifLate, string rezerwacja, int glosnosc, string PSO, string naszaStacja, SpeechSynthesizer synth, string naszaStacjaWRJ, bool czyCzas)
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
                    synth.Speak(Late.KomunikatLate(początek, relacja, torIPeron, godziny, rezerwacja, PSO, naszaStacjaWRJ, czyCzas));
                }
            }
            catch (System.OperationCanceledException)
            {

            }
            finally
            {
                try
                {
                    synth.Dispose();
                }
                catch (Exception)
                {

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

        public void SyntezatorZapisz(string początek, string relacja, string torIPeron, string godziny, Generator_komunikatów_dworcowych.komunikaty current, bool ifLate, string rezerwacja, string PSO, string naszaStacja, SpeechSynthesizer synth, string path, string path1, bool isGongOn, bool czyCzas, string path2)
        {
            try
            {
                if (!ifLate)
                {
                    synth.Speak(Late.Komunikat(początek, relacja, torIPeron, godziny, rezerwacja, PSO, naszaStacja));
                }
                else
                {
                    synth.Speak(Late.KomunikatLate(początek, relacja, torIPeron, godziny, rezerwacja, PSO, naszaStacja, czyCzas));
                }
            }
            catch (System.OperationCanceledException)
            {

            }
            finally
            {
                try
                {
                    synth.Dispose();
                }
                catch (Exception)
                {

                }
                finally
                {
                    current.ButtonDisabled();
                    ButtonEnabled(current);

                    if (isGongOn)
                    {
                        Zapisz(path, path1, path2, current);
                    }
                }
            }
        }

        public void SyntezatorBezPostojuZapisz(Generator_komunikatów_dworcowych.komunikaty current, SpeechSynthesizer synth, string path, string path1, bool isGongOn, string path2)
        {
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

                if (isGongOn)
                {
                    Zapisz(path, path1, path2, current);
                }
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

        private void Zapisz(string path, string path1, string path2, Generator_komunikatów_dworcowych.komunikaty current)
        {
            MethodInvoker changeState = delegate ()
            {
                WaveFormat target = new WaveFormat(22050, 8, 1);
                WaveStream stream = new WaveFileReader(path1);
                WaveFormatConversionStream str = new WaveFormatConversionStream(target, stream);
                WaveFileWriter.CreateWaveFile("temp.wav", str);

                using (var first = new AudioFileReader(path))
                using (var secound = new AudioFileReader("temp.wav"))
                {
                    //var playList = new ConcatenatingSampleProvider(new[] { secound, first });
                    var playList = secound.FollowedBy(TimeSpan.FromMilliseconds(1000), first);
                    WaveFileWriter.CreateWaveFile16(path2, playList);
                }
                stream.Close();
                str.Close();

                File.Delete(path);
                File.Delete(path1);
                File.Delete("temp.wav");
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

        public void NewThread(string początek, string relacja, string torIPeron, string godziny, Generator_komunikatów_dworcowych.komunikaty current, bool ifLate, string NazwaGongu, string rezerwacja, bool isGongOn, int glosnosc, string PSO, string naszaStacja, int glosnoscGongu, bool czyCzas)
        {
            synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = glosnosc;

            threadSyntezator = new Thread(() => gadanie.Syntezator(początek, relacja, torIPeron, godziny, current, ifLate, rezerwacja, glosnosc, PSO, naszaStacja, synth, naszaStacja, czyCzas));

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

        public void ThreadSaveSpeech(string początek, string relacja, string torIPeron, string godziny, Generator_komunikatów_dworcowych.komunikaty current, bool ifLate, string NazwaGongu, string rezerwacja, bool isGongOn, string PSO, string naszaStacja, bool czyCzas)
        {
            synth = new SpeechSynthesizer();

            string path = @".\Speech-" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_"
                + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + DateTime.Now.Millisecond + ".wav";

            string path1 = @".\Speech-" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_"
                + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + (DateTime.Now.Millisecond + 1) + ".wav";

            string path2 = @".\Speech-" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_"
                            + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + (DateTime.Now.Millisecond + 2) + ".wav";

            if (isGongOn)
            {
                Uri uri = GongSet(NazwaGongu);
                string tmpPath = uri.LocalPath;
                File.Copy(tmpPath, path1);
            }

            synth.SetOutputToWaveFile(path);
            synth.Volume = 100;

            threadSyntezator = new Thread(() => gadanie.SyntezatorZapisz(początek, relacja, torIPeron, godziny, current, ifLate, rezerwacja, PSO, naszaStacja, synth, path, path1, isGongOn, czyCzas, path2));
            threadSyntezator.Start();

            string path3 = path2.Remove(0, 2);
            string filePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directoryPath = System.IO.Path.GetDirectoryName(filePath);
            string fullPath = Path.Combine(directoryPath, path3);
            MessageBox.Show("Komunikat głosowy został zapisany do pliku " + fullPath, "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ThreadSaveSpeechBezZatrzymania(Generator_komunikatów_dworcowych.komunikaty current, string NazwaGongu, bool isGongOn)
        {
            synth = new SpeechSynthesizer();
            //@".\Speech-"
            string path = @".\Speech-" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_"
                + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + DateTime.Now.Millisecond + ".wav";

            string path1 = @".\Speech-" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_"
                + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + (DateTime.Now.Millisecond + 1) + ".wav";

            string path2 = @".\Speech-" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_"
                + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + (DateTime.Now.Millisecond + 2) + ".wav";

            if (isGongOn)
            {
                Uri uri = GongSet(NazwaGongu);
                string tmpPath = uri.LocalPath;
                File.Copy(tmpPath, path1);
            }

            synth.SetOutputToWaveFile(path);
            synth.Volume = 100;

            threadSyntezator = new Thread(() => gadanie.SyntezatorBezPostojuZapisz(current, synth, path, path1, isGongOn, path2));
            threadSyntezator.Start();

            string path3 = path2.Remove(0, 2);
            string filePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directoryPath = System.IO.Path.GetDirectoryName(filePath);
            string fullPath = Path.Combine(directoryPath, path3);
            MessageBox.Show("Komunikat głosowy został zapisany do pliku " + fullPath, "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            c.Close();
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
