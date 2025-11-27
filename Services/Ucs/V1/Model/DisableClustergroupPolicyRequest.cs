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
    /// Request Object
    /// </summary>
    public class DisableClustergroupPolicyRequest 
    {

        /// <summary>
        /// 容器舰队id
        /// </summary>
        [SDKProperty("clustergroupid", IsPath = true)]
        [JsonProperty("clustergroupid", NullValueHandling = NullValueHandling.Ignore)]
        public string Clustergroupid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisableClustergroupPolicyRequest {\n");
            sb.Append("  clustergroupid: ").Append(Clustergroupid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisableClustergroupPolicyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisableClustergroupPolicyRequest input)
        {
            if (input == null) return false;
            if (this.Clustergroupid != input.Clustergroupid || (this.Clustergroupid != null && !this.Clustergroupid.Equals(input.Clustergroupid))) return false;

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
                if (this.Clustergroupid != null) hashCode = hashCode * 59 + this.Clustergroupid.GetHashCode();
                return hashCode;
            }
        }
    }
}
