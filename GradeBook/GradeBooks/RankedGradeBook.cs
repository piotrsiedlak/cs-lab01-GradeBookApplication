using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    internal class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool IsWeight) : base(name, IsWeight)
        {
            GradeBookType Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            int i = 0;
            foreach (var student in Students)
                i++;
            int tw_pr = i / 5;
            if (i<5)
                throw new InvalidOperationException("A number of students needs to be larger than 5.");
            int number = 0;
            foreach (var student in Students)
                if(averageGrade>student.AverageGrade)
                    number++;
            if (number < tw_pr)
                return 'F';
            else if (number < tw_pr * 2)
                return 'D';
            else if (number < tw_pr * 3)
                return 'C';
            else if (number < tw_pr * 4)
                return 'B';
            else
                return 'A';
        }

        public override void CalculateStatistics()
        {
            int i = 0;
            foreach (var student in Students)
                i++;
            if (i < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
            else
                base.CalculateStatistics();
        }
    }
}
