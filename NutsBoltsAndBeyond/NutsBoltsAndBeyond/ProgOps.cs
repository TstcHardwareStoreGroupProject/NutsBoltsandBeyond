using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
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
                // Not for production
                //MessageBox.Show("Connection Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

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

        #region Initialize

        public static SqlConnection _cntDatabase;
        public static SqlDataAdapter _daRes;

        // shop and cart
        public static DataTable CartTable = new DataTable();
        public static DataTable ShopTable = new DataTable();
        // Global Users
        public static Models.UserModel resetUser = new Models.UserModel();
        public static Models.UserModel currentUser = new Models.UserModel();

        #endregion

        #region Load Methods

        public static void LoadUsers(DataTable _dt, String _query)
        {
            _dt = new DataTable();

            //TODO: Rigged for data normalization... to be fixed...
            ProgOps._daRes = new SqlDataAdapter(_query, _dbConnect);
            ProgOps._daRes.Fill(_dt);

            ProgOps.CloseDB();
        }

        #endregion

        #region Delete Methods

        public static bool _deleteUserFromDB(int ID)
        {
            String del;
            bool flag = false;
            try
            {
                using (_cntDatabase = new SqlConnection(Utils.CONNECT_STRING))
                {
                    del = "DELETE FROM GROUP1SP212330.USERS ";
                    del += "WHERE USER_ID = " + ID;

                    using (SqlCommand cmd = new SqlCommand(del, _cntDatabase))
                    {
                        _cntDatabase.Open();
                        cmd.ExecuteNonQuery();
                    }
                    flag = true;
                    CloseDB();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return flag;
        }

        public static bool _deleteItem(String _id)
        {
            ConnectDB();

            String del;
            bool flag = false;
            try
            {
                using (_cntDatabase = new SqlConnection(Utils.CONNECT_STRING))
                {
                    del = "DELETE FROM GROUP1SP212330.ITEMS ";
                    del += "WHERE ITEM_ID = '" + _id + "'";

                    using (SqlCommand cmd = new SqlCommand(del, _cntDatabase))
                    {
                        _cntDatabase.Open();
                        cmd.ExecuteNonQuery();
                    }
                    flag = true;
                    CloseDB();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return flag;
        }

        #endregion

        #region Save Model Methods

        //Use with try/catch in program to confirm save

        /*
        *   Insert Manager model to DB        
        *   @param: Models.UserModel
        *   @return: void
        */
        public static void _saveUser(Models.UserModel _user)
        {
            String upd;

            _user.ID = Utils._IDGenerator();

            using (_cntDatabase = new SqlConnection(Utils.CONNECT_STRING))
            {
                _cntDatabase.Open();

                upd = "INSERT INTO GROUP1SP212330.USERS ";
                upd += "VALUES(@USER_ID, @FNAME, @LNAME, @USERNAME, @PASSWORD, @DESIGNATION, @EMAIL);";

                using (var cmd = new SqlCommand(upd, _cntDatabase))
                {
                    cmd.Parameters.AddWithValue("@USER_ID", _user.ID);
                    cmd.Parameters.AddWithValue("@FNAME", _user.Fname);
                    cmd.Parameters.AddWithValue("@LNAME", _user.Lname);
                    cmd.Parameters.AddWithValue("@USERNAME", _user.Username);
                    cmd.Parameters.AddWithValue("@PASSWORD", _user.Password);
                    cmd.Parameters.AddWithValue("@DESIGNATION", _user.Designation);
                    cmd.Parameters.AddWithValue("@EMAIL", _user.Email);

                    cmd.ExecuteNonQuery();
                }
                CloseDB();
            }
        }

        /*
        *   Insert Item model to DB        
        *   @param: Models.ItemModel
        *   @return: void
        */
        public static void _saveItems(Models.ItemModel _item)
        {
            ConnectDB();

            String upd;

            _item.ITEM_ID = Utils._IDGenerator();

            using (_cntDatabase = new SqlConnection(Utils.CONNECT_STRING))
            {
                _cntDatabase.Open();
                upd = "INSERT INTO GROUP1SP212330.ITEMS ";
                upd += "VALUES(@ITEM_ID, @ITEM_NAME, @PRICE, @QUANTITY, @DEPARTMENT)";
                using (var cmd = new SqlCommand(upd, _cntDatabase))
                {
                    cmd.Parameters.AddWithValue("@ITEM_ID", _item.ITEM_ID);
                    cmd.Parameters.AddWithValue("@ITEM_NAME", _item.Item_Name);
                    cmd.Parameters.Add("@PRICE", SqlDbType.Money).Value = _item.Price;
                    cmd.Parameters.AddWithValue("@QUANTITY", _item.Quantity);
                    cmd.Parameters.AddWithValue("@DEPARTMENT", _item.Department);

                    cmd.ExecuteNonQuery();
                }
                CloseDB();
            }
        }

        /*
        *   Insert Transactions model to DB        
        *   @param: _orderid, _customerid, _employeeid, _cartid, _purchasedate, _total
        *   @return: void
        */
        public static void _saveTransaction(int _transactionid, int _username, int _itemid, 
            String _purchasedate, int _quantity, String _total)
        {
            String upd;

            
            var date = DateTime.ParseExact(_purchasedate, "yyyy/MM/dd", CultureInfo.InvariantCulture);

            using (_cntDatabase = new SqlConnection(Utils.CONNECT_STRING))
            {
                _cntDatabase.Open();
                upd = "INSERT INTO GROUP1SP212330.ORDERCART ";
                upd += "VALUES(@TRANSACTION_ID, @USERNAME, @ITEM_ID, QUANTITY, @TOTAL, @PURCHASEDATE)";
                using (var cmd = new SqlCommand(upd, _cntDatabase))
                {
                    cmd.Parameters.AddWithValue("@TRANSACTION_ID", _transactionid);
                    cmd.Parameters.AddWithValue("@USERNAME", _username);
                    cmd.Parameters.AddWithValue("@ITEM_ID", _itemid);
                    cmd.Parameters.AddWithValue("@QUANTITY", _quantity);
                    cmd.Parameters.AddWithValue("@PURCHASEDATE", date);
                    cmd.Parameters.Add("@TOTAL", SqlDbType.Money).Value = Decimal.Parse(_total);

                    cmd.ExecuteNonQuery();
                }
                CloseDB();
            }
        }

        #endregion

        #region Update Methods

        public static bool _updateUser(Models.UserModel _user)
        {
            String upd;
            bool flag = false;
            try
            {
                using (_cntDatabase = new SqlConnection(Utils.CONNECT_STRING))
                {
                    _cntDatabase.Open();
                    upd = "UPDATE GROUP1SP212330.USERS ";
                    upd += "SET FNAME = @FNAME, LNAME = @LNAME, " +
                        "USERNAME = @USERNAME, PASSWORD = @PASSWORD, DESIGNATION = @DESIGNATION, EMAIL = @EMAIL";
                    upd += " WHERE USER_ID = @USER_ID";
                    using (var cmd = new SqlCommand(upd, _cntDatabase))
                    {
                        cmd.Parameters.AddWithValue("@USER_ID", _user.ID);
                        cmd.Parameters.AddWithValue("@FNAME", _user.Fname);
                        cmd.Parameters.AddWithValue("@LNAME", _user.Lname);
                        cmd.Parameters.AddWithValue("@USERNAME", _user.Username);
                        cmd.Parameters.AddWithValue("@PASSWORD", _user.Password);
                        cmd.Parameters.AddWithValue("@DESIGNATION", _user.Designation);
                        cmd.Parameters.AddWithValue("@EMAIL", _user.Email);

                        cmd.ExecuteNonQuery();
                    }
                    flag = true;
                    CloseDB();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return flag;
        }

        public static void Reload(DataTable _dt)
        {
            ConnectDB();

            _dt = new DataTable();

            String query = "SELECT * FROM GROUP1SP212330.USERS";

            switch (currentUser.Designation)
            {
                case "Customer":
                    query += $" WHERE USERNAME = '{ProgOps.currentUser.Username}';";
                    break;
                case "Employee":
                    query += " WHERE DESIGNATION = 'Customer';";
                    break;
                case "Admin":
                    if (frmAdminMenu.type == "cus")
                        query += " WHERE DESIGNATION = 'Customer';";
                    else if (frmAdminMenu.type == "emp")
                        query += " WHERE DESIGNATION != 'Customer';";
                    else
                        query += ";";
                    break;
                default:
                    break;
            }

            _dt = new DataTable();

            _daRes = new SqlDataAdapter(query, ProgOps._dbConnect);
            _daRes.Fill(_dt);

            ProgOps.CloseDB();
        }

        #endregion
    }
}
