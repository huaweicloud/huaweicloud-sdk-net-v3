using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListAddonTemplatesRequest 
    {

        /// <summary>
        /// 插件包版本号
        /// </summary>
        [SDKProperty("version", IsQuery = true)]
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 是否获取集群内创建的最新状态
        /// </summary>
        [SDKProperty("newest", IsQuery = true)]
        [JsonProperty("newest", NullValueHandling = NullValueHandling.Ignore)]
        public string Newest { get; set; }

        /// <summary>
        /// 集群id
        /// </summary>
        [SDKProperty("cluster_id", IsQuery = true)]
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 插件模板名称
        /// </summary>
        [SDKProperty("addon_template_name", IsQuery = true)]
        [JsonProperty("addon_template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AddonTemplateName { get; set; }

        /// <summary>
        /// 插件的最低版本
        /// </summary>
        [SDKProperty("base_update_addon_version", IsQuery = true)]
        [JsonProperty("base_update_addon_version", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseUpdateAddonVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAddonTemplatesRequest {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  newest: ").Append(Newest).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  addonTemplateName: ").Append(AddonTemplateName).Append("\n");
            sb.Append("  baseUpdateAddonVersion: ").Append(BaseUpdateAddonVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAddonTemplatesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAddonTemplatesRequest input)
        {
            if (input == null) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Newest != input.Newest || (this.Newest != null && !this.Newest.Equals(input.Newest))) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.AddonTemplateName != input.AddonTemplateName || (this.AddonTemplateName != null && !this.AddonTemplateName.Equals(input.AddonTemplateName))) return false;
            if (this.BaseUpdateAddonVersion != input.BaseUpdateAddonVersion || (this.BaseUpdateAddonVersion != null && !this.BaseUpdateAddonVersion.Equals(input.BaseUpdateAddonVersion))) return false;

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
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Newest != null) hashCode = hashCode * 59 + this.Newest.GetHashCode();
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.AddonTemplateName != null) hashCode = hashCode * 59 + this.AddonTemplateName.GetHashCode();
                if (this.BaseUpdateAddonVersion != null) hashCode = hashCode * 59 + this.BaseUpdateAddonVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
