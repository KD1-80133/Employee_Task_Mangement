﻿using EnitityModelLib;
using Project_logger;
using RepositoryLib;
using RepositoryLib.RepositoryLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = EnitityModelLib.Task;



namespace EMS
{
    public class Program
    {
        static void Main(string[] args)
        {
            //------------logger------------------//
            //Logger errorLogger = LoggerFactory.GetErrorLogger("file");
            //errorLogger.LoggerEntry(new Exception("File error"));

            //errorLogger = LoggerFactory.GetErrorLogger("console");
            //errorLogger.LoggerEntry(new Exception("Console occurred."));

            //errorLogger = LoggerFactory.GetErrorLogger("db");
            //errorLogger.LoggerEntry(new Exception("DataBase error ."));

            //-----------Membership-------------------------//
            //MembershipRepository repo = new MembershipRepository();
            //repo.ChangePassword("nivedita.patil96@gmail.com", "nivedita", "pratik");


            //MembershipRepository repo = new MembershipRepository();
            //repo.CreateUser("akanksha", "akkki", "9874563214", "akanksha@gmail.com");


            //MembershipRepository repo = new MembershipRepository();
            //repo.DeleteUser("akanksha@gmail.com");


            //MembershipRepository repo = new MembershipRepository();
            //string result = repo.GenerateOTP("akanksha@gmail.com");
            //Console.WriteLine(result);

            //MembershipRepository repo = new MembershipRepository();
            //repo.GetAllUsers();

            //MembershipRepository repo = new MembershipRepository();
            //int count=repo.GetNumberOfUsersOnline();
            //Console.WriteLine(count);

            //MembershipRepository repo = new MembershipRepository();
            //User user=repo.GetUserByEmail("nivedita@gmail.com");
            //Console.WriteLine(user.ToString());

            //MembershipRepository repo = new MembershipRepository();
            //User user = repo.GetUserByMobileNo("8888135978");
            //Console.WriteLine(user.ToString());

            //MembershipRepository repo = new MembershipRepository();
            //bool result=repo.LockUser("akanksha@gmail.com");
            //Console.WriteLine(result);

            //MembershipRepository repo1 = new MembershipRepository();
            //bool result1 = repo1.ResetPassword("akanksha@gmail.com", "DA8F5", "mule");
            //Console.WriteLine(result1);

            //MembershipRepository repo1 = new MembershipRepository();
            //bool result1=repo1.UnlockUser("akanksha@gmail.com");
            //Console.WriteLine(result1);

            //MembershipRepository repo1 = new MembershipRepository();
            //bool result=repo1.UpdateUser(new User("nivedita.patil96@gmail.com","9975072126","shital",2));
            //Console.WriteLine(result);

            //MembershipRepository repo1 = new MembershipRepository();
            //bool result = repo1.ValidateUser("nivedita.patil96@gmail.com", "nivu");
            //Console.WriteLine(result);


            /*IMembershipRepository mbr = new MembershipRepository();
            Console.WriteLine(
            mbr.ValidateUser("user1@example.com","nopassword"));*/



            //---------------Department--------------------//
            //IDepartmentRepository dept = new DepartmentRepository();
            //Department department = new Department() { DeptName = "Development" };
            //dept.Add(department);
            // dept.Modify(new Department() { DeptId = 2, DeptName = "HR123" });
            //dept.Remove(1);


            //IDepartmentRepository department = new DepartmentRepository();
            //Department dept = new Department() { DeptName = "fin" };
            //department.Add(dept);

            //IDepartmentRepository department = new DepartmentRepository();
            //department.Remove(1);
            //IDepartmentRepository department = new DepartmentRepository();
            //Department dept = new Department() {DeptId=2 ,DeptName = "customer relation" };
            //department.Modify(dept);

            //IDepartmentRepository department = new DepartmentRepository();
            //IEnumerable<Department> deptList = department.GetDepartments();
            //foreach (var item in deptList)
            //{
            //    Console.WriteLine(item);

            //}

            //------------------Designation--------------//
            //IDesignationRepository desgn = new DesignationRepository();
            //Designation designation = new Designation() { DesignationName = "Team Leader" };
            ////desgn.Add(designation);
            ////desgn.Modify(new Designation { DesignationId = 1, DesignationName = "Team Head" });
            //desgn.Remove(1);


            //IDesignationRepository designation = new DesignationRepository();
            //Designation desg = new Designation() { DesignationName = "DBA" };
            //designation.Add(desg);

            //IDesignationRepository designation = new DesignationRepository();
            //Console.WriteLine( designation.FindById(4));

            //IDesignationRepository designation = new DesignationRepository();
            //IEnumerable<Designation> desgList  =designation.GetDesignations();
            //foreach (var item in desgList)
            //{
            //    Console.WriteLine(item);

            //}

            //IDesignationRepository designation = new DesignationRepository();
            //designation.Remove(2);


            //IDesignationRepository designation = new DesignationRepository();
            //Designation desg = new Designation() { DesignationId = 1, DesignationName = "project manager" };
            //designation.Modify(desg);


            //----------------------Employee-----------------//

            //IEmployeeRepository emp = new EmployeeRepository();
            //Employee employee = new Employee() { firstname = "nivedita", lastname = "patil", designationid = 1, hiredate = datetime.now, isresigned = false, hourlyrate = 800, departmentid = 1, managerid = 1 };
            //emp.add(employee);

            //   emp.Modify(new Employee() { FirstName = "Nivedita", LastName = "chougule", IsResigned = true, HourlyRate = 800, ManagerId = 2 });

            //IEmployeeRepository emp = new EmployeeRepository();
            //emp.Modify(new Employee() { FirstName = "Nivedita", LastName = "chougule", IsResigned = true, HourlyRate = 800, ManagerId = 2 });

            //IEmployeeRepository employee = new EmployeeRepository();
            //Employee emp = new Employee() { FirstName = "Salman", LastName = "Khan",DesignationId=1,DeptId=3,IsResigned= false ,HourlyRate=5000,ManagerId=2,HireDate=new DateTime(2005,10,1)};
            //employee.Add(emp);

            /*            IEmployeeRepository employee = new EmployeeRepository();
                        IEnumerable<Employee> emps=employee.GetAllEmployees();
                        foreach (var emp in emps)
                        {
                            Console.WriteLine(emp);
                        }
            */

            /*IEmployeeRepository employee = new EmployeeRepository();
            Console.WriteLine( employee.FindById(6));*/

            /*             IEmployeeRepository employee = new EmployeeRepository();
                           employee.Remove(7);*/

            /* IEmployeeRepository employee = new EmployeeRepository();
              Employee emp = new Employee { EmpId = 6, FirstName = "DB", LastName = "Admin", DesignationId = 1, DeptId = 1, IsResigned = false, HourlyRate = 3000, ManagerId = 1 };
              employee.Modify(emp);*/


            //----------BankAccount-------------//
            //-------ADD AccountDetails--------//
            //IBankAccountRepository bankAccount = new BankAccountRepository();
            //BankAccount bank = new BankAccount() { AccountNo=1,AccountHolderName="Akanksha",AccountType= "Savings", BankName = "SBI", IFSCCode = 123456,UserId=2 };
            //bankAccount.Add(bank);



            // Modifying a BankAccount
            //IBankAccountRepository bankAccountRepository = new BankAccountRepository();
            //BankAccount bankAccount = new BankAccount() { AccountNo = 1, AccountHolderName = "Aknksha1", AccountType = "Savings", BankName = "BOI", IFSCCode = 654321, UserId = 3 };
            //bankAccountRepository.Modify(bankAccount);



            // BankAccount list
            //IBankAccountRepository bankAccountRepository = new BankAccountRepository();
            //IEnumerable<BankAccount> bankAccounts = bankAccountRepository.GetAllAccount();

            //foreach (var bankAccount in bankAccounts)
            //{
            //    Console.WriteLine(bankAccount);
            //}

            //find By AccountNo
            //IBankAccountRepository bankAccountRepository = new BankAccountRepository();
            //BankAccount bankAccount = bankAccountRepository.FindById(1);


            //remove bankaccount

            //IBankAccountRepository bankAccountRepository = new BankAccountRepository();
            //bool removed = bankAccountRepository.Remove(1);

            //-------------Task--------//
            //Add Task
            //ITaskRepository taskRepository = new TaskRepository();
            //Task task = new Task()
            //{
            //    UserId = 3,
            //    ProjectId = 1,
            //    TaskDescription = "Enitity",
            //    StartDate = new DateTime(2024, 2, 12), 
            //    EndDate = new DateTime(2024, 2, 21),
            //    Status = "Inprogress"
            //};

            //taskRepository.Add(task);

            //Remove Task
            //int taskIdToRemove = 1; 
            //bool removed = taskRepository.Remove(taskIdToRemove);

            //Modify Task
            //Task taskToModify = new Task()
            //{
            //    TaskId = 3,
            //    UserId = 3,
            //    ProjectId = 1,
            //    TaskDescription = "Entity Framework",
            //    StartDate = new DateTime(2024, 2, 20),
            //    EndDate = new DateTime(2024, 2, 25),
            //    Status = "Completed"
            //};
            //taskRepository.Modify(taskToModify);


            //Find By TAsk Id
            //int taskIdToFind = 2; 
            //Task foundTask = taskRepository.FindById(taskIdToFind);
            //Console.WriteLine(foundTask);

            //Gat All Task
            //IEnumerable<Task> allTasks = taskRepository.GetAllTasks();
            //foreach (var task in allTasks)
            //{
            //    Console.WriteLine(task);
            //}


            //---------Project---------------//
            //IProjectRepository proj = new ProjectRepository();
            //Project project = new Project() { Title = "Matrimonal mgt. system" ,StartDate=new DateTime(2024,10,15) ,EndDate=new DateTime(2024,12,10)};
            //proj.Add(project);

            //proj.Modify(new Project() { ProjectId=1, Title = "ETiffin mgt. system", StartDate = new DateTime(2024, 10, 15), EndDate = new DateTime(2024, 11, 10) });
            //Project project = new Project() { Title = "Educational mgt. system", StartDate = new DateTime(2024, 02, 22), EndDate = new DateTime(2024, 03, 05) };
            //proj.Add(project);
            //proj.Remove(2);
            //Project project = new Project() { Title = "Educational mgt. system", StartDate = new DateTime(2024, 02, 22), EndDate = new DateTime(2024, 03, 05) };
            //proj.Add(project);
            //IEnumerable<Project> projList = proj.GetAllProjects();
            //foreach (var item in projList)
            //{
            //    Console.WriteLine(item);

            //}

            //------------------projectmember----------------//
            //IProjectMembersRepository projmem = new ProjectMembersRepository();
            //ProjectMembers members = new ProjectMembers() { UserId=1,ProjectId=3};
            //projmem.Add(members);
            //ProjectMembers members = new ProjectMembers() { UserId = 2, ProjectId = 1};
            //projmem.Add(members);
            //projmem.Remove(3);
            //IEnumerable<ProjectMembers> projMemList = projmem.GetAllProjectMembers();
            //foreach (var item in projMemList)
            //{
            //    Console.WriteLine(item);

            //}
        }




    }
    }

        