namespace Wybory.Scripts {
    partial class DistrictWindow {
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabControl2 = new TabControl();
            tabPage5 = new TabPage();
            voterRegisterForm = new VoterRegisterForm();
            tabPage6 = new TabPage();
            voterList = new CustomList();
            tabPage4 = new TabPage();
            votingRegistrationForm = new VotingRegistrationForm();
            tabPage2 = new TabPage();
            tabControl4 = new TabControl();
            tabPage9 = new TabPage();
            candidateRegisterForm = new CandidateRegisterForm();
            tabPage10 = new TabPage();
            candidateList = new CustomList();
            tabPage3 = new TabPage();
            tabControl3 = new TabControl();
            tabPage7 = new TabPage();
            comiteeRegisterForm = new UserControls.ComiteeRegisterForm();
            tabPage8 = new TabPage();
            comiteeList = new CustomList();
            tabPage11 = new TabPage();
            votingResults = new VotingResults();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl4.SuspendLayout();
            tabPage9.SuspendLayout();
            tabPage10.SuspendLayout();
            tabPage3.SuspendLayout();
            tabControl3.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage8.SuspendLayout();
            tabPage11.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage11);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ItemSize = new Size(200, 50);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(40, 3);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(961, 752);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tabControl2);
            tabPage1.Location = new Point(4, 54);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(953, 694);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Wyborca";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Controls.Add(tabPage6);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.ItemSize = new Size(200, 50);
            tabControl2.Location = new Point(3, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.Padding = new Point(40, 3);
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(947, 688);
            tabControl2.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(voterRegisterForm);
            tabPage5.Location = new Point(4, 54);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(939, 630);
            tabPage5.TabIndex = 0;
            tabPage5.Text = "Zarejestruj";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // voterRegisterForm
            // 
            voterRegisterForm.Dock = DockStyle.Fill;
            voterRegisterForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            voterRegisterForm.Location = new Point(3, 3);
            voterRegisterForm.Margin = new Padding(0);
            voterRegisterForm.Name = "voterRegisterForm";
            voterRegisterForm.Size = new Size(933, 624);
            voterRegisterForm.TabIndex = 0;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(voterList);
            tabPage6.Location = new Point(4, 54);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(939, 630);
            tabPage6.TabIndex = 1;
            tabPage6.Text = "Lista wyborców";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // voterList
            // 
            voterList.Dock = DockStyle.Fill;
            voterList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            voterList.Location = new Point(3, 3);
            voterList.Margin = new Padding(4);
            voterList.Name = "voterList";
            voterList.Size = new Size(933, 624);
            voterList.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(votingRegistrationForm);
            tabPage4.Location = new Point(4, 54);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(939, 630);
            tabPage4.TabIndex = 2;
            tabPage4.Text = "Głosuj";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // votingRegistrationForm
            // 
            votingRegistrationForm.districtRef = null;
            votingRegistrationForm.Dock = DockStyle.Fill;
            votingRegistrationForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            votingRegistrationForm.Location = new Point(0, 0);
            votingRegistrationForm.Margin = new Padding(4);
            votingRegistrationForm.Name = "votingRegistrationForm";
            votingRegistrationForm.Size = new Size(939, 630);
            votingRegistrationForm.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tabControl4);
            tabPage2.Location = new Point(4, 54);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(953, 694);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kandydat";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            tabControl4.Controls.Add(tabPage9);
            tabControl4.Controls.Add(tabPage10);
            tabControl4.Dock = DockStyle.Fill;
            tabControl4.ItemSize = new Size(250, 50);
            tabControl4.Location = new Point(3, 3);
            tabControl4.Name = "tabControl4";
            tabControl4.Padding = new Point(40, 3);
            tabControl4.SelectedIndex = 0;
            tabControl4.Size = new Size(947, 688);
            tabControl4.TabIndex = 0;
            // 
            // tabPage9
            // 
            tabPage9.Controls.Add(candidateRegisterForm);
            tabPage9.Location = new Point(4, 54);
            tabPage9.Name = "tabPage9";
            tabPage9.Padding = new Padding(3);
            tabPage9.Size = new Size(939, 630);
            tabPage9.TabIndex = 0;
            tabPage9.Text = "Zarejestruj";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // candidateRegisterForm
            // 
            candidateRegisterForm.Dock = DockStyle.Fill;
            candidateRegisterForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            candidateRegisterForm.Location = new Point(3, 3);
            candidateRegisterForm.Margin = new Padding(4);
            candidateRegisterForm.Name = "candidateRegisterForm";
            candidateRegisterForm.Size = new Size(933, 624);
            candidateRegisterForm.TabIndex = 0;
            // 
            // tabPage10
            // 
            tabPage10.Controls.Add(candidateList);
            tabPage10.Location = new Point(4, 54);
            tabPage10.Name = "tabPage10";
            tabPage10.Padding = new Padding(3);
            tabPage10.Size = new Size(939, 630);
            tabPage10.TabIndex = 1;
            tabPage10.Text = "Lista kandydatów";
            tabPage10.UseVisualStyleBackColor = true;
            // 
            // candidateList
            // 
            candidateList.Dock = DockStyle.Fill;
            candidateList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            candidateList.Location = new Point(3, 3);
            candidateList.Margin = new Padding(4);
            candidateList.Name = "candidateList";
            candidateList.Size = new Size(933, 624);
            candidateList.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tabControl3);
            tabPage3.Location = new Point(4, 54);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(953, 694);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Komitet";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            tabControl3.Controls.Add(tabPage7);
            tabControl3.Controls.Add(tabPage8);
            tabControl3.Dock = DockStyle.Fill;
            tabControl3.ItemSize = new Size(200, 50);
            tabControl3.Location = new Point(3, 3);
            tabControl3.Name = "tabControl3";
            tabControl3.Padding = new Point(40, 3);
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(947, 688);
            tabControl3.TabIndex = 0;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(comiteeRegisterForm);
            tabPage7.Location = new Point(4, 54);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(939, 630);
            tabPage7.TabIndex = 0;
            tabPage7.Text = "Zarejestruj";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // comiteeRegisterForm
            // 
            comiteeRegisterForm.Dock = DockStyle.Fill;
            comiteeRegisterForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comiteeRegisterForm.Location = new Point(3, 3);
            comiteeRegisterForm.Margin = new Padding(0);
            comiteeRegisterForm.Name = "comiteeRegisterForm";
            comiteeRegisterForm.Size = new Size(933, 624);
            comiteeRegisterForm.TabIndex = 0;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(comiteeList);
            tabPage8.Location = new Point(4, 54);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(939, 630);
            tabPage8.TabIndex = 1;
            tabPage8.Text = "Lista komitetów";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // comiteeList
            // 
            comiteeList.Dock = DockStyle.Fill;
            comiteeList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comiteeList.Location = new Point(3, 3);
            comiteeList.Margin = new Padding(4);
            comiteeList.Name = "comiteeList";
            comiteeList.Size = new Size(933, 624);
            comiteeList.TabIndex = 0;
            // 
            // tabPage11
            // 
            tabPage11.Controls.Add(votingResults);
            tabPage11.Location = new Point(4, 54);
            tabPage11.Name = "tabPage11";
            tabPage11.Size = new Size(953, 694);
            tabPage11.TabIndex = 3;
            tabPage11.Text = "Wyniki";
            tabPage11.UseVisualStyleBackColor = true;
            // 
            // votingResults
            // 
            votingResults.Dock = DockStyle.Fill;
            votingResults.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            votingResults.Location = new Point(0, 0);
            votingResults.Margin = new Padding(4);
            votingResults.Name = "votingResults";
            votingResults.Size = new Size(953, 694);
            votingResults.TabIndex = 0;
            // 
            // DistrictWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 752);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "DistrictWindow";
            Text = "DistrictWindow";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabControl4.ResumeLayout(false);
            tabPage9.ResumeLayout(false);
            tabPage10.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
            tabPage8.ResumeLayout(false);
            tabPage11.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabControl tabControl2;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private VoterRegisterForm voterRegisterForm;
        private CustomList voterList;
        private TabPage tabPage4;
        private TabControl tabControl3;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private UserControls.ComiteeRegisterForm comiteeRegisterForm;
        private CustomList comiteeList;
        private TabControl tabControl4;
        private TabPage tabPage9;
        private TabPage tabPage10;
        private CandidateRegisterForm candidateRegisterForm;
        private CustomList candidateList;
        private VotingRegistrationForm votingRegistrationForm;
        private TabPage tabPage11;
        private VotingResults votingResults;
    }
}