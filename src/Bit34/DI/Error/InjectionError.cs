namespace Bit34.DI.Error
{
    public class InjectionError
    {
        //  MEMBERS
        public readonly InjectionErrorType error;
        public readonly string message;

        //  CONSTRUCTOR
        public InjectionError(InjectionErrorType error, string message)
        {
            this.error = error;
            this.message = message;
        }
    }
}
