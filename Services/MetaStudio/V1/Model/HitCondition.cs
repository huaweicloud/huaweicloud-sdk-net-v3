using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 命中条件配置
    /// </summary>
    public class HitCondition 
    {
        /// <summary>
        /// **参数解释**： 条件关系。对于多个条件的逻辑运算关系。 **约束限制**： 不涉及。 **取值范围**： * AND：表示多个条件同时满足。 * OR：表示多个条件满足其一即可。 * RESERVED：兜底回复不会去判断其他命中条件。  **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： 条件关系。对于多个条件的逻辑运算关系。 **约束限制**： 不涉及。 **取值范围**： * AND：表示多个条件同时满足。 * OR：表示多个条件满足其一即可。 * RESERVED：兜底回复不会去判断其他命中条件。  **默认取值**： 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<RelationEnum>))]
        public class RelationEnum
        {
            /// <summary>
            /// Enum AND for value: AND
            /// </summary>
            public static readonly RelationEnum AND = new RelationEnum("AND");

            /// <summary>
            /// Enum OR for value: OR
            /// </summary>
            public static readonly RelationEnum OR = new RelationEnum("OR");

            /// <summary>
            /// Enum RESERVED for value: RESERVED
            /// </summary>
            public static readonly RelationEnum RESERVED = new RelationEnum("RESERVED");

            private static readonly Dictionary<string, RelationEnum> StaticFields =
            new Dictionary<string, RelationEnum>()
            {
                { "AND", AND },
                { "OR", OR },
                { "RESERVED", RESERVED },
            };

            private string _value;

            public RelationEnum()
            {

            }

            public RelationEnum(string value)
            {
                _value = value;
            }

            public static RelationEnum FromValue(string value)
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

                if (this.Equals(obj as RelationEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RelationEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RelationEnum a, RelationEnum b)
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

            public static bool operator !=(RelationEnum a, RelationEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 条件关系。对于多个条件的逻辑运算关系。 **约束限制**： 不涉及。 **取值范围**： * AND：表示多个条件同时满足。 * OR：表示多个条件满足其一即可。 * RESERVED：兜底回复不会去判断其他命中条件。  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("relation", NullValueHandling = NullValueHandling.Ignore)]
        public RelationEnum Relation { get; set; }
        /// <summary>
        /// **参数解释**： 优先级，数值越低优先级越高；取值0-999，默认值为500，为可选值 **约束限制**： 不涉及
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 匹配关系配置
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<HitConditionTag> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HitCondition {\n");
            sb.Append("  relation: ").Append(Relation).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HitCondition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HitCondition input)
        {
            if (input == null) return false;
            if (this.Relation != input.Relation) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;

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
                hashCode = hashCode * 59 + this.Relation.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
