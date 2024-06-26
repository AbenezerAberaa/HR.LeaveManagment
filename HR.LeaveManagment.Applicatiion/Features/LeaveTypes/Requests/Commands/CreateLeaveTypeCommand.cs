﻿using HR.LeaveManagment.Applicatiion.DTOs.LeaveType;
using HR.LeaveManagment.Applicatiion.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Applicatiion.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand : IRequest<BaseCommondResponse>
    {
        public CreateLeaveTypeDto LeaveTypeDto { get; set; }
    }
}
