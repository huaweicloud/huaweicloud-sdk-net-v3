using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 工作项字段值
    /// </summary>
    public class WorkItemFlowFieldValueVO 
    {

        /// <summary>
        /// 引用属性名
        /// </summary>
        [JsonProperty("ref_prop", NullValueHandling = NullValueHandling.Ignore)]
        public string RefProp { get; set; }

        /// <summary>
        /// 配置值对象列表
        /// </summary>
        [JsonProperty("setting_val_object", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, Object>> SettingValObject { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemFlowFieldValueVO {\n");
            sb.Append("  refProp: ").Append(RefProp).Append("\n");
            sb.Append("  settingValObject: ").Append(SettingValObject).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkItemFlowFieldValueVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkItemFlowFieldValueVO input)
        {
            if (input == null) return false;
            if (this.RefProp != input.RefProp || (this.RefProp != null && !this.RefProp.Equals(input.RefProp))) return false;
            if (this.SettingValObject != input.SettingValObject || (this.SettingValObject != null && input.SettingValObject != null && !this.SettingValObject.SequenceEqual(input.SettingValObject))) return false;

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
                if (this.RefProp != null) hashCode = hashCode * 59 + this.RefProp.GetHashCode();
                if (this.SettingValObject != null) hashCode = hashCode * 59 + this.SettingValObject.GetHashCode();
                return hashCode;
            }
        }
    }
}
