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
    /// 查询迁移任务列表
    /// </summary>
    public class MigrationTaskList 
    {
        /// <summary>
        /// 迁移任务状态，这个字段的值包括：SUCCESS（成功）, FAILED（失败）, MIGRATING（迁移中），TERMINATED（已结束）。
        /// </summary>
        /// <value>迁移任务状态，这个字段的值包括：SUCCESS（成功）, FAILED（失败）, MIGRATING（迁移中），TERMINATED（已结束）。</value>
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

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 迁移任务类型，包括备份文件导入和在线迁移两种类型。
        /// </summary>
        /// <value>迁移任务类型，包括备份文件导入和在线迁移两种类型。</value>
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

            private string _value;

            public MigrationTypeEnum()
            {

            }

            public MigrationTypeEnum(string value)
            {
                _value = value;
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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

            private string _value;

            public MigrationMethodEnum()
            {

            }

            public MigrationMethodEnum(string value)
            {
                _value = value;
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 迁移任务状态，这个字段的值包括：SUCCESS（成功）, FAILED（失败）, MIGRATING（迁移中），TERMINATED（已结束）。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 迁移任务类型，包括备份文件导入和在线迁移两种类型。
        /// </summary>
        [JsonProperty("migration_type", NullValueHandling = NullValueHandling.Ignore)]
        public MigrationTypeEnum MigrationType { get; set; }
        /// <summary>
        /// 迁移方式，包括全量迁移和增量迁移两种类型。
        /// </summary>
        [JsonProperty("migration_method", NullValueHandling = NullValueHandling.Ignore)]
        public MigrationMethodEnum MigrationMethod { get; set; }
        /// <summary>
        /// 迁移机租户侧私有IP，与目的/源redis私有IP处于同VPC，可将此IP加入白名单。
        /// </summary>
        [JsonProperty("ecs_tenant_private_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string EcsTenantPrivateIp { get; set; }

        /// <summary>
        /// 源redis地址，格式为ip:port或者桶名。
        /// </summary>
        [JsonProperty("data_source", NullValueHandling = NullValueHandling.Ignore)]
        public string DataSource { get; set; }

        /// <summary>
        /// 源实例名称，若自建redis则为空。
        /// </summary>
        [JsonProperty("source_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceName { get; set; }

        /// <summary>
        /// 源实例ID，若自建redis则为空。
        /// </summary>
        [JsonProperty("source_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// 目标redis地址，格式为ip:port。
        /// </summary>
        [JsonProperty("target_instance_addrs", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetInstanceAddrs { get; set; }

        /// <summary>
        /// 目标实例名称。
        /// </summary>
        [JsonProperty("target_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetInstanceName { get; set; }

        /// <summary>
        /// 目标实例ID。
        /// </summary>
        [JsonProperty("target_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetInstanceId { get; set; }

        /// <summary>
        /// 迁移任务创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 迁移任务描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 源实例状态，若自建redis则为空。
        /// </summary>
        [JsonProperty("source_instance_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceStatus { get; set; }

        /// <summary>
        /// 目标实例状态。
        /// </summary>
        [JsonProperty("target_instance_status", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetInstanceStatus { get; set; }

        /// <summary>
        /// 源实例子网ID，若自建redis则为空。
        /// </summary>
        [JsonProperty("source_instance_subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceSubnetId { get; set; }

        /// <summary>
        /// 目标实例子网ID。
        /// </summary>
        [JsonProperty("target_instance_subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetInstanceSubnetId { get; set; }

        /// <summary>
        /// 源实例规格编码，若自建redis则为空。
        /// </summary>
        [JsonProperty("source_instance_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceSpecCode { get; set; }

        /// <summary>
        /// 目标实例规格编码。
        /// </summary>
        [JsonProperty("target_instance_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetInstanceSpecCode { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 迁移机释放时间。
        /// </summary>
        [JsonProperty("released_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleasedAt { get; set; }

        /// <summary>
        /// 版本。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 操作模式，分为auto和manual。
        /// </summary>
        [JsonProperty("resume_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ResumeMode { get; set; }

        /// <summary>
        /// 支持的特性。
        /// </summary>
        [JsonProperty("supported_features", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportedFeatures { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrationTaskList {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  migrationType: ").Append(MigrationType).Append("\n");
            sb.Append("  migrationMethod: ").Append(MigrationMethod).Append("\n");
            sb.Append("  ecsTenantPrivateIp: ").Append(EcsTenantPrivateIp).Append("\n");
            sb.Append("  dataSource: ").Append(DataSource).Append("\n");
            sb.Append("  sourceInstanceName: ").Append(SourceInstanceName).Append("\n");
            sb.Append("  sourceInstanceId: ").Append(SourceInstanceId).Append("\n");
            sb.Append("  targetInstanceAddrs: ").Append(TargetInstanceAddrs).Append("\n");
            sb.Append("  targetInstanceName: ").Append(TargetInstanceName).Append("\n");
            sb.Append("  targetInstanceId: ").Append(TargetInstanceId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  sourceInstanceStatus: ").Append(SourceInstanceStatus).Append("\n");
            sb.Append("  targetInstanceStatus: ").Append(TargetInstanceStatus).Append("\n");
            sb.Append("  sourceInstanceSubnetId: ").Append(SourceInstanceSubnetId).Append("\n");
            sb.Append("  targetInstanceSubnetId: ").Append(TargetInstanceSubnetId).Append("\n");
            sb.Append("  sourceInstanceSpecCode: ").Append(SourceInstanceSpecCode).Append("\n");
            sb.Append("  targetInstanceSpecCode: ").Append(TargetInstanceSpecCode).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  releasedAt: ").Append(ReleasedAt).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  resumeMode: ").Append(ResumeMode).Append("\n");
            sb.Append("  supportedFeatures: ").Append(SupportedFeatures).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrationTaskList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrationTaskList input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.Status != input.Status) return false;
            if (this.MigrationType != input.MigrationType) return false;
            if (this.MigrationMethod != input.MigrationMethod) return false;
            if (this.EcsTenantPrivateIp != input.EcsTenantPrivateIp || (this.EcsTenantPrivateIp != null && !this.EcsTenantPrivateIp.Equals(input.EcsTenantPrivateIp))) return false;
            if (this.DataSource != input.DataSource || (this.DataSource != null && !this.DataSource.Equals(input.DataSource))) return false;
            if (this.SourceInstanceName != input.SourceInstanceName || (this.SourceInstanceName != null && !this.SourceInstanceName.Equals(input.SourceInstanceName))) return false;
            if (this.SourceInstanceId != input.SourceInstanceId || (this.SourceInstanceId != null && !this.SourceInstanceId.Equals(input.SourceInstanceId))) return false;
            if (this.TargetInstanceAddrs != input.TargetInstanceAddrs || (this.TargetInstanceAddrs != null && !this.TargetInstanceAddrs.Equals(input.TargetInstanceAddrs))) return false;
            if (this.TargetInstanceName != input.TargetInstanceName || (this.TargetInstanceName != null && !this.TargetInstanceName.Equals(input.TargetInstanceName))) return false;
            if (this.TargetInstanceId != input.TargetInstanceId || (this.TargetInstanceId != null && !this.TargetInstanceId.Equals(input.TargetInstanceId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.SourceInstanceStatus != input.SourceInstanceStatus || (this.SourceInstanceStatus != null && !this.SourceInstanceStatus.Equals(input.SourceInstanceStatus))) return false;
            if (this.TargetInstanceStatus != input.TargetInstanceStatus || (this.TargetInstanceStatus != null && !this.TargetInstanceStatus.Equals(input.TargetInstanceStatus))) return false;
            if (this.SourceInstanceSubnetId != input.SourceInstanceSubnetId || (this.SourceInstanceSubnetId != null && !this.SourceInstanceSubnetId.Equals(input.SourceInstanceSubnetId))) return false;
            if (this.TargetInstanceSubnetId != input.TargetInstanceSubnetId || (this.TargetInstanceSubnetId != null && !this.TargetInstanceSubnetId.Equals(input.TargetInstanceSubnetId))) return false;
            if (this.SourceInstanceSpecCode != input.SourceInstanceSpecCode || (this.SourceInstanceSpecCode != null && !this.SourceInstanceSpecCode.Equals(input.SourceInstanceSpecCode))) return false;
            if (this.TargetInstanceSpecCode != input.TargetInstanceSpecCode || (this.TargetInstanceSpecCode != null && !this.TargetInstanceSpecCode.Equals(input.TargetInstanceSpecCode))) return false;
            if (this.ErrorMessage != input.ErrorMessage || (this.ErrorMessage != null && !this.ErrorMessage.Equals(input.ErrorMessage))) return false;
            if (this.ReleasedAt != input.ReleasedAt || (this.ReleasedAt != null && !this.ReleasedAt.Equals(input.ReleasedAt))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.ResumeMode != input.ResumeMode || (this.ResumeMode != null && !this.ResumeMode.Equals(input.ResumeMode))) return false;
            if (this.SupportedFeatures != input.SupportedFeatures || (this.SupportedFeatures != null && input.SupportedFeatures != null && !this.SupportedFeatures.SequenceEqual(input.SupportedFeatures))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.MigrationType.GetHashCode();
                hashCode = hashCode * 59 + this.MigrationMethod.GetHashCode();
                if (this.EcsTenantPrivateIp != null) hashCode = hashCode * 59 + this.EcsTenantPrivateIp.GetHashCode();
                if (this.DataSource != null) hashCode = hashCode * 59 + this.DataSource.GetHashCode();
                if (this.SourceInstanceName != null) hashCode = hashCode * 59 + this.SourceInstanceName.GetHashCode();
                if (this.SourceInstanceId != null) hashCode = hashCode * 59 + this.SourceInstanceId.GetHashCode();
                if (this.TargetInstanceAddrs != null) hashCode = hashCode * 59 + this.TargetInstanceAddrs.GetHashCode();
                if (this.TargetInstanceName != null) hashCode = hashCode * 59 + this.TargetInstanceName.GetHashCode();
                if (this.TargetInstanceId != null) hashCode = hashCode * 59 + this.TargetInstanceId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SourceInstanceStatus != null) hashCode = hashCode * 59 + this.SourceInstanceStatus.GetHashCode();
                if (this.TargetInstanceStatus != null) hashCode = hashCode * 59 + this.TargetInstanceStatus.GetHashCode();
                if (this.SourceInstanceSubnetId != null) hashCode = hashCode * 59 + this.SourceInstanceSubnetId.GetHashCode();
                if (this.TargetInstanceSubnetId != null) hashCode = hashCode * 59 + this.TargetInstanceSubnetId.GetHashCode();
                if (this.SourceInstanceSpecCode != null) hashCode = hashCode * 59 + this.SourceInstanceSpecCode.GetHashCode();
                if (this.TargetInstanceSpecCode != null) hashCode = hashCode * 59 + this.TargetInstanceSpecCode.GetHashCode();
                if (this.ErrorMessage != null) hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.ReleasedAt != null) hashCode = hashCode * 59 + this.ReleasedAt.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ResumeMode != null) hashCode = hashCode * 59 + this.ResumeMode.GetHashCode();
                if (this.SupportedFeatures != null) hashCode = hashCode * 59 + this.SupportedFeatures.GetHashCode();
                return hashCode;
            }
        }
    }
}
