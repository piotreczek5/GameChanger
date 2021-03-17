using System;
using System.Collections;
using System.Collections.Generic;
using MediatR;

namespace GameChanger.Core.MediatR.Messages.Queries
{
    public class GetAllSectorIdsQuery : IRequest<IEnumerable<Guid>>
    {
    }
}