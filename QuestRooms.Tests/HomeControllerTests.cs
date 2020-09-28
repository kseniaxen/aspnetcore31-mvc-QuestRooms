using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Moq;
using QuestRooms.Controllers;
using QuestRooms.Models;
using Xunit;
namespace QuestRooms.Tests
{
    public class QuestRoomsControllerTests
    {
        [Fact]
        public void Can_Use_Repository()
        {
            // Arrange
            Mock<IRoomsRepository> mock = new Mock<IRoomsRepository>();
            mock.Setup(m => m.QuestRooms).Returns((new QuestRoom[] {
                new QuestRoom{ QuestRoomID = 1, Name = "N1"},
                new QuestRoom{ QuestRoomID = 2, Name = "N2"}
            }).AsQueryable<QuestRoom>());
            HomeController controller = new HomeController(mock.Object);
            // Act
            IEnumerable<QuestRoom> result =
            (controller.Index() as ViewResult).ViewData.Model
            as IEnumerable<QuestRoom>;
            // Assert
            QuestRoom[] roomArray = result.ToArray();
            Assert.True(roomArray.Length == 2);
            Assert.Equal("N1", roomArray[0].Name);
            Assert.Equal("N2", roomArray[1].Name);
        }
    }
}