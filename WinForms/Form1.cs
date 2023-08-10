namespace WinForms
{
    //Bsp-Enum
    enum TestEnum { Test1, Test2, Test3 }

    //PARTIAL besagt, dass diese Klasse in mehrere Teile (Dateien) aufgeteilt ist
    public partial class MeinFenster : Form
    {
        //Konstruktor für das Form (Fenster)
        public MeinFenster()
        {
            InitializeComponent();

            //Neuzuweisung einer Property des Buttons
            Btn_KlickMich.BackColor = Color.Aqua;

            //Hinzufügen eines weiteren EventHandlers zum Button.Click-Event
            Btn_KlickMich.Click += NochEinEventHandler;

            for (int i = 0; i < Enum.GetValues(typeof(TestEnum)).Length; i++)
            {
                //Befüllung der ComboBox mit Enum-Elementen
                Cbx_Enum.Items.Add((TestEnum)i);
            }

            //Neuzuweisung einer Property der TextBox
            Tbx_Input.Text = $"Hallo{Environment.NewLine}Moin";

            Lbx_Auswahl.Items.Add(new DateTime(2002, 3, 1));
            Lbx_Auswahl.Items.Add(new DateTime(2003, 3, 1));
            Lbx_Auswahl.Items.Add(new DateTime(2022, 3, 1));
            Lbx_Auswahl.Items.Add(DateTime.Now);
        }


        //EventHandler-Methoden

        //EventHandler, welche auf einen Klick auf den Button 'KlickMich" reagiert
        private void Btn_KlickMich_Click(object sender, EventArgs e)
        {
            //Neuzuweisung einer Eigenschaft des Buttons
            Btn_KlickMich.Text = "Button wurde geklickt";

            //Neuzuweisung einer Eigenschaft des Forms
            this.BackColor = Color.Yellow;

            //Prüfung, ob in der ComboBox ein Element angewählt wurde
            if (Cbx_Haken.Checked)
                //Neuzuweisung einer Eigenschaft des Buttons über den sender-Parameter
                (sender as Button).BackColor = Color.LightCoral;

            //Prüfung, ob in der ListBox ein Element angewählt wurde
            if (Lbx_Auswahl.SelectedItem != null)
                //Übertrag des Elements in den Button.Text
                Btn_KlickMich.Text = Lbx_Auswahl.SelectedItem.ToString();

            //Prüfung, ob in der ComboBox ein Element angewählt wurde
            if (Cbx_Enum.SelectedItem != null)
            {
                //Übertrag des Elements in das Label
                TestEnum enumVar = (TestEnum)Cbx_Enum.SelectedItem;
                Lbl_Output.Text = enumVar.ToString();
            }

            //Übertrag des TextBoxTexts in den Titel des Forms
            this.Text = Tbx_Input.Text;
        }

        //Weiterer Event-Handler, der im Konstruktor dem Button.Click-Event zugrordnet wurde (färbt Button-Text ein)
        private void NochEinEventHandler(object sender, EventArgs e) => (sender as Button).ForeColor = Color.White;

        private void Cbb_Auswahl_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Cbb_Auswahl.SelectedItem == "Auswahl2")
                Gbx_Bla.BackColor = Color.Green;
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Aufruf einer MessageBox und Prüfung des geklickten Buttons
            if (MessageBox.Show(
                                "Möchtest du das Fenster wirklich schließen?",
                                "Beenden",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning
                            ) == DialogResult.Yes)

                //Schließend des Fensters
                this.Close();

            //Schließend der Applikation
            //Application.Exit();
        }

        private void öffneNeuesFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziieren eines neuen Forms
            Form neuesFenster = new MeinFenster();
            //Neuzuweisung einer Eigenschaft des neuen Fensters
            neuesFenster.Text = "Neues Fenster";
            //Öffnen des Forms als gleichberechtigtes Fenster
            neuesFenster.Show();
        }

        private void öffneDialogFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziieren eines neuen Forms
            Form neuesFenster = new MeinFenster();
            //Neuzuweisung einer Eigenschaft des neuen Fensters
            neuesFenster.Text = "Neues Dialog-Fenster";
            (neuesFenster as MeinFenster).Btn_Ok.Enabled = true;
            //Öffen des Forms als Dialogfenster (muss exklusiv bearbeitet werden) und Überprüfung des zurückgegebenen DialogResults (s.u.)
            if (neuesFenster.ShowDialog() == DialogResult.OK)
                Lbl_Output.Text = "Es wurde auf OK geklickt";
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            //Setzen des DialogResults des DialogFensters (wird von ShowDialog zurückgegeben)
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}