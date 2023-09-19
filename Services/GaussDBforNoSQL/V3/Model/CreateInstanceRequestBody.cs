using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 实例信息。
    /// </summary>
    public class CreateInstanceRequestBody 
    {

        /// <summary>
        /// 实例名称，允许和已有名称重复。 取值范围：长度为4~64位，必须以字母开头（A~Z或a~z），区分大小写，可以包含字母、数字（0~9）、中划线（-）或者下划线（_），不能包含其他特殊字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("datastore", NullValueHandling = NullValueHandling.Ignore)]
        public DatastoreOption Datastore { get; set; }

        /// <summary>
        /// - 区域ID - 取值：非空。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 可用区ID。 取值：请参见查询所有实例规格信息中返回的“az_status” ，支持创建3可用区实例，中间以逗号隔开。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 虚拟私有云ID，获取方法如下：   - 方法1：登录虚拟私有云服务的控制台界面，在虚拟私有云的详情页面查找VPC ID。   - 方法2：通过虚拟私有云服务的API接口查询，具体操作可参考查询VPC列表。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 子网的网络ID，获取方法如下：   - 方法1：登录虚拟私有云服务的控制台界面，单击VPC下的子网，进入子网详情页面，查找网络ID。   - 方法2：通过虚拟私有云服务的API接口查询，具体操作可参考查询子网列表。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 安全组ID，获取方法如下：   - 方法1：登录虚拟私有云服务的控制台界面，在安全组的详情页面查找安全组ID。   - 方法2：通过虚拟私有云服务的API接口查询，具体操作可参考查询安全组列表。
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 数据库密码。 取值范围：长度为8~32位，必须是大写字母（A~Z）、小写字母（a~z）、数字（0~9）、特殊字符~!@#%^*-_&#x3D;+?的组合。 建议您输入高强度密码，以提高安全性，防止出现密码被暴力破解等安全风险。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 实例类型。   - GaussDB(for Cassandra)支持集群类型，取值为“Cluster”。   - GaussDB(for Mongo)4.0版本支持副本集类型，取值为“ReplicaSet”。   - GaussDB(for Influx)支持集群类型，取值为“Cluster”。   - GaussDB(for Influx)支持单节点类型，取值为“InfluxdbSingle”。   - GaussDB(for redis)支持集群类型，取值为“Cluster”。   - GaussDB(for redis)支持主备类型，取值为“Replication”。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// 实例规格详情。获取方法请参见查询所有实例规格信息中响应“flavors”字段下参数的值。
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateInstanceFlavorOption> Flavor { get; set; }

        /// <summary>
        /// 参数模板ID。
        /// </summary>
        [JsonProperty("configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigurationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backup_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public BackupStrategyOption BackupStrategy { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 专属资源ID，只有开通专属资源池后才可以下发此参数。
        /// </summary>
        [JsonProperty("dedicated_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedResourceId { get; set; }

        /// <summary>
        /// SSL开关选项。 取值： - 取“0”，表示DDS实例默认不启用SSL连接。 - 取“1”，表示DDS实例默认启用SSL连接。 - 不传该参数时，默认不启用SSL连接。
        /// </summary>
        [JsonProperty("ssl_option", NullValueHandling = NullValueHandling.Ignore)]
        public string SslOption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("charge_info", NullValueHandling = NullValueHandling.Ignore)]
        public ChargeInfoOption ChargeInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("restore_info", NullValueHandling = NullValueHandling.Ignore)]
        public RestoreInfo RestoreInfo { get; set; }

        /// <summary>
        /// 数据库访问端口号。 目前仅支持GaussDB(for Redis)实例支持自定义端口，取值范围为：1024~65535，禁用端口号为：2180、2887、3887、6377、6378、6380、8018、8079、8091、8479、8484、8999、12017、12333、50069。 不指定端口时，创建GaussDB(for Redis)实例的访问端口默认为6379。 如果该实例计划用于搭建双活容灾场景，请配置为8635端口。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("availability_zone_detail", NullValueHandling = NullValueHandling.Ignore)]
        public AvailabilityZoneDetail AvailabilityZoneDetail { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateInstanceRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  datastore: ").Append(Datastore).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  configurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  backupStrategy: ").Append(BackupStrategy).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  dedicatedResourceId: ").Append(DedicatedResourceId).Append("\n");
            sb.Append("  sslOption: ").Append(SslOption).Append("\n");
            sb.Append("  chargeInfo: ").Append(ChargeInfo).Append("\n");
            sb.Append("  restoreInfo: ").Append(RestoreInfo).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  availabilityZoneDetail: ").Append(AvailabilityZoneDetail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateInstanceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateInstanceRequestBody input)
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
                    this.Datastore == input.Datastore ||
                    (this.Datastore != null &&
                    this.Datastore.Equals(input.Datastore))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.AvailabilityZone == input.AvailabilityZone ||
                    (this.AvailabilityZone != null &&
                    this.AvailabilityZone.Equals(input.AvailabilityZone))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.SubnetId == input.SubnetId ||
                    (this.SubnetId != null &&
                    this.SubnetId.Equals(input.SubnetId))
                ) && 
                (
                    this.SecurityGroupId == input.SecurityGroupId ||
                    (this.SecurityGroupId != null &&
                    this.SecurityGroupId.Equals(input.SecurityGroupId))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.Flavor == input.Flavor ||
                    this.Flavor != null &&
                    input.Flavor != null &&
                    this.Flavor.SequenceEqual(input.Flavor)
                ) && 
                (
                    this.ConfigurationId == input.ConfigurationId ||
                    (this.ConfigurationId != null &&
                    this.ConfigurationId.Equals(input.ConfigurationId))
                ) && 
                (
                    this.BackupStrategy == input.BackupStrategy ||
                    (this.BackupStrategy != null &&
                    this.BackupStrategy.Equals(input.BackupStrategy))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.DedicatedResourceId == input.DedicatedResourceId ||
                    (this.DedicatedResourceId != null &&
                    this.DedicatedResourceId.Equals(input.DedicatedResourceId))
                ) && 
                (
                    this.SslOption == input.SslOption ||
                    (this.SslOption != null &&
                    this.SslOption.Equals(input.SslOption))
                ) && 
                (
                    this.ChargeInfo == input.ChargeInfo ||
                    (this.ChargeInfo != null &&
                    this.ChargeInfo.Equals(input.ChargeInfo))
                ) && 
                (
                    this.RestoreInfo == input.RestoreInfo ||
                    (this.RestoreInfo != null &&
                    this.RestoreInfo.Equals(input.RestoreInfo))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.AvailabilityZoneDetail == input.AvailabilityZoneDetail ||
                    (this.AvailabilityZoneDetail != null &&
                    this.AvailabilityZoneDetail.Equals(input.AvailabilityZoneDetail))
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
                if (this.Datastore != null)
                    hashCode = hashCode * 59 + this.Datastore.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.AvailabilityZone != null)
                    hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.SecurityGroupId != null)
                    hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Flavor != null)
                    hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.ConfigurationId != null)
                    hashCode = hashCode * 59 + this.ConfigurationId.GetHashCode();
                if (this.BackupStrategy != null)
                    hashCode = hashCode * 59 + this.BackupStrategy.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.DedicatedResourceId != null)
                    hashCode = hashCode * 59 + this.DedicatedResourceId.GetHashCode();
                if (this.SslOption != null)
                    hashCode = hashCode * 59 + this.SslOption.GetHashCode();
                if (this.ChargeInfo != null)
                    hashCode = hashCode * 59 + this.ChargeInfo.GetHashCode();
                if (this.RestoreInfo != null)
                    hashCode = hashCode * 59 + this.RestoreInfo.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.AvailabilityZoneDetail != null)
                    hashCode = hashCode * 59 + this.AvailabilityZoneDetail.GetHashCode();
                return hashCode;
            }
        }
    }
}
