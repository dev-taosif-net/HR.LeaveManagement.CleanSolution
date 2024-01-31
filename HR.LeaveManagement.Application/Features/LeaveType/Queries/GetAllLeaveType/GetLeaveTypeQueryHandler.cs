using AutoMapper;
using HR.LeaveManagement.Application.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveType;

public class GetLeaveTypeQueryHandler : IRequestHandler<GetLeaveTypeQuery, List<LeaveTypeDTO>>
{
    private readonly IMapper mapper;
    private readonly ILeaveType leaveType;

    public GetLeaveTypeQueryHandler(IMapper mapper,ILeaveType leaveType)
    {
        this.mapper = mapper;
        this.leaveType = leaveType;
    }


    public async Task<List<LeaveTypeDTO>> Handle(GetLeaveTypeQuery request, CancellationToken cancellationToken)
    {

        var lt = await leaveType.GetAsync();

        var resullt= mapper.Map<List<LeaveTypeDTO>>(lt);

        return resullt;
    }
}
