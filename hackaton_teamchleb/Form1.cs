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
        string str = "";
        List<char> strChars = new List<char>();
        string output = "";

        Plugboard plugboard;
        Rotor rotorL;
        Rotor rotorS;
        Rotor rotorP;
        Rotors rotory;
        EntryWheel entryWheel = new EntryWheel();
        Reflector reflector;

        public Form1()
        {
            InitializeComponent();
        }

        //Przy kliknięciu guzika
        private void code_button_Click(object sender, EventArgs e)
        {
            getPlugs();
            getRotors();
            getReflector();

            str = input_textbox.Text;
            clearString();

            output = enigmaCipher(strChars);

            output_textbox.Text = output;
        }

        //Szyfrowanie :D
        private string enigmaCipher(List<char> chars)
        {
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
                //znak = entryWheel.ZamienZnak(znak);
                znak = rotorP.ZamienZnak(znak);
                znak = rotorS.ZamienZnak(znak);
                znak = rotorL.ZamienZnak(znak);
                znak = reflector.ZamienZnak(znak);

                rotorL.czyPoReflektorze = true;
                rotorS.czyPoReflektorze = true;
                rotorP.czyPoReflektorze = true;
                //entryWheel.czyPoReflektorze = true;

                znak = rotorL.ZamienZnak(znak);
                znak = rotorS.ZamienZnak(znak);
                znak = rotorP.ZamienZnak(znak);
                //znak = entryWheel.ZamienZnak(znak);*/
                znak = plugboard.ZamienZnak(znak);

                wynik += znak;
            }

            return wynik;
        }

        //Czyści string z niekompatybilnych znaków
        private void clearString()
        {
            str = str.ToUpper();
            strChars = str.ToList();

            List<char> doUsuniecia = new List<char>();

            foreach (char ch in strChars)
            {
                if (!char.IsLetter(ch))
                {
                    doUsuniecia.Add(ch);
                }
            }

            foreach (char doU in doUsuniecia)
            {
                strChars.Remove(doU);
            }
        }

        //Zbiera informację o plugach
        private void getPlugs()
        {
            List<Plug> tempLista = new List<Plug>();

            if (plug1L.Text != "" && plug1P.Text != "" && char.IsLetter(plug1L.Text[0]) && char.IsLetter(plug1P.Text[0]))
            {
                tempLista.Add(new Plug(plug1L.Text.ToUpper()[0], plug1P.Text.ToUpper()[0]));
            }

            if (plug2L.Text != "" && plug2P.Text != "" && char.IsLetter(plug2L.Text[0]) && char.IsLetter(plug2P.Text[0]))
            {
                tempLista.Add(new Plug(plug2L.Text.ToUpper()[0], plug2P.Text.ToUpper()[0]));
            }

            if (plug3L.Text != "" && plug3P.Text != "" && char.IsLetter(plug3L.Text[0]) && char.IsLetter(plug3P.Text[0]))
            {
                tempLista.Add(new Plug(plug3L.Text.ToUpper()[0], plug3P.Text.ToUpper()[0]));
            }

            if (plug4L.Text != "" && plug4P.Text != "" && char.IsLetter(plug4L.Text[0]) && char.IsLetter(plug4P.Text[0]))
            {
                tempLista.Add(new Plug(plug4L.Text.ToUpper()[0], plug4P.Text.ToUpper()[0]));
            }

            if (plug5L.Text != "" && plug5P.Text != "" && char.IsLetter(plug5L.Text[0]) && char.IsLetter(plug5P.Text[0]))
            {
                tempLista.Add(new Plug(plug5L.Text.ToUpper()[0], plug5P.Text.ToUpper()[0]));
            }

            if (plug6L.Text != "" && plug6P.Text != "" && char.IsLetter(plug6L.Text[0]) && char.IsLetter(plug6P.Text[0]))
            {
                tempLista.Add(new Plug(plug6L.Text.ToUpper()[0], plug6P.Text.ToUpper()[0]));
            }

            if (plug7L.Text != "" && plug7P.Text != "" && char.IsLetter(plug7L.Text[0]) && char.IsLetter(plug7P.Text[0]))
            {
                tempLista.Add(new Plug(plug7L.Text.ToUpper()[0], plug7P.Text.ToUpper()[0]));
            }

            if (plug8L.Text != "" && plug8P.Text != "" && char.IsLetter(plug8L.Text[0]) && char.IsLetter(plug8P.Text[0]))
            {
                tempLista.Add(new Plug(plug8L.Text.ToUpper()[0], plug8P.Text.ToUpper()[0]));
            }

            if (plug9L.Text != "" && plug9P.Text != "" && char.IsLetter(plug9L.Text[0]) && char.IsLetter(plug9P.Text[0]))
            {
                tempLista.Add(new Plug(plug9L.Text.ToUpper()[0], plug9P.Text.ToUpper()[0]));
            }

            if (plug10L.Text != "" && plug10P.Text != "" && char.IsLetter(plug10L.Text[0]) && char.IsLetter(plug10P.Text[0]))
            {
                tempLista.Add(new Plug(plug10L.Text.ToUpper()[0], plug10P.Text.ToUpper()[0]));
            }

            if (plug11L.Text != "" && plug11P.Text != "" && char.IsLetter(plug11L.Text[0]) && char.IsLetter(plug11P.Text[0]))
            {
                tempLista.Add(new Plug(plug11L.Text.ToUpper()[0], plug11P.Text.ToUpper()[0]));
            }

            if (plug12L.Text != "" && plug12P.Text != "" && char.IsLetter(plug12L.Text[0]) && char.IsLetter(plug12P.Text[0]))
            {
                tempLista.Add(new Plug(plug12L.Text.ToUpper()[0], plug12P.Text.ToUpper()[0]));
            }

            if (plug13L.Text != "" && plug13P.Text != "" && char.IsLetter(plug13L.Text[0]) && char.IsLetter(plug13P.Text[0]))
            {
                tempLista.Add(new Plug(plug13L.Text.ToUpper()[0], plug13P.Text.ToUpper()[0]));
            }

            plugboard = new Plugboard(tempLista);
        }

        //Zbiera informację o rotorach
        private void getRotors()
        {
            rotorL = new Rotor(rotor1_type.Text, (int)rotor1_position.Value, (int)rotor1_ringPosition.Value);
            rotorS = new Rotor(rotor2_type.Text, (int)rotor2_position.Value, (int)rotor2_ringPosition.Value);
            rotorP = new Rotor(rotor3_type.Text, (int)rotor3_position.Value, (int)rotor3_ringPosition.Value);
            rotory = new Rotors(rotorP, rotorS, rotorL);
        }

        private void getReflector()
        {
            reflector = new Reflector(reflector_type.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            else if (rotorType == "IV")
            {
                rotorKey = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
                rotorRotateChar = 'K';
            }
            else if (rotorType == "V")
            {
                rotorKey = "VZBRGITYUPSDNHLXAWMJQOFECK";
                rotorRotateChar = 'A';
            }
        }

        //Zmienia znak zgodnie z obecnym ustawieniem rotora i jego pierścienia
        public char ZamienZnak(char ch)
        {
            offset = rotorPos - ringPos;
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
        Rotor rotorP, rotorS, rotorL;

        //Konstruktor
        public Rotors(Rotor rP, Rotor rS, Rotor rL)
        {
            rotorP = rP;
            rotorS = rS;
            rotorL = rL;
        }

        //Obraca rotory
        public void ObrocRotory()
        {
            if (rotorP.rotorPos != 26)
            {
                rotorP.rotorPos++;
                if (rotorP.rotorKey[rotorP.rotorPos] == rotorP.rotorRotateChar)
                {
                    if (rotorS.rotorPos != 26)
                    {
                        rotorS.rotorPos++;
                        if (rotorS.rotorKey[rotorS.rotorPos] == rotorS.rotorRotateChar)
                        {
                            if (rotorL.rotorPos != 26)
                            {
                                rotorL.rotorPos++;
                            }
                            else
                            {
                                rotorL.rotorPos = 1;
                            }
                        }
                    }
                    else
                    {
                        rotorS.rotorPos = 1;
                    }
                }
            }
            else
            {
                rotorP.rotorPos = 1;
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
            
            if (reflectorType == "UKW A")
            {
                reflectorKey = "EJMZALYXVBWFCRQUONTSPIKHGD";
            }
            else if (reflectorType == "UKW B")
            {
                reflectorKey = "YRUHQSLDPXNGOKMIEBFZCWVJAT";
            }
            else if (reflectorType == "UKW C")
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
