using System;
using Xunit;

namespace xUnit_ill
{
    public class FirstTestAtAll
    {
        [Fact]
        public void OMG_I_am_broken()
        {
            Assert.True(false, "as expected");
        }
    }
}
