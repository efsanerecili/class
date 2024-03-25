

using System;

class Employee
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string DepartmentName { get; set; }
    public double Salary { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Employee[] employees = new Employee[100];
        int count = 0;
        while(true) 

        {
            Console.WriteLine("Menu Seçimi:");
            Console.WriteLine("1. Employee əlavə et");
            Console.WriteLine("2. Bütün işçilərə bax");
            Console.WriteLine("3. Maaş aralığına görə işçiləri axtarış et");
            Console.WriteLine("0. Proqramı bitir");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (count < 100)
                    {
                        Employee newEmployee = new Employee();
                        Console.WriteLine("İşçinin adını daxil edin:");
                        newEmployee.Name = Console.ReadLine();
                        Console.WriteLine("İşçinin soyadını daxil edin:");
                        newEmployee.Surname = Console.ReadLine();
                        Console.WriteLine("İşçinin yaşını daxil edin:");
                        newEmployee.Age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("İşçinin departamentini daxil edin:");
                        newEmployee.DepartmentName = Console.ReadLine();
                        Console.WriteLine("İşçinin maaşını daxil edin:");
                        newEmployee.Salary = Convert.ToDouble(Console.ReadLine());

                        employees[count] = newEmployee;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Əməliyyat yerinə yetirilə bilmədi. Çalışan sayısı limitə çatıb.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Bütün işçilər:");
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine($"Ad: {employees[i].Name}, Soyad: {employees[i].Surname}, Yaş: {employees[i].Age}, Departament: {employees[i].DepartmentName}, Maaş: {employees[i].Salary}");
                    }
                    break;
                case 3:
                    Console.WriteLine("Minimum maaşı daxil edin:");
                    double minSalary = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Maksimum maaşı daxil edin:");
                    double maxSalary = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Maaş aralığı {minSalary} ilə {maxSalary} arasında olan işçilər:");
                    for (int i = 0; i < count; i++)
                    {
                        if (employees[i].Salary >= minSalary && employees[i].Salary <= maxSalary)
                        {
                            Console.WriteLine($"Ad: {employees[i].Name}, Soyad: {employees[i].Surname}, Yaş: {employees[i].Age}, Departament: {employees[i].DepartmentName}, Maaş: {employees[i].Salary}");
                        }
                    }
                    break;
                case 0:
                    Console.WriteLine("Proqram bitirilir.");
                    return;
                default:
                    Console.WriteLine("Yanlış seçim. Zəhmət olmasa düzgün seçim edin.");
                    break;
            }
        }
    }
}
