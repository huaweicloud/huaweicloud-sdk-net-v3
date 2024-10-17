using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListTranscodeDataResponse : SdkResponse
    {

        /// <summary>
        /// 采样数据列表。
        /// </summary>
        [JsonProperty("transcode_data_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TranscodeData> TranscodeDataList { get; set; }

        /// <summary>
        /// 指定时间区间内各转码规格转码时长总和。
        /// </summary>
        [JsonProperty("summary_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TranscodeSummary> SummaryList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTranscodeDataResponse {\n");
            sb.Append("  transcodeDataList: ").Append(TranscodeDataList).Append("\n");
            sb.Append("  summaryList: ").Append(SummaryList).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTranscodeDataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTranscodeDataResponse input)
        {
            if (input == null) return false;
            if (this.TranscodeDataList != input.TranscodeDataList || (this.TranscodeDataList != null && input.TranscodeDataList != null && !this.TranscodeDataList.SequenceEqual(input.TranscodeDataList))) return false;
            if (this.SummaryList != input.SummaryList || (this.SummaryList != null && input.SummaryList != null && !this.SummaryList.SequenceEqual(input.SummaryList))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.TranscodeDataList != null) hashCode = hashCode * 59 + this.TranscodeDataList.GetHashCode();
                if (this.SummaryList != null) hashCode = hashCode * 59 + this.SummaryList.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
