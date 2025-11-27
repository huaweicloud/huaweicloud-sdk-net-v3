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
    /// 插件实例信息
    /// </summary>
    public class AddonInstanceSpec 
    {

        /// <summary>
        /// cluster ID信息
        /// </summary>
        [JsonProperty("clusterID", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterID { get; set; }

        /// <summary>
        /// 插件版本信息
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 插件模板名称
        /// </summary>
        [JsonProperty("addonTemplateName", NullValueHandling = NullValueHandling.Ignore)]
        public string AddonTemplateName { get; set; }

        /// <summary>
        /// 插件模板类型
        /// </summary>
        [JsonProperty("addonTemplateType", NullValueHandling = NullValueHandling.Ignore)]
        public string AddonTemplateType { get; set; }

        /// <summary>
        /// 插件模板Logo
        /// </summary>
        [JsonProperty("addonTemplateLogo", NullValueHandling = NullValueHandling.Ignore)]
        public string AddonTemplateLogo { get; set; }

        /// <summary>
        /// 插件模板标签
        /// </summary>
        [JsonProperty("addonTemplateLabels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AddonTemplateLabels { get; set; }

        /// <summary>
        /// 信息说明
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 插件实例的配置参数
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Values { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public ReleaseParams Parameters { get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddonInstanceSpec {\n");
            sb.Append("  clusterID: ").Append(ClusterID).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  addonTemplateName: ").Append(AddonTemplateName).Append("\n");
            sb.Append("  addonTemplateType: ").Append(AddonTemplateType).Append("\n");
            sb.Append("  addonTemplateLogo: ").Append(AddonTemplateLogo).Append("\n");
            sb.Append("  addonTemplateLabels: ").Append(AddonTemplateLabels).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddonInstanceSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddonInstanceSpec input)
        {
            if (input == null) return false;
            if (this.ClusterID != input.ClusterID || (this.ClusterID != null && !this.ClusterID.Equals(input.ClusterID))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.AddonTemplateName != input.AddonTemplateName || (this.AddonTemplateName != null && !this.AddonTemplateName.Equals(input.AddonTemplateName))) return false;
            if (this.AddonTemplateType != input.AddonTemplateType || (this.AddonTemplateType != null && !this.AddonTemplateType.Equals(input.AddonTemplateType))) return false;
            if (this.AddonTemplateLogo != input.AddonTemplateLogo || (this.AddonTemplateLogo != null && !this.AddonTemplateLogo.Equals(input.AddonTemplateLogo))) return false;
            if (this.AddonTemplateLabels != input.AddonTemplateLabels || (this.AddonTemplateLabels != null && input.AddonTemplateLabels != null && !this.AddonTemplateLabels.SequenceEqual(input.AddonTemplateLabels))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Values != input.Values || (this.Values != null && input.Values != null && !this.Values.SequenceEqual(input.Values))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && !this.Parameters.Equals(input.Parameters))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;

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
                if (this.ClusterID != null) hashCode = hashCode * 59 + this.ClusterID.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.AddonTemplateName != null) hashCode = hashCode * 59 + this.AddonTemplateName.GetHashCode();
                if (this.AddonTemplateType != null) hashCode = hashCode * 59 + this.AddonTemplateType.GetHashCode();
                if (this.AddonTemplateLogo != null) hashCode = hashCode * 59 + this.AddonTemplateLogo.GetHashCode();
                if (this.AddonTemplateLabels != null) hashCode = hashCode * 59 + this.AddonTemplateLabels.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Values != null) hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                return hashCode;
            }
        }
    }
}
