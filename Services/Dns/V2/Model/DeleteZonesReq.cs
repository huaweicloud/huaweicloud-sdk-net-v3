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
    public class DeleteZonesReq 
    {

        /// <summary>
        /// 待删除zone类型，当前仅支持 public 或 private
        /// </summary>
        [JsonProperty("zone_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneType { get; set; }

        /// <summary>
        /// 待删除Zone ID。
        /// </summary>
        [JsonProperty("zone_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ZoneIds { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteZonesReq {\n");
            sb.Append("  zoneType: ").Append(ZoneType).Append("\n");
            sb.Append("  zoneIds: ").Append(ZoneIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteZonesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteZonesReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ZoneType == input.ZoneType ||
                    (this.ZoneType != null &&
                    this.ZoneType.Equals(input.ZoneType))
                ) && 
                (
                    this.ZoneIds == input.ZoneIds ||
                    this.ZoneIds != null &&
                    input.ZoneIds != null &&
                    this.ZoneIds.SequenceEqual(input.ZoneIds)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ZoneType != null)
                    hashCode = hashCode * 59 + this.ZoneType.GetHashCode();
                if (this.ZoneIds != null)
                    hashCode = hashCode * 59 + this.ZoneIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
