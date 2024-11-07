using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Trace_Quest {
    public partial class MainMenuGUI : Form {

        Quest01Form questOneForm;
        Quest02Form questTwoForm;
        Quest03Form questThreeForm;

        private DBConnection dbConnection;
        private SqlConnection conn;
        private int totalGold;
        public string totalGoldDisplay;

        public MainMenuGUI() {

            InitializeComponent();
            dbConnection = new DBConnection();
            conn = dbConnection.connection;
            questOneForm = new Quest01Form(this);
            questTwoForm = new Quest02Form(this);
            questThreeForm = new Quest03Form(this);
            conn.Open();
        }

        public void GetTotalGold() {

            try {

                SqlCommand comm = new SqlCommand("SELECT SUM(Gold_Collected) AS TotalGold FROM GoldCollectedTable", conn);

                object result = comm.ExecuteScalar();
                totalGold = Convert.ToInt32(result);
                totalGoldDisplay = Convert.ToString(totalGold);
                totalGoldLabel.Text = "Gold: " + totalGoldDisplay;
            }
            catch (Exception ex) {
                MessageBox.Show($"Error retrieving total gold: {ex.Message}");
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

        private void MainMenuGUI_Shown(object sender, EventArgs e) {

            GetTotalGold();
        }
    }
}
