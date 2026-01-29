using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowGroupResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 是否可以消费。 **约束限制**： 不涉及。 **取值范围**： - true：可以消费。 - false：不可以消费。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// **参数解释**： 是否广播。 **约束限制**： 不涉及。 **取值范围**： - true：开启广播消费。 - false：不开启广播消费。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("broadcast", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Broadcast { get; set; }

        /// <summary>
        /// **参数解释**： 关联的代理列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("brokers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Brokers { get; set; }

        /// <summary>
        /// **参数解释**： 消费组名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 消费组描述。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("group_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupDesc { get; set; }

        /// <summary>
        /// **参数解释**： 创建时间。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// **参数解释**： 最大重试次数。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("retry_max_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetryMaxTime { get; set; }

        /// <summary>
        /// **参数解释**： 权限。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// **参数解释**： 是否顺序消费。 **约束限制**： 不涉及。 **取值范围**： - true：开启顺序消费。 - false：不开启顺序消费。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("consume_orderly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConsumeOrderly { get; set; }

        /// <summary>
        /// **参数解释**： 消费组是否在线。 **约束限制**： 不涉及。 **取值范围**： - true：消费组在线。 - false：消费组不在线。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("group_online", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GroupOnline { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGroupResponse {\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  broadcast: ").Append(Broadcast).Append("\n");
            sb.Append("  brokers: ").Append(Brokers).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  groupDesc: ").Append(GroupDesc).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  retryMaxTime: ").Append(RetryMaxTime).Append("\n");
            sb.Append("  permissions: ").Append(Permissions).Append("\n");
            sb.Append("  consumeOrderly: ").Append(ConsumeOrderly).Append("\n");
            sb.Append("  groupOnline: ").Append(GroupOnline).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGroupResponse input)
        {
            if (input == null) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.Broadcast != input.Broadcast || (this.Broadcast != null && !this.Broadcast.Equals(input.Broadcast))) return false;
            if (this.Brokers != input.Brokers || (this.Brokers != null && input.Brokers != null && !this.Brokers.SequenceEqual(input.Brokers))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.GroupDesc != input.GroupDesc || (this.GroupDesc != null && !this.GroupDesc.Equals(input.GroupDesc))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.RetryMaxTime != input.RetryMaxTime || (this.RetryMaxTime != null && !this.RetryMaxTime.Equals(input.RetryMaxTime))) return false;
            if (this.Permissions != input.Permissions || (this.Permissions != null && input.Permissions != null && !this.Permissions.SequenceEqual(input.Permissions))) return false;
            if (this.ConsumeOrderly != input.ConsumeOrderly || (this.ConsumeOrderly != null && !this.ConsumeOrderly.Equals(input.ConsumeOrderly))) return false;
            if (this.GroupOnline != input.GroupOnline || (this.GroupOnline != null && !this.GroupOnline.Equals(input.GroupOnline))) return false;

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
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Broadcast != null) hashCode = hashCode * 59 + this.Broadcast.GetHashCode();
                if (this.Brokers != null) hashCode = hashCode * 59 + this.Brokers.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.GroupDesc != null) hashCode = hashCode * 59 + this.GroupDesc.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.RetryMaxTime != null) hashCode = hashCode * 59 + this.RetryMaxTime.GetHashCode();
                if (this.Permissions != null) hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.ConsumeOrderly != null) hashCode = hashCode * 59 + this.ConsumeOrderly.GetHashCode();
                if (this.GroupOnline != null) hashCode = hashCode * 59 + this.GroupOnline.GetHashCode();
                return hashCode;
            }
        }
    }
}
