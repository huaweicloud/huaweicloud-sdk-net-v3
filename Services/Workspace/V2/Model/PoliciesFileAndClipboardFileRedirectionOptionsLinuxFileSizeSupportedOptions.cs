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
    /// Linux支持设置文件大小控制项。
    /// </summary>
    public class PoliciesFileAndClipboardFileRedirectionOptionsLinuxFileSizeSupportedOptions 
    {

        /// <summary>
        /// Linux设置文件大小阈值（Byte）。取值范围为[0-4096]。默认：100。
        /// </summary>
        [JsonProperty("linux_file_size_supported_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? LinuxFileSizeSupportedThreshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesFileAndClipboardFileRedirectionOptionsLinuxFileSizeSupportedOptions {\n");
            sb.Append("  linuxFileSizeSupportedThreshold: ").Append(LinuxFileSizeSupportedThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesFileAndClipboardFileRedirectionOptionsLinuxFileSizeSupportedOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesFileAndClipboardFileRedirectionOptionsLinuxFileSizeSupportedOptions input)
        {
            if (input == null) return false;
            if (this.LinuxFileSizeSupportedThreshold != input.LinuxFileSizeSupportedThreshold || (this.LinuxFileSizeSupportedThreshold != null && !this.LinuxFileSizeSupportedThreshold.Equals(input.LinuxFileSizeSupportedThreshold))) return false;

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
                if (this.LinuxFileSizeSupportedThreshold != null) hashCode = hashCode * 59 + this.LinuxFileSizeSupportedThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
