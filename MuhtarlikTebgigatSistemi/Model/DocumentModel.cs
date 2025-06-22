namespace MuhtarlikTebgigatSistemi.Model;

public class DocumentModel
{
    public int DocumentId { get; set; }
    public int DocumentTypeId { get; set; }
    public int? PersonId { get; set; }
    public int? CompanyId { get; set; }
    public int? ReceiverId { get; set; }
    public DateTime RegistrationDate { get; set; }
    public DateTime? UpdateDate { get; set; }
}

public class DocumentOverviewModel
{
    public int DocumentId { get; set; }
    public string? DocumentType { get; set; }
    public DateTime? RegistrationDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? ReceiverName { get; set; }
    public string? Name { get; set; }
    public string? Street { get; set; }
    public string? Building { get; set; }
}
