namespace restfulback.Domain.Contracts
{
    public class ApiDataResponse<T>
    {
        public T? Data { get; set; }
        public string Message { get; set; } 
        public int StatusCode { get; set; }
    }
    public class ApiResponse
    {
        public string? Message { get; set; }
        public int StatusCode { get; set; }
    }
}