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
    public class ShowExportProgressResponse : SdkResponse
    {

        /// <summary>
        /// 导出进度。
        /// </summary>
        [JsonProperty("process_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ProcessStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowExportProgressResponse {\n");
            sb.Append("  processStatus: ").Append(ProcessStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowExportProgressResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowExportProgressResponse input)
        {
            if (input == null) return false;
            if (this.ProcessStatus != input.ProcessStatus || (this.ProcessStatus != null && !this.ProcessStatus.Equals(input.ProcessStatus))) return false;

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
                if (this.ProcessStatus != null) hashCode = hashCode * 59 + this.ProcessStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
