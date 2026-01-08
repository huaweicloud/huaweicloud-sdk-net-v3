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
    /// Response Object
    /// </summary>
    public class CheckDesktopImagesResponse : SdkResponse
    {

        /// <summary>
        /// 桌面镜像信息。
        /// </summary>
        [JsonProperty("image_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<DesktopImageInfo> ImageInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckDesktopImagesResponse {\n");
            sb.Append("  imageInfos: ").Append(ImageInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckDesktopImagesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckDesktopImagesResponse input)
        {
            if (input == null) return false;
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
                if (this.ImageInfos != null) hashCode = hashCode * 59 + this.ImageInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
