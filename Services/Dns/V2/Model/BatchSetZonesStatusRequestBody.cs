using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchSetZonesStatusRequestBody 
    {

        /// <summary>
        /// 待设置域名状态，支持DISABLE或ENABLE。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 待设置域名ID列表。 最多支持50个。
        /// </summary>
        [JsonProperty("zone_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ZoneIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchSetZonesStatusRequestBody {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  zoneIds: ").Append(ZoneIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchSetZonesStatusRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchSetZonesStatusRequestBody input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ZoneIds != input.ZoneIds || (this.ZoneIds != null && input.ZoneIds != null && !this.ZoneIds.SequenceEqual(input.ZoneIds))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ZoneIds != null) hashCode = hashCode * 59 + this.ZoneIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
