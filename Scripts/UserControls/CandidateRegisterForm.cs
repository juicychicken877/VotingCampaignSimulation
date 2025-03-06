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
    public partial class CandidateRegisterForm : UserControl {
        public DistrictWindow.CandidateRegistrationHandler CandidateRegistrationHandler;

        private readonly int NAME_MIN_LENGTH = 3;
        private List<Comitee> currentComiteesRef = null;
        public CandidateRegisterForm() {
            InitializeComponent();
        }

        public void UpdateComitees(List<Comitee> currentComitees) {
            comiteeComboBox.Items.Clear();

            comiteeComboBox.DataSource = currentComitees;
            comiteeComboBox.DisplayMember = "name";
            comiteeComboBox.ValueMember = "name";
            comiteeComboBox.SelectedItem = null;

            currentComiteesRef = currentComitees;
        }

        private string CheckName(string name) {
            // Check first name
            if (name.Length < NAME_MIN_LENGTH) {
                return $"Imię musi być >= {NAME_MIN_LENGTH}";
            } else {
                foreach (char ch in name) {
                    if (!char.IsLetter(ch)) {
                        return "Niedozwolone znaki";
                    }
                }

                return null;
            }
        }

        public bool IsCorrect(List<Candidate> currentCandidates) {
            string PESEL = peselInput.Text;
            string firstName = firstNameInput.Text;
            string secondName = secondNameInput.Text;

            // Check PESEL
            if (PESEL.Length != 11) {
                errorProvider.SetError(peselInput, "Nieprawidłowy PESEL");
                return false;
            } else {
                if (currentCandidates.Find(candidate => candidate.PESEL == PESEL) != null) {
                    errorProvider.SetError(peselInput, "Wyborca z tym numerem PESEL jest już zarejestrowany");
                    return false;
                } else {
                    foreach (char ch in PESEL) {
                        if (!char.IsDigit(ch)) {
                            errorProvider.SetError(peselInput, "Nieprawidłowy PESEL");
                            return false;
                        }
                    }

                    errorProvider.SetError(peselInput, null);
                }

                errorProvider.SetError(peselInput, null);
            }

            // Check first name
            string message = CheckName(firstName);
            if (message != null) {
                errorProvider.SetError(firstNameInput, message);
                return false;
            } else errorProvider.SetError(firstNameInput, null);

            // Check second name
            message = CheckName(secondName);
            if (message != null) {
                errorProvider.SetError(secondNameInput, message);
                return false;
            } else errorProvider.SetError(secondNameInput, null);

            // Check political party
            if (politicalPartyComboBox.SelectedItem == null) {
                errorProvider.SetError(politicalPartyComboBox, $"Zaznacz przynależność do partii politycznej");
                return false;
            } else {
                errorProvider.SetError(politicalPartyComboBox, null);
            }
            // Check selected comitee
            if (comiteeComboBox.SelectedValue == null) {
                errorProvider.SetError(comiteeComboBox, $"Zaznacz przynależność do komitetu");
                return false;
            } else {
                errorProvider.SetError(comiteeComboBox, null);
            }

            return true;
        }

        public Candidate GetCandidateObject() {
            Candidate newCandidate = new();

            newCandidate.PESEL = peselInput.Text;
            newCandidate.firstName = firstNameInput.Text;
            newCandidate.secondName = secondNameInput.Text;
            newCandidate.dateOfBirth = birthDatePicker.Value;
            newCandidate.politicalParty = politicalPartyComboBox.SelectedItem.ToString();
            newCandidate.comitee = currentComiteesRef.Find(currentComitee => currentComitee.name == comiteeComboBox.SelectedValue.ToString());

            return newCandidate;
        }

        public void Clear() {
            peselInput.Clear();
            firstNameInput.Clear();
            secondNameInput.Clear();
            birthDatePicker.Value = DateTime.Today;
            politicalPartyComboBox.SelectedItem = null;
            comiteeComboBox.SelectedItem = null;
        }

        private void registerBtn_Click(object sender, EventArgs e) {
            CandidateRegistrationHandler?.Invoke(this);
        }
    }
}
