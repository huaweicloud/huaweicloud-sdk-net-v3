using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAuditlogsResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("auditlogs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Auditlog> Auditlogs { get; set; }

        /// <summary>
        /// 总记录数。
        /// </summary>
        [JsonProperty("total_record", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRecord { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAuditlogsResponse {\n");
            sb.Append("  auditlogs: ").Append(Auditlogs).Append("\n");
            sb.Append("  totalRecord: ").Append(TotalRecord).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAuditlogsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAuditlogsResponse input)
        {
            if (input == null) return false;
            if (this.Auditlogs != input.Auditlogs || (this.Auditlogs != null && input.Auditlogs != null && !this.Auditlogs.SequenceEqual(input.Auditlogs))) return false;
            if (this.TotalRecord != input.TotalRecord || (this.TotalRecord != null && !this.TotalRecord.Equals(input.TotalRecord))) return false;

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
                if (this.Auditlogs != null) hashCode = hashCode * 59 + this.Auditlogs.GetHashCode();
                if (this.TotalRecord != null) hashCode = hashCode * 59 + this.TotalRecord.GetHashCode();
                return hashCode;
            }
        }
    }
}
