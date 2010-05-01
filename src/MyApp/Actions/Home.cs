using MyApp.Models;

namespace MyApp.Actions
{
    public class Home
    {
        public IndexResponse Index()
        {
            return new IndexResponse();
        }

        public ShowPersonResponse ShowPerson(ShowPersonRequest request)
        {
            return new ShowPersonResponse();
        }
    }

    public class ShowPersonRequest {}

    public class ShowPersonResponse
    {
        public Person Person { get; set; }
    }

    public class IndexResponse {}
}