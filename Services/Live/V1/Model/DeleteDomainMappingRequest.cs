using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteDomainMappingRequest 
    {

        /// <summary>
        /// 直播播放域名
        /// </summary>
        [SDKProperty("pull_domain", IsQuery = true)]
        [JsonProperty("pull_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PullDomain { get; set; }

        /// <summary>
        /// 直播推流域名
        /// </summary>
        [SDKProperty("push_domain", IsQuery = true)]
        [JsonProperty("push_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PushDomain { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteDomainMappingRequest {\n");
            sb.Append("  pullDomain: ").Append(PullDomain).Append("\n");
            sb.Append("  pushDomain: ").Append(PushDomain).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteDomainMappingRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteDomainMappingRequest input)
        {
            if (input == null) return false;
            if (this.PullDomain != input.PullDomain || (this.PullDomain != null && !this.PullDomain.Equals(input.PullDomain))) return false;
            if (this.PushDomain != input.PushDomain || (this.PushDomain != null && !this.PushDomain.Equals(input.PushDomain))) return false;

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
                if (this.PullDomain != null) hashCode = hashCode * 59 + this.PullDomain.GetHashCode();
                if (this.PushDomain != null) hashCode = hashCode * 59 + this.PushDomain.GetHashCode();
                return hashCode;
            }
        }
    }
}
