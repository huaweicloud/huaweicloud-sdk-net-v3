using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowDeploymentHostDetailRequest 
    {

        /// <summary>
        /// 主机集群id
        /// </summary>
        [SDKProperty("group_id", IsPath = true)]
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 主机id
        /// </summary>
        [SDKProperty("host_id", IsPath = true)]
        [JsonProperty("host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HostId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDeploymentHostDetailRequest {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  hostId: ").Append(HostId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDeploymentHostDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDeploymentHostDetailRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.HostId == input.HostId ||
                    (this.HostId != null &&
                    this.HostId.Equals(input.HostId))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.HostId != null)
                    hashCode = hashCode * 59 + this.HostId.GetHashCode();
                return hashCode;
            }
        }
    }
}
