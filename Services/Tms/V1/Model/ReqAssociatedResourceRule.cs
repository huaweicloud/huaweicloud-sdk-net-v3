using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Tms.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ReqAssociatedResourceRule 
    {

        /// <summary>
        /// 规则配置名称
        /// </summary>
        [JsonProperty("setting_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SettingName { get; set; }

        /// <summary>
        /// 标签键列表
        /// </summary>
        [JsonProperty("tag_keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TagKeys { get; set; }

        /// <summary>
        /// 存量资源生效状态：enable、disable
        /// </summary>
        [JsonProperty("existing_resource_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ExistingResourceStatus { get; set; }

        /// <summary>
        /// 关系解除后自动删除能力状态：enable、disable
        /// </summary>
        [JsonProperty("auto_delete_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AutoDeleteStatus { get; set; }

        /// <summary>
        /// 规则生效的regionId
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReqAssociatedResourceRule {\n");
            sb.Append("  settingName: ").Append(SettingName).Append("\n");
            sb.Append("  tagKeys: ").Append(TagKeys).Append("\n");
            sb.Append("  existingResourceStatus: ").Append(ExistingResourceStatus).Append("\n");
            sb.Append("  autoDeleteStatus: ").Append(AutoDeleteStatus).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReqAssociatedResourceRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReqAssociatedResourceRule input)
        {
            if (input == null) return false;
            if (this.SettingName != input.SettingName || (this.SettingName != null && !this.SettingName.Equals(input.SettingName))) return false;
            if (this.TagKeys != input.TagKeys || (this.TagKeys != null && input.TagKeys != null && !this.TagKeys.SequenceEqual(input.TagKeys))) return false;
            if (this.ExistingResourceStatus != input.ExistingResourceStatus || (this.ExistingResourceStatus != null && !this.ExistingResourceStatus.Equals(input.ExistingResourceStatus))) return false;
            if (this.AutoDeleteStatus != input.AutoDeleteStatus || (this.AutoDeleteStatus != null && !this.AutoDeleteStatus.Equals(input.AutoDeleteStatus))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;

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
                if (this.SettingName != null) hashCode = hashCode * 59 + this.SettingName.GetHashCode();
                if (this.TagKeys != null) hashCode = hashCode * 59 + this.TagKeys.GetHashCode();
                if (this.ExistingResourceStatus != null) hashCode = hashCode * 59 + this.ExistingResourceStatus.GetHashCode();
                if (this.AutoDeleteStatus != null) hashCode = hashCode * 59 + this.AutoDeleteStatus.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
