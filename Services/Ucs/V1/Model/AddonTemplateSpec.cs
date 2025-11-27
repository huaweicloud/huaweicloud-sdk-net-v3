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
    /// 
    /// </summary>
    public class AddonTemplateSpec 
    {

        /// <summary>
        /// 插件的安装类型，支持helm安装或static安装
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 该插件是否为必装
        /// </summary>
        [JsonProperty("require", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Require { get; set; }

        /// <summary>
        /// 插件的标签列表
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Labels { get; set; }

        /// <summary>
        /// Logo链接
        /// </summary>
        [JsonProperty("logoURL", NullValueHandling = NullValueHandling.Ignore)]
        public string LogoURL { get; set; }

        /// <summary>
        /// README文档链接
        /// </summary>
        [JsonProperty("readmeURL", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadmeURL { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 插件的版本列表
        /// </summary>
        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddonVersion> Versions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddonTemplateSpec {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  require: ").Append(Require).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  logoURL: ").Append(LogoURL).Append("\n");
            sb.Append("  readmeURL: ").Append(ReadmeURL).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  versions: ").Append(Versions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddonTemplateSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddonTemplateSpec input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Require != input.Require || (this.Require != null && !this.Require.Equals(input.Require))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && input.Labels != null && !this.Labels.SequenceEqual(input.Labels))) return false;
            if (this.LogoURL != input.LogoURL || (this.LogoURL != null && !this.LogoURL.Equals(input.LogoURL))) return false;
            if (this.ReadmeURL != input.ReadmeURL || (this.ReadmeURL != null && !this.ReadmeURL.Equals(input.ReadmeURL))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Versions != input.Versions || (this.Versions != null && input.Versions != null && !this.Versions.SequenceEqual(input.Versions))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Require != null) hashCode = hashCode * 59 + this.Require.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.LogoURL != null) hashCode = hashCode * 59 + this.LogoURL.GetHashCode();
                if (this.ReadmeURL != null) hashCode = hashCode * 59 + this.ReadmeURL.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Versions != null) hashCode = hashCode * 59 + this.Versions.GetHashCode();
                return hashCode;
            }
        }
    }
}
