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
    public class AddonObjectMeta 
    {

        /// <summary>
        /// 唯一标识符
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// 对象的名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 对象的标签
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// 对象的注解
        /// </summary>
        [JsonProperty("annotations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("creationTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationTimestamp { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updateTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTimestamp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddonObjectMeta {\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  annotations: ").Append(Annotations).Append("\n");
            sb.Append("  creationTimestamp: ").Append(CreationTimestamp).Append("\n");
            sb.Append("  updateTimestamp: ").Append(UpdateTimestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddonObjectMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddonObjectMeta input)
        {
            if (input == null) return false;
            if (this.Uid != input.Uid || (this.Uid != null && !this.Uid.Equals(input.Uid))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && input.Labels != null && !this.Labels.SequenceEqual(input.Labels))) return false;
            if (this.Annotations != input.Annotations || (this.Annotations != null && input.Annotations != null && !this.Annotations.SequenceEqual(input.Annotations))) return false;
            if (this.CreationTimestamp != input.CreationTimestamp || (this.CreationTimestamp != null && !this.CreationTimestamp.Equals(input.CreationTimestamp))) return false;
            if (this.UpdateTimestamp != input.UpdateTimestamp || (this.UpdateTimestamp != null && !this.UpdateTimestamp.Equals(input.UpdateTimestamp))) return false;

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
                if (this.Uid != null) hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Annotations != null) hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.CreationTimestamp != null) hashCode = hashCode * 59 + this.CreationTimestamp.GetHashCode();
                if (this.UpdateTimestamp != null) hashCode = hashCode * 59 + this.UpdateTimestamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
