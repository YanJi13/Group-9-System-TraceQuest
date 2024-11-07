using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trace_Quest {
    public partial class Quest03Form : Form {

        private DBConnection dbConnection;
        private MainMenuGUI mainMenuGUI;
        private const int quest03Reward = 500; // this is the gold reward u get from quest 3

        public Quest03Form(MainMenuGUI mainMenu) {

            InitializeComponent();
            dbConnection = new DBConnection();
            mainMenuGUI = mainMenu;
        }

        private void ct03AnswerButton_Click(object sender, EventArgs e) {

            string userInput = codeTracing03TextBox.Text;
            int parsedUserInput;

            if (int.TryParse(userInput, out parsedUserInput)) {

                if (parsedUserInput == mindBreaker()) {

                    MessageBox.Show("You resist the spell and finally put Robin Dabank to justice!");
                    codeTracing03TextBox.Clear();
                    using (SqlConnection conn = dbConnection.connection) {

                        conn.Open();
                        SqlCommand comm = new SqlCommand("insert into GoldCollectedTable (Gold_Collected) values (@quest03Reward)", conn);
                        comm.Parameters.AddWithValue("@quest03Reward", quest03Reward);
                        comm.ExecuteNonQuery();
                    }
                    mainMenuGUI.GetTotalGold();
                } else {

                    MessageBox.Show("Your mind is broken! Robin Dabank gets away!");
                    codeTracing03TextBox.Clear();
                }
            }
            else {

                MessageBox.Show("Your mind is broken! Robin Dabank gets away!");
                codeTracing03TextBox.Clear();
            }

        }

        // this method is another example of imperative programming
        // uses nested if else statements instead of loops

        // its only purpose is to mess with your mind, I didnt even bother tracing it
        // I just plugged it in my IDE to see the correct answer LMAO

        private int mindBreaker() {

            int nine = 10;
            int three = 2;
            int seven = 5;
            int five = 1;

            for (int one = 0; one < nine; one++) {
                if (three > five) {
                    if (seven < three) {
                        three += five;
                    }
                    else {
                        five += seven;
                    }
                }
                else if (five < three) {
                    if (seven > three) {
                        seven += nine;
                    }
                    else {
                        three += seven;
                    }
                }
            }

            return three + seven + five; // output is 13
        }
    }
}
