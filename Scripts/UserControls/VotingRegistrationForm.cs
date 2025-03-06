using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wybory.Scripts {
    public partial class VotingRegistrationForm : UserControl {
        public VotingSystem.RegistrationHandler VotingSystemRegistrationHandler;
        public District districtRef { get; set; }
        public Voter currentVoter { get; private set; }
        public VotingRegistrationForm() {
            InitializeComponent();
        }

        public bool IsCorrect() {
            Voter voter = districtRef.GetVoters().Find(voter => voter.PESEL == peselInput.Text);

            if (voter != null) {
                // Go through vote list in district and check if voter already voted
                if (districtRef.GetVotes().Find(vote => vote.voter.PESEL == voter.PESEL) == null) {
                    errorProvider.SetError(peselInput, null);
                    currentVoter = voter;
                    return true;
                } else {
                    errorProvider.SetError(peselInput, "Ta osoba już głosowała.");
                    currentVoter = null;
                    return false;
                }
                
            } else {
                errorProvider.SetError(peselInput, "Wyborca o takim peselu nie istnieje. Zarejestruj się by oddać głos.");
                currentVoter = null;
                return false;
            }

        }

        public void Clear() {
            peselInput.Text = "";
        }

        private void continueBtn_Click(object sender, EventArgs e) {
            VotingSystemRegistrationHandler?.Invoke(this);
        }
    }
}
