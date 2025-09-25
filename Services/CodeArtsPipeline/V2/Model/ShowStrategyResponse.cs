using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowStrategyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 规则模板实例ID。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 规则模板实例名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 规则模板类型。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 规则模板策略。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释**： 策略创建人。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        /// **参数解释**： 策略创建时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// **参数解释**： 策略最近更新人。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("updater", NullValueHandling = NullValueHandling.Ignore)]
        public string Updater { get; set; }

        /// <summary>
        /// **参数解释**： 策略最近更新时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// **参数解释**： 策略是否生效。 **取值范围**： - true：策略生效。 - false：策略不生效。 
        /// </summary>
        [JsonProperty("is_valid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsValid { get; set; }

        /// <summary>
        /// **参数解释**： 规则实例集合。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("rule_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleInstance> RuleInstances { get; set; }

        /// <summary>
        /// **参数解释**： 规则实例生效级别。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        /// <summary>
        /// **参数解释**： 规则实例是否系统级。 **取值范围**： - true：规则实例是系统级。 - false：规则实例不是系统级。 
        /// </summary>
        [JsonProperty("is_public", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// **参数解释**： 规则实例是1.0的数据。 **取值范围**： - true：规则实例是1.0的数据。 - false：规则实例是1.0的数据。 
        /// </summary>
        [JsonProperty("is_legacy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLegacy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStrategyResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updater: ").Append(Updater).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  isValid: ").Append(IsValid).Append("\n");
            sb.Append("  ruleInstances: ").Append(RuleInstances).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  isPublic: ").Append(IsPublic).Append("\n");
            sb.Append("  isLegacy: ").Append(IsLegacy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStrategyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStrategyResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.Updater != input.Updater || (this.Updater != null && !this.Updater.Equals(input.Updater))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.IsValid != input.IsValid || (this.IsValid != null && !this.IsValid.Equals(input.IsValid))) return false;
            if (this.RuleInstances != input.RuleInstances || (this.RuleInstances != null && input.RuleInstances != null && !this.RuleInstances.SequenceEqual(input.RuleInstances))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.IsPublic != input.IsPublic || (this.IsPublic != null && !this.IsPublic.Equals(input.IsPublic))) return false;
            if (this.IsLegacy != input.IsLegacy || (this.IsLegacy != null && !this.IsLegacy.Equals(input.IsLegacy))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Updater != null) hashCode = hashCode * 59 + this.Updater.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.IsValid != null) hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                if (this.RuleInstances != null) hashCode = hashCode * 59 + this.RuleInstances.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.IsPublic != null) hashCode = hashCode * 59 + this.IsPublic.GetHashCode();
                if (this.IsLegacy != null) hashCode = hashCode * 59 + this.IsLegacy.GetHashCode();
                return hashCode;
            }
        }
    }
}
