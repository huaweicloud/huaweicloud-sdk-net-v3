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
    public class DescribeInstanceAccessControlAttributeConfigurationResponse : SdkResponse
    {
        /// <summary>
        /// ABAC属性配置的状态
        /// </summary>
        /// <value>ABAC属性配置的状态</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ENABLED for value: ENABLED
            /// </summary>
            public static readonly StatusEnum ENABLED = new StatusEnum("ENABLED");

            /// <summary>
            /// Enum CREATION_IN_PROGRESS for value: CREATION_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum CREATION_IN_PROGRESS = new StatusEnum("CREATION_IN_PROGRESS");

            /// <summary>
            /// Enum CREATION_FAILED for value: CREATION_FAILED
            /// </summary>
            public static readonly StatusEnum CREATION_FAILED = new StatusEnum("CREATION_FAILED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ENABLED", ENABLED },
                { "CREATION_IN_PROGRESS", CREATION_IN_PROGRESS },
                { "CREATION_FAILED", CREATION_FAILED },
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
        /// 
        /// </summary>
        [JsonProperty("instance_access_control_attribute_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceAccessControlAttributeConfigurationDto InstanceAccessControlAttributeConfiguration { get; set; }

        /// <summary>
        /// ABAC属性配置的状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 提供有关指定属性的当前状态的更多详细信息
        /// </summary>
        [JsonProperty("status_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusReason { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DescribeInstanceAccessControlAttributeConfigurationResponse {\n");
            sb.Append("  instanceAccessControlAttributeConfiguration: ").Append(InstanceAccessControlAttributeConfiguration).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  statusReason: ").Append(StatusReason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DescribeInstanceAccessControlAttributeConfigurationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DescribeInstanceAccessControlAttributeConfigurationResponse input)
        {
            if (input == null) return false;
            if (this.InstanceAccessControlAttributeConfiguration != input.InstanceAccessControlAttributeConfiguration || (this.InstanceAccessControlAttributeConfiguration != null && !this.InstanceAccessControlAttributeConfiguration.Equals(input.InstanceAccessControlAttributeConfiguration))) return false;
            if (this.Status != input.Status) return false;
            if (this.StatusReason != input.StatusReason || (this.StatusReason != null && !this.StatusReason.Equals(input.StatusReason))) return false;

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
                if (this.InstanceAccessControlAttributeConfiguration != null) hashCode = hashCode * 59 + this.InstanceAccessControlAttributeConfiguration.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusReason != null) hashCode = hashCode * 59 + this.StatusReason.GetHashCode();
                return hashCode;
            }
        }
    }
}
