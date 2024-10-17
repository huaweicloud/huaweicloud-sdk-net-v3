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
    /// 查询结果详细。
    /// </summary>
    public class SampleDataValue 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sample", NullValueHandling = NullValueHandling.Ignore)]
        public QuerySample Sample { get; set; }

        /// <summary>
        /// 时序数据。
        /// </summary>
        [JsonProperty("data_points", NullValueHandling = NullValueHandling.Ignore)]
        public List<MetricDataPoints> DataPoints { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SampleDataValue {\n");
            sb.Append("  sample: ").Append(Sample).Append("\n");
            sb.Append("  dataPoints: ").Append(DataPoints).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SampleDataValue);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SampleDataValue input)
        {
            if (input == null) return false;
            if (this.Sample != input.Sample || (this.Sample != null && !this.Sample.Equals(input.Sample))) return false;
            if (this.DataPoints != input.DataPoints || (this.DataPoints != null && input.DataPoints != null && !this.DataPoints.SequenceEqual(input.DataPoints))) return false;

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
                if (this.Sample != null) hashCode = hashCode * 59 + this.Sample.GetHashCode();
                if (this.DataPoints != null) hashCode = hashCode * 59 + this.DataPoints.GetHashCode();
                return hashCode;
            }
        }
    }
}
