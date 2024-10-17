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

            private string _value;

            public NetworkTypeEnum()
            {

            }

            public NetworkTypeEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 租户VPC ID。
        /// </summary>
        [JsonProperty("tenant_vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantVpcId { get; set; }

        /// <summary>
        /// 租户子网ID。
        /// </summary>
        [JsonProperty("tenant_subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantSubnetId { get; set; }

        /// <summary>
        /// 租户安全组ID。
        /// </summary>
        [JsonProperty("tenant_security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantSecurityGroupId { get; set; }

        /// <summary>
        /// 带宽限制速度。
        /// </summary>
        [JsonProperty("bandwidth_limit_mb", NullValueHandling = NullValueHandling.Ignore)]
        public string BandwidthLimitMb { get; set; }

        /// <summary>
        /// 任务状态。
        /// </summary>
        [JsonProperty("task_status", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskStatus { get; set; }



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
            sb.Append("  releasedAt: ").Append(ReleasedAt).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  resumeMode: ").Append(ResumeMode).Append("\n");
            sb.Append("  supportedFeatures: ").Append(SupportedFeatures).Append("\n");
            sb.Append("  tenantVpcId: ").Append(TenantVpcId).Append("\n");
            sb.Append("  tenantSubnetId: ").Append(TenantSubnetId).Append("\n");
            sb.Append("  tenantSecurityGroupId: ").Append(TenantSecurityGroupId).Append("\n");
            sb.Append("  bandwidthLimitMb: ").Append(BandwidthLimitMb).Append("\n");
            sb.Append("  taskStatus: ").Append(TaskStatus).Append("\n");
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
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Status != input.Status) return false;
            if (this.MigrationType != input.MigrationType) return false;
            if (this.MigrationMethod != input.MigrationMethod) return false;
            if (this.EcsTenantPrivateIp != input.EcsTenantPrivateIp || (this.EcsTenantPrivateIp != null && !this.EcsTenantPrivateIp.Equals(input.EcsTenantPrivateIp))) return false;
            if (this.BackupFiles != input.BackupFiles || (this.BackupFiles != null && !this.BackupFiles.Equals(input.BackupFiles))) return false;
            if (this.NetworkType != input.NetworkType) return false;
            if (this.SourceInstance != input.SourceInstance || (this.SourceInstance != null && !this.SourceInstance.Equals(input.SourceInstance))) return false;
            if (this.TargetInstance != input.TargetInstance || (this.TargetInstance != null && !this.TargetInstance.Equals(input.TargetInstance))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.ReleasedAt != input.ReleasedAt || (this.ReleasedAt != null && !this.ReleasedAt.Equals(input.ReleasedAt))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.ResumeMode != input.ResumeMode || (this.ResumeMode != null && !this.ResumeMode.Equals(input.ResumeMode))) return false;
            if (this.SupportedFeatures != input.SupportedFeatures || (this.SupportedFeatures != null && input.SupportedFeatures != null && !this.SupportedFeatures.SequenceEqual(input.SupportedFeatures))) return false;
            if (this.TenantVpcId != input.TenantVpcId || (this.TenantVpcId != null && !this.TenantVpcId.Equals(input.TenantVpcId))) return false;
            if (this.TenantSubnetId != input.TenantSubnetId || (this.TenantSubnetId != null && !this.TenantSubnetId.Equals(input.TenantSubnetId))) return false;
            if (this.TenantSecurityGroupId != input.TenantSecurityGroupId || (this.TenantSecurityGroupId != null && !this.TenantSecurityGroupId.Equals(input.TenantSecurityGroupId))) return false;
            if (this.BandwidthLimitMb != input.BandwidthLimitMb || (this.BandwidthLimitMb != null && !this.BandwidthLimitMb.Equals(input.BandwidthLimitMb))) return false;
            if (this.TaskStatus != input.TaskStatus || (this.TaskStatus != null && !this.TaskStatus.Equals(input.TaskStatus))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.MigrationType.GetHashCode();
                hashCode = hashCode * 59 + this.MigrationMethod.GetHashCode();
                if (this.EcsTenantPrivateIp != null) hashCode = hashCode * 59 + this.EcsTenantPrivateIp.GetHashCode();
                if (this.BackupFiles != null) hashCode = hashCode * 59 + this.BackupFiles.GetHashCode();
                hashCode = hashCode * 59 + this.NetworkType.GetHashCode();
                if (this.SourceInstance != null) hashCode = hashCode * 59 + this.SourceInstance.GetHashCode();
                if (this.TargetInstance != null) hashCode = hashCode * 59 + this.TargetInstance.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.ReleasedAt != null) hashCode = hashCode * 59 + this.ReleasedAt.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ResumeMode != null) hashCode = hashCode * 59 + this.ResumeMode.GetHashCode();
                if (this.SupportedFeatures != null) hashCode = hashCode * 59 + this.SupportedFeatures.GetHashCode();
                if (this.TenantVpcId != null) hashCode = hashCode * 59 + this.TenantVpcId.GetHashCode();
                if (this.TenantSubnetId != null) hashCode = hashCode * 59 + this.TenantSubnetId.GetHashCode();
                if (this.TenantSecurityGroupId != null) hashCode = hashCode * 59 + this.TenantSecurityGroupId.GetHashCode();
                if (this.BandwidthLimitMb != null) hashCode = hashCode * 59 + this.BandwidthLimitMb.GetHashCode();
                if (this.TaskStatus != null) hashCode = hashCode * 59 + this.TaskStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
