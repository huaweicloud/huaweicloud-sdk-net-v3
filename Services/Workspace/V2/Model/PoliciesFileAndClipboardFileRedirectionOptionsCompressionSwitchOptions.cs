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
    /// 压缩开关控制项。
    /// </summary>
    public class PoliciesFileAndClipboardFileRedirectionOptionsCompressionSwitchOptions 
    {

        /// <summary>
        /// 压缩阈值（Byte）。取值范围为[0-10240]。默认：512。
        /// </summary>
        [JsonProperty("compression_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? CompressionThreshold { get; set; }

        /// <summary>
        /// 最小压缩率。取值范围为[0-1000]。默认：900。
        /// </summary>
        [JsonProperty("minimum_compression_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimumCompressionRate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesFileAndClipboardFileRedirectionOptionsCompressionSwitchOptions {\n");
            sb.Append("  compressionThreshold: ").Append(CompressionThreshold).Append("\n");
            sb.Append("  minimumCompressionRate: ").Append(MinimumCompressionRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesFileAndClipboardFileRedirectionOptionsCompressionSwitchOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesFileAndClipboardFileRedirectionOptionsCompressionSwitchOptions input)
        {
            if (input == null) return false;
            if (this.CompressionThreshold != input.CompressionThreshold || (this.CompressionThreshold != null && !this.CompressionThreshold.Equals(input.CompressionThreshold))) return false;
            if (this.MinimumCompressionRate != input.MinimumCompressionRate || (this.MinimumCompressionRate != null && !this.MinimumCompressionRate.Equals(input.MinimumCompressionRate))) return false;

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
                if (this.CompressionThreshold != null) hashCode = hashCode * 59 + this.CompressionThreshold.GetHashCode();
                if (this.MinimumCompressionRate != null) hashCode = hashCode * 59 + this.MinimumCompressionRate.GetHashCode();
                return hashCode;
            }
        }
    }
}
