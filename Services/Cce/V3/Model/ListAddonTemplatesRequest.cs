using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListAddonTemplatesRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("addon_template_name", IsQuery = true)]
        [JsonProperty("addon_template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AddonTemplateName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("base_update_addon_version", IsQuery = true)]
        [JsonProperty("base_update_addon_version", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseUpdateAddonVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("cluster_id", IsQuery = true)]
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("newest", IsQuery = true)]
        [JsonProperty("newest", NullValueHandling = NullValueHandling.Ignore)]
        public string Newest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("version", IsQuery = true)]
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAddonTemplatesRequest {\n");
            sb.Append("  addonTemplateName: ").Append(AddonTemplateName).Append("\n");
            sb.Append("  baseUpdateAddonVersion: ").Append(BaseUpdateAddonVersion).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  newest: ").Append(Newest).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.AddonTemplateName == input.AddonTemplateName ||
                    (this.AddonTemplateName != null &&
                    this.AddonTemplateName.Equals(input.AddonTemplateName))
                ) && 
                (
                    this.BaseUpdateAddonVersion == input.BaseUpdateAddonVersion ||
                    (this.BaseUpdateAddonVersion != null &&
                    this.BaseUpdateAddonVersion.Equals(input.BaseUpdateAddonVersion))
                ) && 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.Newest == input.Newest ||
                    (this.Newest != null &&
                    this.Newest.Equals(input.Newest))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AddonTemplateName != null)
                    hashCode = hashCode * 59 + this.AddonTemplateName.GetHashCode();
                if (this.BaseUpdateAddonVersion != null)
                    hashCode = hashCode * 59 + this.BaseUpdateAddonVersion.GetHashCode();
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.Newest != null)
                    hashCode = hashCode * 59 + this.Newest.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }
}
