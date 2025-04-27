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
    public class BatchUpdateRecordSetWithLineRequestBody 
    {

        /// <summary>
        /// 记录集列表。
        /// </summary>
        [JsonProperty("recordsets", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchUpdateRecordSet> Recordsets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateRecordSetWithLineRequestBody {\n");
            sb.Append("  recordsets: ").Append(Recordsets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateRecordSetWithLineRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateRecordSetWithLineRequestBody input)
        {
            if (input == null) return false;
            if (this.Recordsets != input.Recordsets || (this.Recordsets != null && input.Recordsets != null && !this.Recordsets.SequenceEqual(input.Recordsets))) return false;

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
                if (this.Recordsets != null) hashCode = hashCode * 59 + this.Recordsets.GetHashCode();
                return hashCode;
            }
        }
    }
}
