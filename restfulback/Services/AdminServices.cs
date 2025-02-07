using AutoMapper;
using Microsoft.EntityFrameworkCore;
using restfulback.Domain;
using restfulback.Domain.Contracts;
using restfulback.Domain.Entity;
using restfulback.Infrastructure;

namespace restfulback.Services
{
    public class AdminService : IAdminService
    {
        private readonly ApplicationDb _applicationDb;
        private readonly IMapper _mapper;
        public AdminService(ApplicationDb applicationDb, IMapper mapper)
        {
            _applicationDb = applicationDb;
            _mapper = mapper;
        }


        public async Task<ApiResponse> RegisterDeceased(AddDeceasedData request)
        {
            Console.WriteLine("this is called");
            if (request is null)
            {
                return new ApiResponse
                {
                    Message = "Please provide missing information",
                    StatusCode = 400
                };
            }
            Console.WriteLine(request.FullName,
                 request.Gender,
                 request.DateOfBirth,
                request.DateOfDeath,
                request.Age,
                request.Address,
                 request.CauseOfDeath,
                 request.CHINumber,
                 request.NextOfKinName,
                request.NextOfKinGender,
                 request.RelationshipToDeceased,
                 request.NextOfKinEmail,
                 request.NextOfKinPhone,
                 request.NextOfKinAddress,
                 request.RegistrationOffice);
            var deceased = new DeceasedProfile
            {
                FullName = request.FullName,
                Gender = request.Gender,
                DateOfBirth = request.DateOfBirth,
                DateOfDeath = request.DateOfDeath,
                Age = request.Age,
                Address = request.Address,
                CauseOfDeath = request.CauseOfDeath,
                CHINumber = request.CHINumber,
                NextOfKinName = request.NextOfKinName,
                NextOfKinGender = request.NextOfKinGender,
                RelationshipToDeceased = request.RelationshipToDeceased,
                NextOfKinEmail = request.NextOfKinEmail,
                NextOfKinPhone = request.NextOfKinPhone,
                NextOfKinAddress = request.NextOfKinAddress,
                RegistrationOffice = request.RegistrationOffice
            };

            await _applicationDb.DeceasedProfiles.AddAsync(deceased);
            await _applicationDb.SaveChangesAsync();

            var response = new ApiResponse
            {
                Message = "Created",
                StatusCode = 200
            };
            return response;
        }

        public async Task<ApiDataResponse<DeceasedData>> GetDeceasedInfo(Guid Id)
        {
            var profile = await _applicationDb.DeceasedProfiles.FindAsync(Id);
            if (profile == null)
            {
                return new ApiDataResponse<DeceasedData>
                {
                    Data = null,
                    Message = "Profile Not Found",
                    StatusCode = 404
                };
            }
            var profileData = _mapper.Map<DeceasedData>(profile);
            return new ApiDataResponse<DeceasedData>
            {
                Data = profileData,
                StatusCode = 200
            };
        }

        public async Task<ApiDataResponse<List<DeceasedData>>> AllRegisteredData()
        {
            var profiles = await _applicationDb.DeceasedProfiles.ToListAsync();
            var profileData = _mapper.Map<List<DeceasedData>>(profiles);
            return new ApiDataResponse<List<DeceasedData>>
            {
                Data = profileData,
                StatusCode = 200
            };
        }

        public async Task<ApiDataResponse<string>> Login(AccessDto request)
        {
            if (request == null)
            {
                return new ApiDataResponse<string>
                {
                    Data = "",
                    Message = "Please Provide Missing Data",
                    StatusCode = 400
                };
            }
            var user = await _applicationDb.Users.FirstOrDefaultAsync(p => p.UserName == request.UserName);
            if (user == null)
            {
                return new ApiDataResponse<string>
                {
                    Data = "",
                    Message = "Profile Not Recongnized",
                    StatusCode = 400
                };
            }
            return new ApiDataResponse<string>
            {
                Data = user.UserName,
                Message = "Account Verified Successfully",
                StatusCode = 200
            };
        }

        public async Task<List<DeceasedData>> SearchForInformation(string search)
        {
            var info = await _applicationDb.DeceasedProfiles
        .Where(c => c.FullName.ToLower().Contains(search.ToLower()))
        .ToListAsync();
            var profileData = _mapper.Map<List<DeceasedData>>(info);
            return profileData;
        }
    }


}
