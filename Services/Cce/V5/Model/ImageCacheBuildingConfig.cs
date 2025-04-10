using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V5.Model
{
    /// <summary>
    /// 镜像缓存构建配置信息。
    /// </summary>
    public class ImageCacheBuildingConfig 
    {

        /// <summary>
        /// **参数解释：** 构建镜像缓存所启动的临时Pod所在的Autopilot集群的UID。 **约束限制：** 要求使用的Autopilot集群版本为v1.28.8-r0或v1.31.4-r0以上版本。 **取值范围：** 不涉及 **默认取值：** 不涉及 
        /// </summary>
        [JsonProperty("cluster", NullValueHandling = NullValueHandling.Ignore)]
        public string Cluster { get; set; }

        /// <summary>
        /// 下载所需缓存镜像的访问凭证列表，不填写或无有效凭证时仅支持下载公共镜像。
        /// </summary>
        [JsonProperty("image_pull_secrets", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ImagePullSecrets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageCacheBuildingConfig {\n");
            sb.Append("  cluster: ").Append(Cluster).Append("\n");
            sb.Append("  imagePullSecrets: ").Append(ImagePullSecrets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageCacheBuildingConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageCacheBuildingConfig input)
        {
            if (input == null) return false;
            if (this.Cluster != input.Cluster || (this.Cluster != null && !this.Cluster.Equals(input.Cluster))) return false;
            if (this.ImagePullSecrets != input.ImagePullSecrets || (this.ImagePullSecrets != null && input.ImagePullSecrets != null && !this.ImagePullSecrets.SequenceEqual(input.ImagePullSecrets))) return false;

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
                if (this.Cluster != null) hashCode = hashCode * 59 + this.Cluster.GetHashCode();
                if (this.ImagePullSecrets != null) hashCode = hashCode * 59 + this.ImagePullSecrets.GetHashCode();
                return hashCode;
            }
        }
    }
}
