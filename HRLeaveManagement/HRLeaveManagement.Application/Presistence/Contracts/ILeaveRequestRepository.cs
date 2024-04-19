using HRLeaveManagement.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRLeaveManagement.Application.Presistence.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetials(int id);

        Task<List<LeaveRequest>> GetLeaveRequestsWithDetials();

        Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? ApprovalStatus);

    }
}
