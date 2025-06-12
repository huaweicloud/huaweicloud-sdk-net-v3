using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 资源配置。
    /// </summary>
    public class ChatResourceConfig 
    {

        /// <summary>
        /// 资源id
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源数量
        /// </summary>
        [JsonProperty("count_resource", NullValueHandling = NullValueHandling.Ignore)]
        public int? CountResource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatResourceConfig {\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  countResource: ").Append(CountResource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChatResourceConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChatResourceConfig input)
        {
            if (input == null) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.CountResource != input.CountResource || (this.CountResource != null && !this.CountResource.Equals(input.CountResource))) return false;

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
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.CountResource != null) hashCode = hashCode * 59 + this.CountResource.GetHashCode();
                return hashCode;
            }
        }
    }
}
