namespace WinForms
{
    public partial class MeinFenster : Form
    {
        public MeinFenster()
        {
            InitializeComponent();

            Lbx_Auswahl.Items.Add(new DateTime(2002, 3, 1));
            Lbx_Auswahl.Items.Add(new DateTime(2003, 3, 1));
            Lbx_Auswahl.Items.Add(new DateTime(2022, 3, 1));
            Lbx_Auswahl.Items.Add(DateTime.Now);
        }

        private void Btn_KlickMich_Click(object sender, EventArgs e)
        {
            Btn_KlickMich.Text = "Button wurde geklickt";

            this.BackColor = Color.HotPink;

            if (Cbx_Haken.Checked)
                Btn_KlickMich.Left += 100;

            Lbl_Output.Text = Cbb_Auswahl.SelectedItem.ToString();
        }

        private void Cbb_Auswahl_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Cbb_Auswahl.SelectedItem == "Auswahl2")
                Gbx_Bla.BackColor = Color.Green;
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Möchstest du das Fenster wirklich schließen?", "Fenster schließen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                this.Close();
            }
             
        }

        private void öffneNeuesFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new MeinFenster();

            form.Text = "Neues Fenster";

            form.Show();
        }

        private void öffneDialogFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new MeinFenster();

            form.Text = "Neues Dialog-Fenster";

            if (form.ShowDialog() == DialogResult.OK)
                Lbl_Output.Text = "OKAY wurde geklickt";
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}