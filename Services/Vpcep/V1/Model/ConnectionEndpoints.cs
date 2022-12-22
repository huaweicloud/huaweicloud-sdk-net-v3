using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1.Model
{
    /// <summary>
    /// 终端节点列表
    /// </summary>
    public class ConnectionEndpoints 
    {
        /// <summary>
        /// 终端节点的连接状态。 ● pendingAcceptance：待接受 ● creating：创建中 ● accepted：已接受 ● rejected：已拒绝 ● failed：失败 ● deleting：删除中
        /// </summary>
        /// <value>终端节点的连接状态。 ● pendingAcceptance：待接受 ● creating：创建中 ● accepted：已接受 ● rejected：已拒绝 ● failed：失败 ● deleting：删除中</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum PENDINGACCEPTANCE for value: pendingAcceptance
            /// </summary>
            public static readonly StatusEnum PENDINGACCEPTANCE = new StatusEnum("pendingAcceptance");

            /// <summary>
            /// Enum CREATING for value: creating
            /// </summary>
            public static readonly StatusEnum CREATING = new StatusEnum("creating");

            /// <summary>
            /// Enum ACCEPTED for value: accepted
            /// </summary>
            public static readonly StatusEnum ACCEPTED = new StatusEnum("accepted");

            /// <summary>
            /// Enum REJECTED for value: rejected
            /// </summary>
            public static readonly StatusEnum REJECTED = new StatusEnum("rejected");

            /// <summary>
            /// Enum FAILED for value: failed
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("failed");

            /// <summary>
            /// Enum DELETING for value: deleting
            /// </summary>
            public static readonly StatusEnum DELETING = new StatusEnum("deleting");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "pendingAcceptance", PENDINGACCEPTANCE },
                { "creating", CREATING },
                { "accepted", ACCEPTED },
                { "rejected", REJECTED },
                { "failed", FAILED },
                { "deleting", DELETING },
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
        /// 终端节点的ID，唯一标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 终端节点的报文标识。
        /// </summary>
        [JsonProperty("marker_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MarkerId { get; set; }

        /// <summary>
        /// 终端节点的创建时间。 采用UTC时间格式，格式为：YYYY-MMDDTHH:MM:SSZ
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 终端节点的更新时间。 采用UTC时间格式，格式为：YYYY-MMDDTHH:MM:SSZ
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 用户的Domain ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 错误信息。  当终端节点服务状态异常，即“status”的值为“failed”时，会返回该字段。
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryError> Error { get; set; }

        /// <summary>
        /// 终端节点的连接状态。 ● pendingAcceptance：待接受 ● creating：创建中 ● accepted：已接受 ● rejected：已拒绝 ● failed：失败 ● deleting：删除中
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 终端节点连接描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectionEndpoints {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  markerId: ").Append(MarkerId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  error: ").Append(Error).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConnectionEndpoints);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConnectionEndpoints input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MarkerId == input.MarkerId ||
                    (this.MarkerId != null &&
                    this.MarkerId.Equals(input.MarkerId))
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
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.Error == input.Error ||
                    this.Error != null &&
                    input.Error != null &&
                    this.Error.SequenceEqual(input.Error)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MarkerId != null)
                    hashCode = hashCode * 59 + this.MarkerId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
