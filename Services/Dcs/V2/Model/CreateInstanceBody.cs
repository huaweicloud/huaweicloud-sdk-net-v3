using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateInstanceBody 
    {

        /// <summary>
        /// Redis缓存实例绑定的弹性IP地址的id。  如果开启了公网访问功能（即enable_publicip为true），该字段为必选。 
        /// </summary>
        [JsonProperty("publicip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipId { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 企业项目名称。
        /// </summary>
        [JsonProperty("enterprise_project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectName { get; set; }

        /// <summary>
        /// 虚拟私有云ID。  获取方法如下：   - 方法1：登录虚拟私有云服务的控制台界面，在虚拟私有云的详情页面查找VPC ID。   - 方法2：通过虚拟私有云服务的API接口查询，具体操作可参考[查询VPC列表](https://support.huaweicloud.com/api-vpc/vpc_api01_0003.html) 
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 实例的描述信息。  长度不超过1024的字符串。 &gt; \\与\&quot;在json报文中属于特殊字符，如果参数值中需要显示\\或者\&quot;字符，请在字符前增加转义字符\\，比如\\\\或者\\\&quot;。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 指定实例所属的安全组。  获取方法如下： - 方法1：登录虚拟私有云服务的控制台界面，在安全组的详情页面查找安全组ID。 - 方法2：通过虚拟私有云服务的API接口查询，具体操作可参考[查询安全组列表](https://support.huaweicloud.com/api-vpc/vpc_sg01_0002.html) 
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// Redis缓存实例开启公网访问功能时，是否选择支持ssl。 - true：开启 - false：不开启 
        /// </summary>
        [JsonProperty("enable_ssl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSsl { get; set; }

        /// <summary>
        /// 创建缓存实例手动指定的IP地址,支持Redis和Memcached。
        /// </summary>
        [JsonProperty("private_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// 缓存容量（G Byte） - Redis3.0：单机和主备类型实例取值：2、4、8、16、32、64。Proxy集群实例规格支持64、128、256、512和1024。 - Redis4.0和Redis5.0：单机和主备类型实例取值：0.125、0.25、0.5、1、2、4、8、16、32、64。Cluster集群实例规格支持24、32、48、64、96、128、192、256、384、512、768、1024。 - Memcached：单机和主备类型实例取值：2、4、8、16、32、64。 
        /// </summary>
        [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
        public float? Capacity { get; set; }

        /// <summary>
        /// 表示批量创建缓存实例时，购买的实例个数。仅Redis和Memcached实例支持批量创建。  默认值：1  取值范围：1-100 
        /// </summary>
        [JsonProperty("instance_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceNum { get; set; }

        /// <summary>
        /// 维护时间窗开始时间，格式为HH:mm:ss - 维护时间窗开始和结束时间必须为指定的时间段，可参考[查询维护时间窗时间段](https://support.huaweicloud.com/api-dcs/ListMaintenanceWindows.html)获取 - 开始时间必须为22:00:00、02:00:00、06:00:00、10:00:00、14:00:00和18:00:00。 - 该参数不能单独为空，若该值为空，则结束时间也为空。系统分配一个默认开始时间02:00:00。 
        /// </summary>
        [JsonProperty("maintain_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string MaintainBegin { get; set; }

        /// <summary>
        /// 维护时间窗结束时间，格式为HH:mm:ss。 - 维护时间窗开始和结束时间必须为指定的时间段，可参考[查询维护时间窗时间段](https://support.huaweicloud.com/api-dcs/ListMaintenanceWindows.html)获取 - 结束时间在开始时间基础上加四个小时，即当开始时间为22:00:00时，结束时间为02:00:00。 - 该参数不能单独为空，若该值为空，则开始时间也为空，系统分配一个默认结束时间06:00:00。 
        /// </summary>
        [JsonProperty("maintain_end", NullValueHandling = NullValueHandling.Ignore)]
        public string MaintainEnd { get; set; }

        /// <summary>
        /// 缓存实例的认证信息 &gt; 当“no_password_access”配置为“false”或未配置时，请求消息中须包含password参数。 Redis类型的缓存实例密码复杂度要求： - 输入长度为8到32位的字符串。 - 新密码不能与旧密码相同。 - 必须包含如下四种字符中的三种组合：   - 小写字母   - 大写字母   - 数字   - 特殊字符包括（&#x60;~!@#$%^&amp;*()-_&#x3D;+\\|[{}]:&#39;\&quot;,&lt;.&gt;/?） 
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 缓存引擎：Redis和Memcached。
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public string Engine { get; set; }

        /// <summary>
        /// 缓存版本，当缓存引擎为Redis时，取值为3.0、4.0或5.0。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// 产品规格编码。
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// 是否允许免密码访问缓存实例。 - true：该实例无需密码即可访问。 - false：该实例必须通过密码认证才能访问。 若未配置该参数则默认值为“false”。 
        /// </summary>
        [JsonProperty("no_password_access", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NoPasswordAccess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bss_param", NullValueHandling = NullValueHandling.Ignore)]
        public BssParam BssParam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("instance_backup_policy", NullValueHandling = NullValueHandling.Ignore)]
        public BackupPolicy InstanceBackupPolicy { get; set; }

        /// <summary>
        /// 创建缓存节点到指定且有资源的可用区Code。创建缓存节点到指定且有资源的可用区Code。具体查询方法，请参考[查询可用区信息](https://support.huaweicloud.com/api-dcs/ListAvailableZones.html),，在查询时，请注意查看该可用区是否有资源。  如果是创建主备、Proxy集群、Cluster集群实例，支持跨可用区部署，可以为备节点指定备可用区。在为节点指定可用区时，用逗号分隔开，具体请查看示例。 
        /// </summary>
        [JsonProperty("az_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AzCodes { get; set; }

        /// <summary>
        /// 实例标签键值。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTag> Tags { get; set; }

        /// <summary>
        /// 当缓存类型为Redis时，则不需要设置，保持为空即可。  当缓存引擎为Memcached，且“no_password_access”为“false”时才需要设置，表示通过密码认证访问缓存实例的认证用户名。  由英文字符开头，只能由英文字母、数字、中划线和下划线组成，长度为1~64的字符。 &gt;   - 当缓存引擎为Memcached时，该参数为可选项。   - 当缓存引擎为Redis时，该参数不需要设置。 
        /// </summary>
        [JsonProperty("access_user", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessUser { get; set; }

        /// <summary>
        /// Redis缓存实例是否开启公网访问功能。 - true：开启 - false：不开启 
        /// </summary>
        [JsonProperty("enable_publicip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePublicip { get; set; }

        /// <summary>
        /// 实例名称。 由英文字符开头，只能由英文字母、数字、中划线和下划线组成。 创建单个实例时，名称长度为4到64位的字符串。批量创建实例时，名称长度为4到56位的字符串，且实例名称格式为“自定义名称-n”，其中n从000开始，依次递增。例如，批量创建两个实例，自定义名称为dcs_demo，则两个实例的名称为dcs_demo-000和dcs_demo-001。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 子网的网络ID。  获取方法如下： - 方法1：登录虚拟私有云服务的控制台界面，单击VPC下的子网，进入子网详情页面，查找网络ID。 - 方法2：通过虚拟私有云服务的API接口查询，具体操作可参考[查询子网列表](https://support.huaweicloud.com/api-vpc/vpc_subnet01_0003.html) 
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 实例自定义端口。只有创建Redis4.0和Redis5.0实例才支持自定义端口，Redis3.0和Memcached实例不支持。  创建Redis4.0和Redis5.0实例，如果没发送该参数或该参数为空，表示实例使用默认端口6379。如果自定义端口，端口范围为1~65535的任意数字。 
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// 支持自定义重命名高危命令。只有创建Redis4.0和Redis5.0实例才支持重命名高危命令，Redis3.0和Memcached实例不支持。  创建Redis4.0和Redis5.0实例，如果没发送该参数或该参数为空，表示没有需要重命名的命令。当前支持重命名的高危命令有command、keys、flushdb、flushall和hgetall，其他命令暂不支持重命名。 
        /// </summary>
        [JsonProperty("rename_commands", NullValueHandling = NullValueHandling.Ignore)]
        public Object RenameCommands { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateInstanceBody {\n");
            sb.Append("  publicipId: ").Append(PublicipId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  enterpriseProjectName: ").Append(EnterpriseProjectName).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  enableSsl: ").Append(EnableSsl).Append("\n");
            sb.Append("  privateIp: ").Append(PrivateIp).Append("\n");
            sb.Append("  capacity: ").Append(Capacity).Append("\n");
            sb.Append("  instanceNum: ").Append(InstanceNum).Append("\n");
            sb.Append("  maintainBegin: ").Append(MaintainBegin).Append("\n");
            sb.Append("  maintainEnd: ").Append(MaintainEnd).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  noPasswordAccess: ").Append(NoPasswordAccess).Append("\n");
            sb.Append("  bssParam: ").Append(BssParam).Append("\n");
            sb.Append("  instanceBackupPolicy: ").Append(InstanceBackupPolicy).Append("\n");
            sb.Append("  azCodes: ").Append(AzCodes).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  accessUser: ").Append(AccessUser).Append("\n");
            sb.Append("  enablePublicip: ").Append(EnablePublicip).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  renameCommands: ").Append(RenameCommands).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateInstanceBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateInstanceBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PublicipId == input.PublicipId ||
                    (this.PublicipId != null &&
                    this.PublicipId.Equals(input.PublicipId))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.EnterpriseProjectName == input.EnterpriseProjectName ||
                    (this.EnterpriseProjectName != null &&
                    this.EnterpriseProjectName.Equals(input.EnterpriseProjectName))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.SecurityGroupId == input.SecurityGroupId ||
                    (this.SecurityGroupId != null &&
                    this.SecurityGroupId.Equals(input.SecurityGroupId))
                ) && 
                (
                    this.EnableSsl == input.EnableSsl ||
                    (this.EnableSsl != null &&
                    this.EnableSsl.Equals(input.EnableSsl))
                ) && 
                (
                    this.PrivateIp == input.PrivateIp ||
                    (this.PrivateIp != null &&
                    this.PrivateIp.Equals(input.PrivateIp))
                ) && 
                (
                    this.Capacity == input.Capacity ||
                    (this.Capacity != null &&
                    this.Capacity.Equals(input.Capacity))
                ) && 
                (
                    this.InstanceNum == input.InstanceNum ||
                    (this.InstanceNum != null &&
                    this.InstanceNum.Equals(input.InstanceNum))
                ) && 
                (
                    this.MaintainBegin == input.MaintainBegin ||
                    (this.MaintainBegin != null &&
                    this.MaintainBegin.Equals(input.MaintainBegin))
                ) && 
                (
                    this.MaintainEnd == input.MaintainEnd ||
                    (this.MaintainEnd != null &&
                    this.MaintainEnd.Equals(input.MaintainEnd))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Engine == input.Engine ||
                    (this.Engine != null &&
                    this.Engine.Equals(input.Engine))
                ) && 
                (
                    this.EngineVersion == input.EngineVersion ||
                    (this.EngineVersion != null &&
                    this.EngineVersion.Equals(input.EngineVersion))
                ) && 
                (
                    this.SpecCode == input.SpecCode ||
                    (this.SpecCode != null &&
                    this.SpecCode.Equals(input.SpecCode))
                ) && 
                (
                    this.NoPasswordAccess == input.NoPasswordAccess ||
                    (this.NoPasswordAccess != null &&
                    this.NoPasswordAccess.Equals(input.NoPasswordAccess))
                ) && 
                (
                    this.BssParam == input.BssParam ||
                    (this.BssParam != null &&
                    this.BssParam.Equals(input.BssParam))
                ) && 
                (
                    this.InstanceBackupPolicy == input.InstanceBackupPolicy ||
                    (this.InstanceBackupPolicy != null &&
                    this.InstanceBackupPolicy.Equals(input.InstanceBackupPolicy))
                ) && 
                (
                    this.AzCodes == input.AzCodes ||
                    this.AzCodes != null &&
                    input.AzCodes != null &&
                    this.AzCodes.SequenceEqual(input.AzCodes)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.AccessUser == input.AccessUser ||
                    (this.AccessUser != null &&
                    this.AccessUser.Equals(input.AccessUser))
                ) && 
                (
                    this.EnablePublicip == input.EnablePublicip ||
                    (this.EnablePublicip != null &&
                    this.EnablePublicip.Equals(input.EnablePublicip))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SubnetId == input.SubnetId ||
                    (this.SubnetId != null &&
                    this.SubnetId.Equals(input.SubnetId))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.RenameCommands == input.RenameCommands ||
                    (this.RenameCommands != null &&
                    this.RenameCommands.Equals(input.RenameCommands))
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
                if (this.PublicipId != null)
                    hashCode = hashCode * 59 + this.PublicipId.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.EnterpriseProjectName != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectName.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SecurityGroupId != null)
                    hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.EnableSsl != null)
                    hashCode = hashCode * 59 + this.EnableSsl.GetHashCode();
                if (this.PrivateIp != null)
                    hashCode = hashCode * 59 + this.PrivateIp.GetHashCode();
                if (this.Capacity != null)
                    hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.InstanceNum != null)
                    hashCode = hashCode * 59 + this.InstanceNum.GetHashCode();
                if (this.MaintainBegin != null)
                    hashCode = hashCode * 59 + this.MaintainBegin.GetHashCode();
                if (this.MaintainEnd != null)
                    hashCode = hashCode * 59 + this.MaintainEnd.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Engine != null)
                    hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.EngineVersion != null)
                    hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.SpecCode != null)
                    hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.NoPasswordAccess != null)
                    hashCode = hashCode * 59 + this.NoPasswordAccess.GetHashCode();
                if (this.BssParam != null)
                    hashCode = hashCode * 59 + this.BssParam.GetHashCode();
                if (this.InstanceBackupPolicy != null)
                    hashCode = hashCode * 59 + this.InstanceBackupPolicy.GetHashCode();
                if (this.AzCodes != null)
                    hashCode = hashCode * 59 + this.AzCodes.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.AccessUser != null)
                    hashCode = hashCode * 59 + this.AccessUser.GetHashCode();
                if (this.EnablePublicip != null)
                    hashCode = hashCode * 59 + this.EnablePublicip.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.RenameCommands != null)
                    hashCode = hashCode * 59 + this.RenameCommands.GetHashCode();
                return hashCode;
            }
        }
    }
}
