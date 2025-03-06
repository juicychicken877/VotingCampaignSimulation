namespace Wybory.Scripts {
    partial class VotingWindow {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            peselLabel = new Label();
            label2 = new Label();
            candidatesComboBox = new ComboBox();
            voteBtn = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // peselLabel
            // 
            peselLabel.Location = new Point(2, -2);
            peselLabel.Margin = new Padding(4, 0, 4, 0);
            peselLabel.Name = "peselLabel";
            peselLabel.Size = new Size(808, 53);
            peselLabel.TabIndex = 0;
            peselLabel.Text = "Osoba głosująca: 00000000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 98);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 1;
            label2.Text = "Kandydaci";
            // 
            // candidatesComboBox
            // 
            candidatesComboBox.FormattingEnabled = true;
            candidatesComboBox.Location = new Point(185, 149);
            candidatesComboBox.Name = "candidatesComboBox";
            candidatesComboBox.Size = new Size(396, 40);
            candidatesComboBox.TabIndex = 2;
            // 
            // voteBtn
            // 
            voteBtn.Location = new Point(185, 236);
            voteBtn.Name = "voteBtn";
            voteBtn.Size = new Size(396, 47);
            voteBtn.TabIndex = 3;
            voteBtn.Text = "Oddaj głos";
            voteBtn.UseVisualStyleBackColor = true;
            voteBtn.Click += voteBtn_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // VotingWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 543);
            Controls.Add(voteBtn);
            Controls.Add(candidatesComboBox);
            Controls.Add(label2);
            Controls.Add(peselLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "VotingWindow";
            Text = "VotingWindow";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label peselLabel;
        private Label label2;
        private ComboBox candidatesComboBox;
        private Button voteBtn;
        private ErrorProvider errorProvider;
    }
}