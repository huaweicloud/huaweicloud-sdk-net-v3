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
    public class ListAdOusResponse : SdkResponse
    {

        /// <summary>
        /// OU对象。
        /// </summary>
        [JsonProperty("ou_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<AdOuInfo> OuInfos { get; set; }

        /// <summary>
        /// OU总记录数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAdOusResponse {\n");
            sb.Append("  ouInfos: ").Append(OuInfos).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAdOusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAdOusResponse input)
        {
            if (input == null) return false;
            if (this.OuInfos != input.OuInfos || (this.OuInfos != null && input.OuInfos != null && !this.OuInfos.SequenceEqual(input.OuInfos))) return false;
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
                if (this.OuInfos != null) hashCode = hashCode * 59 + this.OuInfos.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
