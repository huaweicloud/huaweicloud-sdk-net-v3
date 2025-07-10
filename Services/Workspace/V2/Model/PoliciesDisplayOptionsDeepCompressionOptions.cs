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
    /// 深度压缩控制选项。
    /// </summary>
    public class PoliciesDisplayOptionsDeepCompressionOptions 
    {

        /// <summary>
        /// 深度压缩级别。取值为： 压缩级别0：Compression grade 0 压缩级别1：Compression grade 1 压缩级别2：Compression grade 2 压缩级别3：Compression grade 3 压缩级别4：Compression grade 4 压缩级别5：Compression grade 5 压缩级别6：Compression grade 6 压缩级别7：Compression grade 7 压缩级别8：Compression grade 8 压缩级别9：Compression grade 9
        /// </summary>
        [JsonProperty("deep_compression_level", NullValueHandling = NullValueHandling.Ignore)]
        public string DeepCompressionLevel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesDisplayOptionsDeepCompressionOptions {\n");
            sb.Append("  deepCompressionLevel: ").Append(DeepCompressionLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesDisplayOptionsDeepCompressionOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesDisplayOptionsDeepCompressionOptions input)
        {
            if (input == null) return false;
            if (this.DeepCompressionLevel != input.DeepCompressionLevel || (this.DeepCompressionLevel != null && !this.DeepCompressionLevel.Equals(input.DeepCompressionLevel))) return false;

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
                if (this.DeepCompressionLevel != null) hashCode = hashCode * 59 + this.DeepCompressionLevel.GetHashCode();
                return hashCode;
            }
        }
    }
}
