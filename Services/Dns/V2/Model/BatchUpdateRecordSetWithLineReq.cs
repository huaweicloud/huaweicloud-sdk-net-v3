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
    public class BatchUpdateRecordSetWithLineReq 
    {

        /// <summary>
        /// RecordSet 列表。
        /// </summary>
        [JsonProperty("recordsets", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchUpdateRecordSet> Recordsets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateRecordSetWithLineReq {\n");
            sb.Append("  recordsets: ").Append(Recordsets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateRecordSetWithLineReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateRecordSetWithLineReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Recordsets == input.Recordsets ||
                    this.Recordsets != null &&
                    input.Recordsets != null &&
                    this.Recordsets.SequenceEqual(input.Recordsets)
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
                if (this.Recordsets != null)
                    hashCode = hashCode * 59 + this.Recordsets.GetHashCode();
                return hashCode;
            }
        }
    }
}
