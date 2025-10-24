namespace Application.Contract.Countries.Commands;

public record UpdateCountryCommand()
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Code { get; init; }
}