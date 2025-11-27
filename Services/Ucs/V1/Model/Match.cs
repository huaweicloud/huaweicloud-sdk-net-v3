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
    public class Match 
    {

        /// <summary>
        /// 生效类型，当前预置，填写不会生效
        /// </summary>
        [JsonProperty("kinds", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceKinds> Kinds { get; set; }

        /// <summary>
        /// 生效的命名空间
        /// </summary>
        [JsonProperty("namespaces", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Namespaces { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Match {\n");
            sb.Append("  kinds: ").Append(Kinds).Append("\n");
            sb.Append("  namespaces: ").Append(Namespaces).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Match);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Match input)
        {
            if (input == null) return false;
            if (this.Kinds != input.Kinds || (this.Kinds != null && input.Kinds != null && !this.Kinds.SequenceEqual(input.Kinds))) return false;
            if (this.Namespaces != input.Namespaces || (this.Namespaces != null && input.Namespaces != null && !this.Namespaces.SequenceEqual(input.Namespaces))) return false;

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
                if (this.Kinds != null) hashCode = hashCode * 59 + this.Kinds.GetHashCode();
                if (this.Namespaces != null) hashCode = hashCode * 59 + this.Namespaces.GetHashCode();
                return hashCode;
            }
        }
    }
}
