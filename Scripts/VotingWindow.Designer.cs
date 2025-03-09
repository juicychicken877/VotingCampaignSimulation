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
            peselLabel.Dock = DockStyle.Top;
            peselLabel.Location = new Point(0, 0);
            peselLabel.Margin = new Padding(4, 0, 4, 0);
            peselLabel.Name = "peselLabel";
            peselLabel.Size = new Size(810, 52);
            peselLabel.TabIndex = 0;
            peselLabel.Text = "Osoba głosująca: 00000000000";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(0, 52);
            label2.Name = "label2";
            label2.Size = new Size(810, 50);
            label2.TabIndex = 1;
            label2.Text = "Kandydaci";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // candidatesComboBox
            // 
            candidatesComboBox.FormattingEnabled = true;
            candidatesComboBox.Location = new Point(206, 118);
            candidatesComboBox.Name = "candidatesComboBox";
            candidatesComboBox.Size = new Size(396, 29);
            candidatesComboBox.TabIndex = 2;
            // 
            // voteBtn
            // 
            voteBtn.Location = new Point(206, 181);
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
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 543);
            Controls.Add(voteBtn);
            Controls.Add(candidatesComboBox);
            Controls.Add(label2);
            Controls.Add(peselLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "VotingWindow";
            Text = "Głosowanie";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label peselLabel;
        private Label label2;
        private ComboBox candidatesComboBox;
        private Button voteBtn;
        private ErrorProvider errorProvider;
    }
}