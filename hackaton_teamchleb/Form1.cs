using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hackaton_teamchleb
{
    public partial class Form1 : Form
    {
        string input = "";
        List<char> inputChars = new List<char>();
        string output = "";

        public Form1()
        {
            InitializeComponent();
        }

        //Przy kliknięciu guzika
        private void code_button_Click(object sender, EventArgs e)
        {
            input = input_textbox.Text.ToUpper();
            inputChars = input.ToList();
            List<char> doUsuniecia = new List<char>();
            foreach (char ch in inputChars)
            {
                if (!char.IsLetter(ch))
                {
                    doUsuniecia.Add(ch);
                }
            }

            foreach (char doU in doUsuniecia)
            {
                inputChars.Remove(doU);
            }

            output = enigmaCipher(inputChars);

            output_textbox.Text = output;

            if (input == "RICKROLL")
            {
                Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ&feature=emb_logo");
            }
        }

        private string enigmaCipher(List<char> chars)
        {
            Plugboard plugboard = new Plugboard(new List<Plug>());
            Rotor rotorL = new Rotor("I", (int)rotor1_position.Value, (int)rotor1_ringPosition.Value);
            Rotor rotorS = new Rotor("II", (int)rotor2_position.Value, (int)rotor2_ringPosition.Value);
            Rotor rotorP = new Rotor("III", (int)rotor3_position.Value, (int)rotor3_ringPosition.Value);
            Rotors rotory = new Rotors(new List<Rotor> { rotorL, rotorS, rotorP });
            EntryWheel entryWheel = new EntryWheel();
            Reflector reflector = new Reflector("B");

            string wynik = "";
            
            foreach (char ch in chars)
            {
                rotory.ObrocRotory();
                rotorL.czyPoReflektorze = false;
                rotorS.czyPoReflektorze = false;
                rotorP.czyPoReflektorze = false;
                entryWheel.czyPoReflektorze = false;

                char znak = ch;
                znak = plugboard.ZamienZnak(znak);
                znak = entryWheel.ZamienZnak(znak);
                znak = rotorP.ZamienZnak(znak);
                znak = rotorS.ZamienZnak(znak);
                znak = rotorL.ZamienZnak(znak);
                znak = reflector.ZamienZnak(znak);

                rotorL.czyPoReflektorze = true;
                rotorS.czyPoReflektorze = true;
                rotorP.czyPoReflektorze = true;
                entryWheel.czyPoReflektorze = true;

                znak = rotorL.ZamienZnak(znak);
                znak = rotorS.ZamienZnak(znak);
                znak = rotorP.ZamienZnak(znak);
                znak = entryWheel.ZamienZnak(znak);
                znak = plugboard.ZamienZnak(znak);

                wynik += znak;
            }

            return wynik;
        }
    }

    class Plug
    {
        //Plugi przechowują informacje na temat jaka litera ma być zastąpiona jaką inną i wice versa
        public char litera1, litera2;

        //Konstruktor
        public Plug(char ch1, char ch2)
        {
            litera1 = ch1;
            litera2 = ch2;
        }
    }

    class Plugboard
    {
        //Przechowuje dane o plugach i zmienia znak zgodnie z nimi
        List<Plug> plugi = new List<Plug>();

        //Konstruktor
        public Plugboard(List<Plug> pl)
        {
            plugi = pl;
        }

        //Zmienia znak zgodnie z plugami
        public char ZamienZnak(char ch)
        {
            foreach (Plug plug in plugi)
            {
                if (plug.litera1 == ch)
                {
                    return plug.litera2;
                }
                else if (plug.litera2 == ch)
                {
                    return plug.litera1;
                }
            }
            return ch;
        }
    }

    class Rotor
    {
        //Serce enigmy. Rotory obracają się zmieniając za każdym razem literę końcową
        public int rotorPos;
        int ringPos;
        int offset;
        string rotorType;
        public string rotorKey;
        public char rotorRotateChar;
        string znaki = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public bool czyPoReflektorze = false;

        //Konstruktor
        public Rotor(string rType, int roPos, int riPos)
        {
            rotorType = rType;
            rotorPos = roPos;
            ringPos = riPos;
            offset = (rotorPos - 1) - (ringPos - 1);

            if (rotorType == "I")
            {
                rotorKey = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
                rotorRotateChar = 'R';
            }
            else if (rotorType == "II")
            {
                rotorKey = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
                rotorRotateChar = 'F';
            }
            else if (rotorType == "III")
            {
                rotorKey = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
                rotorRotateChar = 'W';
            }
        }

        //Zmienia znak zgodnie z obecnym ustawieniem rotora i jego pierścienia
        public char ZamienZnak(char ch)
        {
            if (!this.czyPoReflektorze)
            {
                if (znaki.IndexOf(ch) + offset < 26 && znaki.IndexOf(ch) + offset >= 0)
                {
                    ch = rotorKey[znaki.IndexOf(ch) + offset];
                }
                else if (znaki.IndexOf(ch) + offset >= 26)
                {
                    ch = rotorKey[znaki.IndexOf(ch) + offset - 26];
                }
                else if (znaki.IndexOf(ch) + offset < 0)
                {
                    ch = rotorKey[znaki.IndexOf(ch) + offset + 26];
                }
            } 
            else
            {
                //nie jestem pewien
                if (rotorKey.IndexOf(ch) - offset < 26 && rotorKey.IndexOf(ch) - offset >= 0)
                {
                    ch = znaki[rotorKey.IndexOf(ch) - offset];
                }
                else if (rotorKey.IndexOf(ch) - offset >= 26)
                {
                    ch = znaki[rotorKey.IndexOf(ch) - offset - 26];
                }
                else if (rotorKey.IndexOf(ch) - offset < 0)
                {
                    ch = znaki[rotorKey.IndexOf(ch) - offset + 26];
                }
            }
                

            return ch;
        }
    }

    class Rotors
    {
        //Przechowuje listę z wszystkimi rotorami i odpowiada za ich obrót
        //Pierwszy rotor w liście to ma być rotor prawy, drugi to rotor środkowy, a trzeci to rotor lewy
        List<Rotor> rotory = new List<Rotor>();

        //Konstruktor
        public Rotors(List<Rotor> rs)
        {
            rotory = rs;
        }

        //Obraca rotory
        public void ObrocRotory()
        {
            rotory[0].rotorPos++;
            if (rotory[0].rotorKey[rotory[0].rotorPos] == rotory[0].rotorRotateChar)
            {
                rotory[1].rotorPos++;
                if (rotory[1].rotorKey[rotory[1].rotorPos] == rotory[1].rotorRotateChar)
                {
                    rotory[2].rotorPos++;
                }
            }
        }
    }

    class EntryWheel
    {
        //Zamienia znaki zgodnie z alfabetem na znaki zgodnie z klawiaturą QWERTZ
        string znaki = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string klucz = "QWERTZUIOPASDFGHJKLYXCVBNM";
        public bool czyPoReflektorze = false;

        //Robi dokładnie co w komentarzu powyżej
        public char ZamienZnak(char ch)
        {
            if (!czyPoReflektorze)
            {
                ch = znaki[klucz.IndexOf(ch)];
            } 
            else
            {
                ch = klucz[znaki.IndexOf(ch)];
            }
            
            return ch;
        }
    }

    class Reflector
    {
        //Zamienia znaki na inne zgodnie z kluczem, które są później przekazane z powrotem do rotorów
        string reflectorType;
        string reflectorKey;
        string znaki = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        //Konstruktor
        public Reflector(string rType)
        {
            reflectorType = rType;

            if (reflectorType == "B")
            {
                reflectorKey = "YRUHQSLDPXNGOKMIEBFZCWVJAT";
            }
            else if (reflectorType == "C")
            {
                reflectorKey = "FVPJIAOYEDRZXWGCTKUQSBNMHL";
            }
        }

        //Zmienia znak jak napisano powyżej
        public char ZamienZnak(char ch)
        {
            ch = reflectorKey[znaki.IndexOf(ch)];
            return ch;
        }
    }
}
