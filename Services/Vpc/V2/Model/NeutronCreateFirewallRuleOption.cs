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
    public class NeutronCreateFirewallRuleOption 
    {
        /// <summary>
        /// 功能说明：对通过网络ACL的流量执行的操作 取值范围：DENY（拒绝）/ALLOW（允许）
        /// </summary>
        /// <value>功能说明：对通过网络ACL的流量执行的操作 取值范围：DENY（拒绝）/ALLOW（允许）</value>
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
        /// 功能说明：网络ACL规则名称 取值范围：0-255个字符
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：网络ACL规则描述 取值范围：0-255个字符
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能说明：IP协议 取值范围：支持TCP,UDP,ICMP, ICMPV6或者ip协议号（0-255）
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// 功能说明：对通过网络ACL的流量执行的操作 取值范围：DENY（拒绝）/ALLOW（允许）
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// 功能说明：IP协议版本
        /// </summary>
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpVersion { get; set; }

        /// <summary>
        /// 功能说明：目的地址或者CIDR
        /// </summary>
        [JsonProperty("destination_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationIpAddress { get; set; }

        /// <summary>
        /// 功能说明：目的端口号或者一段端口范围
        /// </summary>
        [JsonProperty("destination_port", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationPort { get; set; }

        /// <summary>
        /// 功能说明：源地址或者CIDR
        /// </summary>
        [JsonProperty("source_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceIpAddress { get; set; }

        /// <summary>
        /// 功能说明：源端口号或者一段端口范围
        /// </summary>
        [JsonProperty("source_port", NullValueHandling = NullValueHandling.Ignore)]
        public string SourcePort { get; set; }

        /// <summary>
        /// 功能说明：是否使能网络ACL防火墙规则。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronCreateFirewallRuleOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  destinationIpAddress: ").Append(DestinationIpAddress).Append("\n");
            sb.Append("  destinationPort: ").Append(DestinationPort).Append("\n");
            sb.Append("  sourceIpAddress: ").Append(SourceIpAddress).Append("\n");
            sb.Append("  sourcePort: ").Append(SourcePort).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronCreateFirewallRuleOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronCreateFirewallRuleOption input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;
            if (this.Action != input.Action) return false;
            if (this.IpVersion != input.IpVersion || (this.IpVersion != null && !this.IpVersion.Equals(input.IpVersion))) return false;
            if (this.DestinationIpAddress != input.DestinationIpAddress || (this.DestinationIpAddress != null && !this.DestinationIpAddress.Equals(input.DestinationIpAddress))) return false;
            if (this.DestinationPort != input.DestinationPort || (this.DestinationPort != null && !this.DestinationPort.Equals(input.DestinationPort))) return false;
            if (this.SourceIpAddress != input.SourceIpAddress || (this.SourceIpAddress != null && !this.SourceIpAddress.Equals(input.SourceIpAddress))) return false;
            if (this.SourcePort != input.SourcePort || (this.SourcePort != null && !this.SourcePort.Equals(input.SourcePort))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.IpVersion != null) hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.DestinationIpAddress != null) hashCode = hashCode * 59 + this.DestinationIpAddress.GetHashCode();
                if (this.DestinationPort != null) hashCode = hashCode * 59 + this.DestinationPort.GetHashCode();
                if (this.SourceIpAddress != null) hashCode = hashCode * 59 + this.SourceIpAddress.GetHashCode();
                if (this.SourcePort != null) hashCode = hashCode * 59 + this.SourcePort.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
