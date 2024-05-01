using Build;
using Cake.Common;
using Cake.Core;
using Cake.Frosting;

public class BuildContext : FrostingContext
{
    private readonly BuildType _buildType;
    public string BuildType => _buildType.ToString();
    public string SolutionPath => "../src/CakeTest";

    public BuildContext(ICakeContext context)
        : base(context)
    {
        _buildType = context.Argument(nameof(BuildType), Build.BuildType.Debug);
    }
}