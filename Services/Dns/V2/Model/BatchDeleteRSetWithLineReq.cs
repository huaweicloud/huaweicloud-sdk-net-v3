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
    public class BatchDeleteRSetWithLineReq 
    {

        /// <summary>
        /// Record Set ID列表。最多支持100个。
        /// </summary>
        [JsonProperty("recordset_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RecordsetIds { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteRSetWithLineReq {\n");
            sb.Append("  recordsetIds: ").Append(RecordsetIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteRSetWithLineReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteRSetWithLineReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecordsetIds == input.RecordsetIds ||
                    this.RecordsetIds != null &&
                    input.RecordsetIds != null &&
                    this.RecordsetIds.SequenceEqual(input.RecordsetIds)
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
                if (this.RecordsetIds != null)
                    hashCode = hashCode * 59 + this.RecordsetIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
