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
    public class ShowVodRetrievalResponse : SdkResponse
    {

        /// <summary>
        /// 统计起始时间 
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 采样时间间隔 
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sample_data", NullValueHandling = NullValueHandling.Ignore)]
        public List<VodRetrievalData> SampleData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowVodRetrievalResponse {\n");
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
            return this.Equals(input as ShowVodRetrievalResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowVodRetrievalResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.SampleData == input.SampleData ||
                    this.SampleData != null &&
                    input.SampleData != null &&
                    this.SampleData.SequenceEqual(input.SampleData)
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Interval != null)
                    hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.SampleData != null)
                    hashCode = hashCode * 59 + this.SampleData.GetHashCode();
                return hashCode;
            }
        }
    }
}
