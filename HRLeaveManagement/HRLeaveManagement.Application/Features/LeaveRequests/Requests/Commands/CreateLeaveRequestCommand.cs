﻿using HRLeaveManagement.Application.DTOs.LeaveAllcation;

using MediatR;

using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand : IRequest<int>
    {
        public CreateLeaveAllocationDto createLeaveAllocationDto { get; set; }
    }
}
