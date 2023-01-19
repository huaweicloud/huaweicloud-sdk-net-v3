using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowRuleResponse : SdkResponse
    {

        /// <summary>
        /// 规则id。
        /// </summary>
        [JsonProperty("rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleId { get; set; }

        /// <summary>
        /// 规则名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 规则的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("condition_group", NullValueHandling = NullValueHandling.Ignore)]
        public ConditionGroup ConditionGroup { get; set; }

        /// <summary>
        /// 规则的动作列表，单个规则最多支持设置10个动作。
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleAction> Actions { get; set; }

        /// <summary>
        /// 规则的类型 - DEVICE_LINKAGE：云端联动规则。 - DEVICE_SIDE：端侧规则。
        /// </summary>
        [JsonProperty("rule_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleType { get; set; }

        /// <summary>
        /// 规则的状态，默认值：active。 - active：激活。 - inactive：未激活。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 资源空间ID。此参数为非必选参数，存在多资源空间的用户需要使用该接口时，建议携带该参数指定创建的规则归属到哪个资源空间下，否则创建的规则将会归属到[[默认资源空间](https://support.huaweicloud.com/usermanual-iothub/iot_01_0006.html#section0)](tag:hws)[[默认资源空间](https://support.huaweicloud.com/intl/zh-cn/usermanual-iothub/iot_01_0006.html#section0)](tag:hws_hk)下。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 归属边缘侧节点设备ID列表。
        /// </summary>
        [JsonProperty("edge_node_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EdgeNodeIds { get; set; }

        /// <summary>
        /// 规则最后更新时间，使用UTC时区，格式：yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;。
        /// </summary>
        [JsonProperty("last_update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("device_side", NullValueHandling = NullValueHandling.Ignore)]
        public DeviceSide DeviceSide { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRuleResponse {\n");
            sb.Append("  ruleId: ").Append(RuleId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  conditionGroup: ").Append(ConditionGroup).Append("\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("  ruleType: ").Append(RuleType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  edgeNodeIds: ").Append(EdgeNodeIds).Append("\n");
            sb.Append("  lastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  deviceSide: ").Append(DeviceSide).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRuleResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RuleId == input.RuleId ||
                    (this.RuleId != null &&
                    this.RuleId.Equals(input.RuleId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ConditionGroup == input.ConditionGroup ||
                    (this.ConditionGroup != null &&
                    this.ConditionGroup.Equals(input.ConditionGroup))
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    this.RuleType == input.RuleType ||
                    (this.RuleType != null &&
                    this.RuleType.Equals(input.RuleType))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.EdgeNodeIds == input.EdgeNodeIds ||
                    this.EdgeNodeIds != null &&
                    input.EdgeNodeIds != null &&
                    this.EdgeNodeIds.SequenceEqual(input.EdgeNodeIds)
                ) && 
                (
                    this.LastUpdateTime == input.LastUpdateTime ||
                    (this.LastUpdateTime != null &&
                    this.LastUpdateTime.Equals(input.LastUpdateTime))
                ) && 
                (
                    this.DeviceSide == input.DeviceSide ||
                    (this.DeviceSide != null &&
                    this.DeviceSide.Equals(input.DeviceSide))
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
                if (this.RuleId != null)
                    hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ConditionGroup != null)
                    hashCode = hashCode * 59 + this.ConditionGroup.GetHashCode();
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.RuleType != null)
                    hashCode = hashCode * 59 + this.RuleType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.EdgeNodeIds != null)
                    hashCode = hashCode * 59 + this.EdgeNodeIds.GetHashCode();
                if (this.LastUpdateTime != null)
                    hashCode = hashCode * 59 + this.LastUpdateTime.GetHashCode();
                if (this.DeviceSide != null)
                    hashCode = hashCode * 59 + this.DeviceSide.GetHashCode();
                return hashCode;
            }
        }
    }
}
