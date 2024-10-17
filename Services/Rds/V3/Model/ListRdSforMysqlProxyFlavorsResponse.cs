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
    public class ListRdSforMysqlProxyFlavorsResponse : SdkResponse
    {

        /// <summary>
        /// 规格组信息。
        /// </summary>
        [JsonProperty("compute_flavor_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<MysqlProxyFlavorsResponseComputeFlavorGroups> ComputeFlavorGroups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRdSforMysqlProxyFlavorsResponse {\n");
            sb.Append("  computeFlavorGroups: ").Append(ComputeFlavorGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRdSforMysqlProxyFlavorsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRdSforMysqlProxyFlavorsResponse input)
        {
            if (input == null) return false;
            if (this.ComputeFlavorGroups != input.ComputeFlavorGroups || (this.ComputeFlavorGroups != null && input.ComputeFlavorGroups != null && !this.ComputeFlavorGroups.SequenceEqual(input.ComputeFlavorGroups))) return false;

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
                if (this.ComputeFlavorGroups != null) hashCode = hashCode * 59 + this.ComputeFlavorGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
