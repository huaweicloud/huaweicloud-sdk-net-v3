using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// 配额详细信息。
    /// </summary>
    public class QuotaDetail 
    {

        /// <summary>
        /// 已使用的数量。
        /// </summary>
        [JsonProperty("in_use", NullValueHandling = NullValueHandling.Ignore)]
        public int? InUse { get; set; }

        /// <summary>
        /// 最大的数量。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 预留属性。
        /// </summary>
        [JsonProperty("reserved", NullValueHandling = NullValueHandling.Ignore)]
        public int? Reserved { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuotaDetail {\n");
            sb.Append("  inUse: ").Append(InUse).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  reserved: ").Append(Reserved).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuotaDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuotaDetail input)
        {
            if (input == null) return false;
            if (this.InUse != input.InUse || (this.InUse != null && !this.InUse.Equals(input.InUse))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Reserved != input.Reserved || (this.Reserved != null && !this.Reserved.Equals(input.Reserved))) return false;

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
                if (this.InUse != null) hashCode = hashCode * 59 + this.InUse.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Reserved != null) hashCode = hashCode * 59 + this.Reserved.GetHashCode();
                return hashCode;
            }
        }
    }
}
