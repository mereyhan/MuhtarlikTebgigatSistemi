namespace MuhtarlikTebgigatSistemi.Model;

public class DocumentTypeModel
{
    public int DocumentTypeId { get; set; }
    public string DocumentType { get; set; }
    public DateTime RegisterDate { get; set; }
    public DateTime? UpdateDate { get; set; }
}
