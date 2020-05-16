﻿namespace Wexflow.Core.Db.Oracle
{
    public class Approver : Core.Db.Approver
    {
        public static readonly string ColumnName_Id = "ID";
        public static readonly string ColumnName_UserId = "USER_ID";
        public static readonly string ColumnName_RecordId = "RECORD_ID";
        public static readonly string ColumnName_Approved = "APPROVED";
        public static readonly string ColumnName_ApprovedOn = "APPROVED_ON";

        public static readonly string TableStruct = "(" + ColumnName_Id + " NUMBER GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY, "
                                                        + ColumnName_UserId + " INTEGER, "
                                                        + ColumnName_RecordId + " INTEGER, "
                                                        + ColumnName_Approved + " NUMBER(1), "
                                                        + ColumnName_ApprovedOn + " TIMESTAMP)";

        public long Id { get; set; }

        public override string GetDbId()
        {
            return Id.ToString();
        }
    }
}