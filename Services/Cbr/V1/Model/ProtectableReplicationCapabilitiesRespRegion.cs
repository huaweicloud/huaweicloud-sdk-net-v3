using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ProtectableReplicationCapabilitiesRespRegion 
    {

        /// <summary>
        /// 云服务所在的区域
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 支持复制的目标区域列表
        /// </summary>
        [JsonProperty("replication_destinations", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReplicationDestinations { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtectableReplicationCapabilitiesRespRegion {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  replicationDestinations: ").Append(ReplicationDestinations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProtectableReplicationCapabilitiesRespRegion);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProtectableReplicationCapabilitiesRespRegion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ReplicationDestinations == input.ReplicationDestinations ||
                    this.ReplicationDestinations != null &&
                    input.ReplicationDestinations != null &&
                    this.ReplicationDestinations.SequenceEqual(input.ReplicationDestinations)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ReplicationDestinations != null)
                    hashCode = hashCode * 59 + this.ReplicationDestinations.GetHashCode();
                return hashCode;
            }
        }
    }
}
