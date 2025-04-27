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
    public class BatchSetRecordSetsStatusRequestBody 
    {

        /// <summary>
        /// 待设置记录集状态，支持DISABLE或ENABLE。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 待设置记录集ID列表。 最多支持50个。
        /// </summary>
        [JsonProperty("recordset_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RecordsetIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchSetRecordSetsStatusRequestBody {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  recordsetIds: ").Append(RecordsetIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchSetRecordSetsStatusRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchSetRecordSetsStatusRequestBody input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.RecordsetIds != null) hashCode = hashCode * 59 + this.RecordsetIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
