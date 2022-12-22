using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NeutronFirewallRule 
    {
        /// <summary>
        /// 功能说明：对通过网络ACL的流量执行的操作。 取值范围：DENY（拒绝）/ALLOW（允许）
        /// </summary>
        /// <value>功能说明：对通过网络ACL的流量执行的操作。 取值范围：DENY（拒绝）/ALLOW（允许）</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum DENY for value: DENY
            /// </summary>
            public static readonly ActionEnum DENY = new ActionEnum("DENY");

            /// <summary>
            /// Enum ALLOW for value: ALLOW
            /// </summary>
            public static readonly ActionEnum ALLOW = new ActionEnum("ALLOW");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "DENY", DENY },
                { "ALLOW", ALLOW },
            };

            private string _value;

            public ActionEnum()
            {

            }

            public ActionEnum(string value)
            {
                _value = value;
            }

            public static ActionEnum FromValue(string value)
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

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 功能说明：网络ACL规则的uuid标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 功能说明：网络ACL规则名称。 取值范围：0-255个字符
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：网络ACL规则描述 取值范围：0-255个字符长度
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能说明：对通过网络ACL的流量执行的操作。 取值范围：DENY（拒绝）/ALLOW（允许）
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// 功能说明：IP协议 取值范围：支持TCP,UDP,ICMP, ICMPV6或者IP协议号（0-255）
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// 功能说明：IP协议版本 取值范围：Ipv4/Ipv6
        /// </summary>
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpVersion { get; set; }

        /// <summary>
        /// 功能说明：是否使能网络ACL规则。 取值范围：true/false
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 功能说明：是否支持跨租户共享 取值范围：true/false
        /// </summary>
        [JsonProperty("public", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Public { get; set; }

        /// <summary>
        /// 功能说明：目的地址或者CIDR。
        /// </summary>
        [JsonProperty("destination_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationIpAddress { get; set; }

        /// <summary>
        /// 功能说明：目的端口号或者一段端口范围。
        /// </summary>
        [JsonProperty("destination_port", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationPort { get; set; }

        /// <summary>
        /// 功能说明：源地址或者CIDR。
        /// </summary>
        [JsonProperty("source_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceIpAddress { get; set; }

        /// <summary>
        /// 功能说明：源端口号或者一段端口范围。
        /// </summary>
        [JsonProperty("source_port", NullValueHandling = NullValueHandling.Ignore)]
        public string SourcePort { get; set; }

        /// <summary>
        /// 功能说明：项目ID
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 功能说明：项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronFirewallRule {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  destinationIpAddress: ").Append(DestinationIpAddress).Append("\n");
            sb.Append("  destinationPort: ").Append(DestinationPort).Append("\n");
            sb.Append("  sourceIpAddress: ").Append(SourceIpAddress).Append("\n");
            sb.Append("  sourcePort: ").Append(SourcePort).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronFirewallRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronFirewallRule input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.IpVersion == input.IpVersion ||
                    (this.IpVersion != null &&
                    this.IpVersion.Equals(input.IpVersion))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Public == input.Public ||
                    (this.Public != null &&
                    this.Public.Equals(input.Public))
                ) && 
                (
                    this.DestinationIpAddress == input.DestinationIpAddress ||
                    (this.DestinationIpAddress != null &&
                    this.DestinationIpAddress.Equals(input.DestinationIpAddress))
                ) && 
                (
                    this.DestinationPort == input.DestinationPort ||
                    (this.DestinationPort != null &&
                    this.DestinationPort.Equals(input.DestinationPort))
                ) && 
                (
                    this.SourceIpAddress == input.SourceIpAddress ||
                    (this.SourceIpAddress != null &&
                    this.SourceIpAddress.Equals(input.SourceIpAddress))
                ) && 
                (
                    this.SourcePort == input.SourcePort ||
                    (this.SourcePort != null &&
                    this.SourcePort.Equals(input.SourcePort))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.IpVersion != null)
                    hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Public != null)
                    hashCode = hashCode * 59 + this.Public.GetHashCode();
                if (this.DestinationIpAddress != null)
                    hashCode = hashCode * 59 + this.DestinationIpAddress.GetHashCode();
                if (this.DestinationPort != null)
                    hashCode = hashCode * 59 + this.DestinationPort.GetHashCode();
                if (this.SourceIpAddress != null)
                    hashCode = hashCode * 59 + this.SourceIpAddress.GetHashCode();
                if (this.SourcePort != null)
                    hashCode = hashCode * 59 + this.SourcePort.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
