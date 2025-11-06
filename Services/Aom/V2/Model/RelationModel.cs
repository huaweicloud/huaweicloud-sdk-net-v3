using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 查询条件。
    /// </summary>
    public class RelationModel 
    {
        /// <summary>
        /// 该条件与其他条件的组合方式。  - AND：必须满足所有条件。 -  OR：可以满足其中一个条件。 -  NOT：必须不满足所有条件。
        /// </summary>
        /// <value>该条件与其他条件的组合方式。  - AND：必须满足所有条件。 -  OR：可以满足其中一个条件。 -  NOT：必须不满足所有条件。</value>
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
            /// Enum NOT for value: NOT
            /// </summary>
            public static readonly RelationEnum NOT = new RelationEnum("NOT");

            private static readonly Dictionary<string, RelationEnum> StaticFields =
            new Dictionary<string, RelationEnum>()
            {
                { "AND", AND },
                { "OR", OR },
                { "NOT", NOT },
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

            public static bool operator !=(RelationEnum a, RelationEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 指定查询字段的key，对应metadata里面的key 。当metadata_relation参数不为空时 key参数必填。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 查询条件中指定key的值。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Value { get; set; }

        /// <summary>
        /// 该条件与其他条件的组合方式。  - AND：必须满足所有条件。 -  OR：可以满足其中一个条件。 -  NOT：必须不满足所有条件。
        /// </summary>
        [JsonProperty("relation", NullValueHandling = NullValueHandling.Ignore)]
        public RelationEnum Relation { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelationModel {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  relation: ").Append(Relation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RelationModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RelationModel input)
        {
            if (input == null) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.Value != input.Value || (this.Value != null && input.Value != null && !this.Value.SequenceEqual(input.Value))) return false;
            if (this.Relation != input.Relation) return false;

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
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.Relation.GetHashCode();
                return hashCode;
            }
        }
    }
}
