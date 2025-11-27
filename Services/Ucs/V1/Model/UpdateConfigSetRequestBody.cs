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
    public class UpdateConfigSetRequestBody 
    {

        /// <summary>
        /// 配置集合的名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 所在命名空间
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 基于Helm Chart的部署配置（当前不支持HelmRelease类型）
        /// </summary>
        [JsonProperty("helmReleaseSpec", NullValueHandling = NullValueHandling.Ignore)]
        public Object HelmReleaseSpec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("kustomizationSpec", NullValueHandling = NullValueHandling.Ignore)]
        public KustomizationSpec KustomizationSpec { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateConfigSetRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  helmReleaseSpec: ").Append(HelmReleaseSpec).Append("\n");
            sb.Append("  kustomizationSpec: ").Append(KustomizationSpec).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateConfigSetRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateConfigSetRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.HelmReleaseSpec != input.HelmReleaseSpec || (this.HelmReleaseSpec != null && !this.HelmReleaseSpec.Equals(input.HelmReleaseSpec))) return false;
            if (this.KustomizationSpec != input.KustomizationSpec || (this.KustomizationSpec != null && !this.KustomizationSpec.Equals(input.KustomizationSpec))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.HelmReleaseSpec != null) hashCode = hashCode * 59 + this.HelmReleaseSpec.GetHashCode();
                if (this.KustomizationSpec != null) hashCode = hashCode * 59 + this.KustomizationSpec.GetHashCode();
                return hashCode;
            }
        }
    }
}
