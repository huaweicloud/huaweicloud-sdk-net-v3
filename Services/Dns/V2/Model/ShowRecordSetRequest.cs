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
    /// Request Object
    /// </summary>
    public class ShowRecordSetRequest 
    {

        /// <summary>
        /// 域名ID。
        /// </summary>
        [SDKProperty("zone_id", IsPath = true)]
        [JsonProperty("zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneId { get; set; }

        /// <summary>
        /// 记录集ID。
        /// </summary>
        [SDKProperty("recordset_id", IsPath = true)]
        [JsonProperty("recordset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordsetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRecordSetRequest {\n");
            sb.Append("  zoneId: ").Append(ZoneId).Append("\n");
            sb.Append("  recordsetId: ").Append(RecordsetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRecordSetRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRecordSetRequest input)
        {
            if (input == null) return false;
            if (this.ZoneId != input.ZoneId || (this.ZoneId != null && !this.ZoneId.Equals(input.ZoneId))) return false;
            if (this.RecordsetId != input.RecordsetId || (this.RecordsetId != null && !this.RecordsetId.Equals(input.RecordsetId))) return false;

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
                if (this.ZoneId != null) hashCode = hashCode * 59 + this.ZoneId.GetHashCode();
                if (this.RecordsetId != null) hashCode = hashCode * 59 + this.RecordsetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
