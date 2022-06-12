using DAL;
using Persistence;

namespace BL;
public class EmployeeBL
{
    private EmployeeDAL employeeDAL;

    public EmployeeBL()
    {
        employeeDAL = new EmployeeDAL();
    }
    public Employee GetEmployeeById(int emp_no)
    {
        Employee employee = employeeDAL.GetEmployeeById(emp_no);
        employee.EmployeeFirstName = employee.EmployeeFirstName.ToUpper();
        employee.EmployeeLastName = employee.EmployeeLastName.ToUpper();
        return employee;
    }
}

