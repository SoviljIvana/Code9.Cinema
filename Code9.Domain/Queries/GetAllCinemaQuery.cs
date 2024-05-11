using Code9.Domain.Interfaces;
using Code9.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code9.Domain.Queries
{
    public class GetAllCinemaQuery: IRequest<List<Cinema>>
    {
        
    }
    public class GetAllCinemaQueryHendler : IRequestHandler<GetAllCinemaQuery, List<Cinema>>
    {
        public GetAllCinemaQueryHendler(ICinemaRepository icinema)
        {
            Icinema = icinema;
        }

        public ICinemaRepository Icinema { get; }

        public async Task<List<Cinema>> Handle(GetAllCinemaQuery request, CancellationToken cancellationToken)
        {
            return await Icinema.GetAllCinemas();
        }
    }


}
