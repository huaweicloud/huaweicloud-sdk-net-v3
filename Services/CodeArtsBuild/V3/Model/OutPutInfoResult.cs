using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 结果
    /// </summary>
    public class OutPutInfoResult 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("package_info", NullValueHandling = NullValueHandling.Ignore)]
        public OutPutResult PackageInfo { get; set; }

        /// <summary>
        /// 二方包信息
        /// </summary>
        [JsonProperty("package_infos", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, OutPutResult> PackageInfos { get; set; }

        /// <summary>
        /// 镜像包信息
        /// </summary>
        [JsonProperty("image_infos", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, OutPutResult> ImageInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutPutInfoResult {\n");
            sb.Append("  packageInfo: ").Append(PackageInfo).Append("\n");
            sb.Append("  packageInfos: ").Append(PackageInfos).Append("\n");
            sb.Append("  imageInfos: ").Append(ImageInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OutPutInfoResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OutPutInfoResult input)
        {
            if (input == null) return false;
            if (this.PackageInfo != input.PackageInfo || (this.PackageInfo != null && !this.PackageInfo.Equals(input.PackageInfo))) return false;
            if (this.PackageInfos != input.PackageInfos || (this.PackageInfos != null && input.PackageInfos != null && !this.PackageInfos.SequenceEqual(input.PackageInfos))) return false;
            if (this.ImageInfos != input.ImageInfos || (this.ImageInfos != null && input.ImageInfos != null && !this.ImageInfos.SequenceEqual(input.ImageInfos))) return false;

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
                if (this.PackageInfo != null) hashCode = hashCode * 59 + this.PackageInfo.GetHashCode();
                if (this.PackageInfos != null) hashCode = hashCode * 59 + this.PackageInfos.GetHashCode();
                if (this.ImageInfos != null) hashCode = hashCode * 59 + this.ImageInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
