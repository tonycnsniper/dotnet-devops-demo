using System.Collections.Generic;
using dotnet_core_mvc.Models;

namespace dotnet_core_mvc.Services;

public interface IThreaterService
{
    Task<IEnumerable<Threater>> DisplayAllThreaters();
    Threater GetThreaterById(int id);
    Task<bool> AddThreater(Threater threater);
    void RemoveThreater(int id);

}