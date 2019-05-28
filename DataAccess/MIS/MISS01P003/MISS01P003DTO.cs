﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataAccess.MIS
{
    [Serializable]
    public class MISS01P003DTO : BaseDTO
    {
        public MISS01P003DTO()
        {
            Model = new MISS01P003Model();   // new โมเดล 
        }

        public MISS01P003Model Model { get; set; }   //model
        public List<MISS01P003Model> Models { get; set; }  //list 
    }

    public class MISS01P003ExecuteType : DTOExecuteType
    {
        
        public const string ConfirmStatus = "ConfirmStatus";
        public const string GetDoneTask = "GetDoneTask";
        public const string UpdateSolutionResult = "UpdateSolutionResult";
        public const string GetDoTask = "GetDoTask";
        public const string GetNewTask = "GetNewTask";
        public const string SolutionResult = "SolutionResult";
    }
}