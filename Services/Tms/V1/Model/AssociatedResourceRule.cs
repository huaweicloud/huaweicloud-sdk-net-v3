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
    /// 规则信息
    /// </summary>
    public class AssociatedResourceRule 
    {

        /// <summary>
        /// 规则的配置名称
        /// </summary>
        [JsonProperty("setting_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SettingName { get; set; }

        /// <summary>
        /// 规则作的用标签范围。如果为空则表示对全部标签生效。
        /// </summary>
        [JsonProperty("tag_keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TagKeys { get; set; }

        /// <summary>
        /// 特性开关，规则是否在存量资源生效。
        /// </summary>
        [JsonProperty("existing_resource_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ExistingResourceStatus { get; set; }

        /// <summary>
        /// 特性开关，主资源与子资源关系解除后是否自动删除子资源中与主资源标签键一致的标签。
        /// </summary>
        [JsonProperty("auto_delete_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AutoDeleteStatus { get; set; }

        /// <summary>
        /// 规则状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 规则生效的区域Id
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociatedResourceRule {\n");
            sb.Append("  settingName: ").Append(SettingName).Append("\n");
            sb.Append("  tagKeys: ").Append(TagKeys).Append("\n");
            sb.Append("  existingResourceStatus: ").Append(ExistingResourceStatus).Append("\n");
            sb.Append("  autoDeleteStatus: ").Append(AutoDeleteStatus).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociatedResourceRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociatedResourceRule input)
        {
            if (input == null) return false;
            if (this.SettingName != input.SettingName || (this.SettingName != null && !this.SettingName.Equals(input.SettingName))) return false;
            if (this.TagKeys != input.TagKeys || (this.TagKeys != null && input.TagKeys != null && !this.TagKeys.SequenceEqual(input.TagKeys))) return false;
            if (this.ExistingResourceStatus != input.ExistingResourceStatus || (this.ExistingResourceStatus != null && !this.ExistingResourceStatus.Equals(input.ExistingResourceStatus))) return false;
            if (this.AutoDeleteStatus != input.AutoDeleteStatus || (this.AutoDeleteStatus != null && !this.AutoDeleteStatus.Equals(input.AutoDeleteStatus))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
