using HRLeaveManagement.Application.DTOs.LeaveAllcation;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveRequestDetailRequest : IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }
}
