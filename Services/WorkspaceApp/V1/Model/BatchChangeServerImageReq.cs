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
    /// 批量修改服务器镜像的请求体。
    /// </summary>
    public class BatchChangeServerImageReq 
    {

        /// <summary>
        /// 应用服务器id集合。
        /// </summary>
        [JsonProperty("server_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ServerIds { get; set; }

        /// <summary>
        /// 镜像id，要求与服务器原有镜像id不相同。
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image_type", NullValueHandling = NullValueHandling.Ignore)]
        public ImageTypeEnum ImageType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public OsTypeEnum OsType { get; set; }
        /// <summary>
        /// 镜像的产品id，当镜像是市场镜像时候，该字段必传。
        /// </summary>
        [JsonProperty("image_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageProductId { get; set; }

        /// <summary>
        /// 是否自动升级hda版本。
        /// </summary>
        [JsonProperty("update_access_agent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpdateAccessAgent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchChangeServerImageReq {\n");
            sb.Append("  serverIds: ").Append(ServerIds).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  imageProductId: ").Append(ImageProductId).Append("\n");
            sb.Append("  updateAccessAgent: ").Append(UpdateAccessAgent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchChangeServerImageReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchChangeServerImageReq input)
        {
            if (input == null) return false;
            if (this.ServerIds != input.ServerIds || (this.ServerIds != null && input.ServerIds != null && !this.ServerIds.SequenceEqual(input.ServerIds))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.ImageType != input.ImageType) return false;
            if (this.OsType != input.OsType) return false;
            if (this.ImageProductId != input.ImageProductId || (this.ImageProductId != null && !this.ImageProductId.Equals(input.ImageProductId))) return false;
            if (this.UpdateAccessAgent != input.UpdateAccessAgent || (this.UpdateAccessAgent != null && !this.UpdateAccessAgent.Equals(input.UpdateAccessAgent))) return false;

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
                if (this.ServerIds != null) hashCode = hashCode * 59 + this.ServerIds.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.ImageProductId != null) hashCode = hashCode * 59 + this.ImageProductId.GetHashCode();
                if (this.UpdateAccessAgent != null) hashCode = hashCode * 59 + this.UpdateAccessAgent.GetHashCode();
                return hashCode;
            }
        }
    }
}
