using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
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
        // TransactionList for Receipts and Admin filtering

        public static SqlConnection _cntDatabase;
        public static SqlDataAdapter _daRes;

        public static DataTable ManagersTable;
        public static DataTable EmployeesTable;
        public static DataTable CustomersTable;
        public static DataTable ProductsTable;
        public static DataTable OrdersTable;
        public static DataTable OrderCartTable;

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

        public static bool _deleteManagerFromDB(int ID)
        {
            String del;
            bool flag = false;

            //S
                try
                {
                    using (_cntDatabase = new SqlConnection(Utils.CONNECT_STRING))
                    {
                        del = "DELETE FROM " + Utils.DB + ".USER_DETAILS ";
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
                catch (Exception)
                {
                    throw;
                }
                return flag;
        }

        #endregion

        #region Save Model Methods

        //Use with try/catch in program to confirm save

        /*
        *   Insert Manager model to DB        
        *   @param: _managerid, _fname, _lname, _address, _zip, _phone
        *   @return: void
        */
        public static void _saveUser(String
            _fname, String _lname, String _username, String _password, String _designation)
        {
            String upd;

            int _id = Utils._IDGenerator();

            using (_cntDatabase = new SqlConnection(Utils.CONNECT_STRING))
            {
                _cntDatabase.Open();

                upd = "INSERT INTO GROUP1SP212330.USERS ";
                upd += "VALUES(@USER_ID, @FNAME, @LNAME, @USERNAME, @PASSWORD, @DESIGNATION);";

                using (var cmd = new SqlCommand(upd, _cntDatabase))
                {
                    cmd.Parameters.AddWithValue("@USER_ID", _id);
                    cmd.Parameters.AddWithValue("@FNAME", _fname);
                    cmd.Parameters.AddWithValue("@LNAME", _lname);
                    cmd.Parameters.AddWithValue("@USERNAME", _username);
                    cmd.Parameters.AddWithValue("@PASSWORD", _password);
                    cmd.Parameters.AddWithValue("@DESIGNATION", _designation);

                    cmd.ExecuteNonQuery();
                }
                CloseDB();
            }
        }

        /*
        *   Insert Employee model to DB        
        *   @param: _employeeid, _managerid, _fname, _lname, _address, _zip, _phone
        *   @return: void
        */
        public static void _saveEmployee(int _employeeid, int _managerid, String
            _fname, String _lname, String _address, String _zip, String _phone)
        {
            String upd;

            _employeeid = Utils._IDGenerator();

            using (_cntDatabase = new SqlConnection(Utils.CONNECT_STRING))
            {
                _cntDatabase.Open();
                upd = "INSERT INTO GROUP1SP212330.EMPLOYEES ";
                upd += "VALUES(@EMPLOYEEID, @MANAGERID, @FNAME, @LNAME, @ADDRESS, @ZIP, @PHONE)";
                using (var cmd = new SqlCommand(upd, _cntDatabase))
                {
                    cmd.Parameters.AddWithValue("@EMPLOYEEID", _employeeid);
                    cmd.Parameters.AddWithValue("@MANAGERID", _managerid);
                    cmd.Parameters.AddWithValue("@FNAME", _fname);
                    cmd.Parameters.AddWithValue("@LNAME", _lname);
                    cmd.Parameters.AddWithValue("@ADDRESS", _address);
                    cmd.Parameters.AddWithValue("@ZIP", _zip);
                    cmd.Parameters.AddWithValue("@PHONE", _phone);

                    cmd.ExecuteNonQuery();
                }
                CloseDB();
            }
        }

        /*
        *   Insert Customer model to DB        
        *   @param: _customerid, _fname, _lname, _address, _zip, _ccnumber, _expdate, _ccv
        *   @return: void
        */
        public static void _saveCustomer(int _customerid, String _fname, String _lname, 
            String _address, String _zip, String _ccnumber, String _expdate, String _ccv)
        {
            String upd;

            _customerid = Utils._IDGenerator();

            using (_cntDatabase = new SqlConnection(Utils.CONNECT_STRING))
            {
                _cntDatabase.Open();
                upd = "INSERT INTO GROUP1SP212330.CUSTOMERS ";
                upd += "VALUES(@CUSTOMERID, @FNAME, @LNAME, @ADDRESS, @ZIP, @CCNUMBER, @EXPDATE, @CCV)";
                using (var cmd = new SqlCommand(upd, _cntDatabase))
                {
                    cmd.Parameters.AddWithValue("@CUSTOMERID", _customerid);
                    cmd.Parameters.AddWithValue("@FNAME", _fname);
                    cmd.Parameters.AddWithValue("@LNAME", _lname);
                    cmd.Parameters.AddWithValue("@ADDRESS", _address);
                    cmd.Parameters.AddWithValue("@ZIP", _zip);
                    cmd.Parameters.AddWithValue("@CCNUMBER", _ccnumber);
                    cmd.Parameters.AddWithValue("@EXPDATE", _expdate);
                    cmd.Parameters.AddWithValue("@CCV", _ccv);

                    cmd.ExecuteNonQuery();
                }
                CloseDB();
            }
        }

        /*
        *   Insert Product model to DB        
        *   @param: _productid, _type, _price
        *   @return: void
        */
        public static void _saveProducts(int _productid, String _type, String _price)
        {
            String upd;

            _productid = Utils._IDGenerator();

            using (_cntDatabase = new SqlConnection(Utils.CONNECT_STRING))
            {
                _cntDatabase.Open();
                upd = "INSERT INTO GROUP1SP212330.PRODUCTS ";
                upd += "VALUES(@PRODUCTID, @TYPE, @PRICE)";
                using (var cmd = new SqlCommand(upd, _cntDatabase))
                {
                    cmd.Parameters.AddWithValue("@PRODUCTID", _productid);
                    cmd.Parameters.AddWithValue("@TYPE", _type);
                    cmd.Parameters.Add("@PRICE", SqlDbType.Money).Value = Decimal.Parse(_price);

                    cmd.ExecuteNonQuery();
                }
                CloseDB();
            }
        }

        /*
        *   Insert OrderCart model to DB        
        *   @param: _cartid _productid, _quantity, _priceperitem
        *   @return: void
        */
        public static void _saveOrderCart(int _cartid, int _productid, int _quantity, String _priceperitem)
        {
            String upd;

            _cartid = Utils._IDGenerator();

            using (_cntDatabase = new SqlConnection(Utils.CONNECT_STRING))
            {
                _cntDatabase.Open();
                upd = "INSERT INTO GROUP1SP212330.ORDERCART ";
                upd += "VALUES(@CARTID, @PRODUCTID, @QUANTITY, @PRICEPERITEM)";
                using (var cmd = new SqlCommand(upd, _cntDatabase))
                {
                    cmd.Parameters.AddWithValue("@CARTID", _cartid);
                    cmd.Parameters.AddWithValue("@PRODUCTID", _productid);
                    cmd.Parameters.AddWithValue("@QUANTITY", _quantity);
                    cmd.Parameters.Add("@PRICEPERITEM", SqlDbType.Money).Value = Decimal.Parse(_priceperitem);

                    cmd.ExecuteNonQuery();
                }
                CloseDB();
            }
        }

        /*
        *   Insert Orders model to DB        
        *   @param: _orderid, _customerid, _employeeid, _cartid, _purchasedate, _total
        *   @return: void
        */
        public static void _saveOrders(int _orderid, int _customerid, int _employeeid, 
            int _cartid, String _purchasedate, String _total)
        {
            String upd;

            _orderid = Utils._IDGenerator();
            var date = DateTime.ParseExact(_purchasedate, "yyyy/MM/dd", CultureInfo.InvariantCulture);

            using (_cntDatabase = new SqlConnection(Utils.CONNECT_STRING))
            {
                _cntDatabase.Open();
                upd = "INSERT INTO GROUP1SP212330.ORDERCART ";
                upd += "VALUES(@ORDERID, @CUSTOMERID, @EMPLOYEEID, @CARTID, @PURCHASEDATE, @TOTAL)";
                using (var cmd = new SqlCommand(upd, _cntDatabase))
                {
                    cmd.Parameters.AddWithValue("@ORDERID", _orderid);
                    cmd.Parameters.AddWithValue("@CUSTOMERID", _customerid);
                    cmd.Parameters.AddWithValue("@EMPLOYEEID", _employeeid);
                    cmd.Parameters.AddWithValue("@EMPLOYEEID", _cartid);
                    cmd.Parameters.AddWithValue("@PURCHASEDATE", date);
                    cmd.Parameters.Add("@TOTAL", SqlDbType.Money).Value = Decimal.Parse(_total);

                    cmd.ExecuteNonQuery();
                }
                CloseDB();
            }
        }

        #endregion
    }
}
