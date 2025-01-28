
using restfulback;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using restfulback.Controllers;
using restfulback.Domain;
using restfulback.Domain.Contracts;
using restfulback.Services;
using Xunit;

namespace restful.Test
{
    public class AdminControllerTest
    {
        private readonly IAdminService _adminService;
        public AdminControllerTest()
        {
            _adminService = A.Fake<IAdminService>();
        }
        [Fact]
        public async Task AdminController_RegisterDeceasedPerson_ReturnOK()
        {
            //Arrange
            var FakeAddDeceasedData = A.Fake<AddDeceasedData>();
            var controller = new AdminContoller(_adminService);
            A.CallTo(() => _adminService.RegisterDeceased(FakeAddDeceasedData)).Returns(new ApiResponse { StatusCode = 200, Message = "Created" });
            //Act
            var result = await controller.RegisterDeceasedPerson(FakeAddDeceasedData);
            //Assert
            var actionResult = Assert.IsType<ActionResult<ApiResponse>>(result);
            var apiResponse = Assert.IsType<ApiResponse>(actionResult.Value);
            Assert.Equal(200, apiResponse.StatusCode);
            Assert.Equal("Created", apiResponse.Message);
          
        }

        [Fact]
        public async Task AdminController_GetDeceasedProfile_ReturnOK()
        {
            //Arrange
            var Id = Guid.NewGuid();
            var expectedProfile = A.Fake<DeceasedData>();
            var controller = new AdminContoller(_adminService);
            A.CallTo(() => _adminService.GetDeceasedInfo(Id)).Returns(new ApiDataResponse<DeceasedData> {Data = expectedProfile,StatusCode=200});
            //Act
            var result = await controller.GetDeceasedProfile(Id);
            //Assert
            var actionResult = Assert.IsType<ActionResult<ApiDataResponse<DeceasedData>>>(result);
            var apiResponse = Assert.IsType<ApiDataResponse<DeceasedData>>(actionResult.Value);
            Assert.Equal(200,apiResponse.StatusCode);
            
        }
    }
}