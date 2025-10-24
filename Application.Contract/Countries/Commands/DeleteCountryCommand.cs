namespace Application.Contract.Countries.Commands;

public record DeleteCountryCommand()
{
    public Guid Id { get; init; }
};