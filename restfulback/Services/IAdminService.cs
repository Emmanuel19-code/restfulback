using restfulback.Domain;
using restfulback.Domain.Contracts;



namespace restfulback.Services
{
    public interface IAdminService
    {
        Task<ApiResponse> RegisterDeceased(AddDeceasedData request);
        Task<ApiDataResponse<DeceasedData>> GetDeceasedInfo(Guid Id);
        Task<ApiDataResponse<List<DeceasedData>>> AllRegisteredData();
        Task<ApiDataResponse<string>> Login(AccessDto request);
        
    }
}