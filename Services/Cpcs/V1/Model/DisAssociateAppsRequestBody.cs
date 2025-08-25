using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DisAssociateAppsRequestBody 
    {

        /// <summary>
        /// 所需要绑定的集群ID
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 所需要解绑的应用ID列表
        /// </summary>
        [JsonProperty("app_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AppIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisAssociateAppsRequestBody {\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  appIds: ").Append(AppIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisAssociateAppsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisAssociateAppsRequestBody input)
        {
            if (input == null) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.AppIds != input.AppIds || (this.AppIds != null && input.AppIds != null && !this.AppIds.SequenceEqual(input.AppIds))) return false;

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
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.AppIds != null) hashCode = hashCode * 59 + this.AppIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
