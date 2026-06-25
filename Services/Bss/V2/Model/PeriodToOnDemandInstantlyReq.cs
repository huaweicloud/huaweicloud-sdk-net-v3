using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PeriodToOnDemandInstantlyReq 
    {

        /// <summary>
        /// |参数名称：资源ID列表。| |参数约束以及描述：该参数必填，数组范围限制:1-10，字符长度限制1-64。|
        /// </summary>
        [JsonProperty("resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PeriodToOnDemandInstantlyReq {\n");
            sb.Append("  resourceIds: ").Append(ResourceIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PeriodToOnDemandInstantlyReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PeriodToOnDemandInstantlyReq input)
        {
            if (input == null) return false;
            if (this.ResourceIds != input.ResourceIds || (this.ResourceIds != null && input.ResourceIds != null && !this.ResourceIds.SequenceEqual(input.ResourceIds))) return false;

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
                if (this.ResourceIds != null) hashCode = hashCode * 59 + this.ResourceIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
