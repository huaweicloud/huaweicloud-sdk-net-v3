using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListMigrationTaskResponse : SdkResponse
    {
        /// <summary>
        /// 迁移方式，包括全量迁移和增量迁移两种类型。
        /// </summary>
        /// <value>迁移方式，包括全量迁移和增量迁移两种类型。</value>
        [JsonConverter(typeof(EnumClassConverter<MigrationMethodEnum>))]
        public class MigrationMethodEnum
        {
            /// <summary>
            /// Enum FULL_AMOUNT_MIGRATION for value: full_amount_migration
            /// </summary>
            public static readonly MigrationMethodEnum FULL_AMOUNT_MIGRATION = new MigrationMethodEnum("full_amount_migration");

            /// <summary>
            /// Enum INCREMENTAL_MIGRATION for value: incremental_migration
            /// </summary>
            public static readonly MigrationMethodEnum INCREMENTAL_MIGRATION = new MigrationMethodEnum("incremental_migration");

            private static readonly Dictionary<string, MigrationMethodEnum> StaticFields =
            new Dictionary<string, MigrationMethodEnum>()
            {
                { "full_amount_migration", FULL_AMOUNT_MIGRATION },
                { "incremental_migration", INCREMENTAL_MIGRATION },
            };

            private string Value;

            public MigrationMethodEnum(string value)
            {
                Value = value;
            }

            public static MigrationMethodEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as MigrationMethodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MigrationMethodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(MigrationMethodEnum a, MigrationMethodEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(MigrationMethodEnum a, MigrationMethodEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 迁移任务类型,包括备份文件导入和在线迁移两种类型。
        /// </summary>
        /// <value>迁移任务类型,包括备份文件导入和在线迁移两种类型。</value>
        [JsonConverter(typeof(EnumClassConverter<MigrateTypeEnum>))]
        public class MigrateTypeEnum
        {
            /// <summary>
            /// Enum BACKUPFILE_IMPORT for value: backupfile_import
            /// </summary>
            public static readonly MigrateTypeEnum BACKUPFILE_IMPORT = new MigrateTypeEnum("backupfile_import");

            /// <summary>
            /// Enum ONLINE_MIGRATION for value: online_migration
            /// </summary>
            public static readonly MigrateTypeEnum ONLINE_MIGRATION = new MigrateTypeEnum("online_migration");

            private static readonly Dictionary<string, MigrateTypeEnum> StaticFields =
            new Dictionary<string, MigrateTypeEnum>()
            {
                { "backupfile_import", BACKUPFILE_IMPORT },
                { "online_migration", ONLINE_MIGRATION },
            };

            private string Value;

            public MigrateTypeEnum(string value)
            {
                Value = value;
            }

            public static MigrateTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as MigrateTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MigrateTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(MigrateTypeEnum a, MigrateTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(MigrateTypeEnum a, MigrateTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 迁移任务状态，这个字段的值包括：SUCCESS, FAILED, MIGRATING，TERMINATED
        /// </summary>
        /// <value>迁移任务状态，这个字段的值包括：SUCCESS, FAILED, MIGRATING，TERMINATED</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            public static readonly StatusEnum SUCCESS = new StatusEnum("SUCCESS");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("FAILED");

            /// <summary>
            /// Enum MIGRATING for value: MIGRATING
            /// </summary>
            public static readonly StatusEnum MIGRATING = new StatusEnum("MIGRATING");

            /// <summary>
            /// Enum TERMINATED for value: TERMINATED
            /// </summary>
            public static readonly StatusEnum TERMINATED = new StatusEnum("TERMINATED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "SUCCESS", SUCCESS },
                { "FAILED", FAILED },
                { "MIGRATING", MIGRATING },
                { "TERMINATED", TERMINATED },
            };

            private string Value;

            public StatusEnum(string value)
            {
                Value = value;
            }

            public static StatusEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 迁移任务数量。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 迁移任务列表。
        /// </summary>
        [JsonProperty("migration_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<MigrationTaskList> MigrationTasks { get; set; }

        /// <summary>
        /// 目标实例地址
        /// </summary>
        [JsonProperty("target_instance_address", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetInstanceAddress { get; set; }

        /// <summary>
        /// 迁移方式，包括全量迁移和增量迁移两种类型。
        /// </summary>
        [JsonProperty("migration_method", NullValueHandling = NullValueHandling.Ignore)]
        public MigrationMethodEnum MigrationMethod { get; set; }
        /// <summary>
        /// 迁移任务名称。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 目标实例ID。
        /// </summary>
        [JsonProperty("target_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetInstanceId { get; set; }

        /// <summary>
        /// 源实例名称，若自建redis则为空。
        /// </summary>
        [JsonProperty("source_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceName { get; set; }

        /// <summary>
        /// 目标实例名称。
        /// </summary>
        [JsonProperty("target_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetInstanceName { get; set; }

        /// <summary>
        /// 迁移任务类型,包括备份文件导入和在线迁移两种类型。
        /// </summary>
        [JsonProperty("migrate_type", NullValueHandling = NullValueHandling.Ignore)]
        public MigrateTypeEnum MigrateType { get; set; }
        /// <summary>
        /// 迁移任务创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 源实例ID，若自建redis则为空。
        /// </summary>
        [JsonProperty("source_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// 迁移任务ID。
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 源redis地址，格式为ip:port或者桶名。
        /// </summary>
        [JsonProperty("data_source", NullValueHandling = NullValueHandling.Ignore)]
        public string DataSource { get; set; }

        /// <summary>
        /// 迁移任务状态，这个字段的值包括：SUCCESS, FAILED, MIGRATING，TERMINATED
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMigrationTaskResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  migrationTasks: ").Append(MigrationTasks).Append("\n");
            sb.Append("  targetInstanceAddress: ").Append(TargetInstanceAddress).Append("\n");
            sb.Append("  migrationMethod: ").Append(MigrationMethod).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  targetInstanceId: ").Append(TargetInstanceId).Append("\n");
            sb.Append("  sourceInstanceName: ").Append(SourceInstanceName).Append("\n");
            sb.Append("  targetInstanceName: ").Append(TargetInstanceName).Append("\n");
            sb.Append("  migrateType: ").Append(MigrateType).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  sourceInstanceId: ").Append(SourceInstanceId).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  dataSource: ").Append(DataSource).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMigrationTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMigrationTaskResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.MigrationTasks == input.MigrationTasks ||
                    this.MigrationTasks != null &&
                    input.MigrationTasks != null &&
                    this.MigrationTasks.SequenceEqual(input.MigrationTasks)
                ) && 
                (
                    this.TargetInstanceAddress == input.TargetInstanceAddress ||
                    (this.TargetInstanceAddress != null &&
                    this.TargetInstanceAddress.Equals(input.TargetInstanceAddress))
                ) && 
                (
                    this.MigrationMethod == input.MigrationMethod ||
                    (this.MigrationMethod != null &&
                    this.MigrationMethod.Equals(input.MigrationMethod))
                ) && 
                (
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
                ) && 
                (
                    this.TargetInstanceId == input.TargetInstanceId ||
                    (this.TargetInstanceId != null &&
                    this.TargetInstanceId.Equals(input.TargetInstanceId))
                ) && 
                (
                    this.SourceInstanceName == input.SourceInstanceName ||
                    (this.SourceInstanceName != null &&
                    this.SourceInstanceName.Equals(input.SourceInstanceName))
                ) && 
                (
                    this.TargetInstanceName == input.TargetInstanceName ||
                    (this.TargetInstanceName != null &&
                    this.TargetInstanceName.Equals(input.TargetInstanceName))
                ) && 
                (
                    this.MigrateType == input.MigrateType ||
                    (this.MigrateType != null &&
                    this.MigrateType.Equals(input.MigrateType))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.SourceInstanceId == input.SourceInstanceId ||
                    (this.SourceInstanceId != null &&
                    this.SourceInstanceId.Equals(input.SourceInstanceId))
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.DataSource == input.DataSource ||
                    (this.DataSource != null &&
                    this.DataSource.Equals(input.DataSource))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.MigrationTasks != null)
                    hashCode = hashCode * 59 + this.MigrationTasks.GetHashCode();
                if (this.TargetInstanceAddress != null)
                    hashCode = hashCode * 59 + this.TargetInstanceAddress.GetHashCode();
                if (this.MigrationMethod != null)
                    hashCode = hashCode * 59 + this.MigrationMethod.GetHashCode();
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.TargetInstanceId != null)
                    hashCode = hashCode * 59 + this.TargetInstanceId.GetHashCode();
                if (this.SourceInstanceName != null)
                    hashCode = hashCode * 59 + this.SourceInstanceName.GetHashCode();
                if (this.TargetInstanceName != null)
                    hashCode = hashCode * 59 + this.TargetInstanceName.GetHashCode();
                if (this.MigrateType != null)
                    hashCode = hashCode * 59 + this.MigrateType.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.SourceInstanceId != null)
                    hashCode = hashCode * 59 + this.SourceInstanceId.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.DataSource != null)
                    hashCode = hashCode * 59 + this.DataSource.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
