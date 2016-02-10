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
    public partial class MainForm : Form
    {
        public Dota2Chroma _d2Chroma { get; set; }
    

        public MainForm()
        {
            _d2Chroma = new Dota2Chroma();
            _d2Chroma.Start();
            InitializeComponent();

        }

        private void hpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _d2Chroma.HpBars = hpCheckBox.Checked;
            Console.WriteLine("setting hpbars to " + _d2Chroma.HpBars);
        }

        private void manaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _d2Chroma.ManaBars = manaCheckBox.Checked;
            Console.WriteLine("setting manabars to " + _d2Chroma.ManaBars);
        }

        private void abilityKeysButton_Click(object sender, EventArgs e)
        {
            AbilityKeysForm keysForm = new AbilityKeysForm();
            keysForm._d2 = _d2Chroma;
            keysForm.ShowDialog();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

  
    }
}
