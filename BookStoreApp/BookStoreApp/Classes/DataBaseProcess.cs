using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CSharpCounterFinalProject.Classes
{
    public class DataBaseProcess
    {
        public static string strConnect = "Data Source=DESKTOP-FTUKUSM;Initial Catalog=BTL_LTTQ;Integrated Security=True";

        SqlConnection sqlConnect = null;

        // Open connection
        public SqlConnection GetConnection()
        {
            return new SqlConnection(strConnect);
        }
        public bool Exist(string sql)
        {
            bool check = false;
            DataTable tblData = new DataTable();
            tblData = DataReader(sql);
            if (tblData.Rows.Count > 0)
            {
                check = true;
                return check;
            }
            return check;
        }

        public object ExecuteScalarTransactionQuery(string query, Dictionary<string, object> parameters, SqlConnection connection, SqlTransaction transaction)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, connection, transaction))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }
                    return command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thực thi câu lệnh scalar trong transaction: " + ex.Message);
            }
        }


        // Begin Transaction now returns both connection and transaction
        public (SqlConnection connection, SqlTransaction transaction) BeginTransaction()
        {
            try
            {
                var connection = GetConnection();
                connection.Open();
                var transaction = connection.BeginTransaction();
                return (connection, transaction);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi bắt đầu transaction: " + ex.Message);
            }
        }

        // Modified ExecuteTransactionQuery to use provided connection
        public int ExecuteTransactionQuery(string query, Dictionary<string, object> parameters, SqlConnection connection, SqlTransaction transaction)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, connection, transaction))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thực thi câu lệnh trong transaction: " + ex.Message);
            }
        }

        // Rest of your methods remain the same
        public void ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(strConnect))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                command.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi thực thi truy vấn: " + ex.Message);
                }
            }
        }
        public void OpenConnect()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
            {
                sqlConnect.Open();
            }
        }

        // Close connection
        public void CloseConnect()
        {
            if (sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
                sqlConnect.Dispose();
            }
        }

        // Execute SELECT query
        public DataTable DataReader(string sqlSelect)
        {
            DataTable tblData = new DataTable();
            OpenConnect();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, sqlConnect);
            sqlData.Fill(tblData);
            CloseConnect();
            return tblData;
        }

        public DataTable DataRead(string sqlSelect, Dictionary<string, object> parameters = null)
        {
            DataTable tblData = new DataTable();
            OpenConnect();

            using (SqlCommand cmd = new SqlCommand(sqlSelect, sqlConnect))
            {
                // Thêm parameters nếu có
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                sqlData.Fill(tblData);
            }

            CloseConnect();
            return tblData;
        }

        public int DataChange(string sql)
        {
            int rowsAffected = 0; // Khởi tạo với giá trị mặc định
            try
            {
                OpenConnect();
                using (SqlCommand sqlComma = new SqlCommand(sql, sqlConnect))
                {
                    rowsAffected = sqlComma.ExecuteNonQuery();

                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                Console.WriteLine($"Lỗi SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Xử lý lỗi chung
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            finally
            {
                CloseConnect();
            }
            return rowsAffected;
        }
        public int ExecuteNonQuery(string sql)
        {
            OpenConnect();
            SqlCommand sqlCommand = new SqlCommand
            {
                Connection = sqlConnect,
                CommandText = sql
            };

            // Thực thi câu lệnh và trả về số lượng dòng bị ảnh hưởng (INSERT, UPDATE, DELETE)
            int affectedRows = sqlCommand.ExecuteNonQuery();
            CloseConnect();

            return affectedRows;
        }
        public object ExecuteScalar(string sql)
        {
            OpenConnect();
            SqlCommand sqlCommand = new SqlCommand
            {
                Connection = sqlConnect,
                CommandText = sql
            };

            // Thực thi câu lệnh và trả về một giá trị đơn
            object result = sqlCommand.ExecuteScalar();
            CloseConnect();

            return result;
        }
        public DataTable ExecuteSelectQuery(string query, Dictionary<string, object> parameters)
        {
            using (var connection = new SqlConnection(strConnect))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }

                    using (var dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        // Phương thức thực hiện truy vấn UPDATE, INSERT, DELETE
        public int ExecuteUpdateQuery(string query, Dictionary<string, object> parameters)
        {
            using (var connection = new SqlConnection(strConnect))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    return command.ExecuteNonQuery(); // Trả về số dòng bị ảnh hưởng
                }
            }
        }

    }
}
