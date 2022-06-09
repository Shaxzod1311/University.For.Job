using Newtonsoft.Json;

namespace University.Domain.Common
{
    public class BaseResponse<T>
    {
        [JsonIgnore]
        public int? Code { get; set; }

        public T Data { get; set; }
        public BaseError Error { get; set; }

    }
}
