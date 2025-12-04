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
        /// **参数解释**： 消费组状态。 **取值范围**： - Dead：消费组内没有任何成员，且没有任何元数据。 - Empty：消费组内没有任何成员，存在元数据。 - PreparingRebalance：准备开启rebalance。 - CompletingRebalance：所有成员加入group。 - Stable：消费组内成员可正常消费。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// **参数解释**： 创建时间。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public Object CreatedAt { get; set; }

        /// <summary>
        /// **参数解释**： 消费组名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// **参数解释**： 协调器编号。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("coordinator_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CoordinatorId { get; set; }

        /// <summary>
        /// **参数解释**： 分区分配策略。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("assignment_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string AssignmentStrategy { get; set; }

        /// <summary>
        /// **参数解释**： 消费组描述。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("group_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupDesc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DescribeGroupsRespGroup {\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  coordinatorId: ").Append(CoordinatorId).Append("\n");
            sb.Append("  assignmentStrategy: ").Append(AssignmentStrategy).Append("\n");
            sb.Append("  groupDesc: ").Append(GroupDesc).Append("\n");
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
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.CoordinatorId != input.CoordinatorId || (this.CoordinatorId != null && !this.CoordinatorId.Equals(input.CoordinatorId))) return false;
            if (this.AssignmentStrategy != input.AssignmentStrategy || (this.AssignmentStrategy != null && !this.AssignmentStrategy.Equals(input.AssignmentStrategy))) return false;
            if (this.GroupDesc != input.GroupDesc || (this.GroupDesc != null && !this.GroupDesc.Equals(input.GroupDesc))) return false;

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
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.CoordinatorId != null) hashCode = hashCode * 59 + this.CoordinatorId.GetHashCode();
                if (this.AssignmentStrategy != null) hashCode = hashCode * 59 + this.AssignmentStrategy.GetHashCode();
                if (this.GroupDesc != null) hashCode = hashCode * 59 + this.GroupDesc.GetHashCode();
                return hashCode;
            }
        }
    }
}
