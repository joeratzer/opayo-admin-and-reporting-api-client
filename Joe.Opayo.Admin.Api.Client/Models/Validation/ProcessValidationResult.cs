namespace Joe.Opayo.Admin.Api.Client.Models.Validation
{
    public class ProcessValidationResult
    {
        public ProcessValidationResult()
        {
            ErrorMessages = new List<string>();
        }

        public List<string> ErrorMessages { get; protected set; }
        public bool Success => !ErrorMessages.Any();

        public void AddErrorMessage(string message)
        {
            ErrorMessages.Add(message);
        }
    }
}
