namespace Joe.Opayo.Admin.Api.Client.Model.Exceptions
{
    public class ProcessApiCommandException : Exception
    {
        public ProcessApiCommandException() { }

        public ProcessApiCommandException(string message) : base(message) { }

        public ProcessApiCommandException(string message, Exception inner) : base(message, inner) { }
    }
}
