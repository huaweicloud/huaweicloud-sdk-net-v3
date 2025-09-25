using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 资源耗时信息
    /// </summary>
    public class ResourceTime 
    {

        /// <summary>
        /// **参数解释**: 总耗时（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("all_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? AllTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource_time_details", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceTimeDetails ResourceTimeDetails { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceTime {\n");
            sb.Append("  allTime: ").Append(AllTime).Append("\n");
            sb.Append("  resourceTimeDetails: ").Append(ResourceTimeDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceTime);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceTime input)
        {
            if (input == null) return false;
            if (this.AllTime != input.AllTime || (this.AllTime != null && !this.AllTime.Equals(input.AllTime))) return false;
            if (this.ResourceTimeDetails != input.ResourceTimeDetails || (this.ResourceTimeDetails != null && !this.ResourceTimeDetails.Equals(input.ResourceTimeDetails))) return false;

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
                if (this.AllTime != null) hashCode = hashCode * 59 + this.AllTime.GetHashCode();
                if (this.ResourceTimeDetails != null) hashCode = hashCode * 59 + this.ResourceTimeDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}
