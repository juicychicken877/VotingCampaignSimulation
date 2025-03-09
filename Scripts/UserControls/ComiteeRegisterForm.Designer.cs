namespace Wybory.Scripts.UserControls {
    partial class ComiteeRegisterForm {
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
            nameInput = new TextBox();
            registerBtn = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 10, 0, 0);
            label1.Size = new Size(827, 49);
            label1.TabIndex = 1;
            label1.Text = "Zarejestruj komitet";
            // 
            // nameInput
            // 
            nameInput.Location = new Point(16, 49);
            nameInput.Margin = new Padding(0);
            nameInput.Name = "nameInput";
            nameInput.PlaceholderText = "Nazwa komitetu";
            nameInput.Size = new Size(504, 29);
            nameInput.TabIndex = 2;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(316, 158);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(204, 46);
            registerBtn.TabIndex = 5;
            registerBtn.Text = "Zarejestruj";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ComiteeRegisterForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(registerBtn);
            Controls.Add(nameInput);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(0);
            Name = "ComiteeRegisterForm";
            Size = new Size(827, 587);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameInput;
        private Button registerBtn;
        private ErrorProvider errorProvider;
    }
}
