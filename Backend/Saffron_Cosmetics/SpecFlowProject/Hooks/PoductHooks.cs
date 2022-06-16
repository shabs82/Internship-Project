using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoDi;
using Moq;
using TechTalk.SpecFlow;
using SafCos.Core.DomainService;

namespace SpecFlowProject.Hooks
{
    [Binding]
    public class ProductHooks
    {
        private readonly IObjectContainer container;
        private readonly ScenarioContext _scenarioContext;
        private readonly Mock<IProductRepo> _mockProductRepo;

        public ProductHooks(ScenarioContext scenarioContext, IObjectContainer container)
        {
            this.container = container;
            _scenarioContext = scenarioContext;
            _mockProductRepo = new Mock<IProductRepo>();
        }

        [BeforeScenario]
        public void InitializeBookingManager()
        {
            var bookingManager = new BookingManager(_mockBookingRepo.Object, _mockRoomRepo.Object);
            container.RegisterInstanceAs<IBookingManager>(bookingManager);
        }
    }
}
