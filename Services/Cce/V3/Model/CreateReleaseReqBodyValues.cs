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
    /// 模板实例的值
    /// </summary>
    public class CreateReleaseReqBodyValues 
    {

        /// <summary>
        /// 镜像拉取策略
        /// </summary>
        [JsonProperty("imagePullPolicy", NullValueHandling = NullValueHandling.Ignore)]
        public string ImagePullPolicy { get; set; }

        /// <summary>
        /// 镜像标签
        /// </summary>
        [JsonProperty("imageTag", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageTag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateReleaseReqBodyValues {\n");
            sb.Append("  imagePullPolicy: ").Append(ImagePullPolicy).Append("\n");
            sb.Append("  imageTag: ").Append(ImageTag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateReleaseReqBodyValues);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateReleaseReqBodyValues input)
        {
            if (input == null) return false;
            if (this.ImagePullPolicy != input.ImagePullPolicy || (this.ImagePullPolicy != null && !this.ImagePullPolicy.Equals(input.ImagePullPolicy))) return false;
            if (this.ImageTag != input.ImageTag || (this.ImageTag != null && !this.ImageTag.Equals(input.ImageTag))) return false;

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
                if (this.ImagePullPolicy != null) hashCode = hashCode * 59 + this.ImagePullPolicy.GetHashCode();
                if (this.ImageTag != null) hashCode = hashCode * 59 + this.ImageTag.GetHashCode();
                return hashCode;
            }
        }
    }
}
