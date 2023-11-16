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
    /// 
    /// </summary>
    public class GroupInfoSimple 
    {

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// 消费组ID。
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 消费组状态。包含以下状态： - Dead：消费组内没有任何成员，且没有任何元数据。 - Empty：消费组内没有任何成员，存在元数据。 - PreparingRebalance：准备开启rebalance。 - CompletingRebalance：所有成员加入group。 - Stable：消费组内成员可正常消费。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 协调器编号。
        /// </summary>
        [JsonProperty("coordinator_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CoordinatorId { get; set; }

        /// <summary>
        /// 消费组描述。
        /// </summary>
        [JsonProperty("group_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupDesc { get; set; }

        /// <summary>
        /// 堆积数。
        /// </summary>
        [JsonProperty("lag", NullValueHandling = NullValueHandling.Ignore)]
        public int? Lag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupInfoSimple {\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  coordinatorId: ").Append(CoordinatorId).Append("\n");
            sb.Append("  groupDesc: ").Append(GroupDesc).Append("\n");
            sb.Append("  lag: ").Append(Lag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GroupInfoSimple);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GroupInfoSimple input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.CoordinatorId == input.CoordinatorId ||
                    (this.CoordinatorId != null &&
                    this.CoordinatorId.Equals(input.CoordinatorId))
                ) && 
                (
                    this.GroupDesc == input.GroupDesc ||
                    (this.GroupDesc != null &&
                    this.GroupDesc.Equals(input.GroupDesc))
                ) && 
                (
                    this.Lag == input.Lag ||
                    (this.Lag != null &&
                    this.Lag.Equals(input.Lag))
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CoordinatorId != null)
                    hashCode = hashCode * 59 + this.CoordinatorId.GetHashCode();
                if (this.GroupDesc != null)
                    hashCode = hashCode * 59 + this.GroupDesc.GetHashCode();
                if (this.Lag != null)
                    hashCode = hashCode * 59 + this.Lag.GetHashCode();
                return hashCode;
            }
        }
    }
}
