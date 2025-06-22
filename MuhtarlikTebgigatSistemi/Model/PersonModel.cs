namespace MuhtarlikTebgigatSistemi.Model;

public class PersonModel
{
    public int PersonId { get; set; }
    // Visual Studio'nun nullable olabileceğini düşünmesi (CS8618) nedeniyle başlangıç ataması yapıyorum. çünkü bu alan zorunlu.
    public string PersonName { get; set; }
    public int StreetId { get; set; }
    public string Building { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public DateTime RegisterDate { get; set; }
    public DateTime? UpdateDate { get; set; }
}

public class PersonOverviewModel
{
    public int PersonId { get; set; }
    public string? PersonName { get; set; }
    public string? Street { get; set; }
    public string? Building { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public DateTime? RegisterDate { get; set; }
    public DateTime? UpdateDate { get; set; }
}
