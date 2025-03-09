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
using Wybory.Scripts.UserControls;

namespace Wybory.Scripts {
    public partial class DistrictWindow : Form {
        public delegate void VoterRegistrationHandler(VoterRegisterForm form);
        public delegate void ComiteeRegistrationHandler(ComiteeRegisterForm form);
        public delegate void CandidateRegistrationHandler(CandidateRegisterForm form);

        private District districtRef;
        public DistrictWindow(District district) {
            InitializeComponent();
            // Set window title
            this.Text = $"Okręg wyborczy - {district.name}";

            // Set delegates to registeration forms
            voterRegisterForm.VoterRegistrationHandler += RegisterVoter;
            comiteeRegisterForm.ComiteeRegistrationHandler += RegisterComitee;
            candidateRegisterForm.CandidateRegistrationHandler += RegisterCandidate;

            votingRegistrationForm.VotingSystemRegistrationHandler += VotingSystem.RegisterVoterInVotingSystem;
            votingRegistrationForm.districtRef = district;

            // Voting System
            VotingSystem.OnVote += VotingSystem_OnVote;

            // Voting Results
            votingResults.OnEndCampaignBtnClicked += EndVotingCampaign;
            votingResults.Update(district.votes);
            // If there are any results, display it
            if (district.previousCampaignResults != null)
                votingResults.DisplayResults(district.previousCampaignResults);

            // Display lists
            comiteeList.LoadList(district.comitees.Cast<IListElement>().ToList());
            candidateList.LoadList(district.candidates.Cast<IListElement>().ToList());
            voterList.LoadList(district.voters.Cast<IListElement>().ToList());

            // Update combo box in candidate register form
            candidateRegisterForm.UpdateComitees(district.comitees);

            districtRef = district;
        }

        private void EndVotingCampaign(object? sender, EventArgs e) {
            // Display results and set campaign results
            districtRef.previousCampaignResults = votingResults.DisplayResults(districtRef.votes);

            districtRef.votes.Clear();

            votingResults.Update(districtRef.votes);

            JSONHandler.SaveDistrictDataToJSON(districtRef);
        }

        private void VotingSystem_OnVote(object? sender, VotingSystem.OnVoteEventArgs e) {
            districtRef.votes.Add(e.newVote);

            votingResults.Update(districtRef.votes);

            JSONHandler.SaveDistrictDataToJSON(districtRef);
        }

        private void RegisterVoter(VoterRegisterForm form) {
            if (form.IsCorrect(districtRef.voters)) {
                Voter newVoter = form.GetVoterObject();

                districtRef.voters.Add(newVoter);

                voterList.AddListElement(newVoter);

                form.Clear();

                JSONHandler.SaveDistrictDataToJSON(districtRef);
            }
        }

        private void RegisterComitee(ComiteeRegisterForm form) {
            if (form.IsCorrect(districtRef.comitees)) {
                Comitee newComitee = form.GetComiteeObject();

                districtRef.comitees.Add(newComitee);

                comiteeList.AddListElement(newComitee);

                form.Clear();

                candidateRegisterForm.UpdateComitees(districtRef.comitees);

                JSONHandler.SaveDistrictDataToJSON(districtRef);
            }
        }
        private void RegisterCandidate(CandidateRegisterForm form) {
            if (form.IsCorrect(districtRef.candidates)) {
                Candidate newCandidate = form.GetCandidateObject();

                districtRef.candidates.Add(newCandidate);

                candidateList.AddListElement(newCandidate);

                form.Clear();

                JSONHandler.SaveDistrictDataToJSON(districtRef);
            }
        }
    }
}
