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
    public class BatchDeletePtrRecordsRequestBody 
    {

        /// <summary>
        /// 待删除反向解析记录ID列表。 最多支持50个。
        /// </summary>
        [JsonProperty("floatingip_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FloatingipIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeletePtrRecordsRequestBody {\n");
            sb.Append("  floatingipIds: ").Append(FloatingipIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeletePtrRecordsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeletePtrRecordsRequestBody input)
        {
            if (input == null) return false;
            if (this.FloatingipIds != input.FloatingipIds || (this.FloatingipIds != null && input.FloatingipIds != null && !this.FloatingipIds.SequenceEqual(input.FloatingipIds))) return false;

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
                if (this.FloatingipIds != null) hashCode = hashCode * 59 + this.FloatingipIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
