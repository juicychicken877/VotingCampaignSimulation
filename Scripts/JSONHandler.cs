using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Wybory.Scripts {
    public static class JSONHandler {
        private static readonly string DISTRICT_DATA_DIR_PATH = "D:/LOCAL_Humansoft/Wybory/Data/DistrictData/";
        public static void SaveDistrictDataToJSON(District district) {
            try {
                DistrictJSON districtJSON = new(district);

                string jsonString = JsonSerializer.Serialize(districtJSON, new JsonSerializerOptions() { WriteIndented = true });
                string path = DISTRICT_DATA_DIR_PATH + district.GetJSONFileName();
                File.WriteAllText(path, jsonString);
            } catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }
        private static District ConvertToDistrict(DistrictJSON districtJSON) {
            // If null, create empty list
            districtJSON.voters ??= new();
            districtJSON.comitees ??= new();
            districtJSON.candidates ??= new();
            districtJSON.votes ??= new();

            return new District(districtJSON);
        }
        public static List<District> LoadDistrictsFromJSON() {
            List<District> loadedDistricts = new();

            try {
                string[] fileNames = Directory.GetFiles(DISTRICT_DATA_DIR_PATH);

                foreach (string fileName in fileNames) {
                    string jsonString = File.ReadAllText(fileName);

                    DistrictJSON districtJSON = JsonSerializer.Deserialize<DistrictJSON>(jsonString);

                    loadedDistricts.Add(ConvertToDistrict(districtJSON));
                }

                return loadedDistricts;
            } catch (Exception ex) {
                Debug.WriteLine(ex.Message);

                return null;
            }
        }
    }

    // Special class for json handling 
    public class DistrictJSON {
        public string name { get; set; }
        public string jsonFileName { get; set; }
        public List<Voter> voters { get; set; }
        public List<Comitee> comitees { get; set; }
        public List<Candidate> candidates { get; set; }
        public List<VotingSystem.Vote> votes { get; set; }
        public List<VotingResults.Result> previousCampaignResults { get; set; }
        public DistrictJSON() { }

        public DistrictJSON(District district) {
            this.name = district.name;
            this.jsonFileName = district.GetJSONFileName();
            this.voters = district.GetVoters();
            this.comitees = district.GetComitees();
            this.candidates = district.GetCandidates();
            this.votes = district.GetVotes();
            this.previousCampaignResults = district.GetPreviousCampaignResults();
        }
    }

}
