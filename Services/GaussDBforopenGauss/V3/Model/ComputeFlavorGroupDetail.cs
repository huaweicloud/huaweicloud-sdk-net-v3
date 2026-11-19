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
    /// 
    /// </summary>
    public class ComputeFlavorGroupDetail 
    {
        /// <summary>
        /// **参数解释**: 性能规格。 **取值范围**: - normal：独享型（1:8）。 - normal2：独享型（1:4）。 - armFlavors：鲲鹏独享型（1:8）。 - exclusive：独享型（1:4），仅基础版集中式实例支持。 - armExclusive：鲲鹏独享型（1:4），仅基础版集中式实例支持。 - economical：惠选型（1:4）。 - economical2：惠选型（1:8）。 - armFlavors2：鲲鹏独享型（1:4）。 - general：通用型（1:4）。
        /// </summary>
        /// <value>**参数解释**: 性能规格。 **取值范围**: - normal：独享型（1:8）。 - normal2：独享型（1:4）。 - armFlavors：鲲鹏独享型（1:8）。 - exclusive：独享型（1:4），仅基础版集中式实例支持。 - armExclusive：鲲鹏独享型（1:4），仅基础版集中式实例支持。 - economical：惠选型（1:4）。 - economical2：惠选型（1:8）。 - armFlavors2：鲲鹏独享型（1:4）。 - general：通用型（1:4）。</value>
        [JsonConverter(typeof(EnumClassConverter<GroupTypeEnum>))]
        public class GroupTypeEnum
        {
            /// <summary>
            /// Enum NORMAL for value: normal
            /// </summary>
            public static readonly GroupTypeEnum NORMAL = new GroupTypeEnum("normal");

            /// <summary>
            /// Enum NORMAL2 for value: normal2
            /// </summary>
            public static readonly GroupTypeEnum NORMAL2 = new GroupTypeEnum("normal2");

            /// <summary>
            /// Enum ARMFLAVORS for value: armFlavors
            /// </summary>
            public static readonly GroupTypeEnum ARMFLAVORS = new GroupTypeEnum("armFlavors");

            /// <summary>
            /// Enum EXCLUSIVE for value: exclusive
            /// </summary>
            public static readonly GroupTypeEnum EXCLUSIVE = new GroupTypeEnum("exclusive");

            /// <summary>
            /// Enum ARMEXCLUSIVE for value: armExclusive
            /// </summary>
            public static readonly GroupTypeEnum ARMEXCLUSIVE = new GroupTypeEnum("armExclusive");

            /// <summary>
            /// Enum ECONOMICAL for value: economical
            /// </summary>
            public static readonly GroupTypeEnum ECONOMICAL = new GroupTypeEnum("economical");

            /// <summary>
            /// Enum ECONOMICAL2 for value: economical2
            /// </summary>
            public static readonly GroupTypeEnum ECONOMICAL2 = new GroupTypeEnum("economical2");

            /// <summary>
            /// Enum ARMFLAVORS2 for value: armFlavors2
            /// </summary>
            public static readonly GroupTypeEnum ARMFLAVORS2 = new GroupTypeEnum("armFlavors2");

            /// <summary>
            /// Enum GENERAL for value: general
            /// </summary>
            public static readonly GroupTypeEnum GENERAL = new GroupTypeEnum("general");

            private static readonly Dictionary<string, GroupTypeEnum> StaticFields =
            new Dictionary<string, GroupTypeEnum>()
            {
                { "normal", NORMAL },
                { "normal2", NORMAL2 },
                { "armFlavors", ARMFLAVORS },
                { "exclusive", EXCLUSIVE },
                { "armExclusive", ARMEXCLUSIVE },
                { "economical", ECONOMICAL },
                { "economical2", ECONOMICAL2 },
                { "armFlavors2", ARMFLAVORS2 },
                { "general", GENERAL },
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

            public static bool operator !=(GroupTypeEnum a, GroupTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: 性能规格。 **取值范围**: - normal：独享型（1:8）。 - normal2：独享型（1:4）。 - armFlavors：鲲鹏独享型（1:8）。 - exclusive：独享型（1:4），仅基础版集中式实例支持。 - armExclusive：鲲鹏独享型（1:4），仅基础版集中式实例支持。 - economical：惠选型（1:4）。 - economical2：惠选型（1:8）。 - armFlavors2：鲲鹏独享型（1:4）。 - general：通用型（1:4）。
        /// </summary>
        [JsonProperty("group_type", NullValueHandling = NullValueHandling.Ignore)]
        public GroupTypeEnum GroupType { get; set; }
        /// <summary>
        /// **参数解释**: 计算规格列表。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("compute_flavors", NullValueHandling = NullValueHandling.Ignore)]
        public List<ComputeFlavorItemDetail> ComputeFlavors { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComputeFlavorGroupDetail {\n");
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
            return this.Equals(input as ComputeFlavorGroupDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ComputeFlavorGroupDetail input)
        {
            if (input == null) return false;
            if (this.GroupType != input.GroupType) return false;
            if (this.ComputeFlavors != input.ComputeFlavors || (this.ComputeFlavors != null && input.ComputeFlavors != null && !this.ComputeFlavors.SequenceEqual(input.ComputeFlavors))) return false;

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
                hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.ComputeFlavors != null) hashCode = hashCode * 59 + this.ComputeFlavors.GetHashCode();
                return hashCode;
            }
        }
    }
}
