using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// 区域纳管情况。
    /// </summary>
    public class RegionConfigurationList 
    {
        /// <summary>
        /// 区域状态。
        /// </summary>
        /// <value>区域状态。</value>
        [JsonConverter(typeof(EnumClassConverter<RegionConfigurationStatusEnum>))]
        public class RegionConfigurationStatusEnum
        {
            /// <summary>
            /// Enum ENABLED for value: ENABLED
            /// </summary>
            public static readonly RegionConfigurationStatusEnum ENABLED = new RegionConfigurationStatusEnum("ENABLED");

            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            public static readonly RegionConfigurationStatusEnum DISABLED = new RegionConfigurationStatusEnum("DISABLED");

            private static readonly Dictionary<string, RegionConfigurationStatusEnum> StaticFields =
            new Dictionary<string, RegionConfigurationStatusEnum>()
            {
                { "ENABLED", ENABLED },
                { "DISABLED", DISABLED },
            };

            private string _value;

            public RegionConfigurationStatusEnum()
            {

            }

            public RegionConfigurationStatusEnum(string value)
            {
                _value = value;
            }

            public static RegionConfigurationStatusEnum FromValue(string value)
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

                if (this.Equals(obj as RegionConfigurationStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RegionConfigurationStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RegionConfigurationStatusEnum a, RegionConfigurationStatusEnum b)
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

            public static bool operator !=(RegionConfigurationStatusEnum a, RegionConfigurationStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 区域名字。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 区域状态。
        /// </summary>
        [JsonProperty("region_configuration_status", NullValueHandling = NullValueHandling.Ignore)]
        public RegionConfigurationStatusEnum RegionConfigurationStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegionConfigurationList {\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  regionConfigurationStatus: ").Append(RegionConfigurationStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegionConfigurationList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RegionConfigurationList input)
        {
            if (input == null) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.RegionConfigurationStatus != input.RegionConfigurationStatus) return false;

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
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                hashCode = hashCode * 59 + this.RegionConfigurationStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
