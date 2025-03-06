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
    public partial class CustomListElement : UserControl {
        private readonly int SPACES_BETWEEN = 6;
        public CustomListElement(string[] info) {
            InitializeComponent();

            string fullText = "";

            foreach (string word in info) {
                fullText += word + GetSpaces();
            }

            label.Text = fullText;
        }

        private string GetSpaces() {
            string spaces = "";

            for (int i=0; i<SPACES_BETWEEN; i++) {
                spaces += " ";
            }

            return spaces;
        }
    }
}
