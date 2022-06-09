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
    /// Request Object
    /// </summary>
    public class ListStatisticsRequest 
    {
        /// <summary>
        /// 参数过滤器。
        /// </summary>
        /// <value>参数过滤器。</value>
        [JsonConverter(typeof(EnumClassConverter<FilterEnum>))]
        public class FilterEnum
        {
            /// <summary>
            /// Enum MONITOR_DATA for value: monitor_data
            /// </summary>
            public static readonly FilterEnum MONITOR_DATA = new FilterEnum("monitor_data");

            /// <summary>
            /// Enum MONTHLY_REPORT for value: monthly_report
            /// </summary>
            public static readonly FilterEnum MONTHLY_REPORT = new FilterEnum("monthly_report");

            private static readonly Dictionary<string, FilterEnum> StaticFields =
            new Dictionary<string, FilterEnum>()
            {
                { "monitor_data", MONITOR_DATA },
                { "monthly_report", MONTHLY_REPORT },
            };

            private string Value;

            public FilterEnum(string value)
            {
                Value = value;
            }

            public static FilterEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as FilterEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FilterEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(FilterEnum a, FilterEnum b)
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

            public static bool operator !=(FilterEnum a, FilterEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 月度统计的维度，filter参数取值为monthly_report时才生效。 - \&quot;0\&quot;:表示统计本月。 - \&quot;1\&quot;:表示统计上月。 - \&quot;2\&quot;:表示统计最近三个月。 - \&quot;3\&quot;:表示统计最近六个月。 - 当取值不在以上范围时，默认取\&quot;0”。
        /// </summary>
        /// <value>月度统计的维度，filter参数取值为monthly_report时才生效。 - \&quot;0\&quot;:表示统计本月。 - \&quot;1\&quot;:表示统计上月。 - \&quot;2\&quot;:表示统计最近三个月。 - \&quot;3\&quot;:表示统计最近六个月。 - 当取值不在以上范围时，默认取\&quot;0”。</value>
        [JsonConverter(typeof(EnumClassConverter<OptionEnum>))]
        public class OptionEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly OptionEnum _0 = new OptionEnum("0");

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly OptionEnum _1 = new OptionEnum("1");

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            public static readonly OptionEnum _2 = new OptionEnum("2");

            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            public static readonly OptionEnum _3 = new OptionEnum("3");

            private static readonly Dictionary<string, OptionEnum> StaticFields =
            new Dictionary<string, OptionEnum>()
            {
                { "0", _0 },
                { "1", _1 },
                { "2", _2 },
                { "3", _3 },
            };

            private string Value;

            public OptionEnum(string value)
            {
                Value = value;
            }

            public static OptionEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as OptionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OptionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OptionEnum a, OptionEnum b)
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

            public static bool operator !=(OptionEnum a, OptionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 参数过滤器。
        /// </summary>
        [SDKProperty("filter", IsQuery = true)]
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public FilterEnum Filter { get; set; }
        /// <summary>
        /// 时间段单位为分钟，与filter参数配合使用。
        /// </summary>
        [SDKProperty("period", IsQuery = true)]
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 月度统计的维度，filter参数取值为monthly_report时才生效。 - \&quot;0\&quot;:表示统计本月。 - \&quot;1\&quot;:表示统计上月。 - \&quot;2\&quot;:表示统计最近三个月。 - \&quot;3\&quot;:表示统计最近六个月。 - 当取值不在以上范围时，默认取\&quot;0”。
        /// </summary>
        [SDKProperty("option", IsQuery = true)]
        [JsonProperty("option", NullValueHandling = NullValueHandling.Ignore)]
        public OptionEnum Option { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStatisticsRequest {\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  option: ").Append(Option).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStatisticsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStatisticsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.Option == input.Option ||
                    (this.Option != null &&
                    this.Option.Equals(input.Option))
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
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Option != null)
                    hashCode = hashCode * 59 + this.Option.GetHashCode();
                return hashCode;
            }
        }
    }
}
