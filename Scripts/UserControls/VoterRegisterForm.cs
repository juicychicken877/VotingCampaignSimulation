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
    public partial class VoterRegisterForm : UserControl {
        public DistrictWindow.VoterRegistrationHandler VoterRegistrationHandler;

        private readonly int NAME_MIN_LENGTH = 3;
        public VoterRegisterForm() {
            InitializeComponent();
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

        public bool IsCorrect(List<Voter> currentVoters) {
            string PESEL = peselInput.Text;
            string firstName = firstNameInput.Text;
            string secondName = secondNameInput.Text;

            // Check PESEL
            if (PESEL.Length != 11) {
                errorProvider.SetError(peselInput, "Nieprawidłowy PESEL");
                return false;
            } else {
                if (currentVoters.Find(voter => voter.PESEL == PESEL) != null) {
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
            } 
            else errorProvider.SetError(secondNameInput, null);

            return true;
        }

        public Voter GetVoterObject() {
            Voter newVoter = new();

            newVoter.PESEL = peselInput.Text;
            newVoter.firstName = firstNameInput.Text;
            newVoter.secondName = secondNameInput.Text;
            newVoter.dateOfBirth = birthDatePicker.Value;

            return newVoter;
        }

        public void Clear() {
            peselInput.Clear();
            firstNameInput.Clear();
            secondNameInput.Clear();
            birthDatePicker.Value = DateTime.Today;
        }

        private void registerBtn_Click(object? sender, EventArgs e) {
            VoterRegistrationHandler?.Invoke(this);
        }
    }
}
