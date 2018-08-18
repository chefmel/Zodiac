using System;

namespace Zodiac
{
    class Program
    {
        static void Main(string[] args)
        { //Create a program that asks the user for the date they were born.
            //Display the name of the day(ie Thursday) and the name of the
            //day their next birthday will be on.Finally, display their zodiac
            //symbol and a fake fortune for them.
            Console.WriteLine("Please enter your birthdate as MM/DD/YYYY");
            //string birthdate = Console.ReadLine();
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("You were born on a " + birthdate.DayOfWeek);
            birthdate = new DateTime(DateTime.Now.Year, birthdate.Month, birthdate.Day);

            if (DateTime.Now.CompareTo(birthdate) <= 0)
            {
                birthdate = new DateTime(DateTime.Now.Year + 1, birthdate.Month, birthdate.Day);
            }
                Console.WriteLine("Your next birthday will be on a " + birthdate.DayOfWeek);

                if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 1, 20), new DateTime(birthdate.Year, 2, 18)))
            {
                Console.WriteLine("Your Zodiac sign is Aquarius according to your horoscope, " +
                    "You will find true love");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 2, 19), new DateTime(birthdate.Year, 3, 20)))
            {
                Console.WriteLine("Your Zodiac sign is Pisces according to your horoscope, " +
                    "You will reconnect with an old friend");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 3, 21), new DateTime(birthdate.Year, 4, 19)))
            {
                Console.WriteLine("Your Zodiac sign is Aries according to your horoscope, " +
                    "You will change your career");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 4, 20), new DateTime(birthdate.Year, 5, 20)))
            {
                Console.WriteLine("Your Zodiac sign is Taurus according to your horoscope, " +
                   "You will go on a great vacation");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 5, 21), new DateTime(birthdate.Year, 6, 20)))
            {
                Console.WriteLine("Your Zodiac sign is Gemini according to your horoscope, " +
                   "You will discover your dreams");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 6, 21), new DateTime(birthdate.Year, 7, 22)))
            {
                Console.WriteLine("Your Zodiac sign is Cancer according to your horoscope, " +
                   "You will be blessed with children");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 7, 23), new DateTime(birthdate.Year, 8, 22)))
            {
                Console.WriteLine("Your Zodiac sign is Leo according to your horoscope, " +
                   "You will inherit a great sum of money");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 8, 23), new DateTime(birthdate.Year, 9, 22)))
            {
                Console.WriteLine("Your Zodiac sign is Virgo according to your horoscope, " +
                   "You will be blessed with an unlimited supply of wine");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 9, 23), new DateTime(birthdate.Year, 10, 22)))
            {
                Console.WriteLine("Your Zodiac sign is Libra according to your horoscope, " +
                   "You will inherit a fine collection of art");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 10, 13), new DateTime(birthdate.Year, 11, 21)))
            {
                Console.WriteLine("Your Zodiac sign is Scorpio according to your horoscope, " +
                   "You will win a beauty contest");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 11, 22), new DateTime(birthdate.Year, 12, 21)))
            {
                Console.WriteLine("Your Zodiac sign is Sagittarius according to your horoscope, " +
                   "You will win a spot in a singing contest");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 12, 22), new DateTime(birthdate.Year, 1, 19)))
            {
                Console.WriteLine("Your Zodiac sign is Capricorn according to your horoscope, " +
                   "You will win  lottery");
            }

            Console.ReadLine();


            //Aquarius Jan 20 - Feb 18
            //Pisces Feb 19 - Mar 20
            //Aries Mar 21 - Apr 19
            //Taurus Apr 20 - May 20
            //Gemini May 21 - June 20
            //Cancer Jun 21 - Jul 22
            //Leo Jul 23 - Aug 22
            //Virgo Aug 23 - Sep 22
            //Libra Sep 23 - Oct 22
            //Scorpio Oct 23 - Nov 21
            //Sagittarius Nov 22 - Dec 21
            //Capricorn Dec 22 - Jan 19
        }
        private static bool DateIsBetween(DateTime date, DateTime start, DateTime end)
        {
            if (date >= start && date <= end)
            {
                return true;
            }
            return false;
            
        }
    }
}
