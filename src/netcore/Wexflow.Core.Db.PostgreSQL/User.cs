﻿namespace Wexflow.Core.Db.PostgreSQL
{
    public class User : Core.Db.User
    {
        public const string ColumnName_Id = "ID";
        public const string ColumnName_Username = "USERNAME";
        public const string ColumnName_Password = "PASSWORD";
        public const string ColumnName_UserProfile = "USER_PROFILE";
        public const string ColumnName_Email = "EMAIL";
        public const string ColumnName_CreatedOn = "CREATED_ON";
        public const string ColumnName_ModifiedOn = "MODIFIED_ON";

        public const string TableStruct = "(" + ColumnName_Id + " SERIAL PRIMARY KEY, " + ColumnName_Username + " VARCHAR(255), " + ColumnName_Password + " VARCHAR(255), " + ColumnName_UserProfile + " INT, " + ColumnName_Email + " VARCHAR(255), " + ColumnName_CreatedOn + " TIMESTAMP, " + ColumnName_ModifiedOn + " TIMESTAMP)";

        public int Id { get; set; }

        public override string GetDbId()
        {
            return Id.ToString();
        }
    }
}
