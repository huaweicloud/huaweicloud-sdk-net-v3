using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EndpointResp 
    {

        /// <summary>
        /// 终端节点的ID，UUID形式的一个资源标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 终端节点的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 终端节点方向。 取值： inbound，表示入站终端节点。 outbound，表示出站终端节点。
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// **参数解释：** 资源状态。 **取值范围：** - ACTIVE：正常 - PENDING_CREATE：创建中 - PENDING_DELETE：删除中 - ERROR：失败
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 终端节点所属的VPC ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 该终端节点下的IP地址数量。
        /// </summary>
        [JsonProperty("ipaddress_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpaddressCount { get; set; }

        /// <summary>
        /// 该终端节点下的转发规则数量。 仅创建出站终端节点时返回该参数。
        /// </summary>
        [JsonProperty("resolver_rule_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResolverRuleCount { get; set; }

        /// <summary>
        /// 创建时间。 格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间。 格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndpointResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  ipaddressCount: ").Append(IpaddressCount).Append("\n");
            sb.Append("  resolverRuleCount: ").Append(ResolverRuleCount).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EndpointResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EndpointResp input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Direction != input.Direction || (this.Direction != null && !this.Direction.Equals(input.Direction))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.IpaddressCount != input.IpaddressCount || (this.IpaddressCount != null && !this.IpaddressCount.Equals(input.IpaddressCount))) return false;
            if (this.ResolverRuleCount != input.ResolverRuleCount || (this.ResolverRuleCount != null && !this.ResolverRuleCount.Equals(input.ResolverRuleCount))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Direction != null) hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.IpaddressCount != null) hashCode = hashCode * 59 + this.IpaddressCount.GetHashCode();
                if (this.ResolverRuleCount != null) hashCode = hashCode * 59 + this.ResolverRuleCount.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
