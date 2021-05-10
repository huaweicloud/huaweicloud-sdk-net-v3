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
    /// spec是集合类的元素类型，内容为插件实例具体信息
    /// </summary>
    public class InstanceSpec 
    {

        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("clusterID", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterID { get; set; }

        /// <summary>
        /// 插件模板版本号，如1.0.0
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 插件模板名称，如coredns
        /// </summary>
        [JsonProperty("addonTemplateName", NullValueHandling = NullValueHandling.Ignore)]
        public string AddonTemplateName { get; set; }

        /// <summary>
        /// 插件模板类型
        /// </summary>
        [JsonProperty("addonTemplateType", NullValueHandling = NullValueHandling.Ignore)]
        public string AddonTemplateType { get; set; }

        /// <summary>
        /// 插件模板logo图片的地址
        /// </summary>
        [JsonProperty("addonTemplateLogo", NullValueHandling = NullValueHandling.Ignore)]
        public string AddonTemplateLogo { get; set; }

        /// <summary>
        /// 插件模板所属类型
        /// </summary>
        [JsonProperty("addonTemplateLabels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AddonTemplateLabels { get; set; }

        /// <summary>
        /// 插件模板描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 插件模板安装参数（各插件不同），请根据具体插件模板信息填写安装参数。
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Values { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceSpec {\n");
            sb.Append("  clusterID: ").Append(ClusterID).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  addonTemplateName: ").Append(AddonTemplateName).Append("\n");
            sb.Append("  addonTemplateType: ").Append(AddonTemplateType).Append("\n");
            sb.Append("  addonTemplateLogo: ").Append(AddonTemplateLogo).Append("\n");
            sb.Append("  addonTemplateLabels: ").Append(AddonTemplateLabels).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterID == input.ClusterID ||
                    (this.ClusterID != null &&
                    this.ClusterID.Equals(input.ClusterID))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.AddonTemplateName == input.AddonTemplateName ||
                    (this.AddonTemplateName != null &&
                    this.AddonTemplateName.Equals(input.AddonTemplateName))
                ) && 
                (
                    this.AddonTemplateType == input.AddonTemplateType ||
                    (this.AddonTemplateType != null &&
                    this.AddonTemplateType.Equals(input.AddonTemplateType))
                ) && 
                (
                    this.AddonTemplateLogo == input.AddonTemplateLogo ||
                    (this.AddonTemplateLogo != null &&
                    this.AddonTemplateLogo.Equals(input.AddonTemplateLogo))
                ) && 
                (
                    this.AddonTemplateLabels == input.AddonTemplateLabels ||
                    this.AddonTemplateLabels != null &&
                    input.AddonTemplateLabels != null &&
                    this.AddonTemplateLabels.SequenceEqual(input.AddonTemplateLabels)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                if (this.ClusterID != null)
                    hashCode = hashCode * 59 + this.ClusterID.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.AddonTemplateName != null)
                    hashCode = hashCode * 59 + this.AddonTemplateName.GetHashCode();
                if (this.AddonTemplateType != null)
                    hashCode = hashCode * 59 + this.AddonTemplateType.GetHashCode();
                if (this.AddonTemplateLogo != null)
                    hashCode = hashCode * 59 + this.AddonTemplateLogo.GetHashCode();
                if (this.AddonTemplateLabels != null)
                    hashCode = hashCode * 59 + this.AddonTemplateLabels.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                return hashCode;
            }
        }
    }
}
