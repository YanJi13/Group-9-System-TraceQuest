using System;
using System.Windows.Forms;

namespace Trace_Quest {
    public partial class MainMenuGUI : Form {

        Quest01Form questOneForm = new Quest01Form();
        Quest02Form questTwoForm = new Quest02Form();
        Quest03Form questThreeForm = new Quest03Form();

        public MainMenuGUI() {
            InitializeComponent();
        }

        private void questPoster01Button_Click(object sender, System.EventArgs e) {

            questOneForm.ShowDialog();
        }

        private void questPoster02Button_Click(object sender, System.EventArgs e) {

            questTwoForm.ShowDialog();
        }

        private void questPoster03Button_Click(object sender, System.EventArgs e) {

            questThreeForm.ShowDialog();
        }
    }
}
