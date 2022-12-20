namespace TotalmediaPOCApi.Models
{
    /// <summary>
    /// Api response class
    /// </summary>
    public class ApiResponse
    {
        /// <summary>
        /// If operation has error
        /// </summary>
        public bool HasError { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Response from service  (JSON)
        /// </summary>
        public object Data { get; set; }
    }
}
