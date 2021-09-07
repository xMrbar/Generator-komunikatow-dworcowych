﻿using System.IO;
using System.Threading;
using System.Media;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Generator
{
    static class Late
    {
        public static string Komunikat(string początek, string relacja, string torIPeron, string godziny, string rezerwacja)
        {
            return początek + relacja + torIPeron + rezerwacja + godziny;
        }
        public static string KomunikatLate(string początek, string relacja, string torIPeron, string godziny, string rezerwacja)
        {
            return początek + relacja + godziny + torIPeron + rezerwacja + ". Za opóźnienie pociągu przepraszamy.";
        }
    }

    static class Gadanie
    {
        public static void Syntezator(string początek, string relacja, string torIPeron, string godziny, Generator_komunikatów_dworcowych.komunikaty current, bool ifLate, string NazwaGongu, string rezerwacja, bool isGongOn)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();

            if (isGongOn)
            {
                Stream s = GongSet(NazwaGongu);

                SoundPlayer player = new SoundPlayer(s);

                player.PlaySync();
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
        
        public static void SyntezatorBezPostoju(Generator_komunikatów_dworcowych.komunikaty current, string NazwaGongu, bool isGongOn)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();

            if (isGongOn)
            {
                Stream s = GongSet(NazwaGongu);

                SoundPlayer player = new SoundPlayer(s);

                player.PlaySync();
            }

            synth.Speak("Uwaga! Przez stację przejedzie pociąg, bez zatrzymania! Prosimy zachować ostrożność i odsunąć się od krawędzi peronu!");

            synth.Dispose();

            ButtonEnabled(current);
        }
       
        public static void TestowyDzwiekGongu(Generator_komunikatów_dworcowych.komunikaty current, string NazwaGongu)
        {
            Stream s = GongSet(NazwaGongu);

            SoundPlayer player = new SoundPlayer(s);

            player.PlaySync();

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

    static class Wielowątkowość
    {
        public static void NewThread(string początek, string relacja, string torIPeron, string godziny, Generator_komunikatów_dworcowych.komunikaty current, bool ifLate, string NazwaGongu, string rezerwacja, bool isGongOn)
        {
            Thread test = new Thread(() => Gadanie.Syntezator(początek, relacja, torIPeron, godziny, current, ifLate, NazwaGongu, rezerwacja, isGongOn));
            test.Start();
        }

        public static void NewThread1(Generator_komunikatów_dworcowych.komunikaty current, string NazwaGongu, bool isGongOn)
        {
            Thread test1 = new Thread(() => Gadanie.SyntezatorBezPostoju(current, NazwaGongu, isGongOn));
            test1.Start();
        }

        public static void NewThread2(Generator_komunikatów_dworcowych.komunikaty current, string NazwaGongu)
        {
            Thread test2 = new Thread(() => Gadanie.TestowyDzwiekGongu(current, NazwaGongu));
            test2.Start();
        }
    }
}
