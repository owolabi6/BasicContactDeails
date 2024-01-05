using BasicContactList;

public class contactException : Exception
{
    public contactException() : base() { }

    public contactException(string message) : base(message) { }

    //public contactException(string message, Exception innerException) : base(message, innerException) { }
}
// public class ContactAlreadyExistsException : Exception
// {
//     public ContactAlreadyExistsException() : base("Contact already exists!")
//     {
//     }
// }
