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
    /// Response Object
    /// </summary>
    public class DisassociateAppsResponse : SdkResponse
    {

        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 应用id列表
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AppId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisassociateAppsResponse {\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisassociateAppsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisassociateAppsResponse input)
        {
            if (input == null) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && input.AppId != null && !this.AppId.SequenceEqual(input.AppId))) return false;

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
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                return hashCode;
            }
        }
    }
}
