using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 实例信息。
    /// </summary>
    public class OpengaussRestoreInstanceRequest 
    {

        /// <summary>
        /// 实例名称。 用于表示实例的名称，同一租户下，同类型的实例名可重名。 取值范围：4~64个字符之间，必须以字母开头，区分大小写，可以包含字母、数字、中划线或者下划线，不能包含其他的特殊字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 可用区ID。  GaussDB取值范围：非空，可选部署在同一可用区或三个不同可用区，可用区之间用逗号隔开。详见示例。  - 部署在同一可用区：需要输入三个相同的可用区。例如：部署在“cn-north-4a”可用区，则需要在此处输入\&quot;cn-north-4a,cn-north-4a,cn-north-4a\&quot;。 - 部署在三个不同可用区：需要分别输入三个不同的可用区。 取值范围：非空，请参见[地区和终端节点](https://developer.huaweicloud.com/endpoint)。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 规格码，取值范围：非空。参考[表1](https://support.huaweicloud.com/api-opengauss/opengauss_api_0037.html#opengauss_api_0037__ted9b9d433c8a4c52884e199e17f94479)中GaussDB 的“规格编码”列内容获取。
        /// </summary>
        [JsonProperty("flavor_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public OpenGaussVolume Volume { get; set; }

        /// <summary>
        /// 用于磁盘加密的密钥ID，默认为空。
        /// </summary>
        [JsonProperty("disk_encryption_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskEncryptionId { get; set; }

        /// <summary>
        /// 虚拟私有云ID，获取方法如下：  - 方法1：登录虚拟私有云服务的控制台界面，在虚拟私有云的详情页面查找VPC ID。 - 方法2：通过虚拟私有云服务的API接口查询，具体操作可参考[查询VPC列表](https://support.huaweicloud.com/api-vpc/vpc_api01_0003.html)。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 子网的网络ID信息，获取方法如下：  - 方法1：登录虚拟私有云服务的控制台界面，单击VPC下的子网，进入子网详情页面，查找网络ID。 - 方法2：通过虚拟私有云服务的API接口查询，具体操作可参考[查询子网列表](https://support.huaweicloud.com/api-vpc/vpc_subnet01_0003.html)。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 指定实例所属的安全组。如果不需要指定安全组，请联系客服申请白名单。  - 方法1：登录虚拟私有云服务的控制台界面，在安全组的详情页面查找安全组ID。 - 方法2：通过虚拟私有云服务的API接口查询，具体操作可参考[查询安全组列表](https://support.huaweicloud.com/api-vpc/vpc_sg01_0003.html)。
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 数据库密码。  取值范围：  非空，由大小写字母、数字和特殊符号~!@#%^*-_&#x3D;+?组成，长度8~32个字符。  建议您输入高强度密码，以提高安全性，防止出现密码被暴力破解等安全风险。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("charge_info", NullValueHandling = NullValueHandling.Ignore)]
        public OpenGaussChargeInfo ChargeInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("restore_point", NullValueHandling = NullValueHandling.Ignore)]
        public RestorePoint RestorePoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backup_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public OpenGaussBackupStrategy BackupStrategy { get; set; }

        /// <summary>
        /// 是否支持备份并行恢复。当不传该参数时，企业版默认为不支持，主备版默认支持。
        /// </summary>
        [JsonProperty("enable_parallel_restore", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableParallelRestore { get; set; }

        /// <summary>
        /// 参数组ID，当不传该参数时，使用系统默认的参数模板。
        /// </summary>
        [JsonProperty("configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigurationId { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 数据库对外开放的端口，不填默认为8000，可选范围为：1024-39998。限制端口： 2378,2379,2380,4999,5000,5999,6000,6001,8097,8098,12016,12017,20049,20050,21731,21732,32122,32123,32124。  - GaussDB数据库端口当前只支持设置为8000，当不传该参数时，默认端口为8000。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// 时区。  - 不选择时，国内站默认为UTC+08:00，国际站默认为UTC时间。 - 选择填写时，取值范围为UTC-12:00~UTC+12:00，且只支持整段时间，如UTC+08:00，不支持UTC+08:30。
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }

        /// <summary>
        /// enable_force_switch表示是否开启备机强升主功能，仅支持取值true，false。 enable_force_switch&#x3D;true表示开启备机强升主功能，enable_force_switch&#x3D;false表示关闭，默认关闭。仅支持1.2.2及以上版本。  说明：  备机强升主功能适用场景：在主机发生故障后，为了保障集群的可用性，强制拉起备机作为新主机对外提供服务的场景。 本功能在集群故障状态下，以丢失部分数据为代价换取集群尽可能快的恢复服务。本功能是集群状态为不可用时的一个逃生方法，如果操作者不清楚备机强升后丢失数据对业务的影响，请勿使用本功能。 备机强升主相关介绍请参考《故障处理》备机强升主章节。
        /// </summary>
        [JsonProperty("enable_force_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableForceSwitch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpengaussRestoreInstanceRequest {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  flavorRef: ").Append(FlavorRef).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("  diskEncryptionId: ").Append(DiskEncryptionId).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  chargeInfo: ").Append(ChargeInfo).Append("\n");
            sb.Append("  restorePoint: ").Append(RestorePoint).Append("\n");
            sb.Append("  backupStrategy: ").Append(BackupStrategy).Append("\n");
            sb.Append("  enableParallelRestore: ").Append(EnableParallelRestore).Append("\n");
            sb.Append("  configurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  enableForceSwitch: ").Append(EnableForceSwitch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpengaussRestoreInstanceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpengaussRestoreInstanceRequest input)
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
                    this.FlavorRef == input.FlavorRef ||
                    (this.FlavorRef != null &&
                    this.FlavorRef.Equals(input.FlavorRef))
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.DiskEncryptionId == input.DiskEncryptionId ||
                    (this.DiskEncryptionId != null &&
                    this.DiskEncryptionId.Equals(input.DiskEncryptionId))
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
                    this.ChargeInfo == input.ChargeInfo ||
                    (this.ChargeInfo != null &&
                    this.ChargeInfo.Equals(input.ChargeInfo))
                ) && 
                (
                    this.RestorePoint == input.RestorePoint ||
                    (this.RestorePoint != null &&
                    this.RestorePoint.Equals(input.RestorePoint))
                ) && 
                (
                    this.BackupStrategy == input.BackupStrategy ||
                    (this.BackupStrategy != null &&
                    this.BackupStrategy.Equals(input.BackupStrategy))
                ) && 
                (
                    this.EnableParallelRestore == input.EnableParallelRestore ||
                    (this.EnableParallelRestore != null &&
                    this.EnableParallelRestore.Equals(input.EnableParallelRestore))
                ) && 
                (
                    this.ConfigurationId == input.ConfigurationId ||
                    (this.ConfigurationId != null &&
                    this.ConfigurationId.Equals(input.ConfigurationId))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    this.EnableForceSwitch == input.EnableForceSwitch ||
                    (this.EnableForceSwitch != null &&
                    this.EnableForceSwitch.Equals(input.EnableForceSwitch))
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
                if (this.FlavorRef != null)
                    hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.DiskEncryptionId != null)
                    hashCode = hashCode * 59 + this.DiskEncryptionId.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.SecurityGroupId != null)
                    hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.ChargeInfo != null)
                    hashCode = hashCode * 59 + this.ChargeInfo.GetHashCode();
                if (this.RestorePoint != null)
                    hashCode = hashCode * 59 + this.RestorePoint.GetHashCode();
                if (this.BackupStrategy != null)
                    hashCode = hashCode * 59 + this.BackupStrategy.GetHashCode();
                if (this.EnableParallelRestore != null)
                    hashCode = hashCode * 59 + this.EnableParallelRestore.GetHashCode();
                if (this.ConfigurationId != null)
                    hashCode = hashCode * 59 + this.ConfigurationId.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.EnableForceSwitch != null)
                    hashCode = hashCode * 59 + this.EnableForceSwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
