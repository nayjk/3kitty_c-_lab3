
class Programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите порядковый номер дня недели");
        int day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите время в часах");
        int times = Convert.ToInt32(Console.ReadLine());

        string day_week = "";
        string time_week = "";

        switch (day)
        {
            case 0:
                Console.WriteLine("Вы ввели значение ноль на дне недели, с ума сошли совсем?");
                break;
            case 1:
                day_week = Convert.ToString(days.Monday);
                break;
            case 2:
                day_week = Convert.ToString(days.Tuesday);
                break;
            case 3:
                day_week = Convert.ToString(days.Wednesday);
                break;
            case 4:
                day_week = Convert.ToString(days.Thursday);
                break;
            case 5:
                day_week = Convert.ToString(days.Friday);
                break;
            case 6:
                day_week = Convert.ToString(days.Saturday);
                break;
            case 7:
                day_week = Convert.ToString(days.Sunday);
                break;
            default:
                Console.WriteLine("non");
                break;
        }

        if (times >= 7 && times <= 12)
        {
            time_week = Convert.ToString(time.morning);
        }
        else if (times >= 13 && times <= 18)
        {
            time_week = Convert.ToString(time.afternoon);
        }
        else if (times >= 19 && times <= 23)
        {
            time_week = Convert.ToString(time.evening);
        }
        else if (times >= 0 && times <= 6)
        {
            time_week = Convert.ToString(time.night);
        }
        Console.WriteLine("Сейчас " + day_week + " Время: " + time_week);


    }
    enum days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum time
    {
        morning,
        afternoon,
        evening,
        night
    }
}



