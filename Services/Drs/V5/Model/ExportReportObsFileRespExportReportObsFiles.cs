using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ExportReportObsFileRespExportReportObsFiles 
    {

        /// <summary>
        /// 文件名称。
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 最后修改时间。
        /// </summary>
        [JsonProperty("last_modified", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModified { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportReportObsFileRespExportReportObsFiles {\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  lastModified: ").Append(LastModified).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExportReportObsFileRespExportReportObsFiles);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExportReportObsFileRespExportReportObsFiles input)
        {
            if (input == null) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.LastModified != input.LastModified || (this.LastModified != null && !this.LastModified.Equals(input.LastModified))) return false;

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
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.LastModified != null) hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                return hashCode;
            }
        }
    }
}
