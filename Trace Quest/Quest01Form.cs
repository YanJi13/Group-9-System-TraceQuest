using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trace_Quest {
    public partial class Quest01Form : Form {

        public Quest01Form() {
            InitializeComponent();
        }

        public string findTrueName() {

            // this method is an example of imperative programming
            // uses nested for loops and an if statement

            // this one basically finds duplicates in the array

            char[] name = { 'y', 'b', 'c', 'a', 'h', 'd', 'n', 'r', 'e', 'w', 
                'j', 'i', 'y', 'f', 'a', 'p', 'n', 't', 'x', 'j', 'l', 'i' };
            string trueName = "";

            for (int c = 0; c < name.Length; c++) {
                for (int d = c + 1; d < name.Length; d++) {
                    if (name[c] == name[d]) {
                        trueName += name[d];
                    }
                }
            }
            return trueName;
        }

        private void ct01AnswerButton_Click(object sender, EventArgs e) {

            string userInput = codeTracing01TextBox.Text;
            string trueName = findTrueName();

            if (userInput == trueName) {

                MessageBox.Show("You have successfully banished the demon!");
                codeTracing01TextBox.Clear();
            } else {

                MessageBox.Show("That is not the true name!");
                codeTracing01TextBox.Clear();
            }
        }
    }
}
