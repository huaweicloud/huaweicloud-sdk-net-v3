using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AssociationInfo 
    {

        /// <summary>
        /// 绑定关系ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("cluster_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterName { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 应用所属的VPC名称
        /// </summary>
        [JsonProperty("vpc_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcName { get; set; }

        /// <summary>
        /// 应用所属的VPC的子网
        /// </summary>
        [JsonProperty("subnet_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetName { get; set; }

        /// <summary>
        /// 集群所属的服务
        /// </summary>
        [JsonProperty("cluster_server_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterServerType { get; set; }

        /// <summary>
        /// 访问地址
        /// </summary>
        [JsonProperty("vpcep_address", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcepAddress { get; set; }

        /// <summary>
        /// 绑定关系的最新更改时间，UNIX时间戳，单位毫秒
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 绑定关系的创建时间，UNIX时间戳，单位毫秒
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociationInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  clusterName: ").Append(ClusterName).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  vpcName: ").Append(VpcName).Append("\n");
            sb.Append("  subnetName: ").Append(SubnetName).Append("\n");
            sb.Append("  clusterServerType: ").Append(ClusterServerType).Append("\n");
            sb.Append("  vpcepAddress: ").Append(VpcepAddress).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociationInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociationInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.ClusterName != input.ClusterName || (this.ClusterName != null && !this.ClusterName.Equals(input.ClusterName))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.VpcName != input.VpcName || (this.VpcName != null && !this.VpcName.Equals(input.VpcName))) return false;
            if (this.SubnetName != input.SubnetName || (this.SubnetName != null && !this.SubnetName.Equals(input.SubnetName))) return false;
            if (this.ClusterServerType != input.ClusterServerType || (this.ClusterServerType != null && !this.ClusterServerType.Equals(input.ClusterServerType))) return false;
            if (this.VpcepAddress != input.VpcepAddress || (this.VpcepAddress != null && !this.VpcepAddress.Equals(input.VpcepAddress))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;

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
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterName != null) hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.VpcName != null) hashCode = hashCode * 59 + this.VpcName.GetHashCode();
                if (this.SubnetName != null) hashCode = hashCode * 59 + this.SubnetName.GetHashCode();
                if (this.ClusterServerType != null) hashCode = hashCode * 59 + this.ClusterServerType.GetHashCode();
                if (this.VpcepAddress != null) hashCode = hashCode * 59 + this.VpcepAddress.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
