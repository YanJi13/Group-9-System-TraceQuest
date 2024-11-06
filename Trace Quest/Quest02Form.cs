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
    public partial class Quest02Form : Form {

        public Quest02Form() {
            InitializeComponent();
        }

        private void ct02AnswerButton_Click(object sender, EventArgs e) {

            string userInput = codeTracing02TextBox.Text;
            int parsedUserInput;

            if (int.TryParse(userInput, out parsedUserInput) ) {

                if (parsedUserInput == Riddle(9, 4, 0, 13, 4)) { // 9, 4, 0, 13, and 4 is the key to the puzzle

                    MessageBox.Show("You have successfully solved the riddle!");
                    codeTracing02TextBox.Clear();
                } else {

                    MessageBox.Show("Wrong answer!");
                    codeTracing02TextBox.Clear();
                }
            } else {

                MessageBox.Show("Wrong answer!");
                codeTracing02TextBox.Clear();
            }

        }

        // this one right here is an example of the usage of the functional programming paradigm
        // it has immutability, the returned output is only based on its input and doesnt modify and external state
        // and it has no side effects since it doesnt interact with other parts of the program
        
        // NOTE: since the function is needed to interact with the user interface, PURE functional programming cannot be achieved
        // ,but I do believe its good enough 

        public static int Riddle(int v, int w, int x, int y, int z) {

            return ((v * w) / (x + y)) - z;
        }

        // and yes I'm fully aware of the code snippet shown in the archaeology quest, its intentional
        // its to make things clearer to read, especially since the target audience are young programmers
    }
}
