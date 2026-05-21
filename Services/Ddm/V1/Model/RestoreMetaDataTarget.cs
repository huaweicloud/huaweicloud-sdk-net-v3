using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RestoreMetaDataTarget 
    {

        /// <summary>
        /// metadata恢复目标dn。
        /// </summary>
        [JsonProperty("data_nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DataNodes { get; set; }

        /// <summary>
        /// 实例id。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestoreMetaDataTarget {\n");
            sb.Append("  dataNodes: ").Append(DataNodes).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestoreMetaDataTarget);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestoreMetaDataTarget input)
        {
            if (input == null) return false;
            if (this.DataNodes != input.DataNodes || (this.DataNodes != null && input.DataNodes != null && !this.DataNodes.SequenceEqual(input.DataNodes))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;

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
                if (this.DataNodes != null) hashCode = hashCode * 59 + this.DataNodes.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
