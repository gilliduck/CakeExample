using Cake.Common;
using Cake.Core;
using Cake.Frosting;

public class BuildContext : FrostingContext
{
    public string MsBuildConfiguration { get; set; }
    public string SolutionPath => "../src/CakeTest";

    public BuildContext(ICakeContext context)
        : base(context)
    {
        MsBuildConfiguration = context.Argument("configuration", "Release");
    }
}