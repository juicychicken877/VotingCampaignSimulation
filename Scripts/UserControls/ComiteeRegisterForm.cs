using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wybory.Scripts.UserControls {
    public partial class ComiteeRegisterForm : UserControl {
        public DistrictWindow.ComiteeRegistrationHandler ComiteeRegistrationHandler;

        private readonly int NAME_MIN_LENGTH = 10;
        public ComiteeRegisterForm() {
            InitializeComponent();
        }

        public bool IsCorrect(List<Comitee> currentComitees) {
            string name = nameInput.Text;

            // Check name
            if (name == "" || name.Length < NAME_MIN_LENGTH) {
                errorProvider.SetError(nameInput, $"Nazwa musi być >= {NAME_MIN_LENGTH}");
                return false;
            } else {
                if (currentComitees.Find(comitee => comitee.name == name) != null) {
                    errorProvider.SetError(nameInput, $"Komitet z taką nazwą już istnieje");
                    return false;
                }

                errorProvider.SetError(nameInput, null);
            }

            return true;
        }

        public Comitee GetComiteeObject() {
            Comitee newComitee = new();

            newComitee.name = nameInput.Text;

            return newComitee;
        }

        public void Clear() {
            nameInput.Text = "";
        }

        private void registerBtn_Click(object sender, EventArgs e) {
            ComiteeRegistrationHandler?.Invoke(this);
        }
    }
}
