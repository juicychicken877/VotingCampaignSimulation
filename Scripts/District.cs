namespace Wybory.Scripts {
    public class District {
        public string name;
        private string jsonFileName;
        private List<Voter> voters = new();
        private List<Comitee> comitees = new();
        private List<Candidate> candidates = new();
        private List<VotingSystem.Vote> votes = new();
        private List<VotingResults.Result> previousCampaignResults = new();

        public District(DistrictJSON districtJSON) {
            this.name = districtJSON.name;
            this.jsonFileName = districtJSON.jsonFileName;
            this.voters = districtJSON.voters;
            this.comitees = districtJSON.comitees;
            this.candidates = districtJSON.candidates;
            this.votes = districtJSON.votes;
            this.previousCampaignResults = districtJSON.previousCampaignResults;
        }
        public void AddVote(VotingSystem.Vote newVote) {
            votes.Add(newVote);
        }
        public void AddVoter(Voter newVoter) {
            voters.Add(newVoter);
        }
        public void AddComitee(Comitee newComitee) {
            comitees.Add(newComitee);
        }
        public void AddCandidate(Candidate newCandidate) {
            candidates.Add(newCandidate);
        }
        public List<VotingSystem.Vote> GetVotes() {
            return votes;
        }
        public void ClearVotes() {
            votes.Clear();
        }
        public List<Voter> GetVoters() {
            return voters;
        }
        public List<Comitee> GetComitees() {
            return comitees;
        }
        public List<Candidate> GetCandidates() {
            return candidates;
        }
        public List<VotingResults.Result> GetPreviousCampaignResults() {
            return previousCampaignResults;
        }
        public void SetPreviousCampaignResults(List<VotingResults.Result> newResults) {
            previousCampaignResults = newResults;
        }
        public string GetJSONFileName() {
            return jsonFileName;
        }
    }
    public class Voter : IListElement {
        public string PESEL { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string fullName { get { return $"{firstName} {secondName}"; } }
        public DateTime dateOfBirth { get; set; }

        public string[] GetListInfo() {
            string[] info = [
                PESEL,
                fullName,
                dateOfBirth.ToShortDateString()
            ];

            return info;
        }
    }

    public class Comitee : IListElement {
        public string name { get; set; }

        public string[] GetListInfo() {
            string[] info = [
                name
            ];

            return info;
        }

    }

    public class Candidate : IListElement {
        public string PESEL { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string fullName { get { return $"{firstName} {secondName}"; } }
        public string politicalParty { get; set; }
        public Comitee comitee { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string[] GetListInfo() {
            string[] info = [
                fullName,
                dateOfBirth.ToShortDateString(),
                politicalParty
            ];

            return info;
        }
    }
}
