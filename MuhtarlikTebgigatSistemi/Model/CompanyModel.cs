namespace MuhtarlikTebgigatSistemi.Model;

public class CompanyModel
{
    public int CompanyId { get; set; }
    public string CompanyName { get; set; }
    public int StreetId { get; set; }
    public string Building { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public DateTime RegisterDate { get; set; }
    public DateTime? UpdateDate { get; set; }
}

public class CompanyOverviewModel
{
    public int CompanyId { get; set; }
    public string? CompanyName { get; set; }
    public string? StreetName { get; set; }
    public string? Building { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public DateTime? RegisterDate { get; set; }
    public DateTime? UpdateDate { get; set; }
}