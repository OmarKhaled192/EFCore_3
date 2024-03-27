using demo.Data;
using Microsoft.EntityFrameworkCore;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using ApplicationDBContext dbContext = new ApplicationDBContext();

            //Console.WriteLine(dbContext);

            //Department department = new Department() { Name = "CS" };
            //Employee newEmployee = new Employee() { Name = "Omar", Address = "Nasr city", Age = 22, Salary = 5000.40m, Department = department };

            //dbContext.Add<Employee>(newEmployee);
            //dbContext.SaveChanges();

            #region Example01
            //var employee = (from E in dbContext.Employees
            //                where E.Id == 1
            //                select E).FirstOrDefault();


            //if (employee is not null)
            //{
            //    dbContext.Entry(employee).Reference(E => E.Department).Load(); // Load Explicity

            //    Console.WriteLine($"Employee Name: {employee.Name}, Department Name: {employee.Department?.Name ?? "NA"}");
            //}
            #endregion

            #region Example02 [Explicit Loading]
            //var department = (from D in dbContext.Departments
            //                  where D.Id == 1
            //                  select D).FirstOrDefault();

            //if(department is not null ) {
            //    //Console.WriteLine($"Department Id = {department.Id}, Department Name = {department.Name},  ");

            //    dbContext.Entry(department).Collection(D => D.Employees).Load(); // Explicit Loading 


            //    foreach(var employee in department.Employees)
            //    Console.WriteLine($"Employee Id = {employee.Id}, Emploee Name = {employee.Name},  ");


            //    dbContext.SaveChanges();

            //}


            #endregion

            #region Eager Loading Ex01
            // get data & related date in the same request
            // sepecially when related data is large

            //var employee = (from E in dbContext.Employees.Include(E => E.Department) // Eager Loading
            //                where E.Id == 1
            //                select E).FirstOrDefault();

            //if (employee is not null)
            //{
            //    Console.WriteLine($"Employee Name: {employee.Name}, Department Name: {employee.Department?.Name ?? "NA"}");
            //}

            #endregion

            #region Lazy Loading Ex01 [Loading Implicitly]

            var employee = (from E in dbContext.Employees.Include(E => E.Department) // Eager Loading
                            where E.Id == 1
                            select E).FirstOrDefault();

            if (employee is not null)
            {
                Console.WriteLine($"Employee Name: {employee.Name}, Department Name: {employee.Department?.Name ?? "NA"}");
            }

            #endregion
        }
    }
}
