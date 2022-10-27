namespace FSH.WebApi.Application.Catalog.Brands;

public interface IBrandService : ITransientService
{
    Task<List<BrandDto>> GetListAsync(CancellationToken cancellationToken);

    Task<int> GetCountAsync(CancellationToken cancellationToken);

    Task<bool> ExistsAsync(string brandName, string? excludeId);

    Task<BrandDto> GetByIdAsync(string id);

    Task<BrandDto> GetByIdWithPermissionsAsync(string brandId, CancellationToken cancellationToken);

//    Task<string> CreateOrUpdateAsync(CreateOrUpdateBrandRequest request);

//    Task<string> UpdatePermissionsAsync(UpdateBrandPermissionsRequest request, CancellationToken cancellationToken);

    Task<string> DeleteAsync(string id);
}