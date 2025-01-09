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
    public class Watermark 
    {

        /// <summary>
        /// 是否开启水印策略设置。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("watermark_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WatermarkEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public WatermarkOptions Options { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Watermark {\n");
            sb.Append("  watermarkEnable: ").Append(WatermarkEnable).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Watermark);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Watermark input)
        {
            if (input == null) return false;
            if (this.WatermarkEnable != input.WatermarkEnable || (this.WatermarkEnable != null && !this.WatermarkEnable.Equals(input.WatermarkEnable))) return false;
            if (this.Options != input.Options || (this.Options != null && !this.Options.Equals(input.Options))) return false;

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
                if (this.WatermarkEnable != null) hashCode = hashCode * 59 + this.WatermarkEnable.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }
}
