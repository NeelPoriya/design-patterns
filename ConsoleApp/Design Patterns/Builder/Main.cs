namespace ConsoleApp.Design_Patterns.Builder
{
    class Main
    {
        public static void main()
        {
            HttpRequest.Builder httpRequestBuilder = new HttpRequest.Builder("https://microsoft.com");
            httpRequestBuilder.SetMethod("POST");
            httpRequestBuilder.SetTimeout(30);
            httpRequestBuilder.AddQueryParam("Prefer", "nothing");

            HttpRequest httpRequest = httpRequestBuilder.Build();

            Console.WriteLine(httpRequest);
        }
    }
}
