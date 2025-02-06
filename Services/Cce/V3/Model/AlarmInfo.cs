using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// **参数解释：** 告警助手参数配置。基于AOM服务的告警能力实现，提供集群内的告警快速检索、告警快速配置的能力，告警中心的指标类告警规则依赖云原生监控插件上报数据到AOM实例。 **约束限制：** 不涉及
    /// </summary>
    public class AlarmInfo 
    {

        /// <summary>
        /// **参数解释：** 联系组列表。填写SMN主题名称，通过配置告警联系组，分组管理订阅终端，接收告警信息。 **约束限制：** 不涉及
        /// </summary>
        [JsonProperty("topics", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Topics { get; set; }

        /// <summary>
        /// **参数解释：** 开启告警助手时传入告警模板ID。默认采用容器场景下的告警规则模板。 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("alarmRuleTemplateId", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleTemplateId { get; set; }

        /// <summary>
        /// **参数解释：** 开启告警助手时传入AOM普罗实例的id。若未安装普罗插件或者未对接AOM实例，此参数无需指定，告警中心将不会创建指标类告警规则。 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("promInstanceID", NullValueHandling = NullValueHandling.Ignore)]
        public string PromInstanceID { get; set; }

        /// <summary>
        /// **参数解释：** 开启告警助手时传入AOM普罗实例的企业项目id。若未安装普罗插件或者未对接AOM实例，此参数无需指定，告警中心将不会创建指标类告警规则。 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("promEnterpriseProjectID", NullValueHandling = NullValueHandling.Ignore)]
        public string PromEnterpriseProjectID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmInfo {\n");
            sb.Append("  topics: ").Append(Topics).Append("\n");
            sb.Append("  alarmRuleTemplateId: ").Append(AlarmRuleTemplateId).Append("\n");
            sb.Append("  promInstanceID: ").Append(PromInstanceID).Append("\n");
            sb.Append("  promEnterpriseProjectID: ").Append(PromEnterpriseProjectID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmInfo input)
        {
            if (input == null) return false;
            if (this.Topics != input.Topics || (this.Topics != null && input.Topics != null && !this.Topics.SequenceEqual(input.Topics))) return false;
            if (this.AlarmRuleTemplateId != input.AlarmRuleTemplateId || (this.AlarmRuleTemplateId != null && !this.AlarmRuleTemplateId.Equals(input.AlarmRuleTemplateId))) return false;
            if (this.PromInstanceID != input.PromInstanceID || (this.PromInstanceID != null && !this.PromInstanceID.Equals(input.PromInstanceID))) return false;
            if (this.PromEnterpriseProjectID != input.PromEnterpriseProjectID || (this.PromEnterpriseProjectID != null && !this.PromEnterpriseProjectID.Equals(input.PromEnterpriseProjectID))) return false;

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
                if (this.Topics != null) hashCode = hashCode * 59 + this.Topics.GetHashCode();
                if (this.AlarmRuleTemplateId != null) hashCode = hashCode * 59 + this.AlarmRuleTemplateId.GetHashCode();
                if (this.PromInstanceID != null) hashCode = hashCode * 59 + this.PromInstanceID.GetHashCode();
                if (this.PromEnterpriseProjectID != null) hashCode = hashCode * 59 + this.PromEnterpriseProjectID.GetHashCode();
                return hashCode;
            }
        }
    }
}
