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
    public class BatchDeleteRecordSetWithLineRequestBody 
    {

        /// <summary>
        /// **参数解释：** 记录集ID列表。 **约束限制：** 最多支持100个。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("recordset_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RecordsetIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteRecordSetWithLineRequestBody {\n");
            sb.Append("  recordsetIds: ").Append(RecordsetIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteRecordSetWithLineRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteRecordSetWithLineRequestBody input)
        {
            if (input == null) return false;
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
                if (this.RecordsetIds != null) hashCode = hashCode * 59 + this.RecordsetIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
