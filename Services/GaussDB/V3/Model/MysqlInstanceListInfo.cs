using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MysqlInstanceListInfo 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 创建的实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 实例状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 实例写内网IP地址列表。弹性云服务器创建成功后该值存在，其他情况下为空字列表。
        /// </summary>
        [JsonProperty("private_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PrivateIps { get; set; }

        /// <summary>
        /// 实例读写分离IP地址列表。GaussDB(for MySQL)实例开启代理成功后该值存在，其他情况下为空列表。
        /// </summary>
        [JsonProperty("proxy_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProxyIps { get; set; }

        /// <summary>
        /// 实例读内网IP地址列表。弹性云服务器创建成功后该值存在，其他情况下为空列表。
        /// </summary>
        [JsonProperty("readonly_private_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReadonlyPrivateIps { get; set; }

        /// <summary>
        /// 实例外网IP地址列表。
        /// </summary>
        [JsonProperty("public_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PublicIps { get; set; }

        /// <summary>
        /// 数据库端口号。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// 实例类型，取值为“Cluster”。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 实例所在区域。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("datastore", NullValueHandling = NullValueHandling.Ignore)]
        public MysqlDatastoreWithKernelVersion Datastore { get; set; }

        /// <summary>
        /// 创建时间，格式为\&quot;yyyy-mm-ddThh:mm:ssZ\&quot;。  其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。  说明：创建时返回值为空，数据库实例创建成功后该值不为空。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 更新时间，格式与\&quot;created\&quot;字段对应格式完全相同。  说明：创建时返回值为空，数据库实例创建成功后该值不为空。
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// 默认用户名。
        /// </summary>
        [JsonProperty("db_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbUserName { get; set; }

        /// <summary>
        /// 虚拟私有云ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 子网的网络ID信息。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 安全组ID。
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 规格码。
        /// </summary>
        [JsonProperty("flavor_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("flavor_info", NullValueHandling = NullValueHandling.Ignore)]
        public MysqlFlavorInfo FlavorInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public MysqlVolumeInfo Volume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backup_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public MysqlBackupStrategy BackupStrategy { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 时区。
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("charge_info", NullValueHandling = NullValueHandling.Ignore)]
        public MysqlChargeInfo ChargeInfo { get; set; }

        /// <summary>
        /// 专属资源池ID，只有数据库实例属于专属资源池才会返回该参数。
        /// </summary>
        [JsonProperty("dedicated_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedResourceId { get; set; }

        /// <summary>
        /// 标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceTagItem> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlInstanceListInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  privateIps: ").Append(PrivateIps).Append("\n");
            sb.Append("  proxyIps: ").Append(ProxyIps).Append("\n");
            sb.Append("  readonlyPrivateIps: ").Append(ReadonlyPrivateIps).Append("\n");
            sb.Append("  publicIps: ").Append(PublicIps).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  datastore: ").Append(Datastore).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  dbUserName: ").Append(DbUserName).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  flavorRef: ").Append(FlavorRef).Append("\n");
            sb.Append("  flavorInfo: ").Append(FlavorInfo).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("  backupStrategy: ").Append(BackupStrategy).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  chargeInfo: ").Append(ChargeInfo).Append("\n");
            sb.Append("  dedicatedResourceId: ").Append(DedicatedResourceId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlInstanceListInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlInstanceListInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.PrivateIps != input.PrivateIps || (this.PrivateIps != null && input.PrivateIps != null && !this.PrivateIps.SequenceEqual(input.PrivateIps))) return false;
            if (this.ProxyIps != input.ProxyIps || (this.ProxyIps != null && input.ProxyIps != null && !this.ProxyIps.SequenceEqual(input.ProxyIps))) return false;
            if (this.ReadonlyPrivateIps != input.ReadonlyPrivateIps || (this.ReadonlyPrivateIps != null && input.ReadonlyPrivateIps != null && !this.ReadonlyPrivateIps.SequenceEqual(input.ReadonlyPrivateIps))) return false;
            if (this.PublicIps != input.PublicIps || (this.PublicIps != null && input.PublicIps != null && !this.PublicIps.SequenceEqual(input.PublicIps))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Datastore != input.Datastore || (this.Datastore != null && !this.Datastore.Equals(input.Datastore))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.Updated != input.Updated || (this.Updated != null && !this.Updated.Equals(input.Updated))) return false;
            if (this.DbUserName != input.DbUserName || (this.DbUserName != null && !this.DbUserName.Equals(input.DbUserName))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.SecurityGroupId != input.SecurityGroupId || (this.SecurityGroupId != null && !this.SecurityGroupId.Equals(input.SecurityGroupId))) return false;
            if (this.FlavorRef != input.FlavorRef || (this.FlavorRef != null && !this.FlavorRef.Equals(input.FlavorRef))) return false;
            if (this.FlavorInfo != input.FlavorInfo || (this.FlavorInfo != null && !this.FlavorInfo.Equals(input.FlavorInfo))) return false;
            if (this.Volume != input.Volume || (this.Volume != null && !this.Volume.Equals(input.Volume))) return false;
            if (this.BackupStrategy != input.BackupStrategy || (this.BackupStrategy != null && !this.BackupStrategy.Equals(input.BackupStrategy))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.TimeZone != input.TimeZone || (this.TimeZone != null && !this.TimeZone.Equals(input.TimeZone))) return false;
            if (this.ChargeInfo != input.ChargeInfo || (this.ChargeInfo != null && !this.ChargeInfo.Equals(input.ChargeInfo))) return false;
            if (this.DedicatedResourceId != input.DedicatedResourceId || (this.DedicatedResourceId != null && !this.DedicatedResourceId.Equals(input.DedicatedResourceId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PrivateIps != null) hashCode = hashCode * 59 + this.PrivateIps.GetHashCode();
                if (this.ProxyIps != null) hashCode = hashCode * 59 + this.ProxyIps.GetHashCode();
                if (this.ReadonlyPrivateIps != null) hashCode = hashCode * 59 + this.ReadonlyPrivateIps.GetHashCode();
                if (this.PublicIps != null) hashCode = hashCode * 59 + this.PublicIps.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Datastore != null) hashCode = hashCode * 59 + this.Datastore.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null) hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.DbUserName != null) hashCode = hashCode * 59 + this.DbUserName.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.SecurityGroupId != null) hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.FlavorRef != null) hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.FlavorInfo != null) hashCode = hashCode * 59 + this.FlavorInfo.GetHashCode();
                if (this.Volume != null) hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.BackupStrategy != null) hashCode = hashCode * 59 + this.BackupStrategy.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.TimeZone != null) hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.ChargeInfo != null) hashCode = hashCode * 59 + this.ChargeInfo.GetHashCode();
                if (this.DedicatedResourceId != null) hashCode = hashCode * 59 + this.DedicatedResourceId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
