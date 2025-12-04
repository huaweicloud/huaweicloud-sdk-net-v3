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
    public class InstanceRecycleInfo 
    {

        /// <summary>
        /// **参数解释**： 实例ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 实例状态。  **取值范围**： 详细状态说明请参考[实例状态说明](kafka-api-180514012.xml)。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**： 实例名称。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 引擎。  **取值范围**： kafka。
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public string Engine { get; set; }

        /// <summary>
        /// **参数解释**： 回收时间。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("in_recycle_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? InRecycleTime { get; set; }

        /// <summary>
        /// **参数解释**： 保留时间。  **取值范围**： 1~7天。
        /// </summary>
        [JsonProperty("save_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? SaveTime { get; set; }

        /// <summary>
        /// **参数解释**： 自动删除时间。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("auto_delete_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? AutoDeleteTime { get; set; }

        /// <summary>
        /// **参数解释**： 每小时的费用。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("cost_per_hour", NullValueHandling = NullValueHandling.Ignore)]
        public double? CostPerHour { get; set; }

        /// <summary>
        /// **参数解释**： 错误信息。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// **参数解释**： 产品ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceRecycleInfo {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  inRecycleTime: ").Append(InRecycleTime).Append("\n");
            sb.Append("  saveTime: ").Append(SaveTime).Append("\n");
            sb.Append("  autoDeleteTime: ").Append(AutoDeleteTime).Append("\n");
            sb.Append("  costPerHour: ").Append(CostPerHour).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceRecycleInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceRecycleInfo input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Engine != input.Engine || (this.Engine != null && !this.Engine.Equals(input.Engine))) return false;
            if (this.InRecycleTime != input.InRecycleTime || (this.InRecycleTime != null && !this.InRecycleTime.Equals(input.InRecycleTime))) return false;
            if (this.SaveTime != input.SaveTime || (this.SaveTime != null && !this.SaveTime.Equals(input.SaveTime))) return false;
            if (this.AutoDeleteTime != input.AutoDeleteTime || (this.AutoDeleteTime != null && !this.AutoDeleteTime.Equals(input.AutoDeleteTime))) return false;
            if (this.CostPerHour != input.CostPerHour || (this.CostPerHour != null && !this.CostPerHour.Equals(input.CostPerHour))) return false;
            if (this.ErrorMessage != input.ErrorMessage || (this.ErrorMessage != null && !this.ErrorMessage.Equals(input.ErrorMessage))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Engine != null) hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.InRecycleTime != null) hashCode = hashCode * 59 + this.InRecycleTime.GetHashCode();
                if (this.SaveTime != null) hashCode = hashCode * 59 + this.SaveTime.GetHashCode();
                if (this.AutoDeleteTime != null) hashCode = hashCode * 59 + this.AutoDeleteTime.GetHashCode();
                if (this.CostPerHour != null) hashCode = hashCode * 59 + this.CostPerHour.GetHashCode();
                if (this.ErrorMessage != null) hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                return hashCode;
            }
        }
    }
}
