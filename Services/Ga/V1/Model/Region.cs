using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ga.V1.Model
{
    /// <summary>
    /// 区域。
    /// </summary>
    public class Region 
    {
        /// <summary>
        /// 终端节点类型。
        /// </summary>
        /// <value>终端节点类型。</value>
        [JsonConverter(typeof(EnumClassConverter<SupportedEndpointTypesEnum>))]
        public class SupportedEndpointTypesEnum
        {
            /// <summary>
            /// Enum EIP for value: EIP
            /// </summary>
            public static readonly SupportedEndpointTypesEnum EIP = new SupportedEndpointTypesEnum("EIP");

            private static readonly Dictionary<string, SupportedEndpointTypesEnum> StaticFields =
            new Dictionary<string, SupportedEndpointTypesEnum>()
            {
                { "EIP", EIP },
            };

            private string _value;

            public SupportedEndpointTypesEnum()
            {

            }

            public SupportedEndpointTypesEnum(string value)
            {
                _value = value;
            }

            public static SupportedEndpointTypesEnum FromValue(string value)
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

                if (this.Equals(obj as SupportedEndpointTypesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SupportedEndpointTypesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SupportedEndpointTypesEnum a, SupportedEndpointTypesEnum b)
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

            public static bool operator !=(SupportedEndpointTypesEnum a, SupportedEndpointTypesEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 区域ID。
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// 区域所属地区，取值： - OUTOFCM： 中国大陆以外 - CM：中国大陆
        /// </summary>
        [JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public string Area { get; set; }

        /// <summary>
        /// 区域支持的终端节点类型。取值： EIP：弹性公网IP
        /// </summary>
        [JsonProperty("supported_endpoint_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<SupportedEndpointTypesEnum> SupportedEndpointTypes { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Region {\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  area: ").Append(Area).Append("\n");
            sb.Append("  supportedEndpointTypes: ").Append(SupportedEndpointTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Region);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Region input)
        {
            if (input == null) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.Area != input.Area || (this.Area != null && !this.Area.Equals(input.Area))) return false;
            if (this.SupportedEndpointTypes != input.SupportedEndpointTypes || (this.SupportedEndpointTypes != null && input.SupportedEndpointTypes != null && !this.SupportedEndpointTypes.SequenceEqual(input.SupportedEndpointTypes))) return false;

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
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.Area != null) hashCode = hashCode * 59 + this.Area.GetHashCode();
                hashCode = hashCode * 59 + this.SupportedEndpointTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
