using SafCos.Core.AppService.ServiceInterface;
using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.AppService.Validators
{
    public class LoginValidator : IValidator<LoginInputModel>
    {
        public void DefaultValidation(LoginInputModel entity)
        {
            ValidateUsername(entity.Username);
            ValidatePassword(entity.Password);
        }
        private void ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentNullException(nameof(username), "Username cannot be empty or whitespaces.");
        }

        private void ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException(nameof(password), "Password cannot be empty or whitespaces.");
        }
    }
}
