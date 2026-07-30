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
    public class DownloadDdlLogsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  每个日志文件的下载链接详情。  **取值范围**：  不涉及。 
        /// </summary>
        [JsonProperty("download_files", NullValueHandling = NullValueHandling.Ignore)]
        public List<DownLoadFileInfoItem> DownloadFiles { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadDdlLogsResponse {\n");
            sb.Append("  downloadFiles: ").Append(DownloadFiles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DownloadDdlLogsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DownloadDdlLogsResponse input)
        {
            if (input == null) return false;
            if (this.DownloadFiles != input.DownloadFiles || (this.DownloadFiles != null && input.DownloadFiles != null && !this.DownloadFiles.SequenceEqual(input.DownloadFiles))) return false;

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
                if (this.DownloadFiles != null) hashCode = hashCode * 59 + this.DownloadFiles.GetHashCode();
                return hashCode;
            }
        }
    }
}
