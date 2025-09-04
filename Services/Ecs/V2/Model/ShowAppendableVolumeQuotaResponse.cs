using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAppendableVolumeQuotaResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("free_scsi", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreeScsi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("free_blk", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreeBlk { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAppendableVolumeQuotaResponse {\n");
            sb.Append("  freeScsi: ").Append(FreeScsi).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  freeBlk: ").Append(FreeBlk).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAppendableVolumeQuotaResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAppendableVolumeQuotaResponse input)
        {
            if (input == null) return false;
            if (this.FreeScsi != input.FreeScsi || (this.FreeScsi != null && !this.FreeScsi.Equals(input.FreeScsi))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.FreeBlk != input.FreeBlk || (this.FreeBlk != null && !this.FreeBlk.Equals(input.FreeBlk))) return false;

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
                if (this.FreeScsi != null) hashCode = hashCode * 59 + this.FreeScsi.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.FreeBlk != null) hashCode = hashCode * 59 + this.FreeBlk.GetHashCode();
                return hashCode;
            }
        }
    }
}
