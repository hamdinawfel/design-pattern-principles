namespace OCP;

public interface IApplicantModel
{
    string FirstName { get; set; }
    string Lastname { get; set; }

    IAccounts AccountProcessor { get; set; }
}