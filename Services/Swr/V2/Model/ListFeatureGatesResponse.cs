using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListFeatureGatesResponse : SdkResponse
    {

        /// <summary>
        /// 是否开启域名管理
        /// </summary>
        [JsonProperty("enableDomainName", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableDomainName { get; set; }

        /// <summary>
        /// 老化策略是否支持多条规则
        /// </summary>
        [JsonProperty("enableCombinationRetention", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableCombinationRetention { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFeatureGatesResponse {\n");
            sb.Append("  enableDomainName: ").Append(EnableDomainName).Append("\n");
            sb.Append("  enableCombinationRetention: ").Append(EnableCombinationRetention).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFeatureGatesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFeatureGatesResponse input)
        {
            if (input == null) return false;
            if (this.EnableDomainName != input.EnableDomainName || (this.EnableDomainName != null && !this.EnableDomainName.Equals(input.EnableDomainName))) return false;
            if (this.EnableCombinationRetention != input.EnableCombinationRetention || (this.EnableCombinationRetention != null && !this.EnableCombinationRetention.Equals(input.EnableCombinationRetention))) return false;

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
                if (this.EnableDomainName != null) hashCode = hashCode * 59 + this.EnableDomainName.GetHashCode();
                if (this.EnableCombinationRetention != null) hashCode = hashCode * 59 + this.EnableCombinationRetention.GetHashCode();
                return hashCode;
            }
        }
    }
}
