using HRLeaveManagement.Application.DTOs.LeaveAllcation;

using MediatR;

using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Application.Features.LeaveAllocations.Requests.Commands
{
    public class CreateLeaveAllocationCommand : IRequest<int>
    {
        public LeaveAllocationDto leaveAllocationDto { get; set; }
    }
}
