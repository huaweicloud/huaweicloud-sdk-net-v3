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
    public class EnableFederationRequest 
    {

        /// <summary>
        /// 容器舰队id
        /// </summary>
        [SDKProperty("clustergroupid", IsPath = true)]
        [JsonProperty("clustergroupid", NullValueHandling = NullValueHandling.Ignore)]
        public string Clustergroupid { get; set; }

        /// <summary>
        /// 是否重试集群加入联邦
        /// </summary>
        [SDKProperty("retryjoinall", IsQuery = true)]
        [JsonProperty("retryjoinall", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Retryjoinall { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnableFederationRequest {\n");
            sb.Append("  clustergroupid: ").Append(Clustergroupid).Append("\n");
            sb.Append("  retryjoinall: ").Append(Retryjoinall).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnableFederationRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnableFederationRequest input)
        {
            if (input == null) return false;
            if (this.Clustergroupid != input.Clustergroupid || (this.Clustergroupid != null && !this.Clustergroupid.Equals(input.Clustergroupid))) return false;
            if (this.Retryjoinall != input.Retryjoinall || (this.Retryjoinall != null && !this.Retryjoinall.Equals(input.Retryjoinall))) return false;

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
                if (this.Retryjoinall != null) hashCode = hashCode * 59 + this.Retryjoinall.GetHashCode();
                return hashCode;
            }
        }
    }
}
