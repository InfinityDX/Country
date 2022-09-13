namespace Country.Models
{
    public class BaseResponse<T>
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public T Data { get; set; }

        public BaseResponse(int errorCode, string errorMessage, T data)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            Data = data;
        }
    }
}
