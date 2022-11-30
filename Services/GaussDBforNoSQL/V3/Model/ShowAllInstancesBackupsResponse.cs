using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAllInstancesBackupsResponse : SdkResponse
    {

        /// <summary>
        /// 总记录数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 备份列表信息。
        /// </summary>
        [JsonProperty("backups", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryInstanceBackupResponseBodyBackups> Backups { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAllInstancesBackupsResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  backups: ").Append(Backups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAllInstancesBackupsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAllInstancesBackupsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.Backups == input.Backups ||
                    this.Backups != null &&
                    input.Backups != null &&
                    this.Backups.SequenceEqual(input.Backups)
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
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.Backups != null)
                    hashCode = hashCode * 59 + this.Backups.GetHashCode();
                return hashCode;
            }
        }
    }
}
