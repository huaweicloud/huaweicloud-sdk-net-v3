using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowRecordingFileDownloadUrlsResponse : SdkResponse
    {

        /// <summary>
        /// 录制文件下载链接。
        /// </summary>
        [JsonProperty("recordUrls", NullValueHandling = NullValueHandling.Ignore)]
        public List<RecordDownloadInfoBO> RecordUrls { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRecordingFileDownloadUrlsResponse {\n");
            sb.Append("  recordUrls: ").Append(RecordUrls).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRecordingFileDownloadUrlsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRecordingFileDownloadUrlsResponse input)
        {
            if (input == null) return false;
            if (this.RecordUrls != input.RecordUrls || (this.RecordUrls != null && input.RecordUrls != null && !this.RecordUrls.SequenceEqual(input.RecordUrls))) return false;

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
                if (this.RecordUrls != null) hashCode = hashCode * 59 + this.RecordUrls.GetHashCode();
                return hashCode;
            }
        }
    }
}
