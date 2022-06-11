using BL;
using Persistence;

Console.Write("Nhap ma nhan vien: ");
int emp_no = Convert.ToInt32(Console.ReadLine());

EmployeeBL employeeBL = new EmployeeBL();

Employee emp =  employeeBL.GetEmployeeById(emp_no);

if (emp != null)
{
    Console.WriteLine($"Ho va ten nhan vien: {emp.EmployeeFirstName} {emp.EmployeeLastName}");
}
