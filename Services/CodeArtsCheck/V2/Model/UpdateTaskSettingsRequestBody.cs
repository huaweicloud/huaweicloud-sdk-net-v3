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
    /// **参数解释：** 高级配置参数的相关信息，数组不能为空。 **约束限制：** 不涉及。
    /// </summary>
    public class UpdateTaskSettingsRequestBody 
    {

        /// <summary>
        /// **参数解释：** 高级配置参数的相关信息，数组不能为空。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("task_advanced_settings", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskAdvancedSettingsItem> TaskAdvancedSettings { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTaskSettingsRequestBody {\n");
            sb.Append("  taskAdvancedSettings: ").Append(TaskAdvancedSettings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTaskSettingsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTaskSettingsRequestBody input)
        {
            if (input == null) return false;
            if (this.TaskAdvancedSettings != input.TaskAdvancedSettings || (this.TaskAdvancedSettings != null && input.TaskAdvancedSettings != null && !this.TaskAdvancedSettings.SequenceEqual(input.TaskAdvancedSettings))) return false;

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
                if (this.TaskAdvancedSettings != null) hashCode = hashCode * 59 + this.TaskAdvancedSettings.GetHashCode();
                return hashCode;
            }
        }
    }
}
