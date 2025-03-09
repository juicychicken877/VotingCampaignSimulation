namespace Wybory.Scripts.UserControls {
    partial class CustomListElement {
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
            label = new Label();
            SuspendLayout();
            // 
            // label
            // 
            label.Location = new Point(0, 0);
            label.Margin = new Padding(0, 5, 0, 5);
            label.Name = "label";
            label.Padding = new Padding(20, 0, 0, 0);
            label.Size = new Size(800, 50);
            label.TabIndex = 0;
            label.Text = "-----------";
            label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CustomListElement
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLight;
            Controls.Add(label);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(0);
            Name = "CustomListElement";
            Size = new Size(800, 50);
            ResumeLayout(false);
        }

        #endregion

        private Label label;
    }
}
