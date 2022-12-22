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
    public class DeletePtrRecordReq 
    {

        /// <summary>
        /// 待删除PTR ID。
        /// </summary>
        [JsonProperty("floatingip_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FloatingipIds { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeletePtrRecordReq {\n");
            sb.Append("  floatingipIds: ").Append(FloatingipIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeletePtrRecordReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeletePtrRecordReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FloatingipIds == input.FloatingipIds ||
                    this.FloatingipIds != null &&
                    input.FloatingipIds != null &&
                    this.FloatingipIds.SequenceEqual(input.FloatingipIds)
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
                if (this.FloatingipIds != null)
                    hashCode = hashCode * 59 + this.FloatingipIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
