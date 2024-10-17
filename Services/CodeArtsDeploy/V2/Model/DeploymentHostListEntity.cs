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
    /// 
    /// </summary>
    public class DeploymentHostListEntity 
    {

        /// <summary>
        /// 主机id列表
        /// </summary>
        [JsonProperty("host_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HostIdList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeploymentHostListEntity {\n");
            sb.Append("  hostIdList: ").Append(HostIdList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeploymentHostListEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeploymentHostListEntity input)
        {
            if (input == null) return false;
            if (this.HostIdList != input.HostIdList || (this.HostIdList != null && input.HostIdList != null && !this.HostIdList.SequenceEqual(input.HostIdList))) return false;

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
                if (this.HostIdList != null) hashCode = hashCode * 59 + this.HostIdList.GetHashCode();
                return hashCode;
            }
        }
    }
}
