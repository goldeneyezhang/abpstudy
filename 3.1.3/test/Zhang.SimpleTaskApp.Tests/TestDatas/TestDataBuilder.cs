using Zhang.SimpleTaskApp.EntityFrameworkCore;
using Zhang.SimpleTaskApp.Tasks;

namespace Zhang.SimpleTaskApp.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly SimpleTaskAppDbContext _context;

        public TestDataBuilder(SimpleTaskAppDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
			//create test data here...
			_context.Tasks.AddRange(
		  new Task1("Follow the white rabbit", "Follow the white rabbit in order to know the reality."),
		  new Task1("Clean your room") { State = TaskState.Completed }
		  );
		}
    }
}