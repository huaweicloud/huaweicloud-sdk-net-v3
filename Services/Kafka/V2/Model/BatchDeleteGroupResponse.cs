using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchDeleteGroupResponse : SdkResponse
    {

        /// <summary>
        /// 删除失败的消费组列表。
        /// </summary>
        [JsonProperty("failed_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchDeleteGroupRespFailedGroups> FailedGroups { get; set; }

        /// <summary>
        /// 删除失败的个数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteGroupResponse {\n");
            sb.Append("  failedGroups: ").Append(FailedGroups).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteGroupResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FailedGroups == input.FailedGroups ||
                    this.FailedGroups != null &&
                    input.FailedGroups != null &&
                    this.FailedGroups.SequenceEqual(input.FailedGroups)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.FailedGroups != null)
                    hashCode = hashCode * 59 + this.FailedGroups.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
