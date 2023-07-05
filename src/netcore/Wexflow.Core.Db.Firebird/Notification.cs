﻿namespace Wexflow.Core.Db.Firebird
{
    public class Notification : Core.Db.Notification
    {
        public const string ColumnName_Id = "ID";
        public const string ColumnName_AssignedBy = "ASSIGNED_BY";
        public const string ColumnName_AssignedOn = "ASSIGNED_ON";
        public const string ColumnName_AssignedTo = "ASSIGNED_TO";
        public const string ColumnName_Message = "MESSAGE";
        public const string ColumnName_IsRead = "IS_READ";

        public const string TableStruct = "(" + ColumnName_Id + " integer generated by default as identity primary key, "
                                                        + ColumnName_AssignedBy + " INTEGER, "
                                                        + ColumnName_AssignedOn + " TIMESTAMP, "
                                                        + ColumnName_AssignedTo + " INTEGER, "
                                                        + ColumnName_Message + " BLOB SUB_TYPE TEXT, "
                                                        + ColumnName_IsRead + " BOOLEAN)";

        public int Id { get; set; }

        public override string GetDbId()
        {
            return Id.ToString();
        }
    }
}
