﻿using CrystalQuartz.Core;
using CrystalQuartz.Core.SchedulerProviders;
using CrystalQuartz.Web.Comands.Inputs;
using Quartz;
using Quartz.Impl.Matchers;

namespace CrystalQuartz.Web.Comands
{
    public class ResumeGroupCommand : AbstractOperationCommand<GroupInput>
    {
        public ResumeGroupCommand(ISchedulerProvider schedulerProvider, ISchedulerDataProvider schedulerDataProvider) : base(schedulerProvider, schedulerDataProvider)
        {
        }

        protected override void PerformOperation(GroupInput input)
        {
            Scheduler.ResumeJobs(GroupMatcher<JobKey>.GroupEquals(input.Group));
        }
    }
}