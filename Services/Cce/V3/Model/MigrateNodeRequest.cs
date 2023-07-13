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
    public class MigrateNodeRequest 
    {

        /// <summary>
        /// 集群ID，获取方式请参见[如何获取接口URI中参数](cce_02_0271.xml)。
        /// </summary>
        [SDKProperty("cluster_id", IsPath = true)]
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 集群ID，获取方式请参见[如何获取接口URI中参数](cce_02_0271.xml)。
        /// </summary>
        [SDKProperty("target_cluster_id", IsPath = true)]
        [JsonProperty("target_cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetClusterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public MigrateNodesTask Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrateNodeRequest {\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  targetClusterId: ").Append(TargetClusterId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrateNodeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrateNodeRequest input)
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
                    this.TargetClusterId == input.TargetClusterId ||
                    (this.TargetClusterId != null &&
                    this.TargetClusterId.Equals(input.TargetClusterId))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.TargetClusterId != null)
                    hashCode = hashCode * 59 + this.TargetClusterId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
