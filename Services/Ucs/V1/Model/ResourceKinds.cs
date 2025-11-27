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
    public class ResourceKinds 
    {

        /// <summary>
        /// 资源所属的API组
        /// </summary>
        [JsonProperty("apiGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ApiGroups { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("kinds", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Kinds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceKinds {\n");
            sb.Append("  apiGroups: ").Append(ApiGroups).Append("\n");
            sb.Append("  kinds: ").Append(Kinds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceKinds);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceKinds input)
        {
            if (input == null) return false;
            if (this.ApiGroups != input.ApiGroups || (this.ApiGroups != null && input.ApiGroups != null && !this.ApiGroups.SequenceEqual(input.ApiGroups))) return false;
            if (this.Kinds != input.Kinds || (this.Kinds != null && input.Kinds != null && !this.Kinds.SequenceEqual(input.Kinds))) return false;

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
                if (this.ApiGroups != null) hashCode = hashCode * 59 + this.ApiGroups.GetHashCode();
                if (this.Kinds != null) hashCode = hashCode * 59 + this.Kinds.GetHashCode();
                return hashCode;
            }
        }
    }
}
