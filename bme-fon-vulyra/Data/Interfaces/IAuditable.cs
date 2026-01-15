namespace bme_fon_vulyra.Data.Interfaces
{
    public interface IAuditable
    {
        DateTimeOffset? CreatedOn { get; set; }
    }
}
