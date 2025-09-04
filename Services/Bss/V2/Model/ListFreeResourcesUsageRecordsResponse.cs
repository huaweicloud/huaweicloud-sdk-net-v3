using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListFreeResourcesUsageRecordsResponse : SdkResponse
    {

        /// <summary>
        /// 资源包使用明细记录，具体参见表1。
        /// </summary>
        [JsonProperty("free_resource_records", NullValueHandling = NullValueHandling.Ignore)]
        public List<FreeResourceRecord> FreeResourceRecords { get; set; }

        /// <summary>
        /// 满足条件的总个数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFreeResourcesUsageRecordsResponse {\n");
            sb.Append("  freeResourceRecords: ").Append(FreeResourceRecords).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFreeResourcesUsageRecordsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFreeResourcesUsageRecordsResponse input)
        {
            if (input == null) return false;
            if (this.FreeResourceRecords != input.FreeResourceRecords || (this.FreeResourceRecords != null && input.FreeResourceRecords != null && !this.FreeResourceRecords.SequenceEqual(input.FreeResourceRecords))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.FreeResourceRecords != null) hashCode = hashCode * 59 + this.FreeResourceRecords.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
