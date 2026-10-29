using System;

namespace SummerCamp.Classes
{
    
    public class Camper : Person
    {
        private string _parentName;
        
        public string Cabin { get; }
        public string Grade { get; set; }
        public decimal Fee { get; set; }
        public bool IsPaid => Fee > 0;

        public string ParentName
        {
            get => _parentName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Имя родителя не может быть пустым");
                _parentName = value;
            }
        }

        public string EmergencyContact { get; set; }
        public bool HasAllergies { get; set; }
        public string AllergyInfo { get; set; }

        public Camper() : base()
        {
            Cabin = "A-000";
            Grade = "Unknown";
            Fee = 0;
            _parentName = "Unknown";
            EmergencyContact = "N/A";
            HasAllergies = false;
            AllergyInfo = "None";
        }

        public Camper(string name, int age, string phone, string cabin,
                     string grade, decimal fee, string parent, 
                     string emergency, bool allergies, string allergyInfo = "None")
            : base(name, age, phone)
        {
            Cabin = cabin;
            Grade = grade;
            Fee = fee;
            ParentName = parent;
            EmergencyContact = emergency;
            HasAllergies = allergies;
            AllergyInfo = allergyInfo;
        }

        public override string GetRole()
        {
            return $"Участник (Корпус {Cabin})";
        }

        public new string GetInfo()
        {
            return base.GetInfo() + $", Класс: {Grade}, Корпус: {Cabin}";
        }

        public void PayFee(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма должна быть положительной!");
                return;
            }
            Fee = amount;
            Console.WriteLine($"{Name} оплатил {amount:C}");
        }

        public void RegisterAllergy(string type, string details)
        {
            HasAllergies = true;
            AllergyInfo = $"{type}: {details}";
            Console.WriteLine($"Аллергия зарегистрирована: {AllergyInfo}");
        }

        public bool IsReady()
        {
            return IsPaid && !string.IsNullOrEmpty(EmergencyContact);
        }

        public void ShowSchedule()
        {
            Console.WriteLine($"Расписание для {Name}:");
            Console.WriteLine("08:00 - Подъем");
            Console.WriteLine("12:00 - Обед");
            Console.WriteLine("18:00 - Ужин");
            Console.WriteLine("21:00 - Отбой");
        }
    }
}