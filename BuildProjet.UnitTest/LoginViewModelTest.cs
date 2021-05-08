using System;
using System.Collections.Generic;
using System.Text;
using BuildProject.ViewModels;
using Xunit;

namespace BuildProjet.UnitTest
{
    public class LoginViewModelTest
    {
        [Fact]
        public void LoginCommand_Not_Null_Test()
        {
            var LoginViewModel = new LoginViewModel();

            Assert.NotNull(LoginViewModel.LoginCommand);

        }
    }
}
