using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class GetIdentityCenterServiceStatusResponse : SdkResponse
    {
        /// <summary>
        /// IAM身份中心服务实例状态
        /// </summary>
        /// <value>IAM身份中心服务实例状态</value>
        [JsonConverter(typeof(EnumClassConverter<ServiceStatusEnum>))]
        public class ServiceStatusEnum
        {
            /// <summary>
            /// Enum ENABLED for value: ENABLED
            /// </summary>
            public static readonly ServiceStatusEnum ENABLED = new ServiceStatusEnum("ENABLED");

            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            public static readonly ServiceStatusEnum DISABLED = new ServiceStatusEnum("DISABLED");

            private static readonly Dictionary<string, ServiceStatusEnum> StaticFields =
            new Dictionary<string, ServiceStatusEnum>()
            {
                { "ENABLED", ENABLED },
                { "DISABLED", DISABLED },
            };

            private string _value;

            public ServiceStatusEnum()
            {

            }

            public ServiceStatusEnum(string value)
            {
                _value = value;
            }

            public static ServiceStatusEnum FromValue(string value)
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

                if (this.Equals(obj as ServiceStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ServiceStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ServiceStatusEnum a, ServiceStatusEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ServiceStatusEnum a, ServiceStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// IAM身份中心服务实例状态
        /// </summary>
        [JsonProperty("serviceStatus", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceStatusEnum ServiceStatus { get; set; }
        /// <summary>
        /// IAM身份中心服务实例状态呈现原因
        /// </summary>
        [JsonProperty("serviceStatusReasons", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ServiceStatusReasons { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetIdentityCenterServiceStatusResponse {\n");
            sb.Append("  serviceStatus: ").Append(ServiceStatus).Append("\n");
            sb.Append("  serviceStatusReasons: ").Append(ServiceStatusReasons).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetIdentityCenterServiceStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetIdentityCenterServiceStatusResponse input)
        {
            if (input == null) return false;
            if (this.ServiceStatus != input.ServiceStatus) return false;
            if (this.ServiceStatusReasons != input.ServiceStatusReasons || (this.ServiceStatusReasons != null && input.ServiceStatusReasons != null && !this.ServiceStatusReasons.SequenceEqual(input.ServiceStatusReasons))) return false;

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
                hashCode = hashCode * 59 + this.ServiceStatus.GetHashCode();
                if (this.ServiceStatusReasons != null) hashCode = hashCode * 59 + this.ServiceStatusReasons.GetHashCode();
                return hashCode;
            }
        }
    }
}
