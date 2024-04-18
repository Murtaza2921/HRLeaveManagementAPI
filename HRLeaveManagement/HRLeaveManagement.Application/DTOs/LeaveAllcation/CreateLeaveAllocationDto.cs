using HRLeaveManagement.Application.DTOs.Common;

using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Application.DTOs.LeaveAllcation
{
    public class CreateLeaveAllocationDto : BaseDto
    {
        public int NumberOfDays {  get; set; }
        public int LeaveTypeId { get; set; }
        public int period { get; set; }
    }

}
