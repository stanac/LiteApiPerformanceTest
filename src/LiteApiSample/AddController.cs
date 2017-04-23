using LiteApi;
using LiteApi.Attributes;

namespace LiteApiSample
{
    [RestfulLinks]
    public class AddController: LiteController
    {
        public int Add(int a, int b) => a + b;
    }
}
