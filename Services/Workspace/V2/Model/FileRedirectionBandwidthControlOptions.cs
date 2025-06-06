using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FileRedirectionBandwidthControlOptions 
    {

        /// <summary>
        /// 文件重定向带宽控制量（Kbps）。取值范围为[500-20000]。默认：10000。
        /// </summary>
        [JsonProperty("file_redirection_bandwidth_control_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? FileRedirectionBandwidthControlValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileRedirectionBandwidthControlOptions {\n");
            sb.Append("  fileRedirectionBandwidthControlValue: ").Append(FileRedirectionBandwidthControlValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FileRedirectionBandwidthControlOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FileRedirectionBandwidthControlOptions input)
        {
            if (input == null) return false;
            if (this.FileRedirectionBandwidthControlValue != input.FileRedirectionBandwidthControlValue || (this.FileRedirectionBandwidthControlValue != null && !this.FileRedirectionBandwidthControlValue.Equals(input.FileRedirectionBandwidthControlValue))) return false;

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
                if (this.FileRedirectionBandwidthControlValue != null) hashCode = hashCode * 59 + this.FileRedirectionBandwidthControlValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
