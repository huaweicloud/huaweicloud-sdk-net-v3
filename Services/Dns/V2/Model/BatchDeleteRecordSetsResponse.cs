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
    /// Response Object
    /// </summary>
    public class BatchDeleteRecordSetsResponse : SdkResponse
    {

        /// <summary>
        /// 待删除zone类型，当前仅支持public或private。
        /// </summary>
        [JsonProperty("recordsets", NullValueHandling = NullValueHandling.Ignore)]
        public List<RecordsetData> Recordsets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteRecordSetsResponse {\n");
            sb.Append("  recordsets: ").Append(Recordsets).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteRecordSetsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteRecordSetsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Recordsets == input.Recordsets ||
                    this.Recordsets != null &&
                    input.Recordsets != null &&
                    this.Recordsets.SequenceEqual(input.Recordsets)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
