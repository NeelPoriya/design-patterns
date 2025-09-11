using System.Text.Json;

namespace ConsoleApp.Design_Patterns.Builder
{
    class HttpRequest
    {
        public string Url { get; private set; }
        public string Method { get; private set; }
        public Dictionary<string, string> Headers { get; } = new();
        public Dictionary<string, string> QueryParams { get; } = new();
        public int Timeout { get; private set; }

        private HttpRequest(Builder builder)
        {
            Url = builder.Url;
            Method = builder.Method;
            Headers = builder.Headers;
            QueryParams = builder.QueryParams;
            Timeout = builder.Timeout;
        }

        public override string ToString()
        {
            return $"Url: {Url}, Method: {Method}, Headers: {JsonSerializer.Serialize(Headers)}, QueryParams: {JsonSerializer.Serialize(QueryParams)}, Timeout: {Timeout}";
        }

        public class Builder
        {
            public string Url { get; }
            public string Method { get; private set; } = "GET";
            public Dictionary<string, string> Headers { get; } = new();
            public Dictionary<string, string> QueryParams { get; } = new();
            public int Timeout { get; private set; }

            public Builder(string url)
            {
                Url = url;
            }

            public void SetMethod(string method)
            {
                Method = method;
            }

            public void AddQueryParam(string key, string value)
            {
                QueryParams[key] = value;
            }

            public void AddHeader(string key, string value)
            {
                Headers[key] = value;
            }

            public void SetTimeout(int timeout)
            {
                Timeout = timeout;
            }

            public HttpRequest Build()
            {
                return new HttpRequest(this);
            }
        }
    }
}
