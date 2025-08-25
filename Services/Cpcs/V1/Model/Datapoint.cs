using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// 时间点的统计数据
    /// </summary>
    public class Datapoint 
    {

        /// <summary>
        /// 最大值，未计算默认为0
        /// </summary>
        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public double? Max { get; set; }

        /// <summary>
        /// 最小值，未计算默认为0
        /// </summary>
        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public double? Min { get; set; }

        /// <summary>
        /// 平均值，未计算默认为0
        /// </summary>
        [JsonProperty("average", NullValueHandling = NullValueHandling.Ignore)]
        public double? Average { get; set; }

        /// <summary>
        /// 综合，未计算默认为0
        /// </summary>
        [JsonProperty("sum", NullValueHandling = NullValueHandling.Ignore)]
        public double? Sum { get; set; }

        /// <summary>
        /// 方差，未计算默认为0
        /// </summary>
        [JsonProperty("variance", NullValueHandling = NullValueHandling.Ignore)]
        public double? Variance { get; set; }

        /// <summary>
        /// 毫秒时间戳
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// 数据单位，比如%，个
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Datapoint {\n");
            sb.Append("  max: ").Append(Max).Append("\n");
            sb.Append("  min: ").Append(Min).Append("\n");
            sb.Append("  average: ").Append(Average).Append("\n");
            sb.Append("  sum: ").Append(Sum).Append("\n");
            sb.Append("  variance: ").Append(Variance).Append("\n");
            sb.Append("  timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Datapoint);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Datapoint input)
        {
            if (input == null) return false;
            if (this.Max != input.Max || (this.Max != null && !this.Max.Equals(input.Max))) return false;
            if (this.Min != input.Min || (this.Min != null && !this.Min.Equals(input.Min))) return false;
            if (this.Average != input.Average || (this.Average != null && !this.Average.Equals(input.Average))) return false;
            if (this.Sum != input.Sum || (this.Sum != null && !this.Sum.Equals(input.Sum))) return false;
            if (this.Variance != input.Variance || (this.Variance != null && !this.Variance.Equals(input.Variance))) return false;
            if (this.Timestamp != input.Timestamp || (this.Timestamp != null && !this.Timestamp.Equals(input.Timestamp))) return false;
            if (this.Unit != input.Unit || (this.Unit != null && !this.Unit.Equals(input.Unit))) return false;

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
                if (this.Max != null) hashCode = hashCode * 59 + this.Max.GetHashCode();
                if (this.Min != null) hashCode = hashCode * 59 + this.Min.GetHashCode();
                if (this.Average != null) hashCode = hashCode * 59 + this.Average.GetHashCode();
                if (this.Sum != null) hashCode = hashCode * 59 + this.Sum.GetHashCode();
                if (this.Variance != null) hashCode = hashCode * 59 + this.Variance.GetHashCode();
                if (this.Timestamp != null) hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                return hashCode;
            }
        }
    }
}
