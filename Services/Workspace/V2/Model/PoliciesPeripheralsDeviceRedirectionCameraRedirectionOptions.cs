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
    /// 摄像头设备重定向控制的选项。
    /// </summary>
    public class PoliciesPeripheralsDeviceRedirectionCameraRedirectionOptions 
    {

        /// <summary>
        /// 摄像头帧率（fps）。取值范围为[1-30]。默认：15。
        /// </summary>
        [JsonProperty("camera_frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? CameraFrameRate { get; set; }

        /// <summary>
        /// 摄像头最大宽度（pixel）。取值范围为[1-9999]。默认：3000。
        /// </summary>
        [JsonProperty("camera_max_width", NullValueHandling = NullValueHandling.Ignore)]
        public int? CameraMaxWidth { get; set; }

        /// <summary>
        /// 摄像头最大高度（pixel）。取值范围为[1-9999]。默认：3000。
        /// </summary>
        [JsonProperty("camera_max_heigth", NullValueHandling = NullValueHandling.Ignore)]
        public int? CameraMaxHeigth { get; set; }

        /// <summary>
        /// 摄像头数据压缩方式。取值为：H.264。
        /// </summary>
        [JsonProperty("camera_compression_method", NullValueHandling = NullValueHandling.Ignore)]
        public string CameraCompressionMethod { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPeripheralsDeviceRedirectionCameraRedirectionOptions {\n");
            sb.Append("  cameraFrameRate: ").Append(CameraFrameRate).Append("\n");
            sb.Append("  cameraMaxWidth: ").Append(CameraMaxWidth).Append("\n");
            sb.Append("  cameraMaxHeigth: ").Append(CameraMaxHeigth).Append("\n");
            sb.Append("  cameraCompressionMethod: ").Append(CameraCompressionMethod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPeripheralsDeviceRedirectionCameraRedirectionOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPeripheralsDeviceRedirectionCameraRedirectionOptions input)
        {
            if (input == null) return false;
            if (this.CameraFrameRate != input.CameraFrameRate || (this.CameraFrameRate != null && !this.CameraFrameRate.Equals(input.CameraFrameRate))) return false;
            if (this.CameraMaxWidth != input.CameraMaxWidth || (this.CameraMaxWidth != null && !this.CameraMaxWidth.Equals(input.CameraMaxWidth))) return false;
            if (this.CameraMaxHeigth != input.CameraMaxHeigth || (this.CameraMaxHeigth != null && !this.CameraMaxHeigth.Equals(input.CameraMaxHeigth))) return false;
            if (this.CameraCompressionMethod != input.CameraCompressionMethod || (this.CameraCompressionMethod != null && !this.CameraCompressionMethod.Equals(input.CameraCompressionMethod))) return false;

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
                if (this.CameraFrameRate != null) hashCode = hashCode * 59 + this.CameraFrameRate.GetHashCode();
                if (this.CameraMaxWidth != null) hashCode = hashCode * 59 + this.CameraMaxWidth.GetHashCode();
                if (this.CameraMaxHeigth != null) hashCode = hashCode * 59 + this.CameraMaxHeigth.GetHashCode();
                if (this.CameraCompressionMethod != null) hashCode = hashCode * 59 + this.CameraCompressionMethod.GetHashCode();
                return hashCode;
            }
        }
    }
}
