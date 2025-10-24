namespace M_UserLogin.Models
{
    // ⚠️ This model is used to pass error information to the Error View
    // It helps display a unique Request ID for debugging when an error occurs
    public class ErrorViewModel
    {
        // 🧾 RequestId holds a unique ID for the current request (used to trace an error)
        // The "?" means this property can be null (optional)
        public string? RequestId { get; set; }

        // 🧠 This is a read-only property (called a "computed property")
        // It checks if RequestId is NOT empty or null — if true, it means we can show it in the view
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
