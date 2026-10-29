namespace SummerCamp.Classes
{
    // Наследник 1
    public class Counselor : Person
    {
        // Дополнительные свойства
        public string Specialty { get; set; }
        public int Experience { get; set; }
        public decimal Salary { get; set; }
        public int GroupSize { get; set; }

        // 2 конструктора
        public Counselor() : base()
        {
            Specialty = "General";
            Experience = 0;
            Salary = 0;
            GroupSize = 0;
        }

        public Counselor(string name, int age, string phone, 
            string specialty, int experience, 
            decimal salary, int groupSize)
            : base(name, age, phone)
        {
            Specialty = specialty;
            Experience = experience;
            Salary = salary;
            GroupSize = groupSize;
        }

        // 5+ методов
        public override string GetRole()
        {
            return $"Вожатый ({Specialty})";
        }

        public  string GetInfo()
        {
            return base.GetInfo() + $", Специализация: {Specialty}";
        }

        public void AssignGroup(int size)
        {
            GroupSize = size;
            Console.WriteLine($"{Name} назначен в группу из {size} человек");
        }

        public void ConductActivity(string activity)
        {
            Console.WriteLine($"{Name} проводит: {activity}");
        }

        public void RaiseSalary(decimal percent)
        {
            Salary += Salary * (percent / 100);
            Console.WriteLine($"Зарплата повышена до {Salary:C}");
        }

        public bool IsQualified()
        {
            return Experience >= 2 && GroupSize > 0;
        }
    }
}