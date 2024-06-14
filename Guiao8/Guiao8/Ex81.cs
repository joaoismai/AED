using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao8
{
    internal class Ex81
    {
        public class Date
        {
            private int day;
            private int month;
            private int year;

            public Date(int day, int month, int year)
            {
                if (ValidDate(day, month, year))
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;
                }
                else
                {
                    Console.WriteLine("Invalid date. Using current date instead.");
                    (this.day, this.month, this.year) = CurrentDate();
                }
            }

            public static bool ValidDay(int day, int month, int year)
            {
                if (month >= 1 && month <= 12)
                {
                    int daysInMonth = MonthDays(month, year);
                    return day >= 1 && day <= daysInMonth;
                }
                return false;
            }

            public static bool ValidMonth(int month)
            {
                return month >= 1 && month <= 12;
            }

            public static bool ValidYear(int year)
            {
                return year > 1000;
            }

            public static int MonthDays(int month, int year)
            {
                if (month == 2)
                    return LeapYear(year) ? 29 : 28;
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                    return 30;
                else
                    return 31;
            }

            public static bool LeapYear(int year)
            {
                return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            }

            public static bool ValidDate(int day, int month, int year)
            {
                return ValidDay(day, month, year) && ValidMonth(month) && ValidYear(year);
            }

            public void Set(int day, int month, int year)
            {
                if (ValidDate(day, month, year))
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;
                }
                else
                {
                    Console.WriteLine("Invalid date. Not changing the date.");
                }
            }

            public void Increment()
            {
                int daysInMonth = MonthDays(month, year);
                if (day < daysInMonth)
                    day++;
                else
                {
                    day = 1;
                    if (month < 12)
                        month++;
                    else
                    {
                        month = 1;
                        year++;
                    }
                }
            }

            public void Decrement()
            {
                if (day > 1)
                    day--;
                else
                {
                    if (month > 1)
                    {
                        month--;
                        day = MonthDays(month, year);
                    }
                    else
                    {
                        month = 12;
                        year--;
                        day = MonthDays(month, year);
                    }
                }
            }

            public override string ToString()
            {
                return $"{year:D4}-{month:D2}-{day:D2}";
            }

            private static (int, int, int) CurrentDate()
            {

                DateTime today = DateTime.Today;
                return (today.Day, today.Month, today.Year);
            }
        }
    }
}
