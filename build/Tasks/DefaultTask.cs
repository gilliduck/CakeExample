using Build.Tasks;
using Cake.Frosting;

[IsDependentOn(typeof(TestTask))]
public sealed class Default : FrostingTask
{
}