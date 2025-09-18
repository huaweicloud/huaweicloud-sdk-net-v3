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
    /// 任务配置高级选项的请求信息
    /// </summary>
    public class UpdateTaskSettingsRequestBody 
    {

        /// <summary>
        /// 高级选项参数的相关信息
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
