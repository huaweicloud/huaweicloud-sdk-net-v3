using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterSCIM.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MetaDto 
    {

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("resourceType", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 资源创建时间
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 资源最后更新时间
        /// </summary>
        [JsonProperty("lastModified", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModified { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetaDto {\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  lastModified: ").Append(LastModified).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetaDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetaDto input)
        {
            if (input == null) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.LastModified != input.LastModified || (this.LastModified != null && !this.LastModified.Equals(input.LastModified))) return false;

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
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.LastModified != null) hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                return hashCode;
            }
        }
    }
}
