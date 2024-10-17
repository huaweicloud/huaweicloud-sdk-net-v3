using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SrFlavorResizeReq 
    {

        /// <summary>
        /// FE节点CPU、内存规格ID。填空或者不填视为规格ID与原规格ID保持一致。
        /// </summary>
        [JsonProperty("fe_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FeFlavorId { get; set; }

        /// <summary>
        /// BE节点CPU、内存规格ID。填空或者不填视为规格ID与原规格ID保持一致。
        /// </summary>
        [JsonProperty("be_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BeFlavorId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SrFlavorResizeReq {\n");
            sb.Append("  feFlavorId: ").Append(FeFlavorId).Append("\n");
            sb.Append("  beFlavorId: ").Append(BeFlavorId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SrFlavorResizeReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SrFlavorResizeReq input)
        {
            if (input == null) return false;
            if (this.FeFlavorId != input.FeFlavorId || (this.FeFlavorId != null && !this.FeFlavorId.Equals(input.FeFlavorId))) return false;
            if (this.BeFlavorId != input.BeFlavorId || (this.BeFlavorId != null && !this.BeFlavorId.Equals(input.BeFlavorId))) return false;

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
                if (this.FeFlavorId != null) hashCode = hashCode * 59 + this.FeFlavorId.GetHashCode();
                if (this.BeFlavorId != null) hashCode = hashCode * 59 + this.BeFlavorId.GetHashCode();
                return hashCode;
            }
        }
    }
}
