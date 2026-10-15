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
    /// 导出文件OBS临时URI对象
    /// </summary>
    public class ExportReportObsTmpFileUrlResp 
    {

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// OBS文件临时URI
        /// </summary>
        [JsonProperty("obs_temp_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsTempUri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportReportObsTmpFileUrlResp {\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  obsTempUri: ").Append(ObsTempUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExportReportObsTmpFileUrlResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExportReportObsTmpFileUrlResp input)
        {
            if (input == null) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.ObsTempUri != input.ObsTempUri || (this.ObsTempUri != null && !this.ObsTempUri.Equals(input.ObsTempUri))) return false;

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
                if (this.ObsTempUri != null) hashCode = hashCode * 59 + this.ObsTempUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
