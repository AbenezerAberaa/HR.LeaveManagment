﻿using HR.LeaveManagment.Applicatiion.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Applicatiion.DTOs.LeaveAllocation
{
    public class UpdateLeaveAllocationDto : BaseDto , ILeaveAllocationDto
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
