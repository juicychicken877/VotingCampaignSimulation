namespace Wybory.Scripts {
    partial class VoterRegisterForm {
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
            registerBtn = new Button();
            birthDatePicker = new DateTimePicker();
            label2 = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 10, 0, 0);
            label1.Size = new Size(914, 54);
            label1.TabIndex = 0;
            label1.Text = "Zarejestruj się jako wyborca";
            // 
            // peselInput
            // 
            peselInput.Location = new Point(17, 54);
            peselInput.Margin = new Padding(0);
            peselInput.Name = "peselInput";
            peselInput.PlaceholderText = "PESEL";
            peselInput.Size = new Size(504, 39);
            peselInput.TabIndex = 1;
            // 
            // firstNameInput
            // 
            firstNameInput.Location = new Point(17, 113);
            firstNameInput.Margin = new Padding(0);
            firstNameInput.Name = "firstNameInput";
            firstNameInput.PlaceholderText = "Imię np. Tomasz";
            firstNameInput.Size = new Size(504, 39);
            firstNameInput.TabIndex = 2;
            // 
            // secondNameInput
            // 
            secondNameInput.Location = new Point(17, 172);
            secondNameInput.Margin = new Padding(0);
            secondNameInput.Name = "secondNameInput";
            secondNameInput.PlaceholderText = "Nazwisko np. Kowalski";
            secondNameInput.Size = new Size(504, 39);
            secondNameInput.TabIndex = 3;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(317, 384);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(204, 46);
            registerBtn.TabIndex = 4;
            registerBtn.Text = "Zarejestruj";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // birthDatePicker
            // 
            birthDatePicker.Location = new Point(17, 268);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new Size(504, 39);
            birthDatePicker.TabIndex = 5;
            birthDatePicker.Value = new DateTime(2025, 3, 5, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.Location = new Point(3, 211);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 10, 0, 0);
            label2.Size = new Size(914, 54);
            label2.TabIndex = 6;
            label2.Text = "Data urodzenia";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // VoterRegisterForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(label2);
            Controls.Add(birthDatePicker);
            Controls.Add(registerBtn);
            Controls.Add(secondNameInput);
            Controls.Add(firstNameInput);
            Controls.Add(peselInput);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(0);
            Name = "VoterRegisterForm";
            Size = new Size(920, 615);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox peselInput;
        private TextBox firstNameInput;
        private TextBox secondNameInput;
        private Button registerBtn;
        private DateTimePicker birthDatePicker;
        private Label label2;
        private ErrorProvider errorProvider;
    }
}
