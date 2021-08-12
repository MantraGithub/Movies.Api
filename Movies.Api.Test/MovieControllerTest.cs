using Movie.API.Controllers;
using Xunit;

namespace Movies.Api.Test
{
    public class MovieControllerTest
    {
        [Fact]
        public void Get_Test()
        {
            MoviesController controller = new MoviesController();
            var result = controller.Get();
            Assert.NotNull(result);
        }
    }
}
