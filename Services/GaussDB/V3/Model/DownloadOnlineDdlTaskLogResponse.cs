using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DownloadOnlineDdlTaskLogResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  下载实例无锁变更任务日志的链接。  **取值范围**：   不涉及。
        /// </summary>
        [JsonProperty("download_link", NullValueHandling = NullValueHandling.Ignore)]
        public string DownloadLink { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadOnlineDdlTaskLogResponse {\n");
            sb.Append("  downloadLink: ").Append(DownloadLink).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DownloadOnlineDdlTaskLogResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DownloadOnlineDdlTaskLogResponse input)
        {
            if (input == null) return false;
            if (this.DownloadLink != input.DownloadLink || (this.DownloadLink != null && !this.DownloadLink.Equals(input.DownloadLink))) return false;

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
                if (this.DownloadLink != null) hashCode = hashCode * 59 + this.DownloadLink.GetHashCode();
                return hashCode;
            }
        }
    }
}
