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
    public class ShowReplicationStatusResponse : SdkResponse
    {

        /// <summary>
        /// 复制状态。
        /// </summary>
        [JsonProperty("replication_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplicationStatus { get; set; }

        /// <summary>
        /// 复制异常原因。
        /// </summary>
        [JsonProperty("abnormal_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string AbnormalReason { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowReplicationStatusResponse {\n");
            sb.Append("  replicationStatus: ").Append(ReplicationStatus).Append("\n");
            sb.Append("  abnormalReason: ").Append(AbnormalReason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowReplicationStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowReplicationStatusResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReplicationStatus == input.ReplicationStatus ||
                    (this.ReplicationStatus != null &&
                    this.ReplicationStatus.Equals(input.ReplicationStatus))
                ) && 
                (
                    this.AbnormalReason == input.AbnormalReason ||
                    (this.AbnormalReason != null &&
                    this.AbnormalReason.Equals(input.AbnormalReason))
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
                if (this.ReplicationStatus != null)
                    hashCode = hashCode * 59 + this.ReplicationStatus.GetHashCode();
                if (this.AbnormalReason != null)
                    hashCode = hashCode * 59 + this.AbnormalReason.GetHashCode();
                return hashCode;
            }
        }
    }
}
