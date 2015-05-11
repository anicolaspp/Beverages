using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;


namespace IPC.Beverages.Import.Test
{

    struct MyStruct
    {
        public int a;

        public void X()
        {
        }
    }

    public class TestClass 
    {
        [Fact]
        public void SomeTrueTest()
        {
            true.Should().BeTrue();
        }

        [Fact]
        public void SomeFalseTest()
        {
            false.Should().BeFalse();
            int[] x = new int[10];

            var s = new List<string>();
            
            
        }
    }
}
