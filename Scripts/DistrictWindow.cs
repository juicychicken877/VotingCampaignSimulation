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
            votingResults.Update(district.GetVotes());
            // If there are any results, display it
            if (district.GetPreviousCampaignResults() != null)
                votingResults.DisplayResults(district.GetPreviousCampaignResults());

            // Lists in tabs
            // Cast to IListElement
            List<IListElement> candidates = district.GetCandidates().Cast<IListElement>().ToList();
            List<IListElement> comitees = district.GetComitees().Cast<IListElement>().ToList();
            List<IListElement> voters = district.GetVoters().Cast<IListElement>().ToList();

            // Display list
            comiteeList.LoadList(comitees);
            candidateList.LoadList(candidates);
            voterList.LoadList(voters);

            // Update combo box in candidate register form
            candidateRegisterForm.UpdateComitees(district.GetComitees());

            districtRef = district;
        }

        private void EndVotingCampaign(object? sender, EventArgs e) {
            // Display results and set campaign results
            districtRef.SetPreviousCampaignResults(votingResults.DisplayResults(districtRef.GetVotes()));

            districtRef.ClearVotes();

            votingResults.Update(districtRef.GetVotes());

            JSONHandler.SaveDistrictDataToJSON(districtRef);
        }

        private void VotingSystem_OnVote(object? sender, VotingSystem.OnVoteEventArgs e) {
            districtRef.AddVote(e.newVote);

            votingResults.Update(districtRef.GetVotes());

            JSONHandler.SaveDistrictDataToJSON(districtRef);
        }

        private void RegisterVoter(VoterRegisterForm form) {
            if (form.IsCorrect(districtRef.GetVoters())) {
                Voter newVoter = form.GetVoterObject();

                districtRef.AddVoter(newVoter);

                voterList.AddListElement(newVoter);

                form.Clear();

                JSONHandler.SaveDistrictDataToJSON(districtRef);
            }
        }

        private void RegisterComitee(ComiteeRegisterForm form) {
            if (form.IsCorrect(districtRef.GetComitees())) {
                Comitee newComitee = form.GetComiteeObject();

                districtRef.AddComitee(newComitee);

                comiteeList.AddListElement(newComitee);

                form.Clear();

                candidateRegisterForm.UpdateComitees(districtRef.GetComitees());

                JSONHandler.SaveDistrictDataToJSON(districtRef);
            }
        }
        private void RegisterCandidate(CandidateRegisterForm form) {
            if (form.IsCorrect(districtRef.GetCandidates())) {
                Candidate newCandidate = form.GetCandidateObject();

                districtRef.AddCandidate(newCandidate);

                candidateList.AddListElement(newCandidate);

                form.Clear();

                JSONHandler.SaveDistrictDataToJSON(districtRef);
            }
        }
    }
}
