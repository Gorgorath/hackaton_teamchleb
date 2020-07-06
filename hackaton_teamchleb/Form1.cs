using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void code_button_Click(object sender, EventArgs e)
        {
            input = input_textbox.Text.ToUpper();
            inputChars = input.ToList();
            //Rotor rotorL = new Rotor("I", (int)rotor1_position.Value, (int)rotor1_ringPosition.Value);
            //Plug tplug = new Plug('A', 'P');
            //Plugboard pboard = new Plugboard(new List<Plug> { tplug });
            //EntryWheel ew = new EntryWheel();
            //Reflector reflector = new Reflector("B");
            //output_textbox.Text = reflector.ZamienZnak(inputChars[0]).ToString();
        }
    }

    class Plug
    {
        public char litera1, litera2;

        public Plug(char ch1, char ch2)
        {
            litera1 = ch1;
            litera2 = ch2;
        }
    }

    class Plugboard
    {
        List<Plug> plugi = new List<Plug>();

        public Plugboard(List<Plug> pl)
        {
            plugi = pl;
        }

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
        int rotorPos, ringPos;
        int offset;
        string rotorType;
        string rotorKey;
        string znaki = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public bool czyPoReflektorze = false;

        public Rotor(string rType, int roPos, int riPos)
        {
            rotorType = rType;
            rotorPos = roPos;
            ringPos = riPos;
            offset = rotorPos - 1 + ringPos - 1;

            if (rotorType == "I")
            {
                rotorKey = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
            } 
            else if (rotorType == "II")
            {
                rotorKey = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
            }
            else if (rotorType == "III")
            {
                rotorKey = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
            }
        }

        public char ZamienZnak(char ch)
        {
            if (znaki.IndexOf(ch) + offset < 26)
            {
                ch = rotorKey[znaki.IndexOf(ch) + offset];
            } else if (znaki.IndexOf(ch) + offset >= 26)
            {
                ch = rotorKey[znaki.IndexOf(ch) + offset - 26];
            }
                
            return ch;
        }
    }

    class EntryWheel
    {
        string znaki = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string klucz = "QWERTZUIOPASDFGHJKLYXCVBNM";

        public char ZamienZnak(char ch)
        {
            ch = klucz[znaki.IndexOf(ch)];
            return ch;
        }
    }

    class Reflector
    {
        string reflectorType;
        string reflectorKey;
        string znaki = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public Reflector(string rType)
        {
            reflectorType = rType;

            if (reflectorType == "B")
            {
                reflectorKey = "YRUHQSLDPXNGOKMIEBFZCWVJAT";
            } else if (reflectorType == "C")
            {
                reflectorKey = "FVPJIAOYEDRZXWGCTKUQSBNMHL";
            }
        }

        public char ZamienZnak(char ch)
        {
            ch = reflectorKey[znaki.IndexOf(ch)];
            return ch;
        }
    }
}
