using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspectorLib;

namespace TestInspectorLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FunctionInsp insp = new FunctionInsp();

            // Тест метода GetInspector()
            Console.WriteLine($"Главный инспектор: {insp.GetInspector()}");

            // Тест метода GetСarInspection()
            Console.WriteLine($"Название автоинспекции: {insp.GetСarInspection()}");

            // Тест метода SetInspector()
            Console.WriteLine("Попытка изменить главного инспектора на 'Иванов И.И.'...");
            if (insp.SetInspector("Иванов И.И."))
                Console.WriteLine("Изменение прошло успешно.");
            else
                Console.WriteLine("Изменение не выполнено.");
            Console.WriteLine($"Текущий главный инспектор: {insp.GetInspector()}");

            // Тест метода GenerateNumber()
            Console.WriteLine($"Сгенерированный номер: {insp.GenerateNumber(1234, 'A')}");

            // Тест метода GetWorker()
            Console.WriteLine("Список сотрудников:");
            foreach (var worker in insp.GetWorker())
            {
                Console.WriteLine(worker);
            }

            // Тест метода AddWorker()
            insp.AddWorker("Новиков С.С.");
            Console.WriteLine("Добавлен новый сотрудник. Обновленный список сотрудников:");
            foreach (var worker in insp.GetWorker())
            {
                Console.WriteLine(worker);
            }
        }
    }
}
