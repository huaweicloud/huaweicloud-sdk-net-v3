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
    /// Response Object
    /// </summary>
    public class ListTemplatesResponse : SdkResponse
    {

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 文件列表。
        /// </summary>
        [JsonProperty("export_report_obs_files", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExportReportObsFileRespExportReportObsFiles> ExportReportObsFiles { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTemplatesResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  exportReportObsFiles: ").Append(ExportReportObsFiles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTemplatesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTemplatesResponse input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.ExportReportObsFiles != input.ExportReportObsFiles || (this.ExportReportObsFiles != null && input.ExportReportObsFiles != null && !this.ExportReportObsFiles.SequenceEqual(input.ExportReportObsFiles))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.ExportReportObsFiles != null) hashCode = hashCode * 59 + this.ExportReportObsFiles.GetHashCode();
                return hashCode;
            }
        }
    }
}
