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
    /// 实例信息
    /// </summary>
    public class MysqlInstanceRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("charge_info", NullValueHandling = NullValueHandling.Ignore)]
        public MysqlChargeInfo ChargeInfo { get; set; }

        /// <summary>
        /// 区域ID。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 实例名称。用于表示实例的名称，同一租户下，同类型的实例名可重名。  取值范围：4~64个字符之间，必须以字母开头，区分大小写，可以包含字母、数字、中划线或者下划线，不能包含其他的特殊字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("datastore", NullValueHandling = NullValueHandling.Ignore)]
        public MysqlDatastoreInReq Datastore { get; set; }

        /// <summary>
        /// 实例类型，目前仅支持Cluster。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// 规格码。
        /// </summary>
        [JsonProperty("flavor_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// 虚拟私有云ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 子网的网络ID。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 安全组ID。如果实例所选用的子网开启网络ACL进行访问控制，则该参数非必选。如果未开启ACL进行访问控制，则该参数必选。
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 参数模板ID。
        /// </summary>
        [JsonProperty("configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigurationId { get; set; }

        /// <summary>
        /// 数据库密码。  取值范围：至少包含以下字符的三种：大小写字母、数字和特殊符号~!@#$%^*-_&#x3D;+?,()&amp;，长度8~32个字符。 建议您输入高强度密码，以提高安全性，防止出现密码被暴力破解等安全风险。如果您输入弱密码，系统会自动判定密码非法。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backup_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public MysqlBackupStrategy BackupStrategy { get; set; }

        /// <summary>
        /// 时区。默认时区为UTC。
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }

        /// <summary>
        /// 可用区类型,单可用区single或多可用区multi。
        /// </summary>
        [JsonProperty("availability_zone_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZoneMode { get; set; }

        /// <summary>
        /// 主可用区。
        /// </summary>
        [JsonProperty("master_availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterAvailabilityZone { get; set; }

        /// <summary>
        /// 只读节点个数。单次接口调用最多支持创建9个只读节点。
        /// </summary>
        [JsonProperty("slave_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SlaveCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public MysqlVolume Volume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<MysqlTags> Tags { get; set; }

        /// <summary>
        /// 表名大小写是否敏感，默认值是“1”。  取值范围： - 0：表名被存储成固定且表名称大小写敏感。 - 1：表名将被存储成小写且表名称大小写不敏感。
        /// </summary>
        [JsonProperty("lower_case_table_names", NullValueHandling = NullValueHandling.Ignore)]
        public int? LowerCaseTableNames { get; set; }

        /// <summary>
        /// 企业项目ID。如果账户开通企业项目服务则该参数必选，未开启该参数不可选。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 专属资源池ID，只有开通专属资源池后才可以下发此参数。
        /// </summary>
        [JsonProperty("dedicated_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("restore_point", NullValueHandling = NullValueHandling.Ignore)]
        public MysqlRestorePoint RestorePoint { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlInstanceRequest {\n");
            sb.Append("  chargeInfo: ").Append(ChargeInfo).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  datastore: ").Append(Datastore).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  flavorRef: ").Append(FlavorRef).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  configurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  backupStrategy: ").Append(BackupStrategy).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  availabilityZoneMode: ").Append(AvailabilityZoneMode).Append("\n");
            sb.Append("  masterAvailabilityZone: ").Append(MasterAvailabilityZone).Append("\n");
            sb.Append("  slaveCount: ").Append(SlaveCount).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  lowerCaseTableNames: ").Append(LowerCaseTableNames).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  dedicatedResourceId: ").Append(DedicatedResourceId).Append("\n");
            sb.Append("  restorePoint: ").Append(RestorePoint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlInstanceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlInstanceRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChargeInfo == input.ChargeInfo ||
                    (this.ChargeInfo != null &&
                    this.ChargeInfo.Equals(input.ChargeInfo))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
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
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.FlavorRef == input.FlavorRef ||
                    (this.FlavorRef != null &&
                    this.FlavorRef.Equals(input.FlavorRef))
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
                    this.ConfigurationId == input.ConfigurationId ||
                    (this.ConfigurationId != null &&
                    this.ConfigurationId.Equals(input.ConfigurationId))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.BackupStrategy == input.BackupStrategy ||
                    (this.BackupStrategy != null &&
                    this.BackupStrategy.Equals(input.BackupStrategy))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    this.AvailabilityZoneMode == input.AvailabilityZoneMode ||
                    (this.AvailabilityZoneMode != null &&
                    this.AvailabilityZoneMode.Equals(input.AvailabilityZoneMode))
                ) && 
                (
                    this.MasterAvailabilityZone == input.MasterAvailabilityZone ||
                    (this.MasterAvailabilityZone != null &&
                    this.MasterAvailabilityZone.Equals(input.MasterAvailabilityZone))
                ) && 
                (
                    this.SlaveCount == input.SlaveCount ||
                    (this.SlaveCount != null &&
                    this.SlaveCount.Equals(input.SlaveCount))
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.LowerCaseTableNames == input.LowerCaseTableNames ||
                    (this.LowerCaseTableNames != null &&
                    this.LowerCaseTableNames.Equals(input.LowerCaseTableNames))
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
                    this.RestorePoint == input.RestorePoint ||
                    (this.RestorePoint != null &&
                    this.RestorePoint.Equals(input.RestorePoint))
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
                if (this.ChargeInfo != null)
                    hashCode = hashCode * 59 + this.ChargeInfo.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Datastore != null)
                    hashCode = hashCode * 59 + this.Datastore.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.FlavorRef != null)
                    hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.SecurityGroupId != null)
                    hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.ConfigurationId != null)
                    hashCode = hashCode * 59 + this.ConfigurationId.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.BackupStrategy != null)
                    hashCode = hashCode * 59 + this.BackupStrategy.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.AvailabilityZoneMode != null)
                    hashCode = hashCode * 59 + this.AvailabilityZoneMode.GetHashCode();
                if (this.MasterAvailabilityZone != null)
                    hashCode = hashCode * 59 + this.MasterAvailabilityZone.GetHashCode();
                if (this.SlaveCount != null)
                    hashCode = hashCode * 59 + this.SlaveCount.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.LowerCaseTableNames != null)
                    hashCode = hashCode * 59 + this.LowerCaseTableNames.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.DedicatedResourceId != null)
                    hashCode = hashCode * 59 + this.DedicatedResourceId.GetHashCode();
                if (this.RestorePoint != null)
                    hashCode = hashCode * 59 + this.RestorePoint.GetHashCode();
                return hashCode;
            }
        }
    }
}
