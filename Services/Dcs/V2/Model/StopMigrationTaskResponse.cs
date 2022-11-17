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
    public class StopMigrationTaskResponse : SdkResponse
    {
        /// <summary>
        /// 迁移任务状态，这个字段的值包括：SUCCESS, FAILED, MIGRATING，TERMINATED。
        /// </summary>
        /// <value>迁移任务状态，这个字段的值包括：SUCCESS, FAILED, MIGRATING，TERMINATED。</value>
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
        /// 迁移任务类型,包括备份文件导入和在线迁移两种类型。
        /// </summary>
        /// <value>迁移任务类型,包括备份文件导入和在线迁移两种类型。</value>
        [JsonConverter(typeof(EnumClassConverter<MigrationTypeEnum>))]
        public class MigrationTypeEnum
        {
            /// <summary>
            /// Enum BACKUPFILE_IMPORT for value: backupfile_import
            /// </summary>
            public static readonly MigrationTypeEnum BACKUPFILE_IMPORT = new MigrationTypeEnum("backupfile_import");

            /// <summary>
            /// Enum ONLINE_MIGRATION for value: online_migration
            /// </summary>
            public static readonly MigrationTypeEnum ONLINE_MIGRATION = new MigrationTypeEnum("online_migration");

            private static readonly Dictionary<string, MigrationTypeEnum> StaticFields =
            new Dictionary<string, MigrationTypeEnum>()
            {
                { "backupfile_import", BACKUPFILE_IMPORT },
                { "online_migration", ONLINE_MIGRATION },
            };

            private string Value;

            public MigrationTypeEnum(string value)
            {
                Value = value;
            }

            public static MigrationTypeEnum FromValue(string value)
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

                if (this.Equals(obj as MigrationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MigrationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(MigrationTypeEnum a, MigrationTypeEnum b)
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

            public static bool operator !=(MigrationTypeEnum a, MigrationTypeEnum b)
            {
                return !(a == b);
            }
        }

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
        /// 网络类型，包括vpc和vpn两种类型。
        /// </summary>
        /// <value>网络类型，包括vpc和vpn两种类型。</value>
        [JsonConverter(typeof(EnumClassConverter<NetworkTypeEnum>))]
        public class NetworkTypeEnum
        {
            /// <summary>
            /// Enum VPC for value: vpc
            /// </summary>
            public static readonly NetworkTypeEnum VPC = new NetworkTypeEnum("vpc");

            /// <summary>
            /// Enum VPN for value: vpn
            /// </summary>
            public static readonly NetworkTypeEnum VPN = new NetworkTypeEnum("vpn");

            private static readonly Dictionary<string, NetworkTypeEnum> StaticFields =
            new Dictionary<string, NetworkTypeEnum>()
            {
                { "vpc", VPC },
                { "vpn", VPN },
            };

            private string Value;

            public NetworkTypeEnum(string value)
            {
                Value = value;
            }

            public static NetworkTypeEnum FromValue(string value)
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

                if (this.Equals(obj as NetworkTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NetworkTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(NetworkTypeEnum a, NetworkTypeEnum b)
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

            public static bool operator !=(NetworkTypeEnum a, NetworkTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 迁移任务ID。
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 迁移任务名称。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 迁移任务描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 迁移任务状态，这个字段的值包括：SUCCESS, FAILED, MIGRATING，TERMINATED。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 迁移任务类型,包括备份文件导入和在线迁移两种类型。
        /// </summary>
        [JsonProperty("migration_type", NullValueHandling = NullValueHandling.Ignore)]
        public MigrationTypeEnum MigrationType { get; set; }
        /// <summary>
        /// 迁移方式，包括全量迁移和增量迁移两种类型。
        /// </summary>
        [JsonProperty("migration_method", NullValueHandling = NullValueHandling.Ignore)]
        public MigrationMethodEnum MigrationMethod { get; set; }
        /// <summary>
        /// 迁移机租户侧私有IP，与目的/源redis私有IP处于同VPC，可将此IP加入白名单
        /// </summary>
        [JsonProperty("ecs_tenant_private_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string EcsTenantPrivateIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backup_files", NullValueHandling = NullValueHandling.Ignore)]
        public BackupFilesBody BackupFiles { get; set; }

        /// <summary>
        /// 网络类型，包括vpc和vpn两种类型。
        /// </summary>
        [JsonProperty("network_type", NullValueHandling = NullValueHandling.Ignore)]
        public NetworkTypeEnum NetworkType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source_instance", NullValueHandling = NullValueHandling.Ignore)]
        public SourceInstanceBody SourceInstance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target_instance", NullValueHandling = NullValueHandling.Ignore)]
        public TargetInstanceBody TargetInstance { get; set; }

        /// <summary>
        /// 迁移任务创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 迁移任务完成时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StopMigrationTaskResponse {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  migrationType: ").Append(MigrationType).Append("\n");
            sb.Append("  migrationMethod: ").Append(MigrationMethod).Append("\n");
            sb.Append("  ecsTenantPrivateIp: ").Append(EcsTenantPrivateIp).Append("\n");
            sb.Append("  backupFiles: ").Append(BackupFiles).Append("\n");
            sb.Append("  networkType: ").Append(NetworkType).Append("\n");
            sb.Append("  sourceInstance: ").Append(SourceInstance).Append("\n");
            sb.Append("  targetInstance: ").Append(TargetInstance).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StopMigrationTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StopMigrationTaskResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.MigrationType == input.MigrationType ||
                    (this.MigrationType != null &&
                    this.MigrationType.Equals(input.MigrationType))
                ) && 
                (
                    this.MigrationMethod == input.MigrationMethod ||
                    (this.MigrationMethod != null &&
                    this.MigrationMethod.Equals(input.MigrationMethod))
                ) && 
                (
                    this.EcsTenantPrivateIp == input.EcsTenantPrivateIp ||
                    (this.EcsTenantPrivateIp != null &&
                    this.EcsTenantPrivateIp.Equals(input.EcsTenantPrivateIp))
                ) && 
                (
                    this.BackupFiles == input.BackupFiles ||
                    (this.BackupFiles != null &&
                    this.BackupFiles.Equals(input.BackupFiles))
                ) && 
                (
                    this.NetworkType == input.NetworkType ||
                    (this.NetworkType != null &&
                    this.NetworkType.Equals(input.NetworkType))
                ) && 
                (
                    this.SourceInstance == input.SourceInstance ||
                    (this.SourceInstance != null &&
                    this.SourceInstance.Equals(input.SourceInstance))
                ) && 
                (
                    this.TargetInstance == input.TargetInstance ||
                    (this.TargetInstance != null &&
                    this.TargetInstance.Equals(input.TargetInstance))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.MigrationType != null)
                    hashCode = hashCode * 59 + this.MigrationType.GetHashCode();
                if (this.MigrationMethod != null)
                    hashCode = hashCode * 59 + this.MigrationMethod.GetHashCode();
                if (this.EcsTenantPrivateIp != null)
                    hashCode = hashCode * 59 + this.EcsTenantPrivateIp.GetHashCode();
                if (this.BackupFiles != null)
                    hashCode = hashCode * 59 + this.BackupFiles.GetHashCode();
                if (this.NetworkType != null)
                    hashCode = hashCode * 59 + this.NetworkType.GetHashCode();
                if (this.SourceInstance != null)
                    hashCode = hashCode * 59 + this.SourceInstance.GetHashCode();
                if (this.TargetInstance != null)
                    hashCode = hashCode * 59 + this.TargetInstance.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
