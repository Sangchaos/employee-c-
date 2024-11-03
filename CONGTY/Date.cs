using System;

namespace CONGTY
{
    public class Date
    {
        private int year;
        private int month;
        private int day;

        public Date(int theYear, int theMonth, int theDay)
        {
            year = theYear;
            month = ValidateMonth(theMonth);
            day = ValidateDay(theDay);
        }

        public override string ToString()
        {
            return $"{year}/{month}/{day}";
        }

        private int ValidateMonth(int theMonth)
        {
            if (theMonth > 0 && theMonth <= 12)
            {
                return theMonth;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(theMonth), $"Tháng {theMonth} không hợp lệ. Vui lòng nhập tháng từ 1 đến 12.");
            }
        }

        private int ValidateDay(int testDay)
        {
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (testDay > 0 && testDay <= daysPerMonth[month])
            {
                return testDay;
            }
            if (month == 2 && testDay == 29 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
            {
                return testDay;
            }
            throw new ArgumentOutOfRangeException(nameof(testDay), $"Ngày {testDay} không hợp lệ trong tháng {month} của năm {year}.");
        }
    }
}
