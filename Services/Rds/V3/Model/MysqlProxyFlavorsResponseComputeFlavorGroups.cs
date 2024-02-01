using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MysqlProxyFlavorsResponseComputeFlavorGroups 
    {
        /// <summary>
        /// 规格组类型，如x86、arm。
        /// </summary>
        /// <value>规格组类型，如x86、arm。</value>
        [JsonConverter(typeof(EnumClassConverter<GroupTypeEnum>))]
        public class GroupTypeEnum
        {
            /// <summary>
            /// Enum X86 for value: x86
            /// </summary>
            public static readonly GroupTypeEnum X86 = new GroupTypeEnum("x86");

            /// <summary>
            /// Enum ARM for value: arm
            /// </summary>
            public static readonly GroupTypeEnum ARM = new GroupTypeEnum("arm");

            private static readonly Dictionary<string, GroupTypeEnum> StaticFields =
            new Dictionary<string, GroupTypeEnum>()
            {
                { "x86", X86 },
                { "arm", ARM },
            };

            private string _value;

            public GroupTypeEnum()
            {

            }

            public GroupTypeEnum(string value)
            {
                _value = value;
            }

            public static GroupTypeEnum FromValue(string value)
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

                if (this.Equals(obj as GroupTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(GroupTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(GroupTypeEnum a, GroupTypeEnum b)
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

            public static bool operator !=(GroupTypeEnum a, GroupTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 规格组类型，如x86、arm。
        /// </summary>
        [JsonProperty("group_type", NullValueHandling = NullValueHandling.Ignore)]
        public GroupTypeEnum GroupType { get; set; }
        /// <summary>
        /// 规格信息。
        /// </summary>
        [JsonProperty("compute_flavors", NullValueHandling = NullValueHandling.Ignore)]
        public List<MysqlProxyFlavorsResponseComputeFlavors> ComputeFlavors { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlProxyFlavorsResponseComputeFlavorGroups {\n");
            sb.Append("  groupType: ").Append(GroupType).Append("\n");
            sb.Append("  computeFlavors: ").Append(ComputeFlavors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlProxyFlavorsResponseComputeFlavorGroups);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlProxyFlavorsResponseComputeFlavorGroups input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupType == input.GroupType ||
                    (this.GroupType != null &&
                    this.GroupType.Equals(input.GroupType))
                ) && 
                (
                    this.ComputeFlavors == input.ComputeFlavors ||
                    this.ComputeFlavors != null &&
                    input.ComputeFlavors != null &&
                    this.ComputeFlavors.SequenceEqual(input.ComputeFlavors)
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
                if (this.GroupType != null)
                    hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.ComputeFlavors != null)
                    hashCode = hashCode * 59 + this.ComputeFlavors.GetHashCode();
                return hashCode;
            }
        }
    }
}
