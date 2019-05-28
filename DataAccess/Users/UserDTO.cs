using System;
using System.Collections.Generic;
using UtilityLib;
using DataAccess.SEC;

namespace DataAccess.Users
{
    [Serializable]
    public class UserDTO : BaseDTO
    {
        public UserDTO()
        {
            Model = new UserModel();
            Notification = new NotificationModel();
        }
        
        public UserModel Model { get; set; }
        public List<ModuleModel> ConfigGerarals { get; set; }
        public List<AppModel> Apps { get; set; }
        public List<NotificationModel> Notifications { get; set; }
        public NotificationModel Notification { get; set; }
        public DashboardNewIssueModel DashboardNewIssue { get; set; }
        public List<DashboardNewIssueModel> DashboardNewIssues { get; set; }
        public DashboardCountSummaryModel DashboardCountSummary { get; set; }
        public List<DashboardCountSummaryModel> DashboardCountSummarys { get; set; }
    }

    public class UserExecuteType : DTOExecuteType
    {
        public const string GetUser = "GetUser"; 
        public const string GetConfigGeraral = "GetConfigGeraral";
        public const string GetConfigSys = "GetConfigSys";
        public const string GetApp = "GetApp";
        public const string GetNotification = "GetNotification";
        public const string GetNotificationCount = "GetNotificationCount";
        public const string FatchNotification = "FatchNotification";
        public const string DashboardNewIssue = "DashboardNewIssue";
        public const string DashboardCountSummary = "DashboardCountSummary";
        public const string DashboardCountSummaryAll = "DashboardCountSummaryAll";
        public const string UpdateFlag = "UpdateFlag";
        
    }

    
    //UserDA dal = new UserDA();
    //UserDTO dto = new UserDTO();
    //dto.Query.ExecuteType = UserExecuteType.GetByInRelateID;
    //        dal.Select(dto);
}