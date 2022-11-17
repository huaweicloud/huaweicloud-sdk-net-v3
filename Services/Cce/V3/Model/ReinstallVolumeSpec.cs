using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 服务器重装云硬盘配置
    /// </summary>
    public class ReinstallVolumeSpec 
    {

        /// <summary>
        /// 用户自定义镜像ID
        /// </summary>
        [JsonProperty("imageID", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ImageID { get; set; }

        /// <summary>
        /// 用户主密钥ID。默认为空时，表示云硬盘不加密。
        /// </summary>
        [JsonProperty("cmkID", NullValueHandling = NullValueHandling.Ignore)]
        public string CmkID { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReinstallVolumeSpec {\n");
            sb.Append("  imageID: ").Append(ImageID).Append("\n");
            sb.Append("  cmkID: ").Append(CmkID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReinstallVolumeSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReinstallVolumeSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageID == input.ImageID ||
                    (this.ImageID != null &&
                    this.ImageID.Equals(input.ImageID))
                ) && 
                (
                    this.CmkID == input.CmkID ||
                    (this.CmkID != null &&
                    this.CmkID.Equals(input.CmkID))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ImageID != null)
                    hashCode = hashCode * 59 + this.ImageID.GetHashCode();
                if (this.CmkID != null)
                    hashCode = hashCode * 59 + this.CmkID.GetHashCode();
                return hashCode;
            }
        }
    }
}
