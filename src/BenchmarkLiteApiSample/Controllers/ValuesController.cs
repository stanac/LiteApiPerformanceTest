using LiteApi;

namespace BenchmarkLiteApiSample.Controllers
{
    public class ValuesController : LiteController
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
