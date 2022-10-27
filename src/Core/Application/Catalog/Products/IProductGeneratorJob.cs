using System.ComponentModel;

namespace FSH.WebApi.Application.Catalog.Products;

public interface IProductGeneratorJob : IScopedService
{
    [DisplayName("Generate Random Product example job on Queue notDefault")]
    Task GenerateAsync(int nSeed, CancellationToken cancellationToken);

    [DisplayName("removes all random Products created example job on Queue notDefault")]
    Task CleanAsync(CancellationToken cancellationToken);
}
