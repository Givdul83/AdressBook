namespace AdressBook.Interfaces
{
    public interface IPerson
    {
        string City { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int PhoneNumber { get; set; }
        string StreetName { get; set; }
        int StreetNumber { get; set; }
    }
}