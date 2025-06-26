using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowInstanceEndpointPolicyResponse : SdkResponse
    {
        /// <summary>
        /// 公网访问状态，Enable、Enabling、EnableFailed、Disable、Disabling、DisableFailed
        /// </summary>
        /// <value>公网访问状态，Enable、Enabling、EnableFailed、Disable、Disabling、DisableFailed</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ENABLING for value: Enabling
            /// </summary>
            public static readonly StatusEnum ENABLING = new StatusEnum("Enabling");

            /// <summary>
            /// Enum ENABLE for value: Enable
            /// </summary>
            public static readonly StatusEnum ENABLE = new StatusEnum("Enable");

            /// <summary>
            /// Enum ENABLEFAILED for value: EnableFailed
            /// </summary>
            public static readonly StatusEnum ENABLEFAILED = new StatusEnum("EnableFailed");

            /// <summary>
            /// Enum DISABLE for value: Disable
            /// </summary>
            public static readonly StatusEnum DISABLE = new StatusEnum("Disable");

            /// <summary>
            /// Enum DISABLING for value: Disabling
            /// </summary>
            public static readonly StatusEnum DISABLING = new StatusEnum("Disabling");

            /// <summary>
            /// Enum DISABLEFAILED for value: DisableFailed
            /// </summary>
            public static readonly StatusEnum DISABLEFAILED = new StatusEnum("DisableFailed");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "Enabling", ENABLING },
                { "Enable", ENABLE },
                { "EnableFailed", ENABLEFAILED },
                { "Disable", DISABLE },
                { "Disabling", DISABLING },
                { "DisableFailed", DISABLEFAILED },
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
        /// 公网访问状态，Enable、Enabling、EnableFailed、Disable、Disabling、DisableFailed
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 白名单列表
        /// </summary>
        [JsonProperty("ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<IpInfo> IpList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceEndpointPolicyResponse {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  ipList: ").Append(IpList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceEndpointPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceEndpointPolicyResponse input)
        {
            if (input == null) return false;
            if (this.Status != input.Status) return false;
            if (this.IpList != input.IpList || (this.IpList != null && input.IpList != null && !this.IpList.SequenceEqual(input.IpList))) return false;

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
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.IpList != null) hashCode = hashCode * 59 + this.IpList.GetHashCode();
                return hashCode;
            }
        }
    }
}
