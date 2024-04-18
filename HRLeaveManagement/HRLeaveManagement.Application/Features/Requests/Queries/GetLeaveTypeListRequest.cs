using HRLeaveManagement.Application.DTOs;
using MediatR;

using System.Collections.Generic;

namespace HRLeaveManagement.Application.Features.Requests.Queries
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {
    }
}
