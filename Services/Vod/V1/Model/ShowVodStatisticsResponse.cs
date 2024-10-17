using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowVodStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// 统计起始时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 统计间隔。
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// 采样数据数组。从start_time开始，每个间隔对应一个采样数据。
        /// </summary>
        [JsonProperty("sample_data", NullValueHandling = NullValueHandling.Ignore)]
        public List<VodSampleData> SampleData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowVodStatisticsResponse {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("  sampleData: ").Append(SampleData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowVodStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowVodStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.Interval != input.Interval || (this.Interval != null && !this.Interval.Equals(input.Interval))) return false;
            if (this.SampleData != input.SampleData || (this.SampleData != null && input.SampleData != null && !this.SampleData.SequenceEqual(input.SampleData))) return false;

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
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Interval != null) hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.SampleData != null) hashCode = hashCode * 59 + this.SampleData.GetHashCode();
                return hashCode;
            }
        }
    }
}
