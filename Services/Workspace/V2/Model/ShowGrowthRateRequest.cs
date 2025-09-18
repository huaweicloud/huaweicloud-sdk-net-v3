using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowGrowthRateRequest 
    {
        /// <summary>
        /// 环比周期 | DAY - 天 MONTH - 月。
        /// </summary>
        /// <value>环比周期 | DAY - 天 MONTH - 月。</value>
        [JsonConverter(typeof(EnumClassConverter<GrowPeriodEnum>))]
        public class GrowPeriodEnum
        {
            /// <summary>
            /// Enum DAY for value: DAY
            /// </summary>
            public static readonly GrowPeriodEnum DAY = new GrowPeriodEnum("DAY");

            /// <summary>
            /// Enum MONTH for value: MONTH
            /// </summary>
            public static readonly GrowPeriodEnum MONTH = new GrowPeriodEnum("MONTH");

            private static readonly Dictionary<string, GrowPeriodEnum> StaticFields =
            new Dictionary<string, GrowPeriodEnum>()
            {
                { "DAY", DAY },
                { "MONTH", MONTH },
            };

            private string _value;

            public GrowPeriodEnum()
            {

            }

            public GrowPeriodEnum(string value)
            {
                _value = value;
            }

            public static GrowPeriodEnum FromValue(string value)
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

                if (this.Equals(obj as GrowPeriodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(GrowPeriodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(GrowPeriodEnum a, GrowPeriodEnum b)
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

            public static bool operator !=(GrowPeriodEnum a, GrowPeriodEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 环比周期 | DAY - 天 MONTH - 月。
        /// </summary>
        [SDKProperty("grow_period", IsQuery = true)]
        [JsonProperty("grow_period", NullValueHandling = NullValueHandling.Ignore)]
        public GrowPeriodEnum GrowPeriod { get; set; }
        /// <summary>
        /// 指标名称。
        /// </summary>
        [SDKProperty("metric_name", IsQuery = true)]
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 指标维度 | 目前最大支持3个维度，必须从0开始；维度格式为dim.{i}&#x3D;key,value，key的最大长度32，value的最大长度为256。 单维度：dim.0&#x3D;instance_id,6f3c6f91-4b24-4e1b-b7d1-a94ac1cb011d 多维度：dim.0&#x3D;key,value&amp;dim.1&#x3D;key,value。
        /// </summary>
        [SDKProperty("dim", IsQuery = true)]
        [JsonProperty("dim", NullValueHandling = NullValueHandling.Ignore)]
        public string Dim { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGrowthRateRequest {\n");
            sb.Append("  growPeriod: ").Append(GrowPeriod).Append("\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  dim: ").Append(Dim).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGrowthRateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGrowthRateRequest input)
        {
            if (input == null) return false;
            if (this.GrowPeriod != input.GrowPeriod) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;
            if (this.Dim != input.Dim || (this.Dim != null && !this.Dim.Equals(input.Dim))) return false;

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
                hashCode = hashCode * 59 + this.GrowPeriod.GetHashCode();
                if (this.MetricName != null) hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.Dim != null) hashCode = hashCode * 59 + this.Dim.GetHashCode();
                return hashCode;
            }
        }
    }
}
