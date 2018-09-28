using Newtonsoft.Json;

namespace Helpers
{
    public class TestHelpers
    {
        public static string GenerateUserMessage(object output, object expectedOutput)
        {
            return "Output: " + JsonConvert.SerializeObject(output) + " != " + JsonConvert.SerializeObject(expectedOutput);
        }
    }
}
