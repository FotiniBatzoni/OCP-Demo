using OCPLibrary;


namespace OCP__Library.Applicants
{
    public class TechnicianModel : IApplicantModel
    {
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public IAccounts AccountProcessor { get; set; } = new Accounts();
    }
}
