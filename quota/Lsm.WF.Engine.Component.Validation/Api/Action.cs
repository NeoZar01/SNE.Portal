﻿using System;

namespace DoE.Lsm.WF.WI.Api
{
    using WI.Api;
    using Data.Repositories;

    public class Action  : IActionWorker , IDisposable
    {

        protected readonly IRepositoryStoreManager _repositoryManager;

        public ProcessStepsFactory Invoke
        {
            get { throw new ApplicationException(); }
        }


        public IActionWorker GetWorker(string StepName, string precedingStepId, string precedingStepInstanceId, string currentStepInstanceId)
        {
            return this;
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public Action(IRepositoryStoreManager repositoryManager)
        {
            this._repositoryManager = repositoryManager;
        }
    }
}