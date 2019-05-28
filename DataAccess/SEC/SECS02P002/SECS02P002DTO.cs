﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataAccess.SEC
{
    [Serializable]
    public class SECS02P002DTO : BaseDTO
    {
        public SECS02P002DTO()
        {
            Model = new SECS02P002Model();
        }

        public SECS02P002Model Model { get; set; }
        public List<SECS02P002Model> Models { get; set; }
    }

    public class SECS02P002ExecuteType : DTOExecuteType
    {
        public const string GetQuerySearchAll = "GetQuerySearchAll";
        public const string GetQueryCheckUserAdmin = "GetQueryCheckUserAdmin";
        public const string GetDetailByID = "GetDetailByID";
        public const string Delete = "Delete"; 
        public const string DeleteDetail = "DeleteDetail";
        public const string UpdateLastLogin = "UpdateLastLogin";
        public const string Update = "Update"; 
        public const string GetOldPwd = "GetOldPwd";
        public const string GetFullAppName = "GetFullAppName";
        public const string CheckAdmin = "CheckAdmin";
        public const string GetUserCOM = "GetUserCOM";
        public const string ForGetPassword = "ForGetPassword";
        public const string GetUser = "GetUser"; 
    }
}