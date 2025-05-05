using JWTTokendemo.Data.Entities;

namespace JWTTokendemo.Data.Interface
{
    public interface IState
    {
        List<State> GetAllState();
        bool AddState(State state);
        bool UpdateState(State state);
        bool DeleteState(int id);
    }
}
