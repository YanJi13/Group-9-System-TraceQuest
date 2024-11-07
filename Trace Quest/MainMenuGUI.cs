using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Trace_Quest {
    public partial class MainMenuGUI : Form {

        Quest01Form questOneForm = new Quest01Form();
        Quest02Form questTwoForm = new Quest02Form();
        Quest03Form questThreeForm = new Quest03Form();

        private DBConnection dbConnection;
        private int totalGold;
        public string totalGoldDisplay;

        public MainMenuGUI() {

            InitializeComponent();
            dbConnection = new DBConnection();
        }

        public void GetTotalGold() {

            using (SqlConnection conn = dbConnection.connection) {
                try {
                    conn.Open();

                    SqlCommand comm = new SqlCommand("SELECT SUM(Gold_Collected) AS TotalGold FROM GoldCollectedTable", conn);

                    object result = comm.ExecuteScalar();
                    totalGold = Convert.ToInt32(result);
                    totalGoldDisplay = Convert.ToString(totalGold);
                }
                catch (Exception ex) {
                    MessageBox.Show($"Error retrieving total gold: {ex.Message}");
                }
            }
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
