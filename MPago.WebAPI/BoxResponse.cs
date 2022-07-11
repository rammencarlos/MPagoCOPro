namespace MPago.WebAPI
{
    public class BoxResponse<T>
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public T Object { get; set; }
    }
}
