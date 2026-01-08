using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CheckEdgeSiteResourcesResponse : SdkResponse
    {

        /// <summary>
        /// 配额是否足够1：足够 0 ：不足。
        /// </summary>
        [JsonProperty("is_enough", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsEnough { get; set; }

        /// <summary>
        /// 资源剩余数量信息。
        /// </summary>
        [JsonProperty("resource_remainder", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceRemainderData> ResourceRemainder { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckEdgeSiteResourcesResponse {\n");
            sb.Append("  isEnough: ").Append(IsEnough).Append("\n");
            sb.Append("  resourceRemainder: ").Append(ResourceRemainder).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckEdgeSiteResourcesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckEdgeSiteResourcesResponse input)
        {
            if (input == null) return false;
            if (this.IsEnough != input.IsEnough || (this.IsEnough != null && !this.IsEnough.Equals(input.IsEnough))) return false;
            if (this.ResourceRemainder != input.ResourceRemainder || (this.ResourceRemainder != null && input.ResourceRemainder != null && !this.ResourceRemainder.SequenceEqual(input.ResourceRemainder))) return false;

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
                if (this.IsEnough != null) hashCode = hashCode * 59 + this.IsEnough.GetHashCode();
                if (this.ResourceRemainder != null) hashCode = hashCode * 59 + this.ResourceRemainder.GetHashCode();
                return hashCode;
            }
        }
    }
}
