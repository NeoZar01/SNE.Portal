﻿using System;

namespace DoE.Lsm.Data.Repositories
{
    using UI;
    using Persons;
    using Repositories;
    using Workflow.Engine;
 
    public interface IRepositoryStoreManager : IDisposable
    {

        ///<summary>
        ///      Create a reference store to the workflow namespace
        ///</summary>
        ProcessManagerRepository Processes
        { get; set; }

        ///<summary>
        ///    Handles profile related queries.
        ///    The <c>ASPNETProfile entity should no longer be used since we split it into </c>
        ///    <see> <c>IPrinciple</c> class and how we can extend its methods to add more custom queries.All methods in this class should be moved to this customization. </see>
        ///</summary>
        IdentityAuthRepository IdentityManager
        { get; set; }

        /// <summary>
        /// 
        /// </summary>
        UIManagerRepository UI
        { get; set; }


        /// <summary>
        /// 
        /// </summary>
        DataExtractRepository ExtractScheduler
        { get; set; }
    }
}
