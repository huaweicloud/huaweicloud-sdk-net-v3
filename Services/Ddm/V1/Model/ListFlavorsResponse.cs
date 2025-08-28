using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListFlavorsResponse : SdkResponse
    {

        /// <summary>
        /// 计算类型规格组。
        /// </summary>
        [JsonProperty("computeFlavorGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ComputeFlavorGroupsInfo> ComputeFlavorGroups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFlavorsResponse {\n");
            sb.Append("  computeFlavorGroups: ").Append(ComputeFlavorGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFlavorsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFlavorsResponse input)
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
