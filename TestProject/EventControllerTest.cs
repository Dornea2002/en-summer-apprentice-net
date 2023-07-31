using AutoMapper;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSalesManagement.Models;
using TicketSalesManagement.Models.Dto;
using TicketSalesManagement.Repository;

namespace TestProject
{
    [TestClass]
    internal class EventControllerTest
    {
        Mock<IEventRepository> _eventRepositoryMock;
        Mock<IMapper> _mapperMoq;
        List<Event> _moqList;
        List<EventDto> _dtoMoq;

        [TestInitialize]
        public void SetupMoqData()
        {
            _eventRepositoryMock = new Mock<IEventRepository>();
            _mapperMoq = new Mock<IMapper>();
            _moqList = new List<Event>()
            {
                new Event {Eventid = 1,
                    EventName = "Moq name",
                    EventDescription = "Moq description",
                    EndDate = DateTime.Now,
                    StartDate = DateTime.Now,
                    EventType = new EventType {EventTypeid = 1,EventTypeName="test event type"},
                    EventTypeid = 1,
                    Venue = new Venue {Venueid = 1,Capacity = 12, Location = "Mock location",Type = "mock type"},
                    Venueid = 1
                }
            };
            _dtoMoq = new List<EventDto>(){
                new EventDto
                {
                    EventDescription = "Moq description",
                    EvendID = 1,
                    EventName = "Moq name",
                    //EventType = new EventType {EventTypeid = 1, EventTypeName="test event type"},
                    //Venue = new Venue {Venueid = 1,Capacity = 12, Location = "Mock location",Type = "mock type"}
                }
            };

        }
    }
}
