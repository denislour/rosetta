namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCodeContext = statusCode;
            Message = message ?? GetDefaultForStatusCodeMessage(statusCode);
        }

        private string GetDefaultForStatusCodeMessage(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request you had made.",
                401 => "Authorized you are not",
                404 => "Resource found, it was not",
                500 => "Server error",
                _ => null
            };
        }

        public int StatusCodeContext { get; set; }
        public string Message { get; set; }
    }
}
