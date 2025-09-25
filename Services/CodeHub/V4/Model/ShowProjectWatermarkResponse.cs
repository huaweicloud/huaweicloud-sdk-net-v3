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
    public class ShowProjectWatermarkResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 水印设置状态。 - true，开启水印。 - false，关闭水印。 
        /// </summary>
        [JsonProperty("watermark", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Watermark { get; set; }

        /// <summary>
        /// **参数解释：** 当前用户是否有权限更新水印设置。 - true，有权限更新。 - false，无权限更新。 
        /// </summary>
        [JsonProperty("can_update", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanUpdate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowProjectWatermarkResponse {\n");
            sb.Append("  watermark: ").Append(Watermark).Append("\n");
            sb.Append("  canUpdate: ").Append(CanUpdate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowProjectWatermarkResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowProjectWatermarkResponse input)
        {
            if (input == null) return false;
            if (this.Watermark != input.Watermark || (this.Watermark != null && !this.Watermark.Equals(input.Watermark))) return false;
            if (this.CanUpdate != input.CanUpdate || (this.CanUpdate != null && !this.CanUpdate.Equals(input.CanUpdate))) return false;

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
                if (this.CanUpdate != null) hashCode = hashCode * 59 + this.CanUpdate.GetHashCode();
                return hashCode;
            }
        }
    }
}
