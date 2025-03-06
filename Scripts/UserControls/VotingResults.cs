using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wybory.Scripts {
    public partial class VotingResults : UserControl {
        public class Result : IListElement {
            public Candidate candidate { get; set; }
            public int voteCount { get; set; }

            public Result() { }

            public string[] GetListInfo() {
                string[] info = [
                    candidate.fullName,
                    $"Ilość głosów: {voteCount}"
                ];

                return info;
            }
        }
        public event EventHandler OnEndCampaignBtnClicked;

        public VotingResults() {
            InitializeComponent();
        }

        public void Update(List<VotingSystem.Vote> votes) {
            voteCountLabel.Text = $"Oddane głosy w aktualnych wyborach (w okręgu): {votes.Count}";
        }

        public void DisplayResults(List<Result> results) {
            List<IListElement> resultListObjects = results.Cast<IListElement>().ToList();

            // Display list
            votingResultsCandidateList.LoadList(resultListObjects);
        }

        public List<Result> DisplayResults(List<VotingSystem.Vote> votes) {
            List<Result> results = new();

            // Count votes
            foreach (VotingSystem.Vote vote in votes) {
                Result result = results.Find(item => item.candidate.PESEL == vote.candidate.PESEL);

                if (result != null) {
                    result.voteCount += 1;
                } else {
                    Result newResult = new();
                    newResult.candidate = vote.candidate;
                    newResult.voteCount = 1;
                    results.Add(newResult);
                }
            }

            // Sort descending by vote count
            results = results.OrderByDescending(obj => obj.voteCount).ToList();

            List<IListElement> resultListObjects = results.Cast<IListElement>().ToList();

            // Display list
            votingResultsCandidateList.LoadList(resultListObjects);

            return results;
        }

        private void endVotingBtn_Click(object sender, EventArgs e) {
            OnEndCampaignBtnClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
