using System;
using CheckInWorkFlow.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace CheckInWorkFlow.Tests
{
    public class AppointmentControllerTest
    {
        private readonly AppointmentController _controller;
        public AppointmentControllerTest(AppointmentController controller)
        {
            _controller=controller;
        }
        [Fact]
        public void Index_ActionExecutes_ReturnsViewForIndex()
        {
            var result = _controller.Index();
            Assert.IsType<ViewResult>(result);
        }
    }
}
