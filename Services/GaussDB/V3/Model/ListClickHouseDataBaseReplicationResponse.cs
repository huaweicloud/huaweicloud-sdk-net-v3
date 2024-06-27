using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListClickHouseDataBaseReplicationResponse : SdkResponse
    {

        /// <summary>
        /// 查询数据同步任务数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 数据同步任务信息。
        /// </summary>
        [JsonProperty("replications", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChDatabaseReplicationInfo> Replications { get; set; }

        /// <summary>
        /// taurus操作表示，重启、规格变更、倒换等。
        /// </summary>
        [JsonProperty("ext_text", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtText { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListClickHouseDataBaseReplicationResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  replications: ").Append(Replications).Append("\n");
            sb.Append("  extText: ").Append(ExtText).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListClickHouseDataBaseReplicationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListClickHouseDataBaseReplicationResponse input)
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
                    this.Replications == input.Replications ||
                    this.Replications != null &&
                    input.Replications != null &&
                    this.Replications.SequenceEqual(input.Replications)
                ) && 
                (
                    this.ExtText == input.ExtText ||
                    (this.ExtText != null &&
                    this.ExtText.Equals(input.ExtText))
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
                if (this.Replications != null)
                    hashCode = hashCode * 59 + this.Replications.GetHashCode();
                if (this.ExtText != null)
                    hashCode = hashCode * 59 + this.ExtText.GetHashCode();
                return hashCode;
            }
        }
    }
}
