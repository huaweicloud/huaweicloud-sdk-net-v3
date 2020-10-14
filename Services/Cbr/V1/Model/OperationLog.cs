using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OperationLog 
    {
        /// <summary>
        /// 任务类型
        /// </summary>
        /// <value>任务类型</value>
        [JsonConverter(typeof(EnumClassConverter<OperationTypeEnum>))]
        public class OperationTypeEnum
        {
            /// <summary>
            /// Enum BACKUP for value: backup
            /// </summary>
            public static readonly OperationTypeEnum BACKUP = new OperationTypeEnum("backup");

            /// <summary>
            /// Enum COPY for value: copy
            /// </summary>
            public static readonly OperationTypeEnum COPY = new OperationTypeEnum("copy");

            /// <summary>
            /// Enum REPLICATION for value: replication
            /// </summary>
            public static readonly OperationTypeEnum REPLICATION = new OperationTypeEnum("replication");

            /// <summary>
            /// Enum RESTORE for value: restore
            /// </summary>
            public static readonly OperationTypeEnum RESTORE = new OperationTypeEnum("restore");

            /// <summary>
            /// Enum DELETE for value: delete
            /// </summary>
            public static readonly OperationTypeEnum DELETE = new OperationTypeEnum("delete");

            /// <summary>
            /// Enum SYNC for value: sync
            /// </summary>
            public static readonly OperationTypeEnum SYNC = new OperationTypeEnum("sync");

            /// <summary>
            /// Enum VAULT_DELETE for value: vault_delete
            /// </summary>
            public static readonly OperationTypeEnum VAULT_DELETE = new OperationTypeEnum("vault_delete");

            /// <summary>
            /// Enum REMOVE_RESOURCE for value: remove_resource
            /// </summary>
            public static readonly OperationTypeEnum REMOVE_RESOURCE = new OperationTypeEnum("remove_resource");

            private static readonly Dictionary<string, OperationTypeEnum> StaticFields =
            new Dictionary<string, OperationTypeEnum>()
            {
                { "backup", BACKUP },
                { "copy", COPY },
                { "replication", REPLICATION },
                { "restore", RESTORE },
                { "delete", DELETE },
                { "sync", SYNC },
                { "vault_delete", VAULT_DELETE },
                { "remove_resource", REMOVE_RESOURCE },
            };

            private string Value;

            public OperationTypeEnum(string value)
            {
                Value = value;
            }

            public static OperationTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OperationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OperationTypeEnum a, OperationTypeEnum b)
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

            public static bool operator !=(OperationTypeEnum a, OperationTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 任务状态
        /// </summary>
        /// <value>任务状态</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: success
            /// </summary>
            public static readonly StatusEnum SUCCESS = new StatusEnum("success");

            /// <summary>
            /// Enum SKIPPED for value: skipped
            /// </summary>
            public static readonly StatusEnum SKIPPED = new StatusEnum("skipped");

            /// <summary>
            /// Enum FAILED for value: failed
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("failed");

            /// <summary>
            /// Enum RUNNING for value: running
            /// </summary>
            public static readonly StatusEnum RUNNING = new StatusEnum("running");

            /// <summary>
            /// Enum TIMEOUT for value: timeout
            /// </summary>
            public static readonly StatusEnum TIMEOUT = new StatusEnum("timeout");

            /// <summary>
            /// Enum WAITING for value: waiting
            /// </summary>
            public static readonly StatusEnum WAITING = new StatusEnum("waiting");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "success", SUCCESS },
                { "skipped", SKIPPED },
                { "failed", FAILED },
                { "running", RUNNING },
                { "timeout", TIMEOUT },
                { "waiting", WAITING },
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
        /// 备份记录id
        /// </summary>
        [JsonProperty("checkpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckpointId { get; set; }

        /// <summary>
        /// 创建时间,例如: \&quot;2020-02-23T01:00:32Z\&quot;
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 任务结束时间,例如: \&quot;2020-02-23T01:00:32Z\&quot;
        /// </summary>
        [JsonProperty("ended_at", NullValueHandling = NullValueHandling.Ignore)]
        public string EndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_info", NullValueHandling = NullValueHandling.Ignore)]
        public OpErrorInfo ErrorInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extra_info", NullValueHandling = NullValueHandling.Ignore)]
        public OpExtraInfo ExtraInfo { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public OperationTypeEnum OperationType { get; set; }
        /// <summary>
        /// 策略ID
        /// </summary>
        [JsonProperty("policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 备份提供商ID。用于区分备份对象。
        /// </summary>
        [JsonProperty("provider_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderId { get; set; }

        /// <summary>
        /// 任务开始时间,例如: \&quot;2020-02-23T01:00:32Z\&quot;
        /// </summary>
        [JsonProperty("started_at", NullValueHandling = NullValueHandling.Ignore)]
        public string StartedAt { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 修改时间,例如: \&quot;2020-02-23T01:00:32Z\&quot;
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 任务操作资源所属存储库ID
        /// </summary>
        [JsonProperty("vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultId { get; set; }

        /// <summary>
        /// 任务操作资源所属存储库名称
        /// </summary>
        [JsonProperty("vault_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationLog {\n");
            sb.Append("  checkpointId: ").Append(CheckpointId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  endedAt: ").Append(EndedAt).Append("\n");
            sb.Append("  errorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("  extraInfo: ").Append(ExtraInfo).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  operationType: ").Append(OperationType).Append("\n");
            sb.Append("  policyId: ").Append(PolicyId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  providerId: ").Append(ProviderId).Append("\n");
            sb.Append("  startedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  vaultId: ").Append(VaultId).Append("\n");
            sb.Append("  vaultName: ").Append(VaultName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperationLog);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperationLog input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CheckpointId == input.CheckpointId ||
                    (this.CheckpointId != null &&
                    this.CheckpointId.Equals(input.CheckpointId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.EndedAt == input.EndedAt ||
                    (this.EndedAt != null &&
                    this.EndedAt.Equals(input.EndedAt))
                ) && 
                (
                    this.ErrorInfo == input.ErrorInfo ||
                    (this.ErrorInfo != null &&
                    this.ErrorInfo.Equals(input.ErrorInfo))
                ) && 
                (
                    this.ExtraInfo == input.ExtraInfo ||
                    (this.ExtraInfo != null &&
                    this.ExtraInfo.Equals(input.ExtraInfo))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OperationType == input.OperationType ||
                    (this.OperationType != null &&
                    this.OperationType.Equals(input.OperationType))
                ) && 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ProviderId == input.ProviderId ||
                    (this.ProviderId != null &&
                    this.ProviderId.Equals(input.ProviderId))
                ) && 
                (
                    this.StartedAt == input.StartedAt ||
                    (this.StartedAt != null &&
                    this.StartedAt.Equals(input.StartedAt))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.VaultId == input.VaultId ||
                    (this.VaultId != null &&
                    this.VaultId.Equals(input.VaultId))
                ) && 
                (
                    this.VaultName == input.VaultName ||
                    (this.VaultName != null &&
                    this.VaultName.Equals(input.VaultName))
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
                if (this.CheckpointId != null)
                    hashCode = hashCode * 59 + this.CheckpointId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.EndedAt != null)
                    hashCode = hashCode * 59 + this.EndedAt.GetHashCode();
                if (this.ErrorInfo != null)
                    hashCode = hashCode * 59 + this.ErrorInfo.GetHashCode();
                if (this.ExtraInfo != null)
                    hashCode = hashCode * 59 + this.ExtraInfo.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OperationType != null)
                    hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                if (this.PolicyId != null)
                    hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProviderId != null)
                    hashCode = hashCode * 59 + this.ProviderId.GetHashCode();
                if (this.StartedAt != null)
                    hashCode = hashCode * 59 + this.StartedAt.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                if (this.VaultName != null)
                    hashCode = hashCode * 59 + this.VaultName.GetHashCode();
                return hashCode;
            }
        }
    }
}
