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
    /// **参数解释**：训练作业配额项。
    /// </summary>
    public class ModifyTrainingQuotaItem 
    {

        /// <summary>
        /// **参数解释**：配额的资源类型。 **约束限制**：不涉及。 **取值范围**：枚举值如下： - job-num: 作业个数配额 - visual-job-num: 可视化作业个数配额 - job-retention-enabled: 用户级作业自动老化开关 - job-num-quota-notify: 配额告警SMN通知配置 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public string Resource { get; set; }

        /// <summary>
        /// **参数解释**：配额个数。 **约束限制**：取值约束因资源类型而异：job-retention-enabled取值0（关闭）或1（开启）；job-num-quota-notify固定为0，通知主题URN存于extra_info；其余资源类型要求不小于1。 **取值范围**：0 ~ 2147483647。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quota { get; set; }

        /// <summary>
        /// **参数解释**：已使用的个数。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("used", NullValueHandling = NullValueHandling.Ignore)]
        public int? Used { get; set; }

        /// <summary>
        /// **参数解释**：配额的额外信息。 **约束限制**：当resource为job-num-quota-notify时，该字段存储SMN通知主题URN。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("extra_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtraInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyTrainingQuotaItem {\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("  quota: ").Append(Quota).Append("\n");
            sb.Append("  used: ").Append(Used).Append("\n");
            sb.Append("  extraInfo: ").Append(ExtraInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyTrainingQuotaItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyTrainingQuotaItem input)
        {
            if (input == null) return false;
            if (this.Resource != input.Resource || (this.Resource != null && !this.Resource.Equals(input.Resource))) return false;
            if (this.Quota != input.Quota || (this.Quota != null && !this.Quota.Equals(input.Quota))) return false;
            if (this.Used != input.Used || (this.Used != null && !this.Used.Equals(input.Used))) return false;
            if (this.ExtraInfo != input.ExtraInfo || (this.ExtraInfo != null && !this.ExtraInfo.Equals(input.ExtraInfo))) return false;

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
                if (this.Resource != null) hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.Quota != null) hashCode = hashCode * 59 + this.Quota.GetHashCode();
                if (this.Used != null) hashCode = hashCode * 59 + this.Used.GetHashCode();
                if (this.ExtraInfo != null) hashCode = hashCode * 59 + this.ExtraInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
