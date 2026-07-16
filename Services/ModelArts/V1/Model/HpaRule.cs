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
    /// 自动扩缩容规则返回体
    /// </summary>
    public class HpaRule 
    {

        /// <summary>
        /// **参数解释：** 自动扩缩容规则ID **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容规则关联的策略ID **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("hpa_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HpaId { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容规则名 **取值范围：** 支持4-64个字符，可以包含字母、汉字、数字、中划线和下划线。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容类型。 **取值范围：** - CRON_HPA：定时扩缩容策略 - METRIC_HPA：指标扩缩容策略
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释：** 定时自动扩缩容执行的cron表达式，不支持秒，从分钟开始设定 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("schedule", NullValueHandling = NullValueHandling.Ignore)]
        public string Schedule { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容目标实例数。 **取值范围：** 1-128
        /// </summary>
        [JsonProperty("target_replicas", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetReplicas { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容规则是否启用。 **取值范围：** - false - true
        /// </summary>
        [JsonProperty("disable", NullValueHandling = NullValueHandling.Ignore)]
        public string Disable { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容规则状态。 **取值范围：** - CREATING：创建中 - CONFIG_SUCCESS：配置成功 - EXECUTE_SUCCESS：执行成功 - DELETED：已删除 - FAILED: 执行失败
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HpaRule {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  hpaId: ").Append(HpaId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  schedule: ").Append(Schedule).Append("\n");
            sb.Append("  targetReplicas: ").Append(TargetReplicas).Append("\n");
            sb.Append("  disable: ").Append(Disable).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HpaRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HpaRule input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.HpaId != input.HpaId || (this.HpaId != null && !this.HpaId.Equals(input.HpaId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Schedule != input.Schedule || (this.Schedule != null && !this.Schedule.Equals(input.Schedule))) return false;
            if (this.TargetReplicas != input.TargetReplicas || (this.TargetReplicas != null && !this.TargetReplicas.Equals(input.TargetReplicas))) return false;
            if (this.Disable != input.Disable || (this.Disable != null && !this.Disable.Equals(input.Disable))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.HpaId != null) hashCode = hashCode * 59 + this.HpaId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Schedule != null) hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.TargetReplicas != null) hashCode = hashCode * 59 + this.TargetReplicas.GetHashCode();
                if (this.Disable != null) hashCode = hashCode * 59 + this.Disable.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
