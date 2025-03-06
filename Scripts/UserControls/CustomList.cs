using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wybory.Scripts.UserControls;

namespace Wybory.Scripts {
    public partial class CustomList : UserControl {
        public CustomList() {
            InitializeComponent();
        }

        public void LoadList(List<IListElement> listObjects) {
            panel.Controls.Clear();

            foreach (IListElement listObject in listObjects) {
                AddListElement(listObject.GetListInfo());
            }
        }

        public void LoadList(List<string[]> infoList) {
            panel.Controls.Clear();

            foreach (string[] info in infoList) {
                AddListElement(info);
            }
        }

        public void AddListElement(string[] info) {
            CustomListElement newListElement = new(info);
            panel.Controls.Add(newListElement);
        }

        public void AddListElement(IListElement newElement) {
            CustomListElement newListElement = new(newElement.GetListInfo());
            panel.Controls.Add(newListElement);
        }
    }
}
