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
    /// 
    /// </summary>
    public class InstanceRestoreInfo 
    {
        /// <summary>
        /// 恢复状态。 - waiting：等待中 - restoring：恢复中 - succeed：恢复成功 - failed：恢复失败 
        /// </summary>
        /// <value>恢复状态。 - waiting：等待中 - restoring：恢复中 - succeed：恢复成功 - failed：恢复失败 </value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum WAITING for value: waiting
            /// </summary>
            public static readonly StatusEnum WAITING = new StatusEnum("waiting");

            /// <summary>
            /// Enum RESTORING for value: restoring
            /// </summary>
            public static readonly StatusEnum RESTORING = new StatusEnum("restoring");

            /// <summary>
            /// Enum SUCCEED for value: succeed
            /// </summary>
            public static readonly StatusEnum SUCCEED = new StatusEnum("succeed");

            /// <summary>
            /// Enum FAILED for value: failed
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("failed");

            public static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                {"waiting", WAITING},
                {"restoring", RESTORING},
                {"succeed", SUCCEED},
                {"failed", FAILED},
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
        /// 恢复记录ID。
        /// </summary>
        [JsonProperty("restore_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RestoreId { get; set; }

        /// <summary>
        /// 备份记录名称。
        /// </summary>
        [JsonProperty("backup_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupName { get; set; }

        /// <summary>
        /// 恢复完成时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 恢复备注信息。
        /// </summary>
        [JsonProperty("restore_remark", NullValueHandling = NullValueHandling.Ignore)]
        public string RestoreRemark { get; set; }

        /// <summary>
        /// 恢复任务创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 恢复进度。
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public string Progress { get; set; }

        /// <summary>
        /// 恢复失败后错误码 * &#x60;dcs.08.0001&#x60; - 启动备份恢复工具失败。 * &#x60;dcs.08.0002&#x60; - 执行超时。 * &#x60;dcs.08.0003&#x60; - 删除桶失败。 * &#x60;dcs.08.0004&#x60; - 获取ak/sk 失败。 * &#x60;dcs.08.0005&#x60; - 创建桶失败。 * &#x60;dcs.08.0006&#x60; - 查询备份数据大小失败。 * &#x60;dcs.08.0007&#x60; - 恢复时同步数据失败。 * &#x60;dcs.08.0008&#x60; - 自动备份任务未运行，实例正在运行其他任务。 
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 恢复记录名称。
        /// </summary>
        [JsonProperty("restore_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RestoreName { get; set; }

        /// <summary>
        /// 备份备注信息。
        /// </summary>
        [JsonProperty("backup_remark", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupRemark { get; set; }

        /// <summary>
        /// 恢复状态。 - waiting：等待中 - restoring：恢复中 - succeed：恢复成功 - failed：恢复失败 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceRestoreInfo {\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  restoreId: ").Append(RestoreId).Append("\n");
            sb.Append("  backupName: ").Append(BackupName).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  restoreRemark: ").Append(RestoreRemark).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  restoreName: ").Append(RestoreName).Append("\n");
            sb.Append("  backupRemark: ").Append(BackupRemark).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceRestoreInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceRestoreInfo input)
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
                    this.RestoreId == input.RestoreId ||
                    (this.RestoreId != null &&
                    this.RestoreId.Equals(input.RestoreId))
                ) && 
                (
                    this.BackupName == input.BackupName ||
                    (this.BackupName != null &&
                    this.BackupName.Equals(input.BackupName))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.RestoreRemark == input.RestoreRemark ||
                    (this.RestoreRemark != null &&
                    this.RestoreRemark.Equals(input.RestoreRemark))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                    this.RestoreName == input.RestoreName ||
                    (this.RestoreName != null &&
                    this.RestoreName.Equals(input.RestoreName))
                ) && 
                (
                    this.BackupRemark == input.BackupRemark ||
                    (this.BackupRemark != null &&
                    this.BackupRemark.Equals(input.BackupRemark))
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
                if (this.BackupId != null)
                    hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                if (this.RestoreId != null)
                    hashCode = hashCode * 59 + this.RestoreId.GetHashCode();
                if (this.BackupName != null)
                    hashCode = hashCode * 59 + this.BackupName.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.RestoreRemark != null)
                    hashCode = hashCode * 59 + this.RestoreRemark.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.RestoreName != null)
                    hashCode = hashCode * 59 + this.RestoreName.GetHashCode();
                if (this.BackupRemark != null)
                    hashCode = hashCode * 59 + this.BackupRemark.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
