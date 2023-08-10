namespace WinForms
{
    partial class MeinFenster
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btn_KlickMich = new Button();
            Lbl_Output = new Label();
            Cbx_Haken = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            Gbx_Bla = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            Cbb_Auswahl = new ComboBox();
            Lbx_Auswahl = new ListBox();
            menuStrip1 = new MenuStrip();
            dateiToolStripMenuItem = new ToolStripMenuItem();
            öffnenToolStripMenuItem = new ToolStripMenuItem();
            öffneNeuesFensterToolStripMenuItem = new ToolStripMenuItem();
            öffneDialogFensterToolStripMenuItem = new ToolStripMenuItem();
            schließenToolStripMenuItem = new ToolStripMenuItem();
            Btn_Ok = new Button();
            Cbx_Enum = new ComboBox();
            Tbx_Input = new TextBox();
            Gbx_Bla.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_KlickMich
            // 
            Btn_KlickMich.BackColor = Color.Lime;
            Btn_KlickMich.Location = new Point(63, 52);
            Btn_KlickMich.Name = "Btn_KlickMich";
            Btn_KlickMich.Size = new Size(188, 87);
            Btn_KlickMich.TabIndex = 0;
            Btn_KlickMich.Text = "Klick mich";
            Btn_KlickMich.UseVisualStyleBackColor = false;
            Btn_KlickMich.Click += Btn_KlickMich_Click;
            // 
            // Lbl_Output
            // 
            Lbl_Output.AutoSize = true;
            Lbl_Output.Location = new Point(314, 240);
            Lbl_Output.Name = "Lbl_Output";
            Lbl_Output.Size = new Size(262, 32);
            Lbl_Output.TabIndex = 1;
            Lbl_Output.Text = "Hallo, ich bin ein String";
            // 
            // Cbx_Haken
            // 
            Cbx_Haken.AutoSize = true;
            Cbx_Haken.Location = new Point(410, 85);
            Cbx_Haken.Name = "Cbx_Haken";
            Cbx_Haken.Size = new Size(179, 36);
            Cbx_Haken.TabIndex = 2;
            Cbx_Haken.Text = "Hak mich ab";
            Cbx_Haken.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(41, 223);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(184, 36);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(41, 256);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(184, 36);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(41, 298);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(184, 36);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // Gbx_Bla
            // 
            Gbx_Bla.Controls.Add(radioButton5);
            Gbx_Bla.Controls.Add(radioButton4);
            Gbx_Bla.Location = new Point(355, 299);
            Gbx_Bla.Name = "Gbx_Bla";
            Gbx_Bla.Size = new Size(400, 200);
            Gbx_Bla.TabIndex = 6;
            Gbx_Bla.TabStop = false;
            Gbx_Bla.Text = "Gbx_Bla";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(76, 130);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(184, 36);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "radioButton5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(78, 69);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(184, 36);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // Cbb_Auswahl
            // 
            Cbb_Auswahl.FormattingEnabled = true;
            Cbb_Auswahl.Items.AddRange(new object[] { "Eintrag1", "Auswahl2", "Item3" });
            Cbb_Auswahl.Location = new Point(42, 411);
            Cbb_Auswahl.Name = "Cbb_Auswahl";
            Cbb_Auswahl.Size = new Size(242, 40);
            Cbb_Auswahl.TabIndex = 7;
            Cbb_Auswahl.SelectedValueChanged += Cbb_Auswahl_SelectedValueChanged;
            // 
            // Lbx_Auswahl
            // 
            Lbx_Auswahl.FormattingEnabled = true;
            Lbx_Auswahl.ItemHeight = 32;
            Lbx_Auswahl.Location = new Point(52, 504);
            Lbx_Auswahl.Name = "Lbx_Auswahl";
            Lbx_Auswahl.Size = new Size(240, 164);
            Lbx_Auswahl.TabIndex = 8;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dateiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 40);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            dateiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { öffnenToolStripMenuItem, schließenToolStripMenuItem });
            dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            dateiToolStripMenuItem.Size = new Size(90, 36);
            dateiToolStripMenuItem.Text = "Datei";
            // 
            // öffnenToolStripMenuItem
            // 
            öffnenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { öffneNeuesFensterToolStripMenuItem, öffneDialogFensterToolStripMenuItem });
            öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            öffnenToolStripMenuItem.Size = new Size(250, 44);
            öffnenToolStripMenuItem.Text = "Öffnen";
            // 
            // öffneNeuesFensterToolStripMenuItem
            // 
            öffneNeuesFensterToolStripMenuItem.Name = "öffneNeuesFensterToolStripMenuItem";
            öffneNeuesFensterToolStripMenuItem.Size = new Size(372, 44);
            öffneNeuesFensterToolStripMenuItem.Text = "Öffne neues Fenster";
            öffneNeuesFensterToolStripMenuItem.Click += öffneNeuesFensterToolStripMenuItem_Click;
            // 
            // öffneDialogFensterToolStripMenuItem
            // 
            öffneDialogFensterToolStripMenuItem.Name = "öffneDialogFensterToolStripMenuItem";
            öffneDialogFensterToolStripMenuItem.Size = new Size(372, 44);
            öffneDialogFensterToolStripMenuItem.Text = "Öffne Dialog-Fenster";
            öffneDialogFensterToolStripMenuItem.Click += öffneDialogFensterToolStripMenuItem_Click;
            // 
            // schließenToolStripMenuItem
            // 
            schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            schließenToolStripMenuItem.Size = new Size(250, 44);
            schließenToolStripMenuItem.Text = "Schließen";
            schließenToolStripMenuItem.Click += schließenToolStripMenuItem_Click;
            // 
            // Btn_Ok
            // 
            Btn_Ok.Enabled = false;
            Btn_Ok.Location = new Point(497, 561);
            Btn_Ok.Name = "Btn_Ok";
            Btn_Ok.Size = new Size(150, 46);
            Btn_Ok.TabIndex = 10;
            Btn_Ok.Text = "OK";
            Btn_Ok.UseVisualStyleBackColor = true;
            Btn_Ok.Click += Btn_Ok_Click;
            // 
            // Cbx_Enum
            // 
            Cbx_Enum.FormattingEnabled = true;
            Cbx_Enum.Location = new Point(65, 158);
            Cbx_Enum.Name = "Cbx_Enum";
            Cbx_Enum.Size = new Size(242, 40);
            Cbx_Enum.TabIndex = 11;
            // 
            // Tbx_Input
            // 
            Tbx_Input.Location = new Point(410, 644);
            Tbx_Input.Name = "Tbx_Input";
            Tbx_Input.Size = new Size(200, 39);
            Tbx_Input.TabIndex = 12;
            // 
            // MeinFenster
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 718);
            Controls.Add(Tbx_Input);
            Controls.Add(Cbx_Enum);
            Controls.Add(Btn_Ok);
            Controls.Add(Lbx_Auswahl);
            Controls.Add(Cbb_Auswahl);
            Controls.Add(Gbx_Bla);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(Cbx_Haken);
            Controls.Add(Lbl_Output);
            Controls.Add(Btn_KlickMich);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MeinFenster";
            Text = "Form1";
            Gbx_Bla.ResumeLayout(false);
            Gbx_Bla.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_KlickMich;
        private Label Lbl_Output;
        private CheckBox Cbx_Haken;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox Gbx_Bla;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private ComboBox Cbb_Auswahl;
        private ListBox Lbx_Auswahl;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem öffnenToolStripMenuItem;
        private ToolStripMenuItem öffneNeuesFensterToolStripMenuItem;
        private ToolStripMenuItem öffneDialogFensterToolStripMenuItem;
        private ToolStripMenuItem schließenToolStripMenuItem;
        private Button Btn_Ok;
        private ComboBox Cbx_Enum;
        private TextBox Tbx_Input;
    }
}