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

            Assert.Equal("Letter Grade: A", result);
        }
        [Fact]
        public void ConvertToGradeB()
        {
            var converter = new GradeConverter();

            var result = converter.LetterGrade(85);

            Assert.Equal("Letter Grade: B", result);
        }
        [Fact]
        public void ConvertToGradeC()
        {
            var converter = new GradeConverter();

            var result = converter.LetterGrade(78);

            Assert.Equal("Letter Grade: C", result);
        }
        [Fact]
        public void ConvertToGradeD()
        {
            var converter = new GradeConverter();

            var result = converter.LetterGrade(62);

            Assert.Equal("Letter Grade: D", result);
        }
        [Fact]
        public void ConvertToGradeF()
        {
            var converter = new GradeConverter();

            var result = converter.LetterGrade(50);

            Assert.Equal("Letter Grade: F", result);
        }
    }
}
