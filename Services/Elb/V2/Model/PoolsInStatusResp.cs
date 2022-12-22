using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// 后端云服务器对象列表，用于状态树中
    /// </summary>
    public class PoolsInStatusResp 
    {

        /// <summary>
        /// 后端云服务器组ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 后端云服务器组名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 后端云服务器组关联的后端云服务器列表
        /// </summary>
        [JsonProperty("members", NullValueHandling = NullValueHandling.Ignore)]
        public List<MembersInStatusResp> Members { get; set; }

        /// <summary>
        /// 后端云服务器组的操作状态；该字段为预留字段，暂未启用。默认为ONLINE。
        /// </summary>
        [JsonProperty("operating_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatingStatus { get; set; }

        /// <summary>
        /// 后端云服务器组的配置状态；该字段为预留字段，暂未启用。默认为ACTIVE。
        /// </summary>
        [JsonProperty("provisioning_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvisioningStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("healthmonitor", NullValueHandling = NullValueHandling.Ignore)]
        public HealthmonitorsInStatusResp Healthmonitor { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolsInStatusResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  members: ").Append(Members).Append("\n");
            sb.Append("  operatingStatus: ").Append(OperatingStatus).Append("\n");
            sb.Append("  provisioningStatus: ").Append(ProvisioningStatus).Append("\n");
            sb.Append("  healthmonitor: ").Append(Healthmonitor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolsInStatusResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolsInStatusResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Members == input.Members ||
                    this.Members != null &&
                    input.Members != null &&
                    this.Members.SequenceEqual(input.Members)
                ) && 
                (
                    this.OperatingStatus == input.OperatingStatus ||
                    (this.OperatingStatus != null &&
                    this.OperatingStatus.Equals(input.OperatingStatus))
                ) && 
                (
                    this.ProvisioningStatus == input.ProvisioningStatus ||
                    (this.ProvisioningStatus != null &&
                    this.ProvisioningStatus.Equals(input.ProvisioningStatus))
                ) && 
                (
                    this.Healthmonitor == input.Healthmonitor ||
                    (this.Healthmonitor != null &&
                    this.Healthmonitor.Equals(input.Healthmonitor))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Members != null)
                    hashCode = hashCode * 59 + this.Members.GetHashCode();
                if (this.OperatingStatus != null)
                    hashCode = hashCode * 59 + this.OperatingStatus.GetHashCode();
                if (this.ProvisioningStatus != null)
                    hashCode = hashCode * 59 + this.ProvisioningStatus.GetHashCode();
                if (this.Healthmonitor != null)
                    hashCode = hashCode * 59 + this.Healthmonitor.GetHashCode();
                return hashCode;
            }
        }
    }
}
