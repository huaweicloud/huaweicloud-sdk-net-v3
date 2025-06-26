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
    /// 摄像头重定向。
    /// </summary>
    public class PoliciesPeripheralsDeviceRedirectionCameraRedirection 
    {

        /// <summary>
        /// 是否开启摄像头设备重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("video_compress_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VideoCompressEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public CameraRedirectionOptions Options { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPeripheralsDeviceRedirectionCameraRedirection {\n");
            sb.Append("  videoCompressEnable: ").Append(VideoCompressEnable).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPeripheralsDeviceRedirectionCameraRedirection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPeripheralsDeviceRedirectionCameraRedirection input)
        {
            if (input == null) return false;
            if (this.VideoCompressEnable != input.VideoCompressEnable || (this.VideoCompressEnable != null && !this.VideoCompressEnable.Equals(input.VideoCompressEnable))) return false;
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
                if (this.VideoCompressEnable != null) hashCode = hashCode * 59 + this.VideoCompressEnable.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }
}
