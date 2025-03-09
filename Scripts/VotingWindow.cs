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
    public partial class VotingWindow : Form {
        public VotingSystem.VotingHandler VotingHandler;
        public Voter voterRef { get; private set; }
        public District districtRef { get; private set; }

        public VotingWindow(Voter voter, District district) {
            InitializeComponent();

            candidatesComboBox.DataSource = district.candidates;
            candidatesComboBox.DisplayMember = "fullName";
            candidatesComboBox.ValueMember = "PESEL";
            candidatesComboBox.SelectedItem = null;

            peselLabel.Text = $"Osoba głosująca: {voter.PESEL}";

            voterRef = voter;
            districtRef = district;
        }

        public bool IsCorrect() {
            if (candidatesComboBox.SelectedItem == null) {
                errorProvider.SetError(candidatesComboBox, $"Wybierz kandydata");
                return false;
            } else {
                return true;
            }
        }

        public Candidate GetSelectedCandidate() {
            return districtRef.candidates.Find(candidate => candidate.PESEL == candidatesComboBox.SelectedValue.ToString());
        }

        private void voteBtn_Click(object sender, EventArgs e) {
            VotingHandler?.Invoke(this);
        }
    }
}
