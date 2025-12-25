using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ClusterJoinGroupRequestBody : IFormDataBody
    {

        /// <summary>
        /// 集群加入目标容器舰队的id
        /// </summary>
        [JsonProperty("clusterGroupID", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterGroupID { get; set; }


        

        public Dictionary<string, object> BuildFormData()
        {
            var formData = new Dictionary<string, object>();

            formData.Add("clusterGroupID", new FormDataPart<string>(ClusterGroupID));

            return formData;
        }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterJoinGroupRequestBody {\n");
            sb.Append("  clusterGroupID: ").Append(ClusterGroupID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterJoinGroupRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterJoinGroupRequestBody input)
        {
            if (input == null) return false;
            if (this.ClusterGroupID != input.ClusterGroupID || (this.ClusterGroupID != null && !this.ClusterGroupID.Equals(input.ClusterGroupID))) return false;

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
                if (this.ClusterGroupID != null) hashCode = hashCode * 59 + this.ClusterGroupID.GetHashCode();
                return hashCode;
            }
        }
    }
}
