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
    /// 消费组信息。
    /// </summary>
    public class DescribeGroupsRespGroup 
    {

        /// <summary>
        /// 消费组名称。
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
        /// 消费者列表。
        /// </summary>
        [JsonProperty("members", NullValueHandling = NullValueHandling.Ignore)]
        public List<DescribeGroupsRespGroupMembers> Members { get; set; }

        /// <summary>
        /// 消费进度。
        /// </summary>
        [JsonProperty("group_message_offsets", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowGroupsRespGroupGroupMessageOffsets> GroupMessageOffsets { get; set; }

        /// <summary>
        /// 分区分配策略。
        /// </summary>
        [JsonProperty("assignment_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string AssignmentStrategy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DescribeGroupsRespGroup {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  coordinatorId: ").Append(CoordinatorId).Append("\n");
            sb.Append("  members: ").Append(Members).Append("\n");
            sb.Append("  groupMessageOffsets: ").Append(GroupMessageOffsets).Append("\n");
            sb.Append("  assignmentStrategy: ").Append(AssignmentStrategy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DescribeGroupsRespGroup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DescribeGroupsRespGroup input)
        {
            if (input == null) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.CoordinatorId != input.CoordinatorId || (this.CoordinatorId != null && !this.CoordinatorId.Equals(input.CoordinatorId))) return false;
            if (this.Members != input.Members || (this.Members != null && input.Members != null && !this.Members.SequenceEqual(input.Members))) return false;
            if (this.GroupMessageOffsets != input.GroupMessageOffsets || (this.GroupMessageOffsets != null && input.GroupMessageOffsets != null && !this.GroupMessageOffsets.SequenceEqual(input.GroupMessageOffsets))) return false;
            if (this.AssignmentStrategy != input.AssignmentStrategy || (this.AssignmentStrategy != null && !this.AssignmentStrategy.Equals(input.AssignmentStrategy))) return false;

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
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CoordinatorId != null) hashCode = hashCode * 59 + this.CoordinatorId.GetHashCode();
                if (this.Members != null) hashCode = hashCode * 59 + this.Members.GetHashCode();
                if (this.GroupMessageOffsets != null) hashCode = hashCode * 59 + this.GroupMessageOffsets.GetHashCode();
                if (this.AssignmentStrategy != null) hashCode = hashCode * 59 + this.AssignmentStrategy.GetHashCode();
                return hashCode;
            }
        }
    }
}
