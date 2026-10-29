namespace Project6.домашнее_задание_7._1
{
    class Building
    {
        private static long lastBuildingId = 100000000;
        private long buildingId;
        private double height;
        private int floors;
        private int apartmentsTotal;
        private int entrances;
        public long BuildingId => buildingId;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Floors
        {
            get { return floors; }
            set { floors = value; }
        }
        public int ApartmentsTotal
        {
            get { return apartmentsTotal; }
            set { apartmentsTotal = value; }
        }
        public int Entrances
        {
            get { return entrances; }
            set { entrances = value; }
        }
        public Building(double height, int floors, int apartmentsTotal, int entrances)
        {
            buildingId = GenerateBuildingId(); // генерируем уникальный ID
            Height = height;
            Floors = floors;
            ApartmentsTotal = apartmentsTotal;
            Entrances = entrances;
        }
        private long GenerateBuildingId()
        {
            return ++lastBuildingId;
        }

        //Метод для расчёта средней высоты этажа
        public double FloorHeight()
        {
            return Height / Floors;
        }

        //Метод для расчёта количества квартир в подъезде
        public int ApartmentsPerEntrance()
        {
            return ApartmentsTotal / Entrances;
        }

        //Метод для расчёта количества квартир на этаже
        public int ApartmentsPerFloor()
        {
            return ApartmentsPerEntrance() / Floors;
        }

        //Метод для вывода полной информации о здании
        public void PrintBuildingDetails()
        {
            Console.WriteLine($"Уникальный номер здания: {buildingId}");
            Console.WriteLine($"Высота здания: {height} метров");
            Console.WriteLine($"Количество этажей: {floors}");
            Console.WriteLine($"Всего квартир: {apartmentsTotal}");
            Console.WriteLine($"Количество подъездов: {entrances}");
            Console.WriteLine($"Средняя высота этажа: {FloorHeight()} метров");
            Console.WriteLine($"Квартир в подъезде: {ApartmentsPerEntrance()}");
            Console.WriteLine($"Квартир на этаже: {ApartmentsPerFloor()}");
        }
    }
}
