using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListFreeResourceInfosResponse : SdkResponse
    {

        /// <summary>
        /// 资源包信息列表，具体参见表2。
        /// </summary>
        [JsonProperty("free_resource_packages", NullValueHandling = NullValueHandling.Ignore)]
        public List<FreeResourcePackageV3> FreeResourcePackages { get; set; }

        /// <summary>
        /// 总条数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFreeResourceInfosResponse {\n");
            sb.Append("  freeResourcePackages: ").Append(FreeResourcePackages).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFreeResourceInfosResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFreeResourceInfosResponse input)
        {
            if (input == null) return false;
            if (this.FreeResourcePackages != input.FreeResourcePackages || (this.FreeResourcePackages != null && input.FreeResourcePackages != null && !this.FreeResourcePackages.SequenceEqual(input.FreeResourcePackages))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.FreeResourcePackages != null) hashCode = hashCode * 59 + this.FreeResourcePackages.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
