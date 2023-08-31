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
    public class DimensionInfo 
    {
        /// <summary>
        /// 资源类型, all_instances: 全部资源, specific_instances: 指定资源
        /// </summary>
        /// <value>资源类型, all_instances: 全部资源, specific_instances: 指定资源</value>
        [JsonConverter(typeof(EnumClassConverter<FilterTypeEnum>))]
        public class FilterTypeEnum
        {
            /// <summary>
            /// Enum ALL_INSTANCES for value: all_instances
            /// </summary>
            public static readonly FilterTypeEnum ALL_INSTANCES = new FilterTypeEnum("all_instances");

            /// <summary>
            /// Enum SPECIFIC_INSTANCES for value: specific_instances
            /// </summary>
            public static readonly FilterTypeEnum SPECIFIC_INSTANCES = new FilterTypeEnum("specific_instances");

            private static readonly Dictionary<string, FilterTypeEnum> StaticFields =
            new Dictionary<string, FilterTypeEnum>()
            {
                { "all_instances", ALL_INSTANCES },
                { "specific_instances", SPECIFIC_INSTANCES },
            };

            private string _value;

            public FilterTypeEnum()
            {

            }

            public FilterTypeEnum(string value)
            {
                _value = value;
            }

            public static FilterTypeEnum FromValue(string value)
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

                if (this.Equals(obj as FilterTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FilterTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FilterTypeEnum a, FilterTypeEnum b)
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

            public static bool operator !=(FilterTypeEnum a, FilterTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 维度名称，多维度用逗号分隔，各服务支持的维度可参考：“[服务维度名称](https://support.huaweicloud.com/usermanual-ces/zh-cn_topic_0202622212.html)”
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 资源类型, all_instances: 全部资源, specific_instances: 指定资源
        /// </summary>
        [JsonProperty("filter_type", NullValueHandling = NullValueHandling.Ignore)]
        public FilterTypeEnum FilterType { get; set; }
        /// <summary>
        /// 维度值列表
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Values { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DimensionInfo {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  filterType: ").Append(FilterType).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DimensionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DimensionInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FilterType == input.FilterType ||
                    (this.FilterType != null &&
                    this.FilterType.Equals(input.FilterType))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FilterType != null)
                    hashCode = hashCode * 59 + this.FilterType.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                return hashCode;
            }
        }
    }
}
