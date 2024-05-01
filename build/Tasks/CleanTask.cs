﻿using Cake.Common.IO;
using Cake.Frosting;

namespace Build.Tasks;

[TaskName("Clean")]
public sealed class CleanTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.CleanDirectory($"{context.SolutionPath}/CakeTest.ConsoleApp/bin/{context.MsBuildConfiguration}");
    }
}