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
    /// Request Object
    /// </summary>
    public class ShowDomainResourceReportsRequest 
    {
        /// <summary>
        /// 资源类型
        /// </summary>
        /// <value>资源类型</value>
        [JsonConverter(typeof(EnumClassConverter<ResourceTypeEnum>))]
        public class ResourceTypeEnum
        {
            /// <summary>
            /// Enum DOWNFLOW for value: downflow
            /// </summary>
            public static readonly ResourceTypeEnum DOWNFLOW = new ResourceTypeEnum("downflow");

            /// <summary>
            /// Enum STORE for value: store
            /// </summary>
            public static readonly ResourceTypeEnum STORE = new ResourceTypeEnum("store");

            private static readonly Dictionary<string, ResourceTypeEnum> StaticFields =
            new Dictionary<string, ResourceTypeEnum>()
            {
                { "downflow", DOWNFLOW },
                { "store", STORE },
            };

            private string _value;

            public ResourceTypeEnum()
            {

            }

            public ResourceTypeEnum(string value)
            {
                _value = value;
            }

            public static ResourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ResourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResourceTypeEnum a, ResourceTypeEnum b)
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

            public static bool operator !=(ResourceTypeEnum a, ResourceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 频率类型
        /// </summary>
        /// <value>频率类型</value>
        [JsonConverter(typeof(EnumClassConverter<FrequencyEnum>))]
        public class FrequencyEnum
        {
            /// <summary>
            /// Enum DAILY for value: daily
            /// </summary>
            public static readonly FrequencyEnum DAILY = new FrequencyEnum("daily");

            private static readonly Dictionary<string, FrequencyEnum> StaticFields =
            new Dictionary<string, FrequencyEnum>()
            {
                { "daily", DAILY },
            };

            private string _value;

            public FrequencyEnum()
            {

            }

            public FrequencyEnum(string value)
            {
                _value = value;
            }

            public static FrequencyEnum FromValue(string value)
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

                if (this.Equals(obj as FrequencyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FrequencyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FrequencyEnum a, FrequencyEnum b)
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

            public static bool operator !=(FrequencyEnum a, FrequencyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 资源类型
        /// </summary>
        [SDKProperty("resource_type", IsPath = true)]
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceTypeEnum ResourceType { get; set; }
        /// <summary>
        /// 频率类型
        /// </summary>
        [SDKProperty("frequency", IsPath = true)]
        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public FrequencyEnum Frequency { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDomainResourceReportsRequest {\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  frequency: ").Append(Frequency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDomainResourceReportsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDomainResourceReportsRequest input)
        {
            if (input == null) return false;
            if (this.ResourceType != input.ResourceType) return false;
            if (this.Frequency != input.Frequency) return false;

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
                hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                return hashCode;
            }
        }
    }
}
