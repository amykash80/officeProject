using StreamlineAcademy.Application.RRModels;
using StreamlineAcademy.Application.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Application.Abstractions.IServices
{
    public interface IEnquiryService
    {
        Task<ApiResponse<EnquiryResponse>> AddEnquiry (EnquiryRequest request);
        Task<ApiResponse<EnquiryResponse>> UpdateEnquiry(EnquiryUpdateRequest request);

        Task <ApiResponse<EnquiryResponse>> DeleteEnquiry (Guid id);

        Task<ApiResponse<IEnumerable<EnquiryResponse>>> GetAllEnquiries();

        Task<ApiResponse<EnquiryResponse>> GetEnquiryById(Guid id);

        Task<bool> UpdateEnquiryStatus(string email);
    }
}
