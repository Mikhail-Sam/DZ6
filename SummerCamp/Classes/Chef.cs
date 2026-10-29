using System;

namespace SummerCamp.Classes
{
    public class Chef : Person
    {
        // Доп. свойства
        public string Cuisine { get; set; }
        public int MealsToday { get; set; }
        public decimal HourlyRate { get; set; }
        public bool HasCertificate { get; set; }

        
        public Chef() : base()
        {
            Cuisine = "General";
            MealsToday = 0;
            HourlyRate = 0;
            HasCertificate = false;
        }

        public Chef(string name, int age, string phone, 
            string cuisine, decimal rate, bool hasCert)
            : base(name, age, phone)
        {
            Cuisine = cuisine;
            MealsToday = 0;
            HourlyRate = rate;
            HasCertificate = hasCert;
        }

        
        public override string GetRole()
        {
            return $"Повар ({Cuisine})";
        }

        public new string GetInfo()
        {
            return base.GetInfo() + $", Кухня: {Cuisine}";
        }

        public void PrepareMeal(string meal, int portions)
        {
            if (!HasCertificate)
            {
                Console.WriteLine("Нельзя готовить без сертификата!");
                return;
            }
            MealsToday += portions;
            Console.WriteLine($"{Name} приготовил {meal} ({portions} порций)");
        }

        public void ShowMenu(params string[] dishes)
        {
            Console.WriteLine($"\nМеню от {Name}:");
            foreach (var dish in dishes)
                Console.WriteLine($"- {dish}");
        }

        public decimal CalculateEarnings(int hours)
        {
            return HourlyRate * hours;
        }

        public bool CanWork()
        {
            return HasCertificate && HourlyRate > 0;
        }
    }
}