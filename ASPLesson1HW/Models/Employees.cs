using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ASPLesson1HW.Models
{
    public class Employees
    {
        public int IDEmployee { get; set; }
        [DisplayName("Фамилия")]
        public string FirstName { get; set; }
        [DisplayName("Имя")]
        public string SecondName { get; set; }
        [DisplayName("Отчество")]
        public string LastName { get; set; }
        [DisplayName("Возраст")]
        public int Age { get; set; }
        [DisplayName("Эл. почта")]
        public string Email { get; set; }
        [DisplayName("Моб. номер")]
        public int MobilePhoneNumber { get; set; }

        public Employees(int id, string firstName, string secondName, string lastName, int age, string email, int mobilePhoneNumber)
        {
            IDEmployee = id;
            FirstName = firstName;
            SecondName = secondName;
            LastName = lastName;
            Age = age;
            Email = email;
            MobilePhoneNumber = mobilePhoneNumber;
        }

        public static List<Employees> GetEmployees()
        {
            List<Employees> liEmp = new List<Employees>();

            liEmp.Add(new Employees(1, "Алексеев", "Алексей", "Алексеевич", 25, "aaa@mail.ru", 554466));
            liEmp.Add(new Employees(2, "Петров", "Петр", "Петрович", 30, "ppp@mail.ru", 123456));
            liEmp.Add(new Employees(3, "Василевская", "Василиса", "Васильева", 35, "vvv@mail.ru", 753456));

            return liEmp;
        }
    }
}
