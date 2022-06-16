using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using SafCos.Core.AppService.Service;
using SafCos.Core.AppService.ServiceInterface;
using SafCos.Core.DomainService;
using SafCos.Core.Entities;
using SafCos.Core.Helper;
using Xunit;

namespace UnitTests
{
    public class UserServiceTest
    {
        private Mock<IUserRepo> _userRepoMock;
        private AuthenticationHelper _authenticationHelper;
        private User _user;
        private UserService _userService;

        public UserServiceTest()
        {
            var secretBytes = new byte[40];
            var rand = new Random();
            rand.NextBytes(secretBytes);
            _authenticationHelper = new AuthenticationHelper(secretBytes);
            _userRepoMock = new Mock<IUserRepo>();
        }

        [Fact]
        public void NewUserService_WithNullRepository_ShouldThrowException()
        {
            Action action = () => new UserService(null, _authenticationHelper);
            action.Should().Throw<ArgumentNullException>().WithMessage(("Repository Cannot be Null. (Parameter 'userRepo')"));
        }

        [Fact]
        public void NewUserService_WithNullAuthenticationHelper_ShouldThrowException()
        {
            Action action = () => new UserService(_userRepoMock.Object, null);
            action.Should().Throw<ArgumentNullException>().WithMessage(("Authentication Helper Cannot be Null. (Parameter 'authentication')"));
        }

        [Fact]
        public void GetUserById__ShouldCallRepo_Once()
        {
            IUserService usersService = new UserService(_userRepoMock.Object, _authenticationHelper);
            _userRepoMock.Setup(m => m.ReadById(1)).Returns(() => new User());
            usersService.FindUserById(1);
            _userRepoMock.Verify(repo => repo.ReadById(1), Times.Once);
        }

        [Theory]
        [InlineData("user@email.com")]
        public void FindCorrectUserById_Test(string username)
        {
            var listOfUser = new List<User>
              {
                new User {Id =  1, Email="user@email.com", FirstName = "Bob", LastName = "Dylan", Address = "White street 1", PostCode = "10616",
                    PhoneNumber = "+123456", PasswordHash = new byte[40], PasswordSalt = new byte[40], IsAdmin = true },
                new User {Id =  2, Email="bob@email.com", FirstName = "Bob", LastName = "Dylan", Address = "White street 1", PostCode = "10616",
                    PhoneNumber = "+123456", PasswordHash = new byte[40], PasswordSalt = new byte[40], IsAdmin = true },
                new User {Id =  3, Email="rod@email.com", FirstName = "Bob", LastName = "Dylan", Address = "White street 1", PostCode = "10616",
                    PhoneNumber = "+123456", PasswordHash = new byte[40], PasswordSalt = new byte[40], IsAdmin = true },
             };

            _userRepoMock.Setup(repo => repo.ReadById(1)).Returns(() => listOfUser[0]);

            var service = new UserService(_userRepoMock.Object, _authenticationHelper);

            string actual = service.FindUserById(1).Email;

            string expected = username;

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void GetAllUsers_Test()
        {
            var listOfUser = new List<User>{
                new User {Id =  1, Email="user@email.com", FirstName = "Bob", LastName = "Dylan", Address = "White street 1", PostCode = "10616",
                    PhoneNumber = "+123456", PasswordHash = new byte[40], PasswordSalt = new byte[40], IsAdmin = true },
                new User {Id =  2, Email="bob@email.com", FirstName = "Bob", LastName = "Dylan", Address = "White street 1", PostCode = "10616",
                    PhoneNumber = "+123456", PasswordHash = new byte[40], PasswordSalt = new byte[40], IsAdmin = true },
                new User {Id =  3, Email="rod@email.com", FirstName = "Bob", LastName = "Dylan", Address = "White street 1", PostCode = "10616",
                    PhoneNumber = "+123456", PasswordHash = new byte[40], PasswordSalt = new byte[40], IsAdmin = true },
             };

            _userRepoMock.Setup(repo => repo.ReadAllUsers()).Returns(() => listOfUser);

            var service = new UserService(_userRepoMock.Object, _authenticationHelper);

            var actual = service.GetAllUsers();

            var expected = new List<User>{
                new User {Id =  1, Email="user@email.com", FirstName = "Bob", LastName = "Dylan", Address = "White street 1", PostCode = "10616",
                    PhoneNumber = "+123456", PasswordHash = new byte[40], PasswordSalt = new byte[40], IsAdmin = true },
                new User {Id =  2, Email="bob@email.com", FirstName = "Bob", LastName = "Dylan", Address = "White street 1", PostCode = "10616",
                    PhoneNumber = "+123456", PasswordHash = new byte[40], PasswordSalt = new byte[40], IsAdmin = true },
                new User {Id =  3, Email="rod@email.com", FirstName = "Bob", LastName = "Dylan", Address = "White street 1", PostCode = "10616",
                    PhoneNumber = "+123456", PasswordHash = new byte[40], PasswordSalt = new byte[40], IsAdmin = true },
             };

            actual.Should().BeEquivalentTo(expected);
        }



    }
}
