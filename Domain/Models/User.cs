namespace BrotaAPI.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber {  get; set; }
        public DateTime EmailVerificationDate {  get; set; }
        public DateTime PhoneNumberVerificationDate {  get; set; }
        public DateTime VerificationDate {  get; set; }
        public DateTime CreationDate {  get; set; }
        public DateTime UpdateDate {  get; set; }
    }
}
