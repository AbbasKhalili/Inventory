using Newtonsoft.Json;

namespace Framework.ServiceHost.ExceptionHandling
{
    public class ErrorDetails
    {
        public int Code { get; set; }
        public string ErrorMessage { get; set; }


        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
