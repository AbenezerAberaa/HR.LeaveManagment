﻿using HR.LeaveManagment.Applicatiion.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Applicatiion.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand : IRequest<int>
    {
        public LeaveRequestDto LeaveRequestDto { get; set; }
    }
}
