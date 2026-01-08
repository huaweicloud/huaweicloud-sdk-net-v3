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
    public class ListResourcePackagesResponse : SdkResponse
    {

        /// <summary>
        /// 资源包列表。
        /// </summary>
        [JsonProperty("desktop_resource_packages", NullValueHandling = NullValueHandling.Ignore)]
        public List<DesktopResourcePackage> DesktopResourcePackages { get; set; }

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListResourcePackagesResponse {\n");
            sb.Append("  desktopResourcePackages: ").Append(DesktopResourcePackages).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListResourcePackagesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListResourcePackagesResponse input)
        {
            if (input == null) return false;
            if (this.DesktopResourcePackages != input.DesktopResourcePackages || (this.DesktopResourcePackages != null && input.DesktopResourcePackages != null && !this.DesktopResourcePackages.SequenceEqual(input.DesktopResourcePackages))) return false;
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
                if (this.DesktopResourcePackages != null) hashCode = hashCode * 59 + this.DesktopResourcePackages.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
