using HRLeaveManagement.Domain;

using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Application.Presistence.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
    }
}
