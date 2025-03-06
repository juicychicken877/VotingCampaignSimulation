using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wybory.Scripts {
    public static class VotingSystem {
        public class Vote {
            public Voter voter { get; set; }
            public Candidate candidate { get; set; }

            public Vote() { }
            public Vote(Voter voter, Candidate candidate) {
                this.voter = voter;
                this.candidate = candidate;
            }
        }

        public static event EventHandler<OnVoteEventArgs> OnVote;

        public class OnVoteEventArgs : EventArgs {
            public Vote newVote;
        }

        public delegate void RegistrationHandler(VotingRegistrationForm form);
        public delegate void VotingHandler(VotingWindow votingWindow);

        public static void RegisterVoterInVotingSystem(VotingRegistrationForm form) {
            if (form.IsCorrect()) {
                VotingWindow newVotingWindow = new(form.currentVoter, form.districtRef);

                newVotingWindow.VotingHandler += HandleVoting;

                newVotingWindow.Show();

                form.Clear();
            }
        }

        public static void HandleVoting(VotingWindow votingWindow) {
            if (votingWindow.IsCorrect()) {
                Vote newVote = new(votingWindow.voterRef, votingWindow.GetSelectedCandidate());

                OnVote?.Invoke(null, new OnVoteEventArgs() { newVote = newVote });

                votingWindow.Close();
            }
        }

    }
}
