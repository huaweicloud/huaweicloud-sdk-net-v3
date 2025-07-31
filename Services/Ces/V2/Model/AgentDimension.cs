using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AgentDimension 
    {
        /// <summary>
        /// **参数解释**： 维度名称。 **取值范围**： 枚举类型，mount_point:挂载点，disk:磁盘，proc:进程，gpu:显卡，raid:RAID控制器。 
        /// </summary>
        /// <value>**参数解释**： 维度名称。 **取值范围**： 枚举类型，mount_point:挂载点，disk:磁盘，proc:进程，gpu:显卡，raid:RAID控制器。 </value>
        [JsonConverter(typeof(EnumClassConverter<NameEnum>))]
        public class NameEnum
        {
            /// <summary>
            /// Enum MOUNT_POINT for value: mount_point
            /// </summary>
            public static readonly NameEnum MOUNT_POINT = new NameEnum("mount_point");

            /// <summary>
            /// Enum DISK for value: disk
            /// </summary>
            public static readonly NameEnum DISK = new NameEnum("disk");

            /// <summary>
            /// Enum PROC for value: proc
            /// </summary>
            public static readonly NameEnum PROC = new NameEnum("proc");

            /// <summary>
            /// Enum GPU for value: gpu
            /// </summary>
            public static readonly NameEnum GPU = new NameEnum("gpu");

            /// <summary>
            /// Enum RAID for value: raid
            /// </summary>
            public static readonly NameEnum RAID = new NameEnum("raid");

            private static readonly Dictionary<string, NameEnum> StaticFields =
            new Dictionary<string, NameEnum>()
            {
                { "mount_point", MOUNT_POINT },
                { "disk", DISK },
                { "proc", PROC },
                { "gpu", GPU },
                { "raid", RAID },
            };

            private string _value;

            public NameEnum()
            {

            }

            public NameEnum(string value)
            {
                _value = value;
            }

            public static NameEnum FromValue(string value)
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

                if (this.Equals(obj as NameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NameEnum a, NameEnum b)
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

            public static bool operator !=(NameEnum a, NameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 维度名称。 **取值范围**： 枚举类型，mount_point:挂载点，disk:磁盘，proc:进程，gpu:显卡，raid:RAID控制器。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public NameEnum Name { get; set; }
        /// <summary>
        /// **参数解释**： 维度值。 **取值范围**： 字符串长度为32。 
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// **参数解释**： 实际维度信息。 **取值范围** 字符串长度在 1 到 1024 之间。 
        /// </summary>
        [JsonProperty("origin_value", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentDimension {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  originValue: ").Append(OriginValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgentDimension);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgentDimension input)
        {
            if (input == null) return false;
            if (this.Name != input.Name) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.OriginValue != input.OriginValue || (this.OriginValue != null && !this.OriginValue.Equals(input.OriginValue))) return false;

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
                hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.OriginValue != null) hashCode = hashCode * 59 + this.OriginValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
