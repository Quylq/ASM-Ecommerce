using MySql.Data.MySqlClient;
using Persistence;

namespace DAL
{
    public class EmployeeDAL
    {
        private string query;
        private MySqlDataReader reader;

        public Employee GetEmployeeById(int empId)
        {
            query = @"select emp_no, first_name, last_name from employees where emp_no = " + empId;

            //Mở kết nối đến database
            DbHelper.OpenConnection();

            //Thực thi lệnh
            reader = DbHelper.ExecQuery(query);

            Employee employee = null;
            if (reader.Read())
            {
                employee = GetEmployeeInfo(reader);
            }
            DbHelper.CloseConnection();
            return employee;
        }

        private Employee GetEmployeeInfo(MySqlDataReader reader)
        {
            Employee employee = new Employee();
            employee.EmployeeId = reader.GetInt32("emp_no");
            employee.EmployeeFirstName = reader.GetString("first_name");
            employee.EmployeeLastName = reader.GetString("last_name");

            return employee;
        }
    }
}
