using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using CalcService.Controllers;
namespace CalcService
{
    public class UnitTest1
    {
        [Fact]
        public void GetCalcReturnsResult()
        {            
            CalcController controller = new CalcController();
            var result = (int)(controller.Add(4, 5) as ObjectResult).Value;
            Assert.Equal(9, result);
        }
    }
}
