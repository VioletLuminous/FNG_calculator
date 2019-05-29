namespace WindowsFormsApp1
{
    partial class FNG_calc
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDEFcalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBaseDEF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxItemDEF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelH5 = new System.Windows.Forms.Label();
            this.numericUpDownCharacterDEF = new System.Windows.Forms.NumericUpDown();
            this.labelH5_5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelH1 = new System.Windows.Forms.Label();
            this.labelH2 = new System.Windows.Forms.Label();
            this.labelH3 = new System.Windows.Forms.Label();
            this.labelH4 = new System.Windows.Forms.Label();
            this.labelH1_1 = new System.Windows.Forms.Label();
            this.labelH2_2 = new System.Windows.Forms.Label();
            this.labelH3_3 = new System.Windows.Forms.Label();
            this.labelH4_4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxbuffDef = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxCrit = new System.Windows.Forms.CheckBox();
            this.checkBoxHP2div1 = new System.Windows.Forms.CheckBox();
            this.checkBoxWeak = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxBuffBossDMG = new System.Windows.Forms.TextBox();
            this.textBoxBuffSkillDMG = new System.Windows.Forms.TextBox();
            this.textBoxCritDMG = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxBuffATK = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxItemATK = new System.Windows.Forms.TextBox();
            this.textBoxBaseATK = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonDMGcalc = new System.Windows.Forms.Button();
            this.numericUpDownCharacterDMG = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.labelS4_4 = new System.Windows.Forms.Label();
            this.labelS3_3 = new System.Windows.Forms.Label();
            this.labelS5_5 = new System.Windows.Forms.Label();
            this.labelS2_2 = new System.Windows.Forms.Label();
            this.labelS1_1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxSkillMut = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharacterDEF)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharacterDMG)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDEFcalc
            // 
            this.buttonDEFcalc.Location = new System.Drawing.Point(211, 143);
            this.buttonDEFcalc.Name = "buttonDEFcalc";
            this.buttonDEFcalc.Size = new System.Drawing.Size(64, 23);
            this.buttonDEFcalc.TabIndex = 0;
            this.buttonDEFcalc.Text = "Calc";
            this.buttonDEFcalc.UseVisualStyleBackColor = true;
            this.buttonDEFcalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "BaseDEF";
            // 
            // textBoxBaseDEF
            // 
            this.textBoxBaseDEF.Location = new System.Drawing.Point(89, 19);
            this.textBoxBaseDEF.MaxLength = 5;
            this.textBoxBaseDEF.Name = "textBoxBaseDEF";
            this.textBoxBaseDEF.Size = new System.Drawing.Size(56, 22);
            this.textBoxBaseDEF.TabIndex = 2;
            this.textBoxBaseDEF.Text = "0";
            this.textBoxBaseDEF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBaseDEF_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "ItemDEF";
            // 
            // textBoxItemDEF
            // 
            this.textBoxItemDEF.Location = new System.Drawing.Point(89, 55);
            this.textBoxItemDEF.MaxLength = 5;
            this.textBoxItemDEF.Name = "textBoxItemDEF";
            this.textBoxItemDEF.Size = new System.Drawing.Size(56, 22);
            this.textBoxItemDEF.TabIndex = 4;
            this.textBoxItemDEF.Text = "0";
            this.textBoxItemDEF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxItemDEF_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Character";
            // 
            // labelH5
            // 
            this.labelH5.AutoSize = true;
            this.labelH5.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH5.Location = new System.Drawing.Point(296, 152);
            this.labelH5.Name = "labelH5";
            this.labelH5.Size = new System.Drawing.Size(22, 21);
            this.labelH5.TabIndex = 18;
            this.labelH5.Text = "5.";
            // 
            // numericUpDownCharacterDEF
            // 
            this.numericUpDownCharacterDEF.Location = new System.Drawing.Point(211, 113);
            this.numericUpDownCharacterDEF.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownCharacterDEF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCharacterDEF.Name = "numericUpDownCharacterDEF";
            this.numericUpDownCharacterDEF.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownCharacterDEF.TabIndex = 20;
            this.numericUpDownCharacterDEF.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCharacterDEF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownCharacter_KeyPress);
            // 
            // labelH5_5
            // 
            this.labelH5_5.AutoSize = true;
            this.labelH5_5.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH5_5.Location = new System.Drawing.Point(324, 153);
            this.labelH5_5.Name = "labelH5_5";
            this.labelH5_5.Size = new System.Drawing.Size(30, 17);
            this.labelH5_5.TabIndex = 23;
            this.labelH5_5.Text = "0 %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Happen Rate";
            // 
            // labelH1
            // 
            this.labelH1.AutoSize = true;
            this.labelH1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH1.Location = new System.Drawing.Point(296, 52);
            this.labelH1.Name = "labelH1";
            this.labelH1.Size = new System.Drawing.Size(22, 21);
            this.labelH1.TabIndex = 10;
            this.labelH1.Text = "1.";
            // 
            // labelH2
            // 
            this.labelH2.AutoSize = true;
            this.labelH2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH2.Location = new System.Drawing.Point(296, 77);
            this.labelH2.Name = "labelH2";
            this.labelH2.Size = new System.Drawing.Size(22, 21);
            this.labelH2.TabIndex = 11;
            this.labelH2.Text = "2.";
            // 
            // labelH3
            // 
            this.labelH3.AutoSize = true;
            this.labelH3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH3.Location = new System.Drawing.Point(296, 102);
            this.labelH3.Name = "labelH3";
            this.labelH3.Size = new System.Drawing.Size(22, 21);
            this.labelH3.TabIndex = 17;
            this.labelH3.Text = "3.";
            // 
            // labelH4
            // 
            this.labelH4.AutoSize = true;
            this.labelH4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH4.Location = new System.Drawing.Point(296, 127);
            this.labelH4.Name = "labelH4";
            this.labelH4.Size = new System.Drawing.Size(22, 21);
            this.labelH4.TabIndex = 16;
            this.labelH4.Text = "4.";
            // 
            // labelH1_1
            // 
            this.labelH1_1.AutoSize = true;
            this.labelH1_1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH1_1.Location = new System.Drawing.Point(324, 53);
            this.labelH1_1.Name = "labelH1_1";
            this.labelH1_1.Size = new System.Drawing.Size(30, 17);
            this.labelH1_1.TabIndex = 21;
            this.labelH1_1.Text = "0 %";
            // 
            // labelH2_2
            // 
            this.labelH2_2.AutoSize = true;
            this.labelH2_2.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH2_2.Location = new System.Drawing.Point(324, 78);
            this.labelH2_2.Name = "labelH2_2";
            this.labelH2_2.Size = new System.Drawing.Size(30, 17);
            this.labelH2_2.TabIndex = 22;
            this.labelH2_2.Text = "0 %";
            // 
            // labelH3_3
            // 
            this.labelH3_3.AutoSize = true;
            this.labelH3_3.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH3_3.Location = new System.Drawing.Point(324, 103);
            this.labelH3_3.Name = "labelH3_3";
            this.labelH3_3.Size = new System.Drawing.Size(30, 17);
            this.labelH3_3.TabIndex = 24;
            this.labelH3_3.Text = "0 %";
            // 
            // labelH4_4
            // 
            this.labelH4_4.AutoSize = true;
            this.labelH4_4.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH4_4.Location = new System.Drawing.Point(324, 128);
            this.labelH4_4.Name = "labelH4_4";
            this.labelH4_4.Size = new System.Drawing.Size(30, 17);
            this.labelH4_4.TabIndex = 25;
            this.labelH4_4.Text = "0 %";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.textBoxbuffDef);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelH4_4);
            this.groupBox1.Controls.Add(this.buttonDEFcalc);
            this.groupBox1.Controls.Add(this.labelH3_3);
            this.groupBox1.Controls.Add(this.textBoxBaseDEF);
            this.groupBox1.Controls.Add(this.labelH5_5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelH2_2);
            this.groupBox1.Controls.Add(this.textBoxItemDEF);
            this.groupBox1.Controls.Add(this.labelH1_1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownCharacterDEF);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelH5);
            this.groupBox1.Controls.Add(this.labelH1);
            this.groupBox1.Controls.Add(this.labelH3);
            this.groupBox1.Controls.Add(this.labelH2);
            this.groupBox1.Controls.Add(this.labelH4);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 182);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Defense";
            // 
            // textBoxbuffDef
            // 
            this.textBoxbuffDef.Location = new System.Drawing.Point(89, 91);
            this.textBoxbuffDef.MaxLength = 5;
            this.textBoxbuffDef.Name = "textBoxbuffDef";
            this.textBoxbuffDef.Size = new System.Drawing.Size(56, 22);
            this.textBoxbuffDef.TabIndex = 27;
            this.textBoxbuffDef.Text = "0";
            this.textBoxbuffDef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxbuffDef_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 91);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 21);
            this.label19.TabIndex = 26;
            this.label19.Text = "BuffDEF";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(406, 221);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(398, 195);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Damage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.textBoxSkillMut);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.checkBoxCrit);
            this.groupBox2.Controls.Add(this.checkBoxHP2div1);
            this.groupBox2.Controls.Add(this.checkBoxWeak);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.textBoxBuffBossDMG);
            this.groupBox2.Controls.Add(this.textBoxBuffSkillDMG);
            this.groupBox2.Controls.Add(this.textBoxCritDMG);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.textBoxBuffATK);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.textBoxItemATK);
            this.groupBox2.Controls.Add(this.textBoxBaseATK);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.buttonDMGcalc);
            this.groupBox2.Controls.Add(this.numericUpDownCharacterDMG);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.labelS4_4);
            this.groupBox2.Controls.Add(this.labelS3_3);
            this.groupBox2.Controls.Add(this.labelS5_5);
            this.groupBox2.Controls.Add(this.labelS2_2);
            this.groupBox2.Controls.Add(this.labelS1_1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(7, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 183);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Damage";
            // 
            // checkBoxCrit
            // 
            this.checkBoxCrit.AutoSize = true;
            this.checkBoxCrit.Location = new System.Drawing.Point(188, 64);
            this.checkBoxCrit.Name = "checkBoxCrit";
            this.checkBoxCrit.Size = new System.Drawing.Size(72, 16);
            this.checkBoxCrit.TabIndex = 55;
            this.checkBoxCrit.Text = "傷害暴擊";
            this.checkBoxCrit.UseVisualStyleBackColor = true;
            // 
            // checkBoxHP2div1
            // 
            this.checkBoxHP2div1.AutoSize = true;
            this.checkBoxHP2div1.Location = new System.Drawing.Point(188, 42);
            this.checkBoxHP2div1.Name = "checkBoxHP2div1";
            this.checkBoxHP2div1.Size = new System.Drawing.Size(83, 16);
            this.checkBoxHP2div1.TabIndex = 54;
            this.checkBoxHP2div1.Text = "HP 1/2 加成";
            this.checkBoxHP2div1.UseVisualStyleBackColor = true;
            // 
            // checkBoxWeak
            // 
            this.checkBoxWeak.AutoSize = true;
            this.checkBoxWeak.Location = new System.Drawing.Point(188, 20);
            this.checkBoxWeak.Name = "checkBoxWeak";
            this.checkBoxWeak.Size = new System.Drawing.Size(99, 16);
            this.checkBoxWeak.TabIndex = 53;
            this.checkBoxWeak.Text = "屬性弱點150%";
            this.checkBoxWeak.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 142);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 21);
            this.label23.TabIndex = 52;
            this.label23.Text = "BuffBossD";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 120);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 21);
            this.label22.TabIndex = 51;
            this.label22.Text = "BuffSkillD";
            // 
            // textBoxBuffBossDMG
            // 
            this.textBoxBuffBossDMG.Location = new System.Drawing.Point(89, 141);
            this.textBoxBuffBossDMG.MaxLength = 5;
            this.textBoxBuffBossDMG.Name = "textBoxBuffBossDMG";
            this.textBoxBuffBossDMG.Size = new System.Drawing.Size(56, 22);
            this.textBoxBuffBossDMG.TabIndex = 50;
            this.textBoxBuffBossDMG.Text = "0";
            this.textBoxBuffBossDMG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // textBoxBuffSkillDMG
            // 
            this.textBoxBuffSkillDMG.Location = new System.Drawing.Point(89, 117);
            this.textBoxBuffSkillDMG.MaxLength = 5;
            this.textBoxBuffSkillDMG.Name = "textBoxBuffSkillDMG";
            this.textBoxBuffSkillDMG.Size = new System.Drawing.Size(56, 22);
            this.textBoxBuffSkillDMG.TabIndex = 49;
            this.textBoxBuffSkillDMG.Text = "0";
            this.textBoxBuffSkillDMG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // textBoxCritDMG
            // 
            this.textBoxCritDMG.Location = new System.Drawing.Point(89, 92);
            this.textBoxCritDMG.MaxLength = 5;
            this.textBoxCritDMG.Name = "textBoxCritDMG";
            this.textBoxCritDMG.Size = new System.Drawing.Size(56, 22);
            this.textBoxCritDMG.TabIndex = 48;
            this.textBoxCritDMG.Text = "50";
            this.textBoxCritDMG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 95);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 21);
            this.label21.TabIndex = 47;
            this.label21.Text = "CritDamage";
            // 
            // textBoxBuffATK
            // 
            this.textBoxBuffATK.Location = new System.Drawing.Point(89, 68);
            this.textBoxBuffATK.MaxLength = 5;
            this.textBoxBuffATK.Name = "textBoxBuffATK";
            this.textBoxBuffATK.Size = new System.Drawing.Size(56, 22);
            this.textBoxBuffATK.TabIndex = 46;
            this.textBoxBuffATK.Text = "0";
            this.textBoxBuffATK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 21);
            this.label20.TabIndex = 45;
            this.label20.Text = "BuffATK";
            // 
            // textBoxItemATK
            // 
            this.textBoxItemATK.Location = new System.Drawing.Point(89, 44);
            this.textBoxItemATK.MaxLength = 5;
            this.textBoxItemATK.Name = "textBoxItemATK";
            this.textBoxItemATK.Size = new System.Drawing.Size(56, 22);
            this.textBoxItemATK.TabIndex = 44;
            this.textBoxItemATK.Text = "0";
            this.textBoxItemATK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBoxBaseATK
            // 
            this.textBoxBaseATK.Location = new System.Drawing.Point(89, 20);
            this.textBoxBaseATK.MaxLength = 5;
            this.textBoxBaseATK.Name = "textBoxBaseATK";
            this.textBoxBaseATK.Size = new System.Drawing.Size(56, 22);
            this.textBoxBaseATK.TabIndex = 43;
            this.textBoxBaseATK.Text = "0";
            this.textBoxBaseATK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 21);
            this.label16.TabIndex = 41;
            this.label16.Text = "BaseATK";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 21);
            this.label18.TabIndex = 42;
            this.label18.Text = "ItemATK";
            // 
            // buttonDMGcalc
            // 
            this.buttonDMGcalc.Location = new System.Drawing.Point(211, 143);
            this.buttonDMGcalc.Name = "buttonDMGcalc";
            this.buttonDMGcalc.Size = new System.Drawing.Size(64, 23);
            this.buttonDMGcalc.TabIndex = 38;
            this.buttonDMGcalc.Text = "Calc";
            this.buttonDMGcalc.UseVisualStyleBackColor = true;
            this.buttonDMGcalc.Click += new System.EventHandler(this.buttonDMGcalc_Click);
            // 
            // numericUpDownCharacterDMG
            // 
            this.numericUpDownCharacterDMG.Location = new System.Drawing.Point(211, 113);
            this.numericUpDownCharacterDMG.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownCharacterDMG.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCharacterDMG.Name = "numericUpDownCharacterDMG";
            this.numericUpDownCharacterDMG.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownCharacterDMG.TabIndex = 40;
            this.numericUpDownCharacterDMG.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(207, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 21);
            this.label17.TabIndex = 39;
            this.label17.Text = "Character";
            // 
            // labelS4_4
            // 
            this.labelS4_4.AutoSize = true;
            this.labelS4_4.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS4_4.Location = new System.Drawing.Point(324, 128);
            this.labelS4_4.Name = "labelS4_4";
            this.labelS4_4.Size = new System.Drawing.Size(16, 17);
            this.labelS4_4.TabIndex = 36;
            this.labelS4_4.Text = "0";
            // 
            // labelS3_3
            // 
            this.labelS3_3.AutoSize = true;
            this.labelS3_3.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS3_3.Location = new System.Drawing.Point(324, 103);
            this.labelS3_3.Name = "labelS3_3";
            this.labelS3_3.Size = new System.Drawing.Size(16, 17);
            this.labelS3_3.TabIndex = 35;
            this.labelS3_3.Text = "0";
            // 
            // labelS5_5
            // 
            this.labelS5_5.AutoSize = true;
            this.labelS5_5.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS5_5.Location = new System.Drawing.Point(324, 153);
            this.labelS5_5.Name = "labelS5_5";
            this.labelS5_5.Size = new System.Drawing.Size(16, 17);
            this.labelS5_5.TabIndex = 34;
            this.labelS5_5.Text = "0";
            // 
            // labelS2_2
            // 
            this.labelS2_2.AutoSize = true;
            this.labelS2_2.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS2_2.Location = new System.Drawing.Point(324, 78);
            this.labelS2_2.Name = "labelS2_2";
            this.labelS2_2.Size = new System.Drawing.Size(16, 17);
            this.labelS2_2.TabIndex = 33;
            this.labelS2_2.Text = "0";
            // 
            // labelS1_1
            // 
            this.labelS1_1.AutoSize = true;
            this.labelS1_1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS1_1.Location = new System.Drawing.Point(324, 53);
            this.labelS1_1.Name = "labelS1_1";
            this.labelS1_1.Size = new System.Drawing.Size(16, 17);
            this.labelS1_1.TabIndex = 32;
            this.labelS1_1.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(296, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 21);
            this.label10.TabIndex = 26;
            this.label10.Text = "Skill Damage";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(296, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 21);
            this.label11.TabIndex = 31;
            this.label11.Text = "5.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(296, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 21);
            this.label12.TabIndex = 27;
            this.label12.Text = "1.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(296, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 21);
            this.label13.TabIndex = 30;
            this.label13.Text = "3.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(296, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 21);
            this.label14.TabIndex = 28;
            this.label14.Text = "2.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(296, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 21);
            this.label15.TabIndex = 29;
            this.label15.Text = "4.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(398, 195);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Defense";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(151, 118);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 21);
            this.label24.TabIndex = 56;
            this.label24.Text = "SkillMut";
            // 
            // textBoxSkillMut
            // 
            this.textBoxSkillMut.Location = new System.Drawing.Point(155, 141);
            this.textBoxSkillMut.MaxLength = 3;
            this.textBoxSkillMut.Name = "textBoxSkillMut";
            this.textBoxSkillMut.Size = new System.Drawing.Size(50, 22);
            this.textBoxSkillMut.TabIndex = 57;
            this.textBoxSkillMut.Text = "4.3";
            // 
            // FNG_calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(406, 219);
            this.Controls.Add(this.tabControl1);
            this.Name = "FNG_calc";
            this.Text = "FNG_calc";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharacterDEF)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharacterDMG)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDEFcalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBaseDEF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxItemDEF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelH5;
        private System.Windows.Forms.NumericUpDown numericUpDownCharacterDEF;
        private System.Windows.Forms.Label labelH5_5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelH1;
        private System.Windows.Forms.Label labelH2;
        private System.Windows.Forms.Label labelH3;
        private System.Windows.Forms.Label labelH4;
        private System.Windows.Forms.Label labelH1_1;
        private System.Windows.Forms.Label labelH2_2;
        private System.Windows.Forms.Label labelH3_3;
        private System.Windows.Forms.Label labelH4_4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelS4_4;
        private System.Windows.Forms.Label labelS3_3;
        private System.Windows.Forms.Label labelS5_5;
        private System.Windows.Forms.Label labelS2_2;
        private System.Windows.Forms.Label labelS1_1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxItemATK;
        private System.Windows.Forms.TextBox textBoxBaseATK;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonDMGcalc;
        private System.Windows.Forms.NumericUpDown numericUpDownCharacterDMG;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxbuffDef;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxBuffBossDMG;
        private System.Windows.Forms.TextBox textBoxBuffSkillDMG;
        private System.Windows.Forms.TextBox textBoxCritDMG;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxBuffATK;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox checkBoxCrit;
        private System.Windows.Forms.CheckBox checkBoxHP2div1;
        private System.Windows.Forms.CheckBox checkBoxWeak;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBoxSkillMut;
    }
}

