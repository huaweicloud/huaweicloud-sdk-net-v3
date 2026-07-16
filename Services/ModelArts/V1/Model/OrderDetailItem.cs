using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 订单关联的资源信息。
    /// </summary>
    public class OrderDetailItem 
    {

        /// <summary>
        /// **参数解释**：资源的ID，取值自资源详情的metadata.name字段。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("resourceName", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// **参数解释**：订单关联的资源变更动作类型。 **取值范围**：可选值如下： - createPool：创建资源池。 - deletePool：删除资源池。 - createNode：创建节点。 - deleteNode：删除节点，主要是包周期节点退订场景。 - renew：续费。 - toPeriodic：转包周期。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// **参数解释**：订单关联资源的变更状态。 **取值范围**：可选值如下： - processing：处理中，资源正在处理中。 - succeed：成功，资源处理成功。 - failed：失败，资源处理失败。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：资源开始变更时间戳，形如1744285793000，单位毫秒。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("beginTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTimestamp { get; set; }

        /// <summary>
        /// **参数解释**：资源变更最后更新时间戳，形如1744285793000，单位毫秒。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("updateTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTimestamp { get; set; }

        /// <summary>
        /// **参数解释**：资源变更的执行信息，如失败原因。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderDetailItem {\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  beginTimestamp: ").Append(BeginTimestamp).Append("\n");
            sb.Append("  updateTimestamp: ").Append(UpdateTimestamp).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrderDetailItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OrderDetailItem input)
        {
            if (input == null) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.BeginTimestamp != input.BeginTimestamp || (this.BeginTimestamp != null && !this.BeginTimestamp.Equals(input.BeginTimestamp))) return false;
            if (this.UpdateTimestamp != input.UpdateTimestamp || (this.UpdateTimestamp != null && !this.UpdateTimestamp.Equals(input.UpdateTimestamp))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;

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
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.BeginTimestamp != null) hashCode = hashCode * 59 + this.BeginTimestamp.GetHashCode();
                if (this.UpdateTimestamp != null) hashCode = hashCode * 59 + this.UpdateTimestamp.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
