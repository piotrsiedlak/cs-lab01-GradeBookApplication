using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    internal class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool IsWeight) : base(name, IsWeight)
        {
            GradeBookType Type = GradeBookType.Standard;
        }
    }
}
