﻿namespace Freelasync.Core.Exceptions;
public class ProjectAlreadyStartedException : Exception
{
    public ProjectAlreadyStartedException()
        : base("Project is already ind Started status")
    {
        
    }
}
