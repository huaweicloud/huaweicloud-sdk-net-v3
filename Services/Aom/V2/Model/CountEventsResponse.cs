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
    /// Response Object
    /// </summary>
    public class CountEventsResponse : SdkResponse
    {

        /// <summary>
        /// 统计步长。毫秒数，例如一分钟则填写为60000。
        /// </summary>
        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public long? Step { get; set; }

        /// <summary>
        /// 统计结果对应的时间序列。
        /// </summary>
        [JsonProperty("timestamps", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> Timestamps { get; set; }

        /// <summary>
        /// 事件或者告警不同级别相同时间序列对应的统计结果。
        /// </summary>
        [JsonProperty("series", NullValueHandling = NullValueHandling.Ignore)]
        public List<EventSeries> Series { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountEventsResponse {\n");
            sb.Append("  step: ").Append(Step).Append("\n");
            sb.Append("  timestamps: ").Append(Timestamps).Append("\n");
            sb.Append("  series: ").Append(Series).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CountEventsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CountEventsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Step == input.Step ||
                    (this.Step != null &&
                    this.Step.Equals(input.Step))
                ) && 
                (
                    this.Timestamps == input.Timestamps ||
                    this.Timestamps != null &&
                    input.Timestamps != null &&
                    this.Timestamps.SequenceEqual(input.Timestamps)
                ) && 
                (
                    this.Series == input.Series ||
                    this.Series != null &&
                    input.Series != null &&
                    this.Series.SequenceEqual(input.Series)
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
                if (this.Step != null)
                    hashCode = hashCode * 59 + this.Step.GetHashCode();
                if (this.Timestamps != null)
                    hashCode = hashCode * 59 + this.Timestamps.GetHashCode();
                if (this.Series != null)
                    hashCode = hashCode * 59 + this.Series.GetHashCode();
                return hashCode;
            }
        }
    }
}
