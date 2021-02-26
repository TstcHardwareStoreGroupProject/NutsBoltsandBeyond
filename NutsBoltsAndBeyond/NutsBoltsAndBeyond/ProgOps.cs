using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutsBoltsAndBeyond
{
    class ProgOps
    {
        #region Database Open/Close

        public static SqlConnection _dbConnect;

        public static void ConnectDB()
        {
            _dbConnect = new SqlConnection(Utils.CONNECT_STRING);

            try
            {
                if (_dbConnect.State == ConnectionState.Closed) _dbConnect.Open();
                // For test only
                MessageBox.Show("Connection Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "There was a problem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public static void CloseDB()
        {
            _dbConnect.Close();
            _dbConnect.Dispose();
        }

        #endregion

    }
}
