namespace SpeichernUndLaden
{
    partial class Form1
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
            Tbx_Input = new TextBox();
            Btn_Save = new Button();
            Btn_Load = new Button();
            Btn_SaveP = new Button();
            Btn_LoadP = new Button();
            SuspendLayout();
            // 
            // Tbx_Input
            // 
            Tbx_Input.Location = new Point(71, 55);
            Tbx_Input.Multiline = true;
            Tbx_Input.Name = "Tbx_Input";
            Tbx_Input.Size = new Size(290, 266);
            Tbx_Input.TabIndex = 0;
            // 
            // Btn_Save
            // 
            Btn_Save.Location = new Point(405, 55);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(150, 46);
            Btn_Save.TabIndex = 1;
            Btn_Save.Text = "Speichern";
            Btn_Save.UseVisualStyleBackColor = true;
            Btn_Save.Click += Btn_Save_Click;
            // 
            // Btn_Load
            // 
            Btn_Load.Location = new Point(405, 107);
            Btn_Load.Name = "Btn_Load";
            Btn_Load.Size = new Size(150, 46);
            Btn_Load.TabIndex = 2;
            Btn_Load.Text = "Laden";
            Btn_Load.UseVisualStyleBackColor = true;
            Btn_Load.Click += Btn_Load_Click;
            // 
            // Btn_SaveP
            // 
            Btn_SaveP.Location = new Point(572, 55);
            Btn_SaveP.Name = "Btn_SaveP";
            Btn_SaveP.Size = new Size(150, 46);
            Btn_SaveP.TabIndex = 3;
            Btn_SaveP.Text = "P Speichern";
            Btn_SaveP.UseVisualStyleBackColor = true;
            Btn_SaveP.Click += Btn_SaveP_Click;
            // 
            // Btn_LoadP
            // 
            Btn_LoadP.Location = new Point(572, 107);
            Btn_LoadP.Name = "Btn_LoadP";
            Btn_LoadP.Size = new Size(150, 46);
            Btn_LoadP.TabIndex = 4;
            Btn_LoadP.Text = "P Laden";
            Btn_LoadP.UseVisualStyleBackColor = true;
            Btn_LoadP.Click += Btn_LoadP_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_LoadP);
            Controls.Add(Btn_SaveP);
            Controls.Add(Btn_Load);
            Controls.Add(Btn_Save);
            Controls.Add(Tbx_Input);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Tbx_Input;
        private Button Btn_Save;
        private Button Btn_Load;
        private Button Btn_SaveP;
        private Button Btn_LoadP;
    }
}