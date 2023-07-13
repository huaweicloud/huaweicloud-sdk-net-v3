using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Flavor 
    {
        /// <summary>
        /// 防火墙版本，0：标准版，1：专业版，2：铂金版，3：基础版
        /// </summary>
        /// <value>防火墙版本，0：标准版，1：专业版，2：铂金版，3：基础版</value>
        [JsonConverter(typeof(EnumClassConverter<VersionEnum>))]
        public class VersionEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly VersionEnum NUMBER_0 = new VersionEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly VersionEnum NUMBER_1 = new VersionEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly VersionEnum NUMBER_2 = new VersionEnum(2);

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            public static readonly VersionEnum NUMBER_3 = new VersionEnum(3);

            private static readonly Dictionary<int?, VersionEnum> StaticFields =
            new Dictionary<int?, VersionEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
                { 3, NUMBER_3 },
            };

            private int? _value;

            public VersionEnum()
            {

            }

            public VersionEnum(int? value)
            {
                _value = value;
            }

            public static VersionEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as VersionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VersionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VersionEnum a, VersionEnum b)
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

            public static bool operator !=(VersionEnum a, VersionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 防火墙版本，0：标准版，1：专业版，2：铂金版，3：基础版
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public VersionEnum Version { get; set; }
        /// <summary>
        /// eip数量
        /// </summary>
        [JsonProperty("eip_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? EipCount { get; set; }

        /// <summary>
        /// vpc数量
        /// </summary>
        [JsonProperty("vpc_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? VpcCount { get; set; }

        /// <summary>
        /// 带宽
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// 日志存储
        /// </summary>
        [JsonProperty("log_storage", NullValueHandling = NullValueHandling.Ignore)]
        public int? LogStorage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Flavor {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  eipCount: ").Append(EipCount).Append("\n");
            sb.Append("  vpcCount: ").Append(VpcCount).Append("\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  logStorage: ").Append(LogStorage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Flavor);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Flavor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.EipCount == input.EipCount ||
                    (this.EipCount != null &&
                    this.EipCount.Equals(input.EipCount))
                ) && 
                (
                    this.VpcCount == input.VpcCount ||
                    (this.VpcCount != null &&
                    this.VpcCount.Equals(input.VpcCount))
                ) && 
                (
                    this.Bandwidth == input.Bandwidth ||
                    (this.Bandwidth != null &&
                    this.Bandwidth.Equals(input.Bandwidth))
                ) && 
                (
                    this.LogStorage == input.LogStorage ||
                    (this.LogStorage != null &&
                    this.LogStorage.Equals(input.LogStorage))
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.EipCount != null)
                    hashCode = hashCode * 59 + this.EipCount.GetHashCode();
                if (this.VpcCount != null)
                    hashCode = hashCode * 59 + this.VpcCount.GetHashCode();
                if (this.Bandwidth != null)
                    hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                if (this.LogStorage != null)
                    hashCode = hashCode * 59 + this.LogStorage.GetHashCode();
                return hashCode;
            }
        }
    }
}
