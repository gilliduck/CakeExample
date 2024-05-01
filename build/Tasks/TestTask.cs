using Cake.Common.Tools.DotNet;
using Cake.Common.Tools.DotNet.Test;
using Cake.Frosting;

namespace Build.Tasks;

[TaskName("Test")]
[IsDependentOn(typeof(BuildTask))]
public sealed class TestTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.DotNetTest($"{context.SolutionPath}/CakeTest.sln", new DotNetTestSettings
        {
            Configuration = context.BuildType,
            NoBuild = true
        });
    }
}