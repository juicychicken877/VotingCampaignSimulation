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
        private static readonly string DISTRICT_DATA_DIR_PATH = "../../../Data/DistrictData/";
        public static void SaveDistrictDataToJSON(District district) {
            try {
                string jsonString = JsonSerializer.Serialize(district, new JsonSerializerOptions() { WriteIndented = true });
                string path = DISTRICT_DATA_DIR_PATH + district.jsonFileName;
                File.WriteAllText(path, jsonString);
            } catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }

        private static void CheckForNulls(District district) {
            district.voters ??= new();
            district.votes ??= new();
            district.candidates ??= new();
            district.comitees ??= new();
        }

        public static List<District> LoadDistrictsFromJSON() {
            List<District> loadedDistricts = new();

            try {
                string[] fileNames = Directory.GetFiles(DISTRICT_DATA_DIR_PATH);

                foreach (string fileName in fileNames) {
                    string jsonString = File.ReadAllText(fileName);

                    District district = JsonSerializer.Deserialize<District>(jsonString);

                    CheckForNulls(district);

                    loadedDistricts.Add(district);
                }

                return loadedDistricts;
            } catch (Exception ex) {
                Debug.WriteLine(ex.Message);

                return null;
            }
        }
    }
}
