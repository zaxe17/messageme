using System.Globalization;

namespace mvc_example.Models
{
    public class MessageModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

        public string UpperCaseName => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(FullName?.ToLower());

    }
}
