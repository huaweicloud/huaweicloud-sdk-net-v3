using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListWarmPoolInstancesNewResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }

        /// <summary>
        /// 暖池实例列表
        /// </summary>
        [JsonProperty("warm_pool_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<WarmPoolInstance> WarmPoolInstances { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWarmPoolInstancesNewResponse {\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("  warmPoolInstances: ").Append(WarmPoolInstances).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWarmPoolInstancesNewResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWarmPoolInstancesNewResponse input)
        {
            if (input == null) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;
            if (this.WarmPoolInstances != input.WarmPoolInstances || (this.WarmPoolInstances != null && input.WarmPoolInstances != null && !this.WarmPoolInstances.SequenceEqual(input.WarmPoolInstances))) return false;

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
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                if (this.WarmPoolInstances != null) hashCode = hashCode * 59 + this.WarmPoolInstances.GetHashCode();
                return hashCode;
            }
        }
    }
}
