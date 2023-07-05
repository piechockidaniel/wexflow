﻿namespace Wexflow.Core.Db.Firebird
{
    public class UserWorkflow : Core.Db.UserWorkflow
    {
        public const string ColumnName_Id = "ID";
        public const string ColumnName_UserId = "USER_ID";
        public const string ColumnName_WorkflowId = "WORKFLOW_ID";

        public const string TableStruct = "(" + ColumnName_Id + " integer generated by default as identity primary key, " + ColumnName_UserId + " INTEGER, " + ColumnName_WorkflowId + " INTEGER)";

        public string Id { get; set; }
    }
}
