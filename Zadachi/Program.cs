using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachi
{
    //главный
    public class Борис
    {

    }
    //финансовый директор(Рашид)
    class Рашид : Борис
    {
        
    }
    class Лукас : Рашид
    {

    }
    class Бухгалтерия : Лукас
    {

    }
    // директор по автоматизации:
    class Оильхам : Борис
    {
        
    }
    class Оркадий : Оильхам
    {

    }
    class Володя : Оркадий
    {

    }
    // системщики:
    class Ильшат : Володя
    {
        
    }
    class Иваныч : Ильшат
    {

    }
    class Илья : Иваныч
    {

    }
    class Витя : Иваныч
    {

    }
    class Женя : Иваныч
    {

    }
    // разработчики:
    class Сергей : Володя
    {
        
    }
    class Ляйсан : Сергей
    {

    }
    class Марат : Ляйсан
    {

    }
    class Дина : Ляйсан
    {

    }
    class Ильдар : Ляйсан
    {

    }
    class Антон : Ляйсан
    {

    }
    internal class Program
    {
        static void Otvet(Type a, Type b)
        {
            if (a.IsSubclassOf(b))
            {
                Console.WriteLine("Yes");
            }
            // проверяем является ли классы наследниками друг друга
            else
            {
                Console.WriteLine("No");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи, которая вас интересует");
            Console.WriteLine("1: Расчетитать, начислить, выдать заработную плату");
            Console.WriteLine("2: Разработать и установить операционную систему");
            Console.WriteLine("3: Устранить ошибки");
            Console.WriteLine("4: Принести кофе");
            Console.WriteLine("5: Помыть полы");
            int userChoose;
            if (!int.TryParse(Console.ReadLine(), out userChoose))
            {
                Console.WriteLine("Вы ввели неправильно");
            }
            if (userChoose == 1)
            {
                string C1 = "Расчетитать, начислить, выдать заработную плату";
                Console.WriteLine("Введите кто дал задачу:");
                string A1 = Console.ReadLine();
                Console.WriteLine("Введите кому хотите дать задачу:");
                string B1 = Console.ReadLine();
                Type A = Type.GetType("Zadachi" + "." + A1, false, true); // получаем типы классов по имени(строке)
                Type B = Type.GetType("Zadachi" + "." + B1, false, true);
                Console.WriteLine($"Задача {C1} от {A1} передана для {B1}.");
                Console.WriteLine("Ответ сотрудника:");
                Otvet(B, A);
            }
            else if (userChoose == 2)
            {
                string C1 = "Разработать и установить операционную систему";
                Console.WriteLine("Введите кто дал задачу:");
                string A1 = Console.ReadLine();
                Console.WriteLine("Введите кому хотите дать задачу:");
                string B1 = Console.ReadLine();
                Type A = Type.GetType("Zadachi" + "." + A1, false, true); // получаем типы классов по имени(строке)
                Type B = Type.GetType("Zadachi" + "." + B1, false, true);
                Console.WriteLine($"Задача {C1} от {A1} передана для {B1}.");
                Console.WriteLine("Ответ сотрудника:");
                Otvet(B, A);
            }
            else if (userChoose == 3)
            {
                string C1 = "Устранить ошибки";
                Console.WriteLine("Введите кто дал задачу:");
                string A1 = Console.ReadLine();
                Console.WriteLine("Введите кому хотите дать задачу:");
                string B1 = Console.ReadLine();
                Type A = Type.GetType("Zadachi" + "." + A1, false, true); // получаем типы классов по имени(строке)
                Type B = Type.GetType("Zadachi" + "." + B1, false, true);
                Console.WriteLine($"Задача {C1} от {A1} передана для {B1}.");
                Console.WriteLine("Ответ сотрудника:");
                Otvet(B, A);
            }
            else if (userChoose == 4)
            {
                string C1 = "Принести кофе";
                Console.WriteLine("Введите кто дал задачу:");
                string A1 = Console.ReadLine();
                Console.WriteLine("Введите кому хотите дать задачу:");
                string B1 = Console.ReadLine();
                Type A = Type.GetType("Zadachi" + "." + A1, false, true); // получаем типы классов по имени(строке)
                Type B = Type.GetType("Zadachi" + "." + B1, false, true);
                Console.WriteLine($"Задача {C1} от {A1} передана для {B1}.");
                Console.WriteLine("Ответ сотрудника:");
                Otvet(B, A);
            }
            else if (userChoose == 5)
            {
                string C1 = "Помыть полы";
                Console.WriteLine("Введите кто дал задачу:");
                string A1 = Console.ReadLine();
                Console.WriteLine("Введите кому хотите дать задачу:");
                string B1 = Console.ReadLine();
                Type A = Type.GetType("Zadachi" + "." + A1, false, true); // получаем типы классов по имени(строке)
                Type B = Type.GetType("Zadachi" + "." + B1, false, true);
                Console.WriteLine($"Задача {C1} от {A1} передана для {B1}.");
                Console.WriteLine("Ответ сотрудника:");
                Otvet(B, A);
            }
            Console.ReadKey();
        }
    }
}

