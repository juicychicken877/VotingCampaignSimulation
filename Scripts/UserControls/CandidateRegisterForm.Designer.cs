namespace Wybory.Scripts {
    partial class CandidateRegisterForm {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            peselInput = new TextBox();
            firstNameInput = new TextBox();
            secondNameInput = new TextBox();
            birthDatePicker = new DateTimePicker();
            label2 = new Label();
            registerBtn = new Button();
            politicalPartyComboBox = new ComboBox();
            comiteeComboBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 10, 0, 0);
            label1.Size = new Size(827, 40);
            label1.TabIndex = 1;
            label1.Text = "Zarejestruj się jako kandydat";
            // 
            // peselInput
            // 
            peselInput.Location = new Point(15, 51);
            peselInput.Margin = new Padding(0);
            peselInput.Name = "peselInput";
            peselInput.PlaceholderText = "PESEL";
            peselInput.Size = new Size(504, 29);
            peselInput.TabIndex = 2;
            // 
            // firstNameInput
            // 
            firstNameInput.Location = new Point(15, 94);
            firstNameInput.Margin = new Padding(0);
            firstNameInput.Name = "firstNameInput";
            firstNameInput.PlaceholderText = "Imię np. Tomasz";
            firstNameInput.Size = new Size(504, 29);
            firstNameInput.TabIndex = 3;
            // 
            // secondNameInput
            // 
            secondNameInput.Location = new Point(15, 140);
            secondNameInput.Margin = new Padding(0);
            secondNameInput.Name = "secondNameInput";
            secondNameInput.PlaceholderText = "Nazwisko np. Kowalski";
            secondNameInput.Size = new Size(504, 29);
            secondNameInput.TabIndex = 4;
            // 
            // birthDatePicker
            // 
            birthDatePicker.Location = new Point(15, 219);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new Size(504, 29);
            birthDatePicker.TabIndex = 6;
            birthDatePicker.Value = new DateTime(2025, 3, 5, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.Location = new Point(0, 169);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 10, 0, 0);
            label2.Size = new Size(827, 47);
            label2.TabIndex = 7;
            label2.Text = "Data urodzenia";
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(315, 447);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(204, 46);
            registerBtn.TabIndex = 8;
            registerBtn.Text = "Zarejestruj";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // politicalPartyComboBox
            // 
            politicalPartyComboBox.FormattingEnabled = true;
            politicalPartyComboBox.Items.AddRange(new object[] { "Prawo i Sprawiedliwość", "Koalicja Obywatelska", "Platforma Obywatelska", "Polska 2050", "Lewica", "Polska Partia Przyjacieli Piwa", "Konfederacja" });
            politicalPartyComboBox.Location = new Point(15, 302);
            politicalPartyComboBox.Name = "politicalPartyComboBox";
            politicalPartyComboBox.Size = new Size(504, 29);
            politicalPartyComboBox.TabIndex = 9;
            // 
            // comiteeComboBox
            // 
            comiteeComboBox.FormattingEnabled = true;
            comiteeComboBox.Location = new Point(15, 384);
            comiteeComboBox.Name = "comiteeComboBox";
            comiteeComboBox.Size = new Size(504, 29);
            comiteeComboBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.Location = new Point(0, 251);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 10, 0, 0);
            label3.Size = new Size(827, 48);
            label3.TabIndex = 11;
            label3.Text = "Partia polityczna";
            // 
            // label4
            // 
            label4.Location = new Point(0, 334);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 10, 0, 0);
            label4.Size = new Size(827, 47);
            label4.TabIndex = 12;
            label4.Text = "Komitet";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // CandidateRegisterForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comiteeComboBox);
            Controls.Add(politicalPartyComboBox);
            Controls.Add(registerBtn);
            Controls.Add(label2);
            Controls.Add(birthDatePicker);
            Controls.Add(secondNameInput);
            Controls.Add(firstNameInput);
            Controls.Add(peselInput);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(0);
            Name = "CandidateRegisterForm";
            Size = new Size(827, 587);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox peselInput;
        private TextBox firstNameInput;
        private TextBox secondNameInput;
        private DateTimePicker birthDatePicker;
        private Label label2;
        private Button registerBtn;
        private ComboBox politicalPartyComboBox;
        private ComboBox comiteeComboBox;
        private Label label3;
        private Label label4;
        private ErrorProvider errorProvider;
    }
}
