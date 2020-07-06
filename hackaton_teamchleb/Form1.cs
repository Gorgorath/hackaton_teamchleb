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
            input = input_textbox.Text;
            inputChars = input.ToList();
        }
    }

    class Plug
    {
        public char litera1, litera2;

        Plug(char ch1, char ch2)
        {
            litera1 = ch1;
            litera2 = ch2;
        }
    }

    class Plugboard
    {
        List<Plug> plugi = new List<Plug>();

        Plugboard(List<Plug> pl)
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

        Rotor(string rType, int roPos, int riPos)
        {
            rotorType = rType;
            rotorPos = roPos;
            ringPos = riPos;
            offset = rotorPos + ringPos;

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


            return ch;
        }
    }
}
