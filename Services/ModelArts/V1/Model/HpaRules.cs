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
    /// 自动扩缩容规则
    /// </summary>
    public class HpaRules 
    {

        /// <summary>
        /// **参数解释：** 自动扩缩容规则名。 **取值范围：** 支持4-64个字符，可以包含小写字母、数字和中划线，必须以小写字母开头，不能以中划线结尾。 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容id **取值范围：** 支持4-64个字符，可以包含字母、汉字、数字、中划线和下划线。 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容规则是否启用。 **取值范围：** - false：启动 - true：不启动 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("disable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disable { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容类型。 **取值范围：** - CRON_HPA：定时扩缩容策略 - METRIC_HPA：指标扩缩容策略 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容类型。 **取值范围：** - CREATING：创建扩缩容策略 - CONFIG_SUCCESS：配置成功扩缩容策略 - EXECUTE_SUCCESS：执行成功扩缩容策略 - DELETED：删除扩缩容策略 - FAILED：失败扩缩容策略 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容类型。 **取值范围：** - ADD：添加扩缩容策略规则 - UPDATE：修改扩缩容策略规则 - DELETE：删除扩缩容策略规则 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("operate", NullValueHandling = NullValueHandling.Ignore)]
        public string Operate { get; set; }

        /// <summary>
        /// **参数解释：** 定时自动扩缩容执行的cron表达式，不支持秒，从分钟开始设定 **取值范围：** 不涉及。 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("schedule", NullValueHandling = NullValueHandling.Ignore)]
        public string Schedule { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容目标实例数。 **取值范围：** 1-128，接口能接受浮点类型，后端会自动向下取整 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("target_replicas", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetReplicas { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容最小实例数。 **取值范围：** 1-128，接口能接受浮点类型，后端会自动向下取整 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("min_replicas", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinReplicas { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容最大实例数。 **取值范围：** 1-128，接口能接受浮点类型，后端会自动向下取整 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("max_replicas", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxReplicas { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容扩容冷却时间。 **取值范围：** 1-128，接口能接受浮点类型，后端会自动向下取整 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("downscale_window", NullValueHandling = NullValueHandling.Ignore)]
        public int? DownscaleWindow { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容缩容冷却时间。 **取值范围：** 1-128，接口能接受浮点类型，后端会自动向下取整 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("upscale_window", NullValueHandling = NullValueHandling.Ignore)]
        public int? UpscaleWindow { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HpaRules {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  disable: ").Append(Disable).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  operate: ").Append(Operate).Append("\n");
            sb.Append("  schedule: ").Append(Schedule).Append("\n");
            sb.Append("  targetReplicas: ").Append(TargetReplicas).Append("\n");
            sb.Append("  minReplicas: ").Append(MinReplicas).Append("\n");
            sb.Append("  maxReplicas: ").Append(MaxReplicas).Append("\n");
            sb.Append("  downscaleWindow: ").Append(DownscaleWindow).Append("\n");
            sb.Append("  upscaleWindow: ").Append(UpscaleWindow).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HpaRules);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HpaRules input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Disable != input.Disable || (this.Disable != null && !this.Disable.Equals(input.Disable))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Operate != input.Operate || (this.Operate != null && !this.Operate.Equals(input.Operate))) return false;
            if (this.Schedule != input.Schedule || (this.Schedule != null && !this.Schedule.Equals(input.Schedule))) return false;
            if (this.TargetReplicas != input.TargetReplicas || (this.TargetReplicas != null && !this.TargetReplicas.Equals(input.TargetReplicas))) return false;
            if (this.MinReplicas != input.MinReplicas || (this.MinReplicas != null && !this.MinReplicas.Equals(input.MinReplicas))) return false;
            if (this.MaxReplicas != input.MaxReplicas || (this.MaxReplicas != null && !this.MaxReplicas.Equals(input.MaxReplicas))) return false;
            if (this.DownscaleWindow != input.DownscaleWindow || (this.DownscaleWindow != null && !this.DownscaleWindow.Equals(input.DownscaleWindow))) return false;
            if (this.UpscaleWindow != input.UpscaleWindow || (this.UpscaleWindow != null && !this.UpscaleWindow.Equals(input.UpscaleWindow))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Disable != null) hashCode = hashCode * 59 + this.Disable.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Operate != null) hashCode = hashCode * 59 + this.Operate.GetHashCode();
                if (this.Schedule != null) hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.TargetReplicas != null) hashCode = hashCode * 59 + this.TargetReplicas.GetHashCode();
                if (this.MinReplicas != null) hashCode = hashCode * 59 + this.MinReplicas.GetHashCode();
                if (this.MaxReplicas != null) hashCode = hashCode * 59 + this.MaxReplicas.GetHashCode();
                if (this.DownscaleWindow != null) hashCode = hashCode * 59 + this.DownscaleWindow.GetHashCode();
                if (this.UpscaleWindow != null) hashCode = hashCode * 59 + this.UpscaleWindow.GetHashCode();
                return hashCode;
            }
        }
    }
}
