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
    public class BatchDeleteRecordSetsRequestBody 
    {

        /// <summary>
        /// Zone的类型，取值为public或private。
        /// </summary>
        [JsonProperty("zone_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneType { get; set; }

        /// <summary>
        /// 待删除的Record Set ID列表。 最多支持100个。
        /// </summary>
        [JsonProperty("recordset_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RecordsetIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteRecordSetsRequestBody {\n");
            sb.Append("  zoneType: ").Append(ZoneType).Append("\n");
            sb.Append("  recordsetIds: ").Append(RecordsetIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteRecordSetsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteRecordSetsRequestBody input)
        {
            if (input == null) return false;
            if (this.ZoneType != input.ZoneType || (this.ZoneType != null && !this.ZoneType.Equals(input.ZoneType))) return false;
            if (this.RecordsetIds != input.RecordsetIds || (this.RecordsetIds != null && input.RecordsetIds != null && !this.RecordsetIds.SequenceEqual(input.RecordsetIds))) return false;

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
                if (this.ZoneType != null) hashCode = hashCode * 59 + this.ZoneType.GetHashCode();
                if (this.RecordsetIds != null) hashCode = hashCode * 59 + this.RecordsetIds.GetHashCode();
                return hashCode;
            }
        }
    }
}