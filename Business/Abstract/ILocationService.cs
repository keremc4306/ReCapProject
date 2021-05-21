using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ILocationService
    {
        IDataResult<List<Location>> GetAll();

        IResult Add(Location location);
        IResult Update(Location location);
        IResult Delete(Location location);
    }
}
