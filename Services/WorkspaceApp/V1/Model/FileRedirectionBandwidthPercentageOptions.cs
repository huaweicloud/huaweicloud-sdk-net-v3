using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FileRedirectionBandwidthPercentageOptions 
    {

        /// <summary>
        /// 文件重定向带宽百分比控制量（%）。取值范围为[0-100]。默认：30。
        /// </summary>
        [JsonProperty("file_redirection_bandwidth_percentage_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? FileRedirectionBandwidthPercentageValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileRedirectionBandwidthPercentageOptions {\n");
            sb.Append("  fileRedirectionBandwidthPercentageValue: ").Append(FileRedirectionBandwidthPercentageValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FileRedirectionBandwidthPercentageOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FileRedirectionBandwidthPercentageOptions input)
        {
            if (input == null) return false;
            if (this.FileRedirectionBandwidthPercentageValue != input.FileRedirectionBandwidthPercentageValue || (this.FileRedirectionBandwidthPercentageValue != null && !this.FileRedirectionBandwidthPercentageValue.Equals(input.FileRedirectionBandwidthPercentageValue))) return false;

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
                if (this.FileRedirectionBandwidthPercentageValue != null) hashCode = hashCode * 59 + this.FileRedirectionBandwidthPercentageValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
