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
            if (a.IsSubclassOf(b)) { Console.WriteLine("Yes"); } // проверяем является ли классы наследниками друг друга
            else { Console.WriteLine("No"); }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кто дал задачу:");
            string A1 = Console.ReadLine();
            Console.WriteLine("Введите кому хотите дать задачу:");
            string B1 = Console.ReadLine();
            Console.WriteLine("Введите название задачи:");
            string C1 = Console.ReadLine();
            Type A = Type.GetType("Zadachi" + "." + A1, false, true); // получаем типы классов по имени(строке)
            Type B = Type.GetType("Zadachi" + "." + B1, false, true);
            Console.WriteLine($"Задача {C1} от {A1} передана для {B1}.");
            Console.WriteLine("Ответ сотрудника:");
            Otvet(B, A);
        }
    }
}

