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
    /// 实例信息
    /// </summary>
    public class OpenGaussInstanceRequestBody 
    {
        /// <summary>
        /// 实例副本数，支持取值2，3。不填默认为3。仅支持1.3.0及以上版本的实例。  说明： 2副本选项仅针对特定用户开放，如需配置白名单权限，您可以在管理控制台右上角，选择“[工单 &gt; 新建工单](https://auth.huaweicloud.com/authui/login.html?service&#x3D;https%3A%2F%2Fconsole.huaweicloud.com%2Fticket%2F%3Fregion%3Dcn-north-1%26locale%3Dzh-cn%26cloud_route_state%3D%2Fticketindex%2FcreateIndex#/login)”，提交开通白名单的申请。
        /// </summary>
        /// <value>实例副本数，支持取值2，3。不填默认为3。仅支持1.3.0及以上版本的实例。  说明： 2副本选项仅针对特定用户开放，如需配置白名单权限，您可以在管理控制台右上角，选择“[工单 &gt; 新建工单](https://auth.huaweicloud.com/authui/login.html?service&#x3D;https%3A%2F%2Fconsole.huaweicloud.com%2Fticket%2F%3Fregion%3Dcn-north-1%26locale%3Dzh-cn%26cloud_route_state%3D%2Fticketindex%2FcreateIndex#/login)”，提交开通白名单的申请。</value>
        [JsonConverter(typeof(EnumClassConverter<ReplicaNumEnum>))]
        public class ReplicaNumEnum
        {
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly ReplicaNumEnum NUMBER_2 = new ReplicaNumEnum(2);

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            public static readonly ReplicaNumEnum NUMBER_3 = new ReplicaNumEnum(3);

            private static readonly Dictionary<int?, ReplicaNumEnum> StaticFields =
            new Dictionary<int?, ReplicaNumEnum>()
            {
                { 2, NUMBER_2 },
                { 3, NUMBER_3 },
            };

            private int? _value;

            public ReplicaNumEnum()
            {

            }

            public ReplicaNumEnum(int? value)
            {
                _value = value;
            }

            public static ReplicaNumEnum FromValue(int? value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public int? GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ReplicaNumEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ReplicaNumEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ReplicaNumEnum a, ReplicaNumEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ReplicaNumEnum a, ReplicaNumEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例名称。 用于表示实例的名称，同一租户下，同类型的实例名可重名。  取值范围：4~64个字符之间，必须以字母开头，区分大小写，可以包含字母、数字、中划线或者下划线，不能包含其他的特殊字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("datastore", NullValueHandling = NullValueHandling.Ignore)]
        public OpenGaussDatastoreOption Datastore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ha", NullValueHandling = NullValueHandling.Ignore)]
        public OpenGaussHaOption Ha { get; set; }

        /// <summary>
        /// 参数模板ID。当不传该参数时，使用系统默认的参数模板。
        /// </summary>
        [JsonProperty("configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigurationId { get; set; }

        /// <summary>
        /// 数据库对外开放的端口，不填默认为8000，可选范围为：1024-39998。限制端口： 2378,2379,2380,4999,5000,5999,6000,6001,8097,8098,12016,12017,20049,20050,21731,21732,32122,32123,32124。  - GaussDB数据库端口当前只支持设置为8000，当不传该参数时，默认端口为8000。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// 数据库密码。必选。  取值范围：  &#39;非空； 至少包含大写字母（A-Z），小写字母（a-z），数字（0-9），非字母数字字符（限定为~!@#%^*-_&#x3D;+?,）四类字符中的三类字符；长度8~32个字符。&#39;  &#39;建议您输入高强度密码，以提高安全性，防止出现密码被暴力破解等安全风险。&#39;
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backup_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public OpenGaussBackupStrategy BackupStrategy { get; set; }

        /// <summary>
        /// 企业项目ID。只有企业租户时该参数才生效。  使用请参考《企业管理 API参考》的“[查询企业项目列表](https://support.huaweicloud.com/api-em/zh-cn_topic_0121230880.html)”响应消息表“enterprise_project字段数据结构说明”的“id”。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 用于磁盘加密的密钥ID，默认为空。
        /// </summary>
        [JsonProperty("disk_encryption_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskEncryptionId { get; set; }

        /// <summary>
        /// 规格码，取值范围：非空。参考[表1](https://support.huaweicloud.com/api-opengauss/opengauss_api_0037.html#opengauss_api_0037__ted9b9d433c8a4c52884e199e17f94479)中GaussDB的“规格编码”列内容获取。
        /// </summary>
        [JsonProperty("flavor_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public OpenGaussVolume Volume { get; set; }

        /// <summary>
        /// 区域ID。  取值范围：非空，请参见[地区和终端节点](https://developer.huaweicloud.com/endpoint)。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 可用区ID。  GaussDB取值范围：非空，可选部署在同一可用区或三个不同可用区，可用区之间用逗号隔开。详见示例。  - 部署在同一可用区：需要输入三个相同的可用区。例如：部署在“cn-north-4a”可用区，则需要在此处输入\&quot;cn-north-4a,cn-north-4a,cn-north-4a\&quot;。 - 部署在三个不同可用区：需要分别输入三个不同的可用区。 取值范围：非空，请参见[地区和终端节点](https://developer.huaweicloud.com/endpoint)。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

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
        /// 
        /// </summary>
        [JsonProperty("charge_info", NullValueHandling = NullValueHandling.Ignore)]
        public OpenGaussChargeInfo ChargeInfo { get; set; }

        /// <summary>
        /// UTC时区。  - 不选择时，GaussDB国内站、默认为UTC时间。 - 选择填写时，取值范围为UTC-12:00~UTC+12:00，且只支持整段时间，如UTC+08:00，不支持UTC+08:30。
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }

        /// <summary>
        /// 仅分布式形态需要填写该参数。分片数量，取值范围1~9。
        /// </summary>
        [JsonProperty("sharding_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShardingNum { get; set; }

        /// <summary>
        /// 仅分布式形态需要填写该参数。协调节点数量，取值范围1~9。CN数量必须小于或等于两倍的分片数。
        /// </summary>
        [JsonProperty("coordinator_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CoordinatorNum { get; set; }

        /// <summary>
        /// 实例副本数，支持取值2，3。不填默认为3。仅支持1.3.0及以上版本的实例。  说明： 2副本选项仅针对特定用户开放，如需配置白名单权限，您可以在管理控制台右上角，选择“[工单 &gt; 新建工单](https://auth.huaweicloud.com/authui/login.html?service&#x3D;https%3A%2F%2Fconsole.huaweicloud.com%2Fticket%2F%3Fregion%3Dcn-north-1%26locale%3Dzh-cn%26cloud_route_state%3D%2Fticketindex%2FcreateIndex#/login)”，提交开通白名单的申请。
        /// </summary>
        [JsonProperty("replica_num", NullValueHandling = NullValueHandling.Ignore)]
        public ReplicaNumEnum ReplicaNum { get; set; }
        /// <summary>
        /// enable_force_switch表示是否开启备机强升主功能，enable_force_switch&#x3D;true表示开启备机强升主功能，enable_force_switch&#x3D;false表示关闭，默认关闭。仅支持1.2.2及以上版本。  说明：  备机强升主功能适用场景：在主机发生故障后，为了保障集群的可用性，强制拉起备机作为新主机对外提供服务的场景。 本功能在集群故障状态下，以丢失部分数据为代价换取集群尽可能快的恢复服务。本功能是集群状态为不可用时的一个逃生方法，如果操作者不清楚备机强升后丢失数据对业务的影响，请勿使用本功能。 备机强升主相关介绍请参考《故障处理》备机强升主章节。
        /// </summary>
        [JsonProperty("enable_force_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableForceSwitch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenGaussInstanceRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  datastore: ").Append(Datastore).Append("\n");
            sb.Append("  ha: ").Append(Ha).Append("\n");
            sb.Append("  configurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  backupStrategy: ").Append(BackupStrategy).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  diskEncryptionId: ").Append(DiskEncryptionId).Append("\n");
            sb.Append("  flavorRef: ").Append(FlavorRef).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  chargeInfo: ").Append(ChargeInfo).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  shardingNum: ").Append(ShardingNum).Append("\n");
            sb.Append("  coordinatorNum: ").Append(CoordinatorNum).Append("\n");
            sb.Append("  replicaNum: ").Append(ReplicaNum).Append("\n");
            sb.Append("  enableForceSwitch: ").Append(EnableForceSwitch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpenGaussInstanceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpenGaussInstanceRequestBody input)
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
                    this.Ha == input.Ha ||
                    (this.Ha != null &&
                    this.Ha.Equals(input.Ha))
                ) && 
                (
                    this.ConfigurationId == input.ConfigurationId ||
                    (this.ConfigurationId != null &&
                    this.ConfigurationId.Equals(input.ConfigurationId))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
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
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.DiskEncryptionId == input.DiskEncryptionId ||
                    (this.DiskEncryptionId != null &&
                    this.DiskEncryptionId.Equals(input.DiskEncryptionId))
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
                    this.ChargeInfo == input.ChargeInfo ||
                    (this.ChargeInfo != null &&
                    this.ChargeInfo.Equals(input.ChargeInfo))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    this.ShardingNum == input.ShardingNum ||
                    (this.ShardingNum != null &&
                    this.ShardingNum.Equals(input.ShardingNum))
                ) && 
                (
                    this.CoordinatorNum == input.CoordinatorNum ||
                    (this.CoordinatorNum != null &&
                    this.CoordinatorNum.Equals(input.CoordinatorNum))
                ) && 
                (
                    this.ReplicaNum == input.ReplicaNum ||
                    (this.ReplicaNum != null &&
                    this.ReplicaNum.Equals(input.ReplicaNum))
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
                if (this.Datastore != null)
                    hashCode = hashCode * 59 + this.Datastore.GetHashCode();
                if (this.Ha != null)
                    hashCode = hashCode * 59 + this.Ha.GetHashCode();
                if (this.ConfigurationId != null)
                    hashCode = hashCode * 59 + this.ConfigurationId.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.BackupStrategy != null)
                    hashCode = hashCode * 59 + this.BackupStrategy.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.DiskEncryptionId != null)
                    hashCode = hashCode * 59 + this.DiskEncryptionId.GetHashCode();
                if (this.FlavorRef != null)
                    hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
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
                if (this.ChargeInfo != null)
                    hashCode = hashCode * 59 + this.ChargeInfo.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.ShardingNum != null)
                    hashCode = hashCode * 59 + this.ShardingNum.GetHashCode();
                if (this.CoordinatorNum != null)
                    hashCode = hashCode * 59 + this.CoordinatorNum.GetHashCode();
                if (this.ReplicaNum != null)
                    hashCode = hashCode * 59 + this.ReplicaNum.GetHashCode();
                if (this.EnableForceSwitch != null)
                    hashCode = hashCode * 59 + this.EnableForceSwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
