using JWTTokendemo.Data.Entities;
using JWTTokendemo.Data.Interface;

namespace JWTTokendemo.Data.Repository
{
    public class StateRepository : IState
    {
        private readonly ApplicationDbContext _context;

        public StateRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddState(State state)
        {
            _context.States.Add(state);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteState(int id)
        {
            var state = _context.States.FirstOrDefault(s => s.Id == id);
            _context.States.Remove(state);
            _context.SaveChanges();
            return true;
        }

        public List<State> GetAllState()
        {
            return _context.States.ToList();
        }

        public bool UpdateState(State state)
        {
            _context.States.Update(state);
            _context.SaveChanges();
            return true;
        }
    }
}
