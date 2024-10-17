using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ValidateDeletableReplicaResponse : SdkResponse
    {

        /// <summary>
        /// 是否有可供选择的副本组进行删除。
        /// </summary>
        [JsonProperty("check_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CheckResult { get; set; }

        /// <summary>
        /// 可选的可用区ID列表
        /// </summary>
        [JsonProperty("available_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailableZone { get; set; }

        /// <summary>
        /// 可选的保留节点列表
        /// </summary>
        [JsonProperty("replication_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReplicationInfo> ReplicationList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateDeletableReplicaResponse {\n");
            sb.Append("  checkResult: ").Append(CheckResult).Append("\n");
            sb.Append("  availableZone: ").Append(AvailableZone).Append("\n");
            sb.Append("  replicationList: ").Append(ReplicationList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ValidateDeletableReplicaResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ValidateDeletableReplicaResponse input)
        {
            if (input == null) return false;
            if (this.CheckResult != input.CheckResult || (this.CheckResult != null && !this.CheckResult.Equals(input.CheckResult))) return false;
            if (this.AvailableZone != input.AvailableZone || (this.AvailableZone != null && !this.AvailableZone.Equals(input.AvailableZone))) return false;
            if (this.ReplicationList != input.ReplicationList || (this.ReplicationList != null && input.ReplicationList != null && !this.ReplicationList.SequenceEqual(input.ReplicationList))) return false;

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
                if (this.CheckResult != null) hashCode = hashCode * 59 + this.CheckResult.GetHashCode();
                if (this.AvailableZone != null) hashCode = hashCode * 59 + this.AvailableZone.GetHashCode();
                if (this.ReplicationList != null) hashCode = hashCode * 59 + this.ReplicationList.GetHashCode();
                return hashCode;
            }
        }
    }
}
