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
    /// Response Object
    /// </summary>
    public class ListHostGroupsResponse : SdkResponse
    {

        /// <summary>
        /// 主机集群个数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 主机集群详情响应体
        /// </summary>
        [JsonProperty("host_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<DeploymentGroupDetail> HostGroups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHostGroupsResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  hostGroups: ").Append(HostGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHostGroupsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHostGroupsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.HostGroups == input.HostGroups ||
                    this.HostGroups != null &&
                    input.HostGroups != null &&
                    this.HostGroups.SequenceEqual(input.HostGroups)
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.HostGroups != null)
                    hashCode = hashCode * 59 + this.HostGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
