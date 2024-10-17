using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 可用分区结构体
    /// </summary>
    public class AvailableZones 
    {
        /// <summary>
        /// 分区上是否还有可用资源。 - true：还有资源。 - false：资源已售罄。 
        /// </summary>
        /// <value>分区上是否还有可用资源。 - true：还有资源。 - false：资源已售罄。 </value>
        [JsonConverter(typeof(EnumClassConverter<ResourceAvailabilityEnum>))]
        public class ResourceAvailabilityEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly ResourceAvailabilityEnum TRUE = new ResourceAvailabilityEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly ResourceAvailabilityEnum FALSE = new ResourceAvailabilityEnum("false");

            private static readonly Dictionary<string, ResourceAvailabilityEnum> StaticFields =
            new Dictionary<string, ResourceAvailabilityEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public ResourceAvailabilityEnum()
            {

            }

            public ResourceAvailabilityEnum(string value)
            {
                _value = value;
            }

            public static ResourceAvailabilityEnum FromValue(string value)
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

                if (this.Equals(obj as ResourceAvailabilityEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResourceAvailabilityEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResourceAvailabilityEnum a, ResourceAvailabilityEnum b)
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

            public static bool operator !=(ResourceAvailabilityEnum a, ResourceAvailabilityEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 可用区编码。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 可用区端口号。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// 可用区名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 可用区ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 分区上是否还有可用资源。 - true：还有资源。 - false：资源已售罄。 
        /// </summary>
        [JsonProperty("resource_availability", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceAvailabilityEnum ResourceAvailability { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailableZones {\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  resourceAvailability: ").Append(ResourceAvailability).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AvailableZones);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AvailableZones input)
        {
            if (input == null) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ResourceAvailability != input.ResourceAvailability) return false;

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
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.ResourceAvailability.GetHashCode();
                return hashCode;
            }
        }
    }
}
