using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dota_2_Razer
{
    public partial class AbilityKeysForm : Form
    {
        public Dota2Chroma _d2 { get; set; }

        public AbilityKeysForm()
        {
            InitializeComponent();
        }


        private void skill1Button_Click(object sender, EventArgs e)
        {
            skill1Button.Text = "Press Key";
        }

        private void skill2Button_Click(object sender, EventArgs e)
        {
            skill2Button.Text = "Press Key";
        }

        private void skill3Button_Click(object sender, EventArgs e)
        {
            skill3Button.Text = "Press Key";
        }

        private void skill4Button_Click(object sender, EventArgs e)
        {
            skill4Button.Text = "Press Key";
        }

        private void skill5Button_Click(object sender, EventArgs e)
        {
            skill5Button.Text = "Press Key";
        }

        private void skill6Button_Click(object sender, EventArgs e)
        {
            skill6Button.Text = "Press Key";
        }

        private void skill1Button_KeyPress(object sender, KeyPressEventArgs e)
        {
            _d2.SetAbilityKey(e, 0);
            skill1Button.Text = e.KeyChar.ToString().ToUpper();
            ActiveControl = null;
        }

        private void skill2Button_KeyPress(object sender, KeyPressEventArgs e)
        {
            _d2.SetAbilityKey(e, 1);
            skill2Button.Text = e.KeyChar.ToString().ToUpper();
            ActiveControl = null;
        }

        private void skill3Button_KeyPress(object sender, KeyPressEventArgs e)
        {
            _d2.SetAbilityKey(e, 2);
            skill3Button.Text = e.KeyChar.ToString().ToUpper();
            ActiveControl = null;
        }

        private void skill4Button_KeyPress(object sender, KeyPressEventArgs e)
        {
            _d2.SetAbilityKey(e, 4);
            skill4Button.Text = e.KeyChar.ToString().ToUpper();
            ActiveControl = null;
        }

        private void skill5Button_KeyPress(object sender, KeyPressEventArgs e)
        {
            _d2.SetAbilityKey(e, 5);
            skill5Button.Text = e.KeyChar.ToString().ToUpper();
            ActiveControl = null;
        }

        private void skill6Button_KeyPress(object sender, KeyPressEventArgs e)
        {
            _d2.SetAbilityKey(e, 3);
            skill6Button.Text = e.KeyChar.ToString().ToUpper();
            ActiveControl = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (OnlyHexInString(textBox1.Text))
            {
                if (textBox1.Text.Length == 6)
                {
                    _d2.SetAbilityColor("0xFF" + textBox1.Text);

                    textBox1.Text = textBox1.Text.ToUpper();
                }
            }
            else
            {
                MessageBox.Show("Please use a valid hex code, no # at beginning");
            }
        }


        public bool OnlyHexInString(string test)
        {
            // For C-style hex notation (0xFF) you can use @"\A\b(0[xX])?[0-9a-fA-F]+\b\Z"
            return System.Text.RegularExpressions.Regex.IsMatch(test, @"\A\b[0-9a-fA-F]+\b\Z");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (OnlyHexInString(textBox2.Text))
            {
                if (textBox1.Text.Length == 6)
                {
                    _d2.SetAbilityCooldownColor("0xFF" + textBox2.Text);

                    textBox2.Text = textBox2.Text.ToUpper();
                }
            }
            else
            {
                MessageBox.Show("Please use a valid hex code, no # at beginning");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (OnlyHexInString(textBox3.Text))
            {
                if (textBox1.Text.Length == 6)
                {
                    _d2.SetAbilitySilencedColor("0xFF" + textBox3.Text);
                    textBox3.Text = textBox3.Text.ToUpper();
                }
            }
            else
            {
                MessageBox.Show("Please use a valid hex code, no # at beginning");
            }
        }


    }
}
