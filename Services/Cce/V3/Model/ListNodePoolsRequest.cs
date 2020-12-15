using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListNodePoolsRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("cluster_id", IsPath = true)]
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("errorStatus", IsQuery = true)]
        [JsonProperty("errorStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("showDefaultNodePool", IsQuery = true)]
        [JsonProperty("showDefaultNodePool", NullValueHandling = NullValueHandling.Ignore)]
        public string ShowDefaultNodePool { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNodePoolsRequest {\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  errorStatus: ").Append(ErrorStatus).Append("\n");
            sb.Append("  showDefaultNodePool: ").Append(ShowDefaultNodePool).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNodePoolsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNodePoolsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.ErrorStatus == input.ErrorStatus ||
                    (this.ErrorStatus != null &&
                    this.ErrorStatus.Equals(input.ErrorStatus))
                ) && 
                (
                    this.ShowDefaultNodePool == input.ShowDefaultNodePool ||
                    (this.ShowDefaultNodePool != null &&
                    this.ShowDefaultNodePool.Equals(input.ShowDefaultNodePool))
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
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ErrorStatus != null)
                    hashCode = hashCode * 59 + this.ErrorStatus.GetHashCode();
                if (this.ShowDefaultNodePool != null)
                    hashCode = hashCode * 59 + this.ShowDefaultNodePool.GetHashCode();
                return hashCode;
            }
        }
    }
}
