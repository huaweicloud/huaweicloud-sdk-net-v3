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
    /// 数据过滤数条件信息体
    /// </summary>
    public class DataFilteringCondition 
    {
        /// <summary>
        /// 过滤条件类型  contentConditionalFilter: 简单条件过滤 configConditionalFilter: 关联表过滤
        /// </summary>
        /// <value>过滤条件类型  contentConditionalFilter: 简单条件过滤 configConditionalFilter: 关联表过滤</value>
        [JsonConverter(typeof(EnumClassConverter<FilteringTypeEnum>))]
        public class FilteringTypeEnum
        {
            /// <summary>
            /// Enum CONTENTCONDITIONALFILTER for value: contentConditionalFilter
            /// </summary>
            public static readonly FilteringTypeEnum CONTENTCONDITIONALFILTER = new FilteringTypeEnum("contentConditionalFilter");

            /// <summary>
            /// Enum _CONFIGCONDITIONALFILTER for value:  configConditionalFilter
            /// </summary>
            public static readonly FilteringTypeEnum _CONFIGCONDITIONALFILTER = new FilteringTypeEnum(" configConditionalFilter");

            private static readonly Dictionary<string, FilteringTypeEnum> StaticFields =
            new Dictionary<string, FilteringTypeEnum>()
            {
                { "contentConditionalFilter", CONTENTCONDITIONALFILTER },
                { " configConditionalFilter", _CONFIGCONDITIONALFILTER },
            };

            private string _value;

            public FilteringTypeEnum()
            {

            }

            public FilteringTypeEnum(string value)
            {
                _value = value;
            }

            public static FilteringTypeEnum FromValue(string value)
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

                if (this.Equals(obj as FilteringTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FilteringTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FilteringTypeEnum a, FilteringTypeEnum b)
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

            public static bool operator !=(FilteringTypeEnum a, FilteringTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 过滤条件 当filtering_type是configConditionalFilter时， value默认填写config 当filtering_type是contentConditionalFilter时， value默认填写过滤条件  注意： 每张表仅支持添加一个校验规则。 数据过滤每次最多支持500张表。 过滤表达式不支持使用某种数据库引擎特有的package、函数、变量、常量等写法，须使用通用SQL标准。请直接输入SQL语句中WHERE之后的部分（不包含WHERE和分号，例如：sid &gt; 3 and sname like \&quot;G %\&quot;），最多支持输入512个字符。 过滤条件填写的SQL语句中，关键字需要用反引号，datatime类型（包含日期和时间）需要用单引号，例如：update &gt; &#39;2022-07-13 00:00:00&#39; and age &gt;10。 不支持对LOB字段设置过滤条件，如CLOB、BLOB、BYTEA等大字段类型。 不支持库名、表名带有换行符的对象设置过滤规则。 建议不要对非精确类型字段设置过滤条件，如FLOAT、DECIMAL、DOUBLE等。 建议不要对带有特殊字符的字段设置过滤条件。 不建议使用非幂等表达式或函数作为数据加工条件，如SYSTIMESTAMP，SYSDATE等，因其每次调用返回的结果可能会有差异，导致达不到预期。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 过滤条件类型  contentConditionalFilter: 简单条件过滤 configConditionalFilter: 关联表过滤
        /// </summary>
        [JsonProperty("filtering_type", NullValueHandling = NullValueHandling.Ignore)]
        public FilteringTypeEnum FilteringType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataFilteringCondition {\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  filteringType: ").Append(FilteringType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataFilteringCondition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DataFilteringCondition input)
        {
            if (input == null) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.FilteringType != input.FilteringType) return false;

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
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.FilteringType.GetHashCode();
                return hashCode;
            }
        }
    }
}
