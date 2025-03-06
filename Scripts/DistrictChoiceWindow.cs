using Wybory.Scripts;

namespace Wybory {
    public partial class DistrictChoiceWindow : Form {
        private List<District> districts = new();

        //private DistrictWindow districtWindowInstance = null;
        public DistrictChoiceWindow() {
            InitializeComponent();

            districts = JSONHandler.LoadDistrictsFromJSON();
        }

        private void OpenDistrictWindow(District district) {
            DistrictWindow newDistrictWindow = new(district);

            newDistrictWindow.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            OpenDistrictWindow(districts[0]);
        }

        private void button2_Click(object sender, EventArgs e) {
            OpenDistrictWindow(districts[1]);
        }

        private void button3_Click(object sender, EventArgs e) {
            OpenDistrictWindow(districts[2]);
        }
    }
}
