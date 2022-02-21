using Entitas;
using Entitas.Generic;

public sealed class Entity_Get_CompData_Class : IPerformanceTest
{
    private const int n = 10000000;
    private Entity<TestScope1> _e;
    public int Iterations => n;

    public void Before()
    {
        var contexts = new Contexts();
        contexts.AddScopedContexts();

        var context = contexts.Get<TestScope1>();
        _e = context.CreateEntity();
        _e.Add(new TestCompA_Scope1(5));
        _e.Add(new TestCompB_Scope1(5));
        _e.Flag<TestCompAFlag_Scope1>(true);
    }

    public void Run()
    {
        for (int i = 0; i < n; i++)
        {
            var comp = _e.Get<TestCompA_Scope1>();
        }
    }
}