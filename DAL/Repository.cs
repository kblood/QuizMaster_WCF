using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;
using System.Transactions;
using System.Text.RegularExpressions;

namespace DAL
{
    public class Repository<T>
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["QuizConnection"].ConnectionString;

        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }

        /// <summary>
        /// This creates a transaction that runs an SQL command string
        /// </summary>
        /// <param name="commandText">SQL command</param>
        /// <returns>0 if failed, higher number is the id of the new table row or it is the number of changed rows</returns>
        public int ExecuteStatement(SqlCommand command)
        {
            // Initialize the return value to zero and create a StringWriter to display results.
            int returnValue = 0;
            System.IO.StringWriter writer = new System.IO.StringWriter();

            try
            {
                using (SqlConnection connection1 = new SqlConnection(connectionString))
                {
                    connection1.Open();

                    command.Connection = connection1;
                    Debug.WriteLine(command.CommandText);

                    //writer.WriteLine(commandText);
                    if (command.CommandText.Contains("Select Scope_Identity()"))
                    {
                        returnValue = Convert.ToInt32(command.ExecuteScalar());
                        writer.WriteLine("Id return by command1: {0}", returnValue);
                    }
                    else
                    {
                        returnValue = command.ExecuteNonQuery();
                    }
                }
            }
            catch (TransactionAbortedException ex)
            {
                writer.WriteLine("TransactionAbortedException Message: {0}", ex.Message);
            }
            catch (ApplicationException ex)
            {
                writer.WriteLine("ApplicationException Message: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                writer.WriteLine("Exception Message: {0}", ex.Message);
            }

            // Display messages.
            Debug.WriteLine(writer.ToString());

            return returnValue;
        }

        public T SingleRead(SqlCommand command)
        {
            // Collect messages to later write to debug
            System.IO.StringWriter writer = new System.IO.StringWriter();

            // Make an outputclass to hold the object the object builder will return.
            T outputClass = default(T);

            try
            {
                using (SqlConnection connection1 = new SqlConnection(connectionString))
                {
                    connection1.Open();
                    command.Connection = connection1;
                    writer.WriteLine(command.CommandText);
                    SqlDataReader reader = command.ExecuteReader();
                    if(reader.Read())
                    {
                        outputClass = ReflectionObjectBuilder(reader);
                    }
                }
            }
            catch (TransactionAbortedException ex)
            {
                writer.WriteLine("TransactionAbortedException Message: {0}", ex.Message);
            }
            catch (ApplicationException ex)
            {
                writer.WriteLine("ApplicationException Message: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                writer.WriteLine("Exception Message: {0}", ex.Message);
            }
            // Display messages.
            Debug.WriteLine(writer.ToString());
            return outputClass;
        }

        public Object SimpleRead(SqlCommand command)
        {
            System.IO.StringWriter writer = new System.IO.StringWriter();
            Object obj = new object();
            try
            {
                using (SqlConnection connection1 = new SqlConnection(connectionString))
                {
                    connection1.Open();

                    command.Connection = connection1;
                    writer.WriteLine(command.CommandText);
                    obj = command.ExecuteScalar();
                }
            }
            catch (TransactionAbortedException ex)
            {
                writer.WriteLine("TransactionAbortedException Message: {0}", ex.Message);
            }
            catch (ApplicationException ex)
            {
                writer.WriteLine("ApplicationException Message: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                writer.WriteLine("Exception Message: {0}", ex.Message);
            }
            // Display messages.
            Debug.WriteLine(writer.ToString());
            return obj;
        }

        public List<T> MultiRead(SqlCommand command)
        {
            List<T> list = new List<T>();
            System.IO.StringWriter writer = new System.IO.StringWriter();

            try
            {
                using (SqlConnection connection1 = new SqlConnection(connectionString))
                {
                    connection1.Open();

                    command.Connection = connection1;
                    writer.WriteLine(command.CommandText);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(ReflectionObjectBuilder(reader));
                    }
                }
            }
            catch (TransactionAbortedException ex)
            {
                writer.WriteLine("TransactionAbortedException Message: {0}", ex.Message);
            }
            catch (ApplicationException ex)
            {
                writer.WriteLine("ApplicationException Message: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                writer.WriteLine("Exception Message: {0}", ex.Message);
            }

            // Display messages.
            Debug.WriteLine(writer.ToString());
            return list;
        }

        public string TrimString(string str)
        {
            Regex rgx = new Regex("[^a-åA-Å0-9 @?:!.-]");
            str = rgx.Replace(str, "");
            char[] MyChar = {' '};
            str = str.TrimStart(MyChar);
            str = str.TrimEnd(MyChar);
            return str;
        }

        /// <summary>
        /// A generic object builder that takes the properties from the reader and puts into a
        /// new object of the same type as the destination object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public T ReflectionObjectBuilder(IDataReader reader)
        {
            //Type sourceType = source.GetType();
            Type destinationType = typeof(T);

            T result = (T)Activator.CreateInstance(destinationType);

            // columns is a list of attribute names in the reader
            var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();

            // We get properties from the destination type instead of the source type
            foreach (PropertyInfo pi in destinationType.GetProperties())
            {
                // set pDest to the currently instanced property type
                var pDest = destinationType.GetProperty(pi.Name);
                if (pDest != null && pDest.CanWrite)
                {
                    // Make sure the current property name can be found in the reader
                    if (columns.Contains(pi.Name))
                    {
                        if (pDest.PropertyType == typeof(int))
                        {
                            pDest.SetValue(result, Convert.ToInt32(reader[pi.Name]));
                        }
                        else if (pDest.PropertyType == typeof(float))
                        {
                            pDest.SetValue(result, Convert.ToSingle(reader[pi.Name]));
                        }
                        else if (pDest.PropertyType == typeof(double))
                        {
                            pDest.SetValue(result, Convert.ToDouble(reader[pi.Name]));
                        }
                        else if (pDest.PropertyType == typeof(Boolean))
                        {
                            pDest.SetValue(result, Convert.ToBoolean(reader[pi.Name]));
                        }
                        else if (pDest.PropertyType == typeof(DateTime))
                        {
                            pDest.SetValue(result, Convert.ToDateTime(reader[pi.Name]));
                        }
                        else if (pDest.PropertyType == typeof(string))
                        {
                            pDest.SetValue(result, Convert.ToString(reader[pi.Name]));
                        }
                        else if (pDest.PropertyType == typeof(Guid)) //fails to see guid?
                        {
                            pDest.SetValue(result, (Guid)reader[pi.Name]);
                        }

                    }
                }
            }

            return result;
        }
    }
}
