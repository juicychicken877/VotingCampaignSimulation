namespace Wybory.Scripts {
    public class District {
        public string name { get; set; }
        public string jsonFileName { get; set; }
        public List<Voter> voters { get; set; }
        public List<Comitee> comitees { get; set; }
        public List<Candidate> candidates { get; set; }
        public List<VotingSystem.Vote> votes { get; set; }
        public List<VotingResults.Result> previousCampaignResults { get; set; }

        public District() { }
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
