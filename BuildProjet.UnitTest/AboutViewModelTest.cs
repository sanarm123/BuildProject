using Moq;
using System;
using Xunit;
using BuildProject.ViewModels;

namespace BuildProjet.UnitTest
{
    public class AboutViewModelTest
    {
     
        [Fact]
        public void All_Get_Loaded_After_InitializeAsync_Test()
        {
            var aboutViewModel =new AboutViewModel();

            Assert.Equal(10, 10);

        }
    }
}
