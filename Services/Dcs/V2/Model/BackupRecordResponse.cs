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
    /// 实例备份信息。
    /// </summary>
    public class BackupRecordResponse 
    {
        /// <summary>
        /// 备份类型。 - manual：表示备份类型为手动备份 - auto：表示备份类型为自动备份 
        /// </summary>
        /// <value>备份类型。 - manual：表示备份类型为手动备份 - auto：表示备份类型为自动备份 </value>
        [JsonConverter(typeof(EnumClassConverter<BackupTypeEnum>))]
        public class BackupTypeEnum
        {
            /// <summary>
            /// Enum MANUAL for value: manual
            /// </summary>
            public static readonly BackupTypeEnum MANUAL = new BackupTypeEnum("manual");

            /// <summary>
            /// Enum AUTO for value: auto
            /// </summary>
            public static readonly BackupTypeEnum AUTO = new BackupTypeEnum("auto");

            public static readonly Dictionary<string, BackupTypeEnum> StaticFields =
            new Dictionary<string, BackupTypeEnum>()
            {
                {"manual", MANUAL},
                {"auto", AUTO},
            };

            private string Value;

            public BackupTypeEnum(string Value)
            {
                this.Value = Value;
            }

            public static BackupTypeEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
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

                if (this.Equals(obj as BackupTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BackupTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(BackupTypeEnum a, BackupTypeEnum b)
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

            public static bool operator !=(BackupTypeEnum a, BackupTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 备份状态。 - waiting：等待中。 - backuping：备份中。 - succeed：备份成功。 - failed：备份失败。 - expired：备份文件过期。 - deleted：已手动删除备份文件。 
        /// </summary>
        /// <value>备份状态。 - waiting：等待中。 - backuping：备份中。 - succeed：备份成功。 - failed：备份失败。 - expired：备份文件过期。 - deleted：已手动删除备份文件。 </value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum WAITING for value: waiting
            /// </summary>
            public static readonly StatusEnum WAITING = new StatusEnum("waiting");

            /// <summary>
            /// Enum BACKUPING for value: backuping
            /// </summary>
            public static readonly StatusEnum BACKUPING = new StatusEnum("backuping");

            /// <summary>
            /// Enum SUCCEED for value: succeed
            /// </summary>
            public static readonly StatusEnum SUCCEED = new StatusEnum("succeed");

            /// <summary>
            /// Enum FAILED for value: failed
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("failed");

            /// <summary>
            /// Enum EXPIRED for value: expired
            /// </summary>
            public static readonly StatusEnum EXPIRED = new StatusEnum("expired");

            /// <summary>
            /// Enum DELETED for value: deleted
            /// </summary>
            public static readonly StatusEnum DELETED = new StatusEnum("deleted");

            public static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                {"waiting", WAITING},
                {"backuping", BACKUPING},
                {"succeed", SUCCEED},
                {"failed", FAILED},
                {"expired", EXPIRED},
                {"deleted", DELETED},
            };

            private string Value;

            public StatusEnum(string Value)
            {
                this.Value = Value;
            }

            public static StatusEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
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
        /// 备份记录ID。
        /// </summary>
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        /// <summary>
        /// 备份执行时间段。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 备份记录名称。
        /// </summary>
        [JsonProperty("backup_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupName { get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 备份文件大小（Byte）。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        /// <summary>
        /// 备份类型。 - manual：表示备份类型为手动备份 - auto：表示备份类型为自动备份 
        /// </summary>
        [JsonProperty("backup_type", NullValueHandling = NullValueHandling.Ignore)]
        public BackupTypeEnum BackupType { get; set; }
        /// <summary>
        /// 备份任务创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 备份完成时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 备份进度。
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public string Progress { get; set; }

        /// <summary>
        /// 备份失败后错误码 * &#x60;dcs.08.0001&#x60; - 启动备份恢复工具失败。 * &#x60;dcs.08.0002&#x60; - 执行超时。 * &#x60;dcs.08.0003&#x60; - 删除桶失败。 * &#x60;dcs.08.0004&#x60; - 获取ak/sk 失败。 * &#x60;dcs.08.0005&#x60; - 创建桶失败。 * &#x60;dcs.08.0006&#x60; - 查询备份数据大小失败。 * &#x60;dcs.08.0007&#x60; - 恢复时同步数据失败。 * &#x60;dcs.08.0008&#x60; - 自动备份任务未运行，实例正在运行其他任务。 
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 备份缓存实例的备注信息。
        /// </summary>
        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }

        /// <summary>
        /// 备份状态。 - waiting：等待中。 - backuping：备份中。 - succeed：备份成功。 - failed：备份失败。 - expired：备份文件过期。 - deleted：已手动删除备份文件。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 是否可以进行恢复操作，取值为TRUE或FALSE。
        /// </summary>
        [JsonProperty("is_support_restore", NullValueHandling = NullValueHandling.Ignore)]
        public string IsSupportRestore { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupRecordResponse {\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  backupName: ").Append(BackupName).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  backupType: ").Append(BackupType).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  remark: ").Append(Remark).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  isSupportRestore: ").Append(IsSupportRestore).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupRecordResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupRecordResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupId == input.BackupId ||
                    (this.BackupId != null &&
                    this.BackupId.Equals(input.BackupId))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.BackupName == input.BackupName ||
                    (this.BackupName != null &&
                    this.BackupName.Equals(input.BackupName))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.BackupType == input.BackupType ||
                    (this.BackupType != null &&
                    this.BackupType.Equals(input.BackupType))
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
                ) && 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.Remark == input.Remark ||
                    (this.Remark != null &&
                    this.Remark.Equals(input.Remark))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.IsSupportRestore == input.IsSupportRestore ||
                    (this.IsSupportRestore != null &&
                    this.IsSupportRestore.Equals(input.IsSupportRestore))
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
                if (this.BackupId != null)
                    hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.BackupName != null)
                    hashCode = hashCode * 59 + this.BackupName.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.BackupType != null)
                    hashCode = hashCode * 59 + this.BackupType.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.Remark != null)
                    hashCode = hashCode * 59 + this.Remark.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.IsSupportRestore != null)
                    hashCode = hashCode * 59 + this.IsSupportRestore.GetHashCode();
                return hashCode;
            }
        }
    }
}
