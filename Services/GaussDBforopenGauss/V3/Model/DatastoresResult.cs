using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 数据库引擎列表。
    /// </summary>
    public class DatastoresResult 
    {
        /// <summary>
        /// 部署形态
        /// </summary>
        /// <value>部署形态</value>
        [JsonConverter(typeof(EnumClassConverter<InstanceModeEnum>))]
        public class InstanceModeEnum
        {
            /// <summary>
            /// Enum HA for value: ha
            /// </summary>
            public static readonly InstanceModeEnum HA = new InstanceModeEnum("ha");

            /// <summary>
            /// Enum INDEPENDENT for value: independent
            /// </summary>
            public static readonly InstanceModeEnum INDEPENDENT = new InstanceModeEnum("independent");

            private static readonly Dictionary<string, InstanceModeEnum> StaticFields =
            new Dictionary<string, InstanceModeEnum>()
            {
                { "ha", HA },
                { "independent", INDEPENDENT },
            };

            private string _value;

            public InstanceModeEnum()
            {

            }

            public InstanceModeEnum(string value)
            {
                _value = value;
            }

            public static InstanceModeEnum FromValue(string value)
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

                if (this.Equals(obj as InstanceModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InstanceModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InstanceModeEnum a, InstanceModeEnum b)
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

            public static bool operator !=(InstanceModeEnum a, InstanceModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 部署形态支持的引擎版本列表
        /// </summary>
        [JsonProperty("supported_versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportedVersions { get; set; }

        /// <summary>
        /// 部署形态
        /// </summary>
        [JsonProperty("instance_mode", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceModeEnum InstanceMode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatastoresResult {\n");
            sb.Append("  supportedVersions: ").Append(SupportedVersions).Append("\n");
            sb.Append("  instanceMode: ").Append(InstanceMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DatastoresResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DatastoresResult input)
        {
            if (input == null) return false;
            if (this.SupportedVersions != input.SupportedVersions || (this.SupportedVersions != null && input.SupportedVersions != null && !this.SupportedVersions.SequenceEqual(input.SupportedVersions))) return false;
            if (this.InstanceMode != input.InstanceMode) return false;

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
                if (this.SupportedVersions != null) hashCode = hashCode * 59 + this.SupportedVersions.GetHashCode();
                hashCode = hashCode * 59 + this.InstanceMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
