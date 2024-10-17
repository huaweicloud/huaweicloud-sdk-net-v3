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
    public class ListOffSiteInstancesResponse : SdkResponse
    {

        /// <summary>
        /// 跨区域备份实例信息。
        /// </summary>
        [JsonProperty("offsite_backup_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<OffsiteBackupInstance> OffsiteBackupInstances { get; set; }

        /// <summary>
        /// 总记录数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOffSiteInstancesResponse {\n");
            sb.Append("  offsiteBackupInstances: ").Append(OffsiteBackupInstances).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListOffSiteInstancesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListOffSiteInstancesResponse input)
        {
            if (input == null) return false;
            if (this.OffsiteBackupInstances != input.OffsiteBackupInstances || (this.OffsiteBackupInstances != null && input.OffsiteBackupInstances != null && !this.OffsiteBackupInstances.SequenceEqual(input.OffsiteBackupInstances))) return false;
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
                if (this.OffsiteBackupInstances != null) hashCode = hashCode * 59 + this.OffsiteBackupInstances.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
