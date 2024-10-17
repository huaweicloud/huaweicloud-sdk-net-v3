using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowUnblockRecordResponse : SdkResponse
    {

        /// <summary>
        /// 解封记录
        /// </summary>
        [JsonProperty("unblock_record", NullValueHandling = NullValueHandling.Ignore)]
        public List<UnblockRecordResponseUnblockRecord> UnblockRecord { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowUnblockRecordResponse {\n");
            sb.Append("  unblockRecord: ").Append(UnblockRecord).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowUnblockRecordResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUnblockRecordResponse input)
        {
            if (input == null) return false;
            if (this.UnblockRecord != input.UnblockRecord || (this.UnblockRecord != null && input.UnblockRecord != null && !this.UnblockRecord.SequenceEqual(input.UnblockRecord))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;

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
                if (this.UnblockRecord != null) hashCode = hashCode * 59 + this.UnblockRecord.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                return hashCode;
            }
        }
    }
}
