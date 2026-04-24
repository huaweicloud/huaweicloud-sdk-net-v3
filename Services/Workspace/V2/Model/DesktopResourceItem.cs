using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 桌面资源包。
    /// </summary>
    public class DesktopResourceItem 
    {

        /// <summary>
        /// 资源包名称。
        /// </summary>
        [JsonProperty("resource_package_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourcePackageName { get; set; }

        /// <summary>
        /// 桌面产品编码。
        /// </summary>
        [JsonProperty("desktop_resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopResourceSpecCode { get; set; }

        /// <summary>
        /// 资源包产品编码。
        /// </summary>
        [JsonProperty("resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }

        /// <summary>
        /// 生效时间，格式：yyyy-MM-ddTHH:mm:ssZ（2025-04-12T17:30:00Z）。
        /// </summary>
        [JsonProperty("effective_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 是否自动续订。
        /// </summary>
        [JsonProperty("is_auto_renew", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsAutoRenew { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopResourceItem {\n");
            sb.Append("  resourcePackageName: ").Append(ResourcePackageName).Append("\n");
            sb.Append("  desktopResourceSpecCode: ").Append(DesktopResourceSpecCode).Append("\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
            sb.Append("  effectiveTime: ").Append(EffectiveTime).Append("\n");
            sb.Append("  isAutoRenew: ").Append(IsAutoRenew).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DesktopResourceItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DesktopResourceItem input)
        {
            if (input == null) return false;
            if (this.ResourcePackageName != input.ResourcePackageName || (this.ResourcePackageName != null && !this.ResourcePackageName.Equals(input.ResourcePackageName))) return false;
            if (this.DesktopResourceSpecCode != input.DesktopResourceSpecCode || (this.DesktopResourceSpecCode != null && !this.DesktopResourceSpecCode.Equals(input.DesktopResourceSpecCode))) return false;
            if (this.ResourceSpecCode != input.ResourceSpecCode || (this.ResourceSpecCode != null && !this.ResourceSpecCode.Equals(input.ResourceSpecCode))) return false;
            if (this.EffectiveTime != input.EffectiveTime || (this.EffectiveTime != null && !this.EffectiveTime.Equals(input.EffectiveTime))) return false;
            if (this.IsAutoRenew != input.IsAutoRenew || (this.IsAutoRenew != null && !this.IsAutoRenew.Equals(input.IsAutoRenew))) return false;

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
                if (this.ResourcePackageName != null) hashCode = hashCode * 59 + this.ResourcePackageName.GetHashCode();
                if (this.DesktopResourceSpecCode != null) hashCode = hashCode * 59 + this.DesktopResourceSpecCode.GetHashCode();
                if (this.ResourceSpecCode != null) hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                if (this.EffectiveTime != null) hashCode = hashCode * 59 + this.EffectiveTime.GetHashCode();
                if (this.IsAutoRenew != null) hashCode = hashCode * 59 + this.IsAutoRenew.GetHashCode();
                return hashCode;
            }
        }
    }
}
