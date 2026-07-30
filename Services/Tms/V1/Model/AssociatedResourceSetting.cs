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
    /// 规则的配置信息
    /// </summary>
    public class AssociatedResourceSetting 
    {

        /// <summary>
        /// 规则的配置名称
        /// </summary>
        [JsonProperty("setting_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SettingName { get; set; }

        /// <summary>
        /// 主资源
        /// </summary>
        [JsonProperty("master_service", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterService { get; set; }

        /// <summary>
        /// 主资源类型
        /// </summary>
        [JsonProperty("master_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterResourceType { get; set; }

        /// <summary>
        /// 关联资源
        /// </summary>
        [JsonProperty("associated_service", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociatedService { get; set; }

        /// <summary>
        /// 关联资源类型
        /// </summary>
        [JsonProperty("associated_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociatedResourceType { get; set; }

        /// <summary>
        /// 是否规则是对存量资源生效。
        /// </summary>
        [JsonProperty("support_existing_resource", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportExistingResource { get; set; }

        /// <summary>
        /// 是否支持关系解除后自动删除标签。
        /// </summary>
        [JsonProperty("support_auto_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportAutoDelete { get; set; }

        /// <summary>
        /// 规则配置支持的区域Id。
        /// </summary>
        [JsonProperty("region_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RegionIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociatedResourceSetting {\n");
            sb.Append("  settingName: ").Append(SettingName).Append("\n");
            sb.Append("  masterService: ").Append(MasterService).Append("\n");
            sb.Append("  masterResourceType: ").Append(MasterResourceType).Append("\n");
            sb.Append("  associatedService: ").Append(AssociatedService).Append("\n");
            sb.Append("  associatedResourceType: ").Append(AssociatedResourceType).Append("\n");
            sb.Append("  supportExistingResource: ").Append(SupportExistingResource).Append("\n");
            sb.Append("  supportAutoDelete: ").Append(SupportAutoDelete).Append("\n");
            sb.Append("  regionIds: ").Append(RegionIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociatedResourceSetting);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociatedResourceSetting input)
        {
            if (input == null) return false;
            if (this.SettingName != input.SettingName || (this.SettingName != null && !this.SettingName.Equals(input.SettingName))) return false;
            if (this.MasterService != input.MasterService || (this.MasterService != null && !this.MasterService.Equals(input.MasterService))) return false;
            if (this.MasterResourceType != input.MasterResourceType || (this.MasterResourceType != null && !this.MasterResourceType.Equals(input.MasterResourceType))) return false;
            if (this.AssociatedService != input.AssociatedService || (this.AssociatedService != null && !this.AssociatedService.Equals(input.AssociatedService))) return false;
            if (this.AssociatedResourceType != input.AssociatedResourceType || (this.AssociatedResourceType != null && !this.AssociatedResourceType.Equals(input.AssociatedResourceType))) return false;
            if (this.SupportExistingResource != input.SupportExistingResource || (this.SupportExistingResource != null && !this.SupportExistingResource.Equals(input.SupportExistingResource))) return false;
            if (this.SupportAutoDelete != input.SupportAutoDelete || (this.SupportAutoDelete != null && !this.SupportAutoDelete.Equals(input.SupportAutoDelete))) return false;
            if (this.RegionIds != input.RegionIds || (this.RegionIds != null && input.RegionIds != null && !this.RegionIds.SequenceEqual(input.RegionIds))) return false;

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
                if (this.MasterService != null) hashCode = hashCode * 59 + this.MasterService.GetHashCode();
                if (this.MasterResourceType != null) hashCode = hashCode * 59 + this.MasterResourceType.GetHashCode();
                if (this.AssociatedService != null) hashCode = hashCode * 59 + this.AssociatedService.GetHashCode();
                if (this.AssociatedResourceType != null) hashCode = hashCode * 59 + this.AssociatedResourceType.GetHashCode();
                if (this.SupportExistingResource != null) hashCode = hashCode * 59 + this.SupportExistingResource.GetHashCode();
                if (this.SupportAutoDelete != null) hashCode = hashCode * 59 + this.SupportAutoDelete.GetHashCode();
                if (this.RegionIds != null) hashCode = hashCode * 59 + this.RegionIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
