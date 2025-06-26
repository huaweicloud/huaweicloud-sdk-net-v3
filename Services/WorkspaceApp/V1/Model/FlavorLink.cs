using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FlavorLink 
    {

        /// <summary>
        /// 快捷链接标记名称。
        /// </summary>
        [JsonProperty("rel", NullValueHandling = NullValueHandling.Ignore)]
        public string Rel { get; set; }

        /// <summary>
        /// 对应快捷链接。
        /// </summary>
        [JsonProperty("hrel", NullValueHandling = NullValueHandling.Ignore)]
        public string Hrel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlavorLink {\n");
            sb.Append("  rel: ").Append(Rel).Append("\n");
            sb.Append("  hrel: ").Append(Hrel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlavorLink);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlavorLink input)
        {
            if (input == null) return false;
            if (this.Rel != input.Rel || (this.Rel != null && !this.Rel.Equals(input.Rel))) return false;
            if (this.Hrel != input.Hrel || (this.Hrel != null && !this.Hrel.Equals(input.Hrel))) return false;

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
                if (this.Rel != null) hashCode = hashCode * 59 + this.Rel.GetHashCode();
                if (this.Hrel != null) hashCode = hashCode * 59 + this.Hrel.GetHashCode();
                return hashCode;
            }
        }
    }
}
