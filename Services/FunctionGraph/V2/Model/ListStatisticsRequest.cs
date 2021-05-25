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
            /// Enum MONTHLY_STATISTICS for value: monthly_statistics
            /// </summary>
            public static readonly FilterEnum MONTHLY_STATISTICS = new FilterEnum("monthly_statistics");

            /// <summary>
            /// Enum METRIC for value: metric
            /// </summary>
            public static readonly FilterEnum METRIC = new FilterEnum("metric");

            private static readonly Dictionary<string, FilterEnum> StaticFields =
            new Dictionary<string, FilterEnum>()
            {
                { "monthly_statistics", MONTHLY_STATISTICS },
                { "metric", METRIC },
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
        /// 月度统计的维度，与filter参数monthly_statistics配合使用。 \&quot;0\&quot;:本月月度统计。 \&quot;1\&quot;:上月月度统计。 \&quot;2\&quot;:最近三个月月度统计。 \&quot;3\&quot;:最近六个月月度计。 取值超出范围时默认取\&quot;0”
        /// </summary>
        /// <value>月度统计的维度，与filter参数monthly_statistics配合使用。 \&quot;0\&quot;:本月月度统计。 \&quot;1\&quot;:上月月度统计。 \&quot;2\&quot;:最近三个月月度统计。 \&quot;3\&quot;:最近六个月月度计。 取值超出范围时默认取\&quot;0”</value>
        [JsonConverter(typeof(EnumClassConverter<MonthCodeEnum>))]
        public class MonthCodeEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly MonthCodeEnum _0 = new MonthCodeEnum("0");

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly MonthCodeEnum _1 = new MonthCodeEnum("1");

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            public static readonly MonthCodeEnum _2 = new MonthCodeEnum("2");

            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            public static readonly MonthCodeEnum _3 = new MonthCodeEnum("3");

            private static readonly Dictionary<string, MonthCodeEnum> StaticFields =
            new Dictionary<string, MonthCodeEnum>()
            {
                { "0", _0 },
                { "1", _1 },
                { "2", _2 },
                { "3", _3 },
            };

            private string Value;

            public MonthCodeEnum(string value)
            {
                Value = value;
            }

            public static MonthCodeEnum FromValue(string value)
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

                if (this.Equals(obj as MonthCodeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MonthCodeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(MonthCodeEnum a, MonthCodeEnum b)
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

            public static bool operator !=(MonthCodeEnum a, MonthCodeEnum b)
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
        /// 时间段单位为分钟，与filter参数metric配合使用。
        /// </summary>
        [SDKProperty("period", IsQuery = true)]
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 月度统计的维度，与filter参数monthly_statistics配合使用。 \&quot;0\&quot;:本月月度统计。 \&quot;1\&quot;:上月月度统计。 \&quot;2\&quot;:最近三个月月度统计。 \&quot;3\&quot;:最近六个月月度计。 取值超出范围时默认取\&quot;0”
        /// </summary>
        [SDKProperty("month_code", IsQuery = true)]
        [JsonProperty("month_code", NullValueHandling = NullValueHandling.Ignore)]
        public MonthCodeEnum MonthCode { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStatisticsRequest {\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  monthCode: ").Append(MonthCode).Append("\n");
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
                    this.MonthCode == input.MonthCode ||
                    (this.MonthCode != null &&
                    this.MonthCode.Equals(input.MonthCode))
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
                if (this.MonthCode != null)
                    hashCode = hashCode * 59 + this.MonthCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
