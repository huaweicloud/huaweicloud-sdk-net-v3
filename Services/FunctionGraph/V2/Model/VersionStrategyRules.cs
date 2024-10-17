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
    /// 
    /// </summary>
    public class VersionStrategyRules 
    {
        /// <summary>
        /// 参数类型。
        /// </summary>
        /// <value>参数类型。</value>
        [JsonConverter(typeof(EnumClassConverter<RuleTypeEnum>))]
        public class RuleTypeEnum
        {
            /// <summary>
            /// Enum HEADER for value: header
            /// </summary>
            public static readonly RuleTypeEnum HEADER = new RuleTypeEnum("header");

            /// <summary>
            /// Enum COOKIE for value: cookie
            /// </summary>
            public static readonly RuleTypeEnum COOKIE = new RuleTypeEnum("cookie");

            private static readonly Dictionary<string, RuleTypeEnum> StaticFields =
            new Dictionary<string, RuleTypeEnum>()
            {
                { "header", HEADER },
                { "cookie", COOKIE },
            };

            private string _value;

            public RuleTypeEnum()
            {

            }

            public RuleTypeEnum(string value)
            {
                _value = value;
            }

            public static RuleTypeEnum FromValue(string value)
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

                if (this.Equals(obj as RuleTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RuleTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RuleTypeEnum a, RuleTypeEnum b)
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

            public static bool operator !=(RuleTypeEnum a, RuleTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 规则匹配操作符，目前仅需支持 &#x3D; 或者in。
        /// </summary>
        /// <value>规则匹配操作符，目前仅需支持 &#x3D; 或者in。</value>
        [JsonConverter(typeof(EnumClassConverter<OpEnum>))]
        public class OpEnum
        {
            /// <summary>
            /// Enum IN for value: in
            /// </summary>
            public static readonly OpEnum IN = new OpEnum("in");

            /// <summary>
            /// Enum Equal for value: =
            /// </summary>
            public static readonly OpEnum Equal = new OpEnum("=");

            private static readonly Dictionary<string, OpEnum> StaticFields =
            new Dictionary<string, OpEnum>()
            {
                { "in", IN },
                { "=", Equal },
            };

            private string _value;

            public OpEnum()
            {

            }

            public OpEnum(string value)
            {
                _value = value;
            }

            public static OpEnum FromValue(string value)
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

                if (this.Equals(obj as OpEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OpEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OpEnum a, OpEnum b)
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

            public static bool operator !=(OpEnum a, OpEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 参数类型。
        /// </summary>
        [JsonProperty("rule_type", NullValueHandling = NullValueHandling.Ignore)]
        public RuleTypeEnum RuleType { get; set; }
        /// <summary>
        /// 规则参数名, 只支持大小写字母，数字，下划线，中划线。
        /// </summary>
        [JsonProperty("param", NullValueHandling = NullValueHandling.Ignore)]
        public string Param { get; set; }

        /// <summary>
        /// 规则匹配操作符，目前仅需支持 &#x3D; 或者in。
        /// </summary>
        [JsonProperty("op", NullValueHandling = NullValueHandling.Ignore)]
        public OpEnum Op { get; set; }
        /// <summary>
        /// 规则值，如果op为in，则为逗号分隔的多值字符串
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VersionStrategyRules {\n");
            sb.Append("  ruleType: ").Append(RuleType).Append("\n");
            sb.Append("  param: ").Append(Param).Append("\n");
            sb.Append("  op: ").Append(Op).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VersionStrategyRules);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VersionStrategyRules input)
        {
            if (input == null) return false;
            if (this.RuleType != input.RuleType) return false;
            if (this.Param != input.Param || (this.Param != null && !this.Param.Equals(input.Param))) return false;
            if (this.Op != input.Op) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;

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
                hashCode = hashCode * 59 + this.RuleType.GetHashCode();
                if (this.Param != null) hashCode = hashCode * 59 + this.Param.GetHashCode();
                hashCode = hashCode * 59 + this.Op.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
