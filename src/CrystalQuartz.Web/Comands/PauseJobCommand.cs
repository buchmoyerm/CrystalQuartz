﻿using CrystalQuartz.Core;
using CrystalQuartz.Core.SchedulerProviders;
using CrystalQuartz.Web.Comands.Inputs;
using Quartz;

namespace CrystalQuartz.Web.Comands
{
    public class PauseJobCommand : AbstractOperationCommand<JobInput>
    {
        public PauseJobCommand(ISchedulerProvider schedulerProvider, ISchedulerDataProvider schedulerDataProvider) : base(schedulerProvider, schedulerDataProvider)
        {
        }

        protected override void PerformOperation(JobInput input)
        {
            Scheduler.PauseJob(new JobKey(input.Job, input.Group));
        }
    }
}