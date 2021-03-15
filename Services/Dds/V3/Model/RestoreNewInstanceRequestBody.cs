using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 实例信息。
    /// </summary>
    public class RestoreNewInstanceRequestBody 
    {

        /// <summary>
        /// 实例名称。用于表示实例的名称，用于表示实例的名称，同一租户下，同类型的实例名唯一。 取值范围：长度为4~64位，必须以字母开头（A~Z或a~z），区分大小写，可以包含字母、数字（0~9）、中划线（-）或者下划线（_），不能包含其他特殊字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 可用区ID。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 虚拟私有云ID。获取方法请参见《虚拟私有云API参考》中“VPC”的内容。 取值：非空，字符长度校验，严格UUID正则校验。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 子网ID。获取方法请参见《虚拟私有云API参考》中“子网”的内容。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 指定实例所属的安全组ID。 获取方法请参见《虚拟私有云API参考》中“安全组”的内容。
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 数据库密码。 取值范围：长度为8~32位，必须是大写字母（A~Z）、小写字母（a~z）、数字（0~9）、特殊字符~!@#%^*-_&#x3D;+?的组合。 建议您输入高强度密码，以提高安全性，防止出现密码被暴力破解等安全风险。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 磁盘加密时的密钥ID，严格UUID正则校验。 不传该参数时，表示不进行磁盘加密。
        /// </summary>
        [JsonProperty("disk_encryption_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskEncryptionId { get; set; }

        /// <summary>
        /// 实例规格详情。
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public List<RestoreNewInstanceFlavorOption> Flavor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backup_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public BackupStrategy BackupStrategy { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// SSL开关选项。 取值： - 取“0”，表示DDS实例默认不启用SSL连接。 - 取“1”，表示DDS实例默认启用SSL连接。 - 不传该参数时，默认启用SSL连接。
        /// </summary>
        [JsonProperty("ssl_option", NullValueHandling = NullValueHandling.Ignore)]
        public string SslOption { get; set; }

        /// <summary>
        /// 创建新实例所在专属存储池ID，仅专属云创建实例时有效。
        /// </summary>
        [JsonProperty("dss_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DssPoolId { get; set; }

        /// <summary>
        /// 创建新实例设置云服务器组关联的策略名称列表，仅专属云创建实例时有效。 取值    - 取“anti-affinity”，表示DDS实例开启反亲和部署，反亲和部署是出于高可用性考虑，将您的Primary、Secondary和Hidden节点分别创建在不同的物理机上。当前仅支持该值，不传该值默认不开启反亲和部署。
        /// </summary>
        [JsonProperty("server_group_policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ServerGroupPolicies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("restore_point", NullValueHandling = NullValueHandling.Ignore)]
        public RestorePoint RestorePoint { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestoreNewInstanceRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  diskEncryptionId: ").Append(DiskEncryptionId).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  backupStrategy: ").Append(BackupStrategy).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  sslOption: ").Append(SslOption).Append("\n");
            sb.Append("  dssPoolId: ").Append(DssPoolId).Append("\n");
            sb.Append("  serverGroupPolicies: ").Append(ServerGroupPolicies).Append("\n");
            sb.Append("  restorePoint: ").Append(RestorePoint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestoreNewInstanceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestoreNewInstanceRequestBody input)
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
                    this.DiskEncryptionId == input.DiskEncryptionId ||
                    (this.DiskEncryptionId != null &&
                    this.DiskEncryptionId.Equals(input.DiskEncryptionId))
                ) && 
                (
                    this.Flavor == input.Flavor ||
                    this.Flavor != null &&
                    input.Flavor != null &&
                    this.Flavor.SequenceEqual(input.Flavor)
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
                    this.SslOption == input.SslOption ||
                    (this.SslOption != null &&
                    this.SslOption.Equals(input.SslOption))
                ) && 
                (
                    this.DssPoolId == input.DssPoolId ||
                    (this.DssPoolId != null &&
                    this.DssPoolId.Equals(input.DssPoolId))
                ) && 
                (
                    this.ServerGroupPolicies == input.ServerGroupPolicies ||
                    this.ServerGroupPolicies != null &&
                    input.ServerGroupPolicies != null &&
                    this.ServerGroupPolicies.SequenceEqual(input.ServerGroupPolicies)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
                if (this.DiskEncryptionId != null)
                    hashCode = hashCode * 59 + this.DiskEncryptionId.GetHashCode();
                if (this.Flavor != null)
                    hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.BackupStrategy != null)
                    hashCode = hashCode * 59 + this.BackupStrategy.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.SslOption != null)
                    hashCode = hashCode * 59 + this.SslOption.GetHashCode();
                if (this.DssPoolId != null)
                    hashCode = hashCode * 59 + this.DssPoolId.GetHashCode();
                if (this.ServerGroupPolicies != null)
                    hashCode = hashCode * 59 + this.ServerGroupPolicies.GetHashCode();
                if (this.RestorePoint != null)
                    hashCode = hashCode * 59 + this.RestorePoint.GetHashCode();
                return hashCode;
            }
        }
    }
}
