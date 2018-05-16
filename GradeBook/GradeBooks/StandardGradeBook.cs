using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public bool IsWeighted{ get; set; }
        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            isWeighted = IsWeighted;
          Type = GradeBookType.Standard;
        }
    }
}
