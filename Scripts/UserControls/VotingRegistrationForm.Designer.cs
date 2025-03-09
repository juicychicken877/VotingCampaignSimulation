namespace Wybory.Scripts {
    partial class VotingRegistrationForm {
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
            continueBtn = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(827, 109);
            label1.TabIndex = 0;
            label1.Text = "Zarejestruj się by oddać głos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // peselInput
            // 
            peselInput.Location = new Point(164, 112);
            peselInput.Name = "peselInput";
            peselInput.PlaceholderText = "PESEL";
            peselInput.Size = new Size(503, 29);
            peselInput.TabIndex = 1;
            // 
            // continueBtn
            // 
            continueBtn.Location = new Point(231, 178);
            continueBtn.Name = "continueBtn";
            continueBtn.Size = new Size(376, 45);
            continueBtn.TabIndex = 2;
            continueBtn.Text = "Przejdź do glosowania";
            continueBtn.UseVisualStyleBackColor = true;
            continueBtn.Click += continueBtn_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // VotingRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(continueBtn);
            Controls.Add(peselInput);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(0);
            Name = "VotingRegistrationForm";
            Size = new Size(827, 587);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox peselInput;
        private Button continueBtn;
        private ErrorProvider errorProvider;
    }
}
