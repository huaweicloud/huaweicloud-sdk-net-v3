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
    /// Request Object
    /// </summary>
    public class ListOpLogsRequest 
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
            /// Enum DELETE for value: delete
            /// </summary>
            public static readonly OperationTypeEnum DELETE = new OperationTypeEnum("delete");

            /// <summary>
            /// Enum RESTORE for value: restore
            /// </summary>
            public static readonly OperationTypeEnum RESTORE = new OperationTypeEnum("restore");

            /// <summary>
            /// Enum VAULT_DELETE for value: vault_delete
            /// </summary>
            public static readonly OperationTypeEnum VAULT_DELETE = new OperationTypeEnum("vault_delete");

            /// <summary>
            /// Enum REMOVE_RESOURCE for value: remove_resource
            /// </summary>
            public static readonly OperationTypeEnum REMOVE_RESOURCE = new OperationTypeEnum("remove_resource");

            /// <summary>
            /// Enum SYNC for value: sync
            /// </summary>
            public static readonly OperationTypeEnum SYNC = new OperationTypeEnum("sync");

            private static readonly Dictionary<string, OperationTypeEnum> StaticFields =
            new Dictionary<string, OperationTypeEnum>()
            {
                { "backup", BACKUP },
                { "copy", COPY },
                { "replication", REPLICATION },
                { "delete", DELETE },
                { "restore", RESTORE },
                { "vault_delete", VAULT_DELETE },
                { "remove_resource", REMOVE_RESOURCE },
                { "sync", SYNC },
            };

            private string _value;

            public OperationTypeEnum()
            {

            }

            public OperationTypeEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 任务结束时间，格式为%YYYY-%mm-%ddT%HH:%MM:%SSZ，例如2018-02-01T12:00:00Z
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 每页显示的条目数量，正整数
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 偏移值，正整数
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [SDKProperty("operation_type", IsQuery = true)]
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public OperationTypeEnum OperationType { get; set; }
        /// <summary>
        /// 备份提供商ID
        /// </summary>
        [SDKProperty("provider_id", IsQuery = true)]
        [JsonProperty("provider_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderId { get; set; }

        /// <summary>
        /// 该任务操作的资源ID
        /// </summary>
        [SDKProperty("resource_id", IsQuery = true)]
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 该任务操作的资源名称
        /// </summary>
        [SDKProperty("resource_name", IsQuery = true)]
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 任务开始时间，格式为%YYYY-%mm-%ddT%HH:%MM:%SSZ，例如2018-01-01T12:00:00Z
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 存储库ID,该任务操作的资源所属绑定的存储库。
        /// </summary>
        [SDKProperty("vault_id", IsQuery = true)]
        [JsonProperty("vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultId { get; set; }

        /// <summary>
        /// 存储库名称，该任务操作资源所绑定的存储库名称。
        /// </summary>
        [SDKProperty("vault_name", IsQuery = true)]
        [JsonProperty("vault_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultName { get; set; }

        /// <summary>
        /// 企业项目id或all_granted_eps，all_granted_eps表示查询用户有权限的所有企业项目id
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOpLogsRequest {\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  operationType: ").Append(OperationType).Append("\n");
            sb.Append("  providerId: ").Append(ProviderId).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  vaultId: ").Append(VaultId).Append("\n");
            sb.Append("  vaultName: ").Append(VaultName).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListOpLogsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListOpLogsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.OperationType == input.OperationType ||
                    (this.OperationType != null &&
                    this.OperationType.Equals(input.OperationType))
                ) && 
                (
                    this.ProviderId == input.ProviderId ||
                    (this.ProviderId != null &&
                    this.ProviderId.Equals(input.ProviderId))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.ResourceName == input.ResourceName ||
                    (this.ResourceName != null &&
                    this.ResourceName.Equals(input.ResourceName))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.OperationType != null)
                    hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                if (this.ProviderId != null)
                    hashCode = hashCode * 59 + this.ProviderId.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                if (this.VaultName != null)
                    hashCode = hashCode * 59 + this.VaultName.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
