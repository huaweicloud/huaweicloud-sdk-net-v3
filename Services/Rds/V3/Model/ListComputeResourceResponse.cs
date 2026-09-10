using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListComputeResourceResponse : SdkResponse
    {

        /// <summary>
        /// 资源包信息列表。
        /// </summary>
        [JsonProperty("resource_package_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourcePackageInfo> ResourcePackageInfos { get; set; }

        /// <summary>
        /// 总记录数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListComputeResourceResponse {\n");
            sb.Append("  resourcePackageInfos: ").Append(ResourcePackageInfos).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListComputeResourceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListComputeResourceResponse input)
        {
            if (input == null) return false;
            if (this.ResourcePackageInfos != input.ResourcePackageInfos || (this.ResourcePackageInfos != null && input.ResourcePackageInfos != null && !this.ResourcePackageInfos.SequenceEqual(input.ResourcePackageInfos))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.ResourcePackageInfos != null) hashCode = hashCode * 59 + this.ResourcePackageInfos.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
