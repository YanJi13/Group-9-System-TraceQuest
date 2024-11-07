using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trace_Quest {
    public partial class Quest01Form : Form {

        private DBConnection dbConnection;
        private MainMenuGUI mainMenuGUI;
        private const int quest01Reward = 900; // this is the gold reward u get from quest 1

        public Quest01Form(MainMenuGUI mainMenu) {

            InitializeComponent();
            dbConnection = new DBConnection();
            mainMenuGUI = mainMenu;
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

                using(SqlConnection conn = dbConnection.connection) {

                    conn.Open();
                    SqlCommand comm = new SqlCommand("insert into GoldCollectedTable (Gold_Collected) values (@quest01Reward)",conn);
                    comm.Parameters.AddWithValue("@quest01Reward", quest01Reward);
                    comm.ExecuteNonQuery();
                }
                mainMenuGUI.GetTotalGold();

            } else {

                MessageBox.Show("That is not the true name!");
                codeTracing01TextBox.Clear();
            }
        }
    }
}
