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
    public class ListDesktopsResponse : SdkResponse
    {

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 桌面信息。
        /// </summary>
        [JsonProperty("desktops", NullValueHandling = NullValueHandling.Ignore)]
        public List<SimpleDesktopInfo> Desktops { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDesktopsResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  desktops: ").Append(Desktops).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDesktopsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDesktopsResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.Desktops != input.Desktops || (this.Desktops != null && input.Desktops != null && !this.Desktops.SequenceEqual(input.Desktops))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.Desktops != null) hashCode = hashCode * 59 + this.Desktops.GetHashCode();
                return hashCode;
            }
        }
    }
}
