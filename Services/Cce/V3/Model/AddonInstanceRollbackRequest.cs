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
    /// 
    /// </summary>
    public class AddonInstanceRollbackRequest 
    {

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("clusterID", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddonInstanceRollbackRequest {\n");
            sb.Append("  clusterID: ").Append(ClusterID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddonInstanceRollbackRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddonInstanceRollbackRequest input)
        {
            if (input == null) return false;
            if (this.ClusterID != input.ClusterID || (this.ClusterID != null && !this.ClusterID.Equals(input.ClusterID))) return false;

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
                if (this.ClusterID != null) hashCode = hashCode * 59 + this.ClusterID.GetHashCode();
                return hashCode;
            }
        }
    }
}
