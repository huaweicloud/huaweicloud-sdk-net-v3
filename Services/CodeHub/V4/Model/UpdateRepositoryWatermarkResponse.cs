using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateRepositoryWatermarkResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 水印开启状态。 - true，开启水印。 - false，关闭水印。 
        /// </summary>
        [JsonProperty("watermark", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Watermark { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRepositoryWatermarkResponse {\n");
            sb.Append("  watermark: ").Append(Watermark).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateRepositoryWatermarkResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateRepositoryWatermarkResponse input)
        {
            if (input == null) return false;
            if (this.Watermark != input.Watermark || (this.Watermark != null && !this.Watermark.Equals(input.Watermark))) return false;

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
                if (this.Watermark != null) hashCode = hashCode * 59 + this.Watermark.GetHashCode();
                return hashCode;
            }
        }
    }
}
