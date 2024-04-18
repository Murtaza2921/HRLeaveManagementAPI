using AutoMapper;

using HRLeaveManagement.Application.DTOs;
using HRLeaveManagement.Application.Features.Requests.Queries;
using HRLeaveManagement.Application.Presistence.Contracts;

using MediatR;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HRLeaveManagement.Application.Features.Handlers.Queries
{
    public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
    {
        private readonly ILeaveRequestRepositoy _leaveTypeRepository;
        private readonly IMapper _mapper;
        public GetLeaveTypeListRequestHandler( ILeaveRequestRepositoy leaveRequestRepositoy, IMapper mapper)
        {
            _leaveTypeRepository = leaveRequestRepositoy;
            _mapper = mapper;
        }
        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
        {
            var leaveTypes = await _leaveTypeRepository.GetAll();
            return _mapper.Map<List<LeaveTypeDto>>(leaveTypes);
        }
    }
}
