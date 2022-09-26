using System;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringFullName = "ФИО:", stringAge = "Возраст:", stringEmail = "Email:",
                stringScores = "Баллы за экзамены:", stringProgramming = "- программирование:", stringMaths = "- математика:", stringPhysics = "- физика:",
                stringScoreSumm = "Общий балл:", stringAverageScore = "Средний балл:";

            string fullName0 = "Федор Борисович Иванов", fullName1 = "Алла Сергеевна Рыбкина";
            byte age0 = 18, age1 = 17;
            string email0 = "FBI@rambler.ru", email1 = "best_alla@list.ru";
            double programming0 = 87, programming1 = 95;
            double maths0 = 75, maths1 = 83;
            double physics0 = 56, physics1 = 43;
            double summ0 = programming0 + maths0 + physics0, summ1 = programming1 + maths1 + physics1;
            double average0 = summ0 / 3, average1 = summ1 / 3;
            string average0Form = average0.ToString("#.##"), average1Form = average1.ToString("#.##");

            Console.WriteLine($"{stringFullName,20}{fullName0,25}{fullName1,25}");
            Console.WriteLine($"{stringAge,20}{age0,25}{age1,25}");
            Console.WriteLine($"{stringEmail,20}{email0,25}{email1,25}");
            Console.WriteLine($"{stringScores,20}");
            Console.WriteLine($"{stringProgramming,19}{programming0,26}{programming1,25}");
            Console.WriteLine($"{stringMaths,13}{maths0,32}{maths1,25}");
            Console.WriteLine($"{stringPhysics,9}{physics0,36}{physics1,25}");

            Console.ReadKey(true);

            Console.WriteLine($"{stringScoreSumm,20}");
            Console.WriteLine($"{summ0,45}{summ1,25}");
            Console.WriteLine($"{stringAverageScore,20}");
            Console.WriteLine($"{average0Form,45}{average1Form,25}");
            

            Console.ReadKey();


        }
    }
}
