using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Employee
{
    public class Employee : User
    {
        private int workExperience;
        private string position = string.Empty;

        public Employee()
        {
        }

        public Employee(string surname, string firstname, string patronymic, DateTime date, int workExp, string posit) : base(surname, firstname, patronymic, date)
        {
            this.WorkExperience = workExp;
            this.Position = posit;
        }

        public int WorkExperience
        {
            get
            {
                return this.workExperience;
            }
            set
            {
                try
                {
                    this.CheckPositiveValue(value);
                    this.workExperience = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        public string Position
        {
            get
            {
                return this.position;
            }
            set
            {
                this.position = value;
            }
        }
        
        public override void Display()
        {
            string year = string.Empty;

            if (this.WorkExperience == 1)
            {
                year = "year";
            }
            else
            {
                year = "years";
            }

            Console.WriteLine($"Surname: {SurName}, firstname: {FirstName}, patronymic: {Patronymic}, Date of Birth: {DateOfBirth.ToString("d")}," +
                $"{Environment.NewLine}age: {Age}, work experience: {WorkExperience} {year}, position: {Position}.");
        }

        private void CheckPositiveValue(int x)
        {
            if (x < 0)
            {
                throw new Exception("Value < 0!");
            }

        }

    }
}
