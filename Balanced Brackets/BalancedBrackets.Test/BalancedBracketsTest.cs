using System;
using Xunit;
using BalancedBrackets;

namespace BalancedBrackets.Test
{
    public class BalancedBracketsTest
    {
        [Fact]
        public void PruebaBalanceo_Ok()
        {
            string prueba_1 = "{}";
            string resultado_1 = Program.IsBalanced(prueba_1);

            Assert.True(resultado_1 == "YES");

            string prueba_2 = "(((((((((())))))))))";
            string resultado_2 = Program.IsBalanced(prueba_2);

            Assert.True(resultado_2 == "YES");

            string prueba_3 = "{{{{{{{{{{}}}}}}}}}}";
            string resultado_3 = Program.IsBalanced(prueba_3);

            Assert.True(resultado_3 == "YES");

            string prueba_4 = "[[[[[[[[[[]]]]]]]]]]";
            string resultado_4 = Program.IsBalanced(prueba_4);

            Assert.True(resultado_4 == "YES");
        }

        [Fact]
        public void PruebaBalanceo_Falla()
        {
            string prueba_5 = "[{[[[[[[[[]]]]]]]]]]";
            string resultado_5 = Program.IsBalanced(prueba_5);

            Assert.True(resultado_5 == "NO");

            string prueba_6 = "[[[[[[[[[[]]]]]]]]]";
            string resultado_6 = Program.IsBalanced(prueba_6);

            Assert.True(resultado_6 == "NO");

            string prueba_7 = "{[(]}";
            string resultado_7 = Program.IsBalanced(prueba_7);

            Assert.True(resultado_7 == "NO");

            string prueba_8 = "]]{}";
            string resultado_8 = Program.IsBalanced(prueba_8);

            Assert.True(resultado_8 == "NO");

            string prueba_9 = "]][[]]";
            string resultado_9 = Program.IsBalanced(prueba_9);

            Assert.True(resultado_9 == "NO");

            string prueba_10 = "}}{}";
            string resultado_10 = Program.IsBalanced(prueba_10);

            Assert.True(resultado_10 == "NO");

            string prueba_11 = "({})())";
            string resultado_11 = Program.IsBalanced(prueba_11);

            Assert.True(resultado_10 == "NO");

        }
    }
}
