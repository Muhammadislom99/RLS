namespace Domain.Entities;

public class Country : BaseEntity
{
    public string Code { get; set; }
    public string Name { get; set; }
}

public class Nationality : BaseEntity
{
    public string Name { get; set; }
    public string Code { get; set; }
}