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
    /// 任务配置检查参数请求信息
    /// </summary>
    public class ConfigTaskParameterBody 
    {

        /// <summary>
        /// 检查工具ID
        /// </summary>
        [JsonProperty("check_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CheckId { get; set; }

        /// <summary>
        /// 规则集ID
        /// </summary>
        [JsonProperty("ruleset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RulesetId { get; set; }

        /// <summary>
        /// 规则集语言
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// off：关闭，on：开启
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 检查参数信息
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
