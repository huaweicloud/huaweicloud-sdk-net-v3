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
    /// Request Object
    /// </summary>
    public class ListInstanceBackupSummaryRequest 
    {

        /// <summary>
        /// **参数解释**：  引擎类型。只支持筛选RDS for MySQL,RDS for MariaDB, TaurusDB标准版引擎  **约束限制**：  不涉及。  **取值范围**：  - mysql - mariadb - taurusdb  **默认取值**：  不涉及。
        /// </summary>
        [SDKProperty("engine", IsQuery = true)]
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public string Engine { get; set; }

        /// <summary>
        /// **参数解释**：  排序字段。 根据指定字段排序查询结果。  **约束限制**：  不涉及。  **取值范围**： - backup_used_space:根据备份数据总量排序 - obs ：根据日志备份用量排序  **默认取值**：  不涉及。
        /// </summary>
        [SDKProperty("order_field", IsQuery = true)]
        [JsonProperty("order_field", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderField { get; set; }

        /// <summary>
        /// **参数解释**：  排序规则。  **约束限制**：  不涉及。  **取值范围**：  - ASC ： 根据排序字段升序 - DESC ：根据排序字段降序  **默认取值**：  DESC
        /// </summary>
        [SDKProperty("order_rule", IsQuery = true)]
        [JsonProperty("order_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderRule { get; set; }

        /// <summary>
        /// **参数解释**：  实例ID。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**：  实例名称。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [SDKProperty("instance_name", IsQuery = true)]
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// **参数解释**：  索引位置，偏移量。从第一条数据偏移offset条数据后开始查询。  **约束限制**：  必须为数字，不能为负数。  **取值范围**：  大于等于0的整数。  **默认取值**：  0。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释**：  查询记录数。  **约束限制**：  不涉及。  **取值范围**：  默认为10，不能为负数，最小值为1，最大值为50。  **默认取值**：  10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**：  请求语言类型。  **约束限制**：  不涉及。  **取值范围**：  - en-us - zh-cn **默认取值**：  en-us。
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceBackupSummaryRequest {\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  orderField: ").Append(OrderField).Append("\n");
            sb.Append("  orderRule: ").Append(OrderRule).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceBackupSummaryRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceBackupSummaryRequest input)
        {
            if (input == null) return false;
            if (this.Engine != input.Engine || (this.Engine != null && !this.Engine.Equals(input.Engine))) return false;
            if (this.OrderField != input.OrderField || (this.OrderField != null && !this.OrderField.Equals(input.OrderField))) return false;
            if (this.OrderRule != input.OrderRule || (this.OrderRule != null && !this.OrderRule.Equals(input.OrderRule))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;

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
                if (this.Engine != null) hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.OrderField != null) hashCode = hashCode * 59 + this.OrderField.GetHashCode();
                if (this.OrderRule != null) hashCode = hashCode * 59 + this.OrderRule.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.XLanguage != null) hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                return hashCode;
            }
        }
    }
}
