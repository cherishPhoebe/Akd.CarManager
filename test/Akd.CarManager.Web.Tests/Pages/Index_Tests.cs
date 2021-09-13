using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Akd.CarManager.Pages
{
    public class Index_Tests : CarManagerWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
