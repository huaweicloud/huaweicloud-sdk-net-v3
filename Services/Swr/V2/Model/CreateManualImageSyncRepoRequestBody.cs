using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 手动同步镜像需要的参数
    /// </summary>
    public class CreateManualImageSyncRepoRequestBody 
    {

        /// <summary>
        /// 版本列表
        /// </summary>
        [JsonProperty("imageTag", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ImageTag { get; set; }

        /// <summary>
        /// 是否覆盖，默认为false
        /// </summary>
        [JsonProperty("override", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Override { get; set; }

        /// <summary>
        /// 目标组织
        /// </summary>
        [JsonProperty("remoteNamespace", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteNamespace { get; set; }

        /// <summary>
        /// 目标region ID。
        /// </summary>
        [JsonProperty("remoteRegionId", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteRegionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateManualImageSyncRepoRequestBody {\n");
            sb.Append("  imageTag: ").Append(ImageTag).Append("\n");
            sb.Append("  Override: ").Append(Override).Append("\n");
            sb.Append("  remoteNamespace: ").Append(RemoteNamespace).Append("\n");
            sb.Append("  remoteRegionId: ").Append(RemoteRegionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateManualImageSyncRepoRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateManualImageSyncRepoRequestBody input)
        {
            if (input == null) return false;
            if (this.ImageTag != input.ImageTag || (this.ImageTag != null && input.ImageTag != null && !this.ImageTag.SequenceEqual(input.ImageTag))) return false;
            if (this.Override != input.Override || (this.Override != null && !this.Override.Equals(input.Override))) return false;
            if (this.RemoteNamespace != input.RemoteNamespace || (this.RemoteNamespace != null && !this.RemoteNamespace.Equals(input.RemoteNamespace))) return false;
            if (this.RemoteRegionId != input.RemoteRegionId || (this.RemoteRegionId != null && !this.RemoteRegionId.Equals(input.RemoteRegionId))) return false;

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
                if (this.ImageTag != null) hashCode = hashCode * 59 + this.ImageTag.GetHashCode();
                if (this.Override != null) hashCode = hashCode * 59 + this.Override.GetHashCode();
                if (this.RemoteNamespace != null) hashCode = hashCode * 59 + this.RemoteNamespace.GetHashCode();
                if (this.RemoteRegionId != null) hashCode = hashCode * 59 + this.RemoteRegionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
