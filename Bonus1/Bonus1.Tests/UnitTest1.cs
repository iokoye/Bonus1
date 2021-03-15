using System;
using Xunit;

namespace Bonus1.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ConvertToGradeA()
        {
            var converter = new GradeConverter();

            var result = converter.LetterGrade(90);
        }
    }
}
