using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 引擎具体信息。
    /// </summary>
    public class ListEnginesImageInfo 
    {

        /// <summary>
        /// cpu规格下对应镜像。
        /// </summary>
        [JsonProperty("cpu_image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CpuImageUrl { get; set; }

        /// <summary>
        /// gpu[或者Ascend](tag:hc,hk,fcs_super)规格下对应镜像。
        /// </summary>
        [JsonProperty("gpu_image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GpuImageUrl { get; set; }

        /// <summary>
        /// 镜像版本。
        /// </summary>
        [JsonProperty("image_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEnginesImageInfo {\n");
            sb.Append("  cpuImageUrl: ").Append(CpuImageUrl).Append("\n");
            sb.Append("  gpuImageUrl: ").Append(GpuImageUrl).Append("\n");
            sb.Append("  imageVersion: ").Append(ImageVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEnginesImageInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEnginesImageInfo input)
        {
            if (input == null) return false;
            if (this.CpuImageUrl != input.CpuImageUrl || (this.CpuImageUrl != null && !this.CpuImageUrl.Equals(input.CpuImageUrl))) return false;
            if (this.GpuImageUrl != input.GpuImageUrl || (this.GpuImageUrl != null && !this.GpuImageUrl.Equals(input.GpuImageUrl))) return false;
            if (this.ImageVersion != input.ImageVersion || (this.ImageVersion != null && !this.ImageVersion.Equals(input.ImageVersion))) return false;

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
                if (this.CpuImageUrl != null) hashCode = hashCode * 59 + this.CpuImageUrl.GetHashCode();
                if (this.GpuImageUrl != null) hashCode = hashCode * 59 + this.GpuImageUrl.GetHashCode();
                if (this.ImageVersion != null) hashCode = hashCode * 59 + this.ImageVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
