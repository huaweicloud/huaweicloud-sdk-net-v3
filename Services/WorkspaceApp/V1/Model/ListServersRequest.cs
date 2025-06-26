using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListServersRequest 
    {

        /// <summary>
        /// 查询的偏移量。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询的数量，值区间[1-100]。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 服务器组唯一标识。
        /// </summary>
        [SDKProperty("server_group_id", IsQuery = true)]
        [JsonProperty("server_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// 服务器名称，支持部分匹配。
        /// </summary>
        [SDKProperty("server_name", IsQuery = true)]
        [JsonProperty("server_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerName { get; set; }

        /// <summary>
        /// 机器名称，支持部分匹配。
        /// </summary>
        [SDKProperty("machine_name", IsQuery = true)]
        [JsonProperty("machine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineName { get; set; }

        /// <summary>
        /// ip地址，支持部分匹配。
        /// </summary>
        [SDKProperty("ip_addr", IsQuery = true)]
        [JsonProperty("ip_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddr { get; set; }

        /// <summary>
        /// 服务器唯一标识。
        /// </summary>
        [SDKProperty("server_id", IsQuery = true)]
        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }

        /// <summary>
        /// 服务器维护状态： - true : 维护态的实例。 - false: 非维护态的实例。
        /// </summary>
        [SDKProperty("maintain_status", IsQuery = true)]
        [JsonProperty("maintain_status", NullValueHandling = NullValueHandling.Ignore)]
        public string MaintainStatus { get; set; }

        /// <summary>
        /// 是否是弹性创建： true : 通过弹性伸缩创建。 false: 不是通过弹性伸缩创建。
        /// </summary>
        [SDKProperty("scaling_auto_create", IsQuery = true)]
        [JsonProperty("scaling_auto_create", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingAutoCreate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListServersRequest {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  serverGroupId: ").Append(ServerGroupId).Append("\n");
            sb.Append("  serverName: ").Append(ServerName).Append("\n");
            sb.Append("  machineName: ").Append(MachineName).Append("\n");
            sb.Append("  ipAddr: ").Append(IpAddr).Append("\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  maintainStatus: ").Append(MaintainStatus).Append("\n");
            sb.Append("  scalingAutoCreate: ").Append(ScalingAutoCreate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListServersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServersRequest input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.ServerGroupId != input.ServerGroupId || (this.ServerGroupId != null && !this.ServerGroupId.Equals(input.ServerGroupId))) return false;
            if (this.ServerName != input.ServerName || (this.ServerName != null && !this.ServerName.Equals(input.ServerName))) return false;
            if (this.MachineName != input.MachineName || (this.MachineName != null && !this.MachineName.Equals(input.MachineName))) return false;
            if (this.IpAddr != input.IpAddr || (this.IpAddr != null && !this.IpAddr.Equals(input.IpAddr))) return false;
            if (this.ServerId != input.ServerId || (this.ServerId != null && !this.ServerId.Equals(input.ServerId))) return false;
            if (this.MaintainStatus != input.MaintainStatus || (this.MaintainStatus != null && !this.MaintainStatus.Equals(input.MaintainStatus))) return false;
            if (this.ScalingAutoCreate != input.ScalingAutoCreate || (this.ScalingAutoCreate != null && !this.ScalingAutoCreate.Equals(input.ScalingAutoCreate))) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.ServerGroupId != null) hashCode = hashCode * 59 + this.ServerGroupId.GetHashCode();
                if (this.ServerName != null) hashCode = hashCode * 59 + this.ServerName.GetHashCode();
                if (this.MachineName != null) hashCode = hashCode * 59 + this.MachineName.GetHashCode();
                if (this.IpAddr != null) hashCode = hashCode * 59 + this.IpAddr.GetHashCode();
                if (this.ServerId != null) hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.MaintainStatus != null) hashCode = hashCode * 59 + this.MaintainStatus.GetHashCode();
                if (this.ScalingAutoCreate != null) hashCode = hashCode * 59 + this.ScalingAutoCreate.GetHashCode();
                return hashCode;
            }
        }
    }
}
