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
    /// 会议录制文件下载链接信息。
    /// </summary>
    public class RecordDownloadInfoBO 
    {

        /// <summary>
        /// 会议UUID。
        /// </summary>
        [JsonProperty("confUuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfUuid { get; set; }

        /// <summary>
        /// 下载链接信息。
        /// </summary>
        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<RecordDownloadUrlDO> Urls { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordDownloadInfoBO {\n");
            sb.Append("  confUuid: ").Append(ConfUuid).Append("\n");
            sb.Append("  urls: ").Append(Urls).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecordDownloadInfoBO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecordDownloadInfoBO input)
        {
            if (input == null) return false;
            if (this.ConfUuid != input.ConfUuid || (this.ConfUuid != null && !this.ConfUuid.Equals(input.ConfUuid))) return false;
            if (this.Urls != input.Urls || (this.Urls != null && input.Urls != null && !this.Urls.SequenceEqual(input.Urls))) return false;

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
                if (this.ConfUuid != null) hashCode = hashCode * 59 + this.ConfUuid.GetHashCode();
                if (this.Urls != null) hashCode = hashCode * 59 + this.Urls.GetHashCode();
                return hashCode;
            }
        }
    }
}
