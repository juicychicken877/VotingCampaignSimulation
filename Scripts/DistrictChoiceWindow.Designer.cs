namespace Wybory {
    partial class DistrictChoiceWindow {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button3 = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(746, 70);
            button1.TabIndex = 0;
            button1.Text = "Aksamitny";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 33);
            label1.Name = "label1";
            label1.Size = new Size(746, 56);
            label1.TabIndex = 3;
            label1.Text = "Wybierz okręg wyborczy";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(3, 79);
            button2.Name = "button2";
            button2.Size = new Size(746, 70);
            button2.TabIndex = 4;
            button2.Text = "Szydłowiecki";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Location = new Point(2, 118);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(746, 359);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(3, 155);
            button3.Name = "button3";
            button3.Size = new Size(746, 70);
            button3.TabIndex = 5;
            button3.Text = "Wadowicki";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // DistrictChoiceWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 477);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DistrictChoiceWindow";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button3;
    }
}
