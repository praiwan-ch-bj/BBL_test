namespace test_01.Wrapper
{
    public static class ApiResponse
    {
        public static ApiResponse<T> Response<T>(int statusCode, T data, string message)
            => new() { StatusCode = statusCode, Message = message, Data = data };
    }

    public class ApiResponse<T>
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public T? Data { get; set; }
    }
}
