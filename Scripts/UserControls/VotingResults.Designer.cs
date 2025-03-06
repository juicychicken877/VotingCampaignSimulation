namespace Wybory.Scripts {
    partial class VotingResults {
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
            voteCountLabel = new Label();
            endVotingBtn = new Button();
            label1 = new Label();
            votingResultsCandidateList = new CustomList();
            SuspendLayout();
            // 
            // voteCountLabel
            // 
            voteCountLabel.Location = new Point(0, 18);
            voteCountLabel.Name = "voteCountLabel";
            voteCountLabel.Padding = new Padding(10, 10, 0, 0);
            voteCountLabel.Size = new Size(944, 54);
            voteCountLabel.TabIndex = 1;
            voteCountLabel.Text = "Oddane głosy w aktualnych wyborach (w okręgu): 0";
            // 
            // endVotingBtn
            // 
            endVotingBtn.Location = new Point(4, 91);
            endVotingBtn.Name = "endVotingBtn";
            endVotingBtn.Size = new Size(516, 50);
            endVotingBtn.TabIndex = 2;
            endVotingBtn.Text = "Zakończ aktualną kampanie wyborczą";
            endVotingBtn.UseVisualStyleBackColor = true;
            endVotingBtn.Click += endVotingBtn_Click;
            // 
            // label1
            // 
            label1.Location = new Point(-1, 164);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 10, 0, 0);
            label1.Size = new Size(944, 54);
            label1.TabIndex = 3;
            label1.Text = "Wyniki ostatnich wyborów:";
            // 
            // votingResultsCandidateList
            // 
            votingResultsCandidateList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            votingResultsCandidateList.Location = new Point(4, 222);
            votingResultsCandidateList.Margin = new Padding(4);
            votingResultsCandidateList.Name = "votingResultsCandidateList";
            votingResultsCandidateList.Size = new Size(939, 448);
            votingResultsCandidateList.TabIndex = 4;
            // 
            // VotingResults
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(votingResultsCandidateList);
            Controls.Add(label1);
            Controls.Add(endVotingBtn);
            Controls.Add(voteCountLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "VotingResults";
            Size = new Size(947, 688);
            ResumeLayout(false);
        }

        #endregion

        private Label voteCountLabel;
        private Button endVotingBtn;
        private Label label1;
        private CustomList votingResultsCandidateList;
    }
}
