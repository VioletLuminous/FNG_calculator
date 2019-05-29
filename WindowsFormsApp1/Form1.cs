using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{

    public partial class FNG_calc : Form
    {
        public static float stoPercent(string s1)
        {
            //如果沒有輸入的狀況
            if (s1 == "") { s1 = "0"; }
            float s1_to_i = Int32.Parse(s1);

            float f = ((100 + s1_to_i) / 100);
            return f;
        }

        public static string happenRate(string s1, string s2, string s3)
        {
            int baseDEF = Int32.Parse(s1);
            int itemDEF = Int32.Parse(s2);
            float buffDEF = stoPercent(s3);

            double A, happenRate;

            A = (baseDEF * buffDEF) + (0.6 * itemDEF);
            happenRate = 0.000000169 * A * A + 0.0034 * A + 6.36;

            if(happenRate>45){
                happenRate = 45;
            }
            return happenRate.ToString("N") + " %";
        }
        public FNG_calc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //如果沒有輸入的狀況
            if (textBoxBaseDEF.Text == "") textBoxBaseDEF.Text = "0";
            if (textBoxItemDEF.Text == "") textBoxItemDEF.Text = "0";
            if (textBoxbuffDef.Text == "") textBoxbuffDef.Text = "0";


            if (numericUpDownCharacterDEF.Text == "") numericUpDownCharacterDEF.Text = "0";
            char chara = (numericUpDownCharacterDEF.Text)[0];

            string couttextDEF = happenRate(textBoxBaseDEF.Text, textBoxItemDEF.Text, textBoxbuffDef.Text);
            switch (chara)
            {
                case '1':
                    labelH1_1.Text = couttextDEF;
                    break;
                case '2':
                    labelH2_2.Text = couttextDEF;
                    break;
                case '3':
                    labelH3_3.Text = couttextDEF;
                    break;
                case '4':
                    labelH4_4.Text = couttextDEF;
                    break;
                case '5':
                    labelH5_5.Text = couttextDEF;
                    break;
                default:
                    MessageBox.Show("Character must be 1~5\n");
                    break;
            }
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void textBoxBaseDEF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            };
        }

        private void textBoxItemDEF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            };
        }

        private void textBoxbuffDef_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            };
        }

        private void numericUpDownCharacter_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            };
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            };
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            };
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            };
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            };
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            };
        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            };
        }
        private void buttonDMGcalc_Click(object sender, EventArgs e)
        {
            //如果沒有輸入的狀況
            if (textBoxBaseATK.Text == "") textBoxBaseATK.Text = "0";
            if (textBoxItemATK.Text == "") textBoxItemATK.Text = "0";
            if (textBoxSkillMut.Text == "") textBoxSkillMut.Text = "1";

            int BaseATK = Int32.Parse(textBoxBaseATK.Text);
            int ItemATK = Int32.Parse(textBoxItemATK.Text);

            float BuffATK = stoPercent(textBoxBuffATK.Text);
            float CritDMG;
            float BuffSkillDMG = stoPercent(textBoxBuffSkillDMG.Text);
            float BuffBossDMG = stoPercent(textBoxBuffBossDMG.Text);

            float SkillMut = float.Parse(textBoxSkillMut.Text);

            float Weak = 1, HP2div1 = 1;
            double DMG;
            if (checkBoxWeak.Checked) Weak = 1.5f;
            if (checkBoxHP2div1.Checked) HP2div1 = 1.5f;
            if (checkBoxCrit.Checked)
            {
                CritDMG = stoPercent(textBoxCritDMG.Text);
            }
            else
            {
                CritDMG = 1;
            }

            DMG = ((BaseATK * BuffATK + ItemATK) / 2 * CritDMG * BuffSkillDMG * BuffBossDMG * Weak * HP2div1 * SkillMut * 1.05f);

            if (numericUpDownCharacterDMG.Text == "") numericUpDownCharacterDMG.Text = "0";
            char chara = (numericUpDownCharacterDMG.Text)[0];

            string couttextDMG = DMG.ToString("N");

            switch (chara)
            {
                case '1':
                    labelS1_1.Text = couttextDMG;
                    break;
                case '2':
                    labelS2_2.Text = couttextDMG;
                    break;
                case '3':
                    labelS3_3.Text = couttextDMG;
                    break;
                case '4':
                    labelS4_4.Text = couttextDMG;
                    break;
                case '5':
                    labelS5_5.Text = couttextDMG;
                    break;
                default:
                    MessageBox.Show("Character must be 1~5\n");
                    break;
            }
        }
    }
}
