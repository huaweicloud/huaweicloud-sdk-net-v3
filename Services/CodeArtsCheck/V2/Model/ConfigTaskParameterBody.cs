using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// **参数解释：** 任务配置检查参数请求信息。 **取值范围：** 不涉及。
    /// </summary>
    public class ConfigTaskParameterBody 
    {

        /// <summary>
        /// **参数解释：** 参数已废弃，默认填写0即可。 **约束限制:** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("check_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CheckId { get; set; }

        /// <summary>
        /// **参数解释:** 兼容历史版本的废弃参数，不校验真实性。规则集ID，通过[[查询规则集列表](https://support.huaweicloud.com/api-codecheck/ListRulesets.html)](tag:hws)[[查询规则集列表](https://support.huaweicloud.com/intl/zh-cn/api-codecheck/ListRulesets.html)](tag:hws_hk)[查询规则集列表](tag:hcs,hcs_sm,hcs_site,hcs_sitesm,fcs)接口可获取到规则集ID。 **约束限制:** 不涉及。 **取值范围:** 长度为[1~32]个字符。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("ruleset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RulesetId { get; set; }

        /// <summary>
        /// **参数解释:** 兼容历史版本的废弃参数，不校验真实性。规则集对应语言，通过[[查询规则集列表](https://support.huaweicloud.com/api-codecheck/ListRulesets.html)](tag:hws)[[查询规则集列表](https://support.huaweicloud.com/intl/zh-cn/api-codecheck/ListRulesets.html)](tag:hws_hk)[查询规则集列表](tag:hcs,hcs_sm,hcs_site,hcs_sitesm,fcs)接口可获取到规则集ID对应的语言。 **约束限制:** 不涉及。 **取值范围:** 与ruleset_id规则集的语言对应。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// **参数解释:** 当前规则集对应的编译配置总开关。 **约束限制:** 不涉及。 **取值范围:** - off：关闭。 - on：打开。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释:** 数组类型，当前规则集对应编译配置具体详情，可基于web页面查看当前规则集所涉及的编译配置，多个参数配置多条即可。 **约束限制:** 不涉及。
        /// </summary>
        [JsonProperty("task_check_settings", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskCheckSettingsItem> TaskCheckSettings { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigTaskParameterBody {\n");
            sb.Append("  checkId: ").Append(CheckId).Append("\n");
            sb.Append("  rulesetId: ").Append(RulesetId).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  taskCheckSettings: ").Append(TaskCheckSettings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigTaskParameterBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigTaskParameterBody input)
        {
            if (input == null) return false;
            if (this.CheckId != input.CheckId || (this.CheckId != null && !this.CheckId.Equals(input.CheckId))) return false;
            if (this.RulesetId != input.RulesetId || (this.RulesetId != null && !this.RulesetId.Equals(input.RulesetId))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.TaskCheckSettings != input.TaskCheckSettings || (this.TaskCheckSettings != null && input.TaskCheckSettings != null && !this.TaskCheckSettings.SequenceEqual(input.TaskCheckSettings))) return false;

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
                if (this.CheckId != null) hashCode = hashCode * 59 + this.CheckId.GetHashCode();
                if (this.RulesetId != null) hashCode = hashCode * 59 + this.RulesetId.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TaskCheckSettings != null) hashCode = hashCode * 59 + this.TaskCheckSettings.GetHashCode();
                return hashCode;
            }
        }
    }
}
