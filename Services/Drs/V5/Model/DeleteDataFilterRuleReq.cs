using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 批量删除数据过滤规则请求体对象，包含待删除的规则ID列表和数据过滤类型。
    /// </summary>
    public class DeleteDataFilterRuleReq 
    {
        /// <summary>
        /// 数据过滤条件类型，指定要删除的过滤规则所属的配置层级，取值common表示一般过滤条件，config表示高级配置过滤条件
        /// </summary>
        /// <value>数据过滤条件类型，指定要删除的过滤规则所属的配置层级，取值common表示一般过滤条件，config表示高级配置过滤条件</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum COMMON for value: common
            /// </summary>
            public static readonly TypeEnum COMMON = new TypeEnum("common");

            /// <summary>
            /// Enum CONFIG for value: config
            /// </summary>
            public static readonly TypeEnum CONFIG = new TypeEnum("config");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "common", COMMON },
                { "config", CONFIG },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 待删除的数据过滤规则ID列表，支持批量删除多个规则。对应查询接口响应中的&#x60;batch_id&#x60;字段。
        /// </summary>
        [JsonProperty("rule_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> RuleIds { get; set; }

        /// <summary>
        /// 数据过滤条件类型，指定要删除的过滤规则所属的配置层级，取值common表示一般过滤条件，config表示高级配置过滤条件
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteDataFilterRuleReq {\n");
            sb.Append("  ruleIds: ").Append(RuleIds).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteDataFilterRuleReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteDataFilterRuleReq input)
        {
            if (input == null) return false;
            if (this.RuleIds != input.RuleIds || (this.RuleIds != null && input.RuleIds != null && !this.RuleIds.SequenceEqual(input.RuleIds))) return false;
            if (this.Type != input.Type) return false;

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
                if (this.RuleIds != null) hashCode = hashCode * 59 + this.RuleIds.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
