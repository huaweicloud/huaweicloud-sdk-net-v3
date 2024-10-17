using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// VOD 打包信息，包括DRM resourceID和转封装模板ID，模板ID通过VOD查询
    /// </summary>
    public class VodPackageInfo 
    {

        /// <summary>
        /// VOD 打包信息，转封装模板ID，模板ID通过VOD查询
        /// </summary>
        [JsonProperty("packaging_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PackagingGroupId { get; set; }

        /// <summary>
        /// DRM resourceID
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VodPackageInfo {\n");
            sb.Append("  packagingGroupId: ").Append(PackagingGroupId).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VodPackageInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VodPackageInfo input)
        {
            if (input == null) return false;
            if (this.PackagingGroupId != input.PackagingGroupId || (this.PackagingGroupId != null && !this.PackagingGroupId.Equals(input.PackagingGroupId))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;

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
                if (this.PackagingGroupId != null) hashCode = hashCode * 59 + this.PackagingGroupId.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
