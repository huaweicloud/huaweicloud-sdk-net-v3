using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 灰度策略信息
    /// </summary>
    public class VersionStrategy 
    {
        /// <summary>
        /// 所有规则聚合方式。and：所有规则都满足，or：满足其中一个
        /// </summary>
        /// <value>所有规则聚合方式。and：所有规则都满足，or：满足其中一个</value>
        [JsonConverter(typeof(EnumClassConverter<CombineTypeEnum>))]
        public class CombineTypeEnum
        {
            /// <summary>
            /// Enum AND for value: and
            /// </summary>
            public static readonly CombineTypeEnum AND = new CombineTypeEnum("and");

            /// <summary>
            /// Enum OR for value: or
            /// </summary>
            public static readonly CombineTypeEnum OR = new CombineTypeEnum("or");

            private static readonly Dictionary<string, CombineTypeEnum> StaticFields =
            new Dictionary<string, CombineTypeEnum>()
            {
                { "and", AND },
                { "or", OR },
            };

            private string _value;

            public CombineTypeEnum()
            {

            }

            public CombineTypeEnum(string value)
            {
                _value = value;
            }

            public static CombineTypeEnum FromValue(string value)
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

                if (this.Equals(obj as CombineTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CombineTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CombineTypeEnum a, CombineTypeEnum b)
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

            public static bool operator !=(CombineTypeEnum a, CombineTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 规则列表
        /// </summary>
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<VersionStrategyRules> Rules { get; set; }

        /// <summary>
        /// 所有规则聚合方式。and：所有规则都满足，or：满足其中一个
        /// </summary>
        [JsonProperty("combine_type", NullValueHandling = NullValueHandling.Ignore)]
        public CombineTypeEnum CombineType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VersionStrategy {\n");
            sb.Append("  rules: ").Append(Rules).Append("\n");
            sb.Append("  combineType: ").Append(CombineType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VersionStrategy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VersionStrategy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rules == input.Rules ||
                    this.Rules != null &&
                    input.Rules != null &&
                    this.Rules.SequenceEqual(input.Rules)
                ) && 
                (
                    this.CombineType == input.CombineType ||
                    (this.CombineType != null &&
                    this.CombineType.Equals(input.CombineType))
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
                if (this.Rules != null)
                    hashCode = hashCode * 59 + this.Rules.GetHashCode();
                if (this.CombineType != null)
                    hashCode = hashCode * 59 + this.CombineType.GetHashCode();
                return hashCode;
            }
        }
    }
}
