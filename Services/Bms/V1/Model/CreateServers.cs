using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// server字段数据结构说明
    /// </summary>
    public class CreateServers 
    {

        /// <summary>
        /// 裸金属服务器使用的镜像ID或者镜像资源的URL。ID格式为通用唯一识别码（Universally Unique Identifier，简称UUID）。镜像ID可以从镜像服务控制台获取，或者参考《镜像服务API参考》的“查询镜像列表”章节查询。在使用“查询镜像列表”API查询时，可以添加过滤字段“?virtual_env_type&#x3D;Ironic”来筛选裸金属服务器镜像。
        /// </summary>
        [JsonProperty("imageRef", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ImageRef { get; set; }

        /// <summary>
        /// 裸金属服务器使用的规格ID，格式为physical.x.x。规格ID可以从裸金属服务器控制台获取，也可以通过查询规格详情和规格扩展信息列表API查询。 说明：裸金属服务器规格与镜像间的约束关系请参见裸金属服务器类型与支持的操作系统版本。对于physical.x.x.hba类型的规格，申请的租户只能是DeC租户，且只能挂载DESS卷。
        /// </summary>
        [JsonProperty("flavorRef", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// 裸金属服务器名称。取值范围：只能由中文字符、英文字母（a~z，A~Z）、数字（0~9）、下划线（_）、中划线（-）、点（.）组成，且长度为[1-63]个字符。创建的裸金属服务器数量大于1时，为区分不同裸金属服务器，创建过程中系统会自动在名称后加“-0000”的类似标记。故此时名称的长度为[1-58]个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public MetaDataInfo Metadata { get; set; }

        /// <summary>
        /// 创建裸金属服务器过程中待注入的用户数据。支持注入文本、文本文件或gzip文件。约束：注入内容，需要进行base64格式编码。注入内容（编码之前的内容）最大长度32KB。当key_name没有指定时，user_data注入的数据默认为裸金属服务器root帐户的登录密码。创建密码方式鉴权的Linux裸金属服务器时为必填项，为root用户注入自定义初始化密码。建议密码复杂度如下：长度为8-26位。密码至少必须包含大写字母（A-Z）、小写字母（a-z）、数字（0-9）和特殊字符（!@$%^-_&#x3D;+[{}]:,./?）中的三种。示例：使用明文密码（存在安全风险），以密码cloud.1234为例：#!/bin/bash echo &#39;root:Cloud.1234&#39; | chpasswd ;使用密码：#!/bin/bash echo &#39;root:$6$V6azyeLwcD3CHlpY$BN3VVq18fmCkj66B4zdHLWevqcxlig&#39; | chpasswd -e其中，$6$V6azyeLwcD3CHlpY$BN3VVq18fmCkj66B4zdHLWevqcxlig为密文密码
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }

        /// <summary>
        /// 如果需要使用密码方式登录裸金属服务器，可使用adminPass字段指定裸金属服务器管理员帐户初始登录密码。其中，Linux管理员帐户为root，Windows管理员帐户为Administrator。密码复杂度要求：长度为8-26位。密码至少必须包含大写字母、小写字母、数字和特殊字符（!@$%^-_&#x3D;+[{}]:,./?）中的三种。Linux系统密码不能包含用户名或用户名的逆序。Windows系统密码不能包含用户名或用户名的逆序，不能包含用户名中超过两个连续字符的部分。
        /// </summary>
        [JsonProperty("adminPass", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminPass { get; set; }

        /// <summary>
        /// 扩展属性，指定密钥的名称。如果需要使用SSH密钥方式登录裸金属服务器，请指定已有密钥的名称。密钥可以通过7.10.3-创建和导入SSH密钥（OpenStack原生）API创建，或者使用7.10.1-查询SSH密钥列表（OpenStack原生）API查询已有的密钥。约束：当key_name和user_data同时指定时，user_data只能用做用户数据注入。Windows裸金属服务器登录时，首先需要将密钥解析为密码，然后通过远程登录工具进行登录。具体请参见“MSTSC密码方式登录”“MSTSC密码方式登录”。
        /// </summary>
        [JsonProperty("key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyName { get; set; }

        /// <summary>
        /// 指定裸金属服务器的安全组。详情请参见表 security_groups字段数据结构说明。
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecurityGroupsInfo> SecurityGroups { get; set; }

        /// <summary>
        /// 指定裸金属服务器的网卡信息。详情请参见表 nics字段数据结构说明。约束：一个裸金属服务器最多挂载2个网卡，参数中第一个网卡会作为裸金属服务器的主网卡。若用户指定了多组网卡参数，需保证各组参数都属于同一VPC。
        /// </summary>
        [JsonProperty("nics", NullValueHandling = NullValueHandling.Ignore)]
        public List<Nics> Nics { get; set; }

        /// <summary>
        /// 裸金属服务器对应可用区信息，需要指定可用区（AZ）的名称。请参考地区和终端节点获取。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 创建裸金属服务器所属虚拟私有云（VPC），需要指定已有VPC的ID，UUID格式。VPC的ID可以从网络控制台或者参考《虚拟私有云API参考》的“查询VPC”。
        /// </summary>
        [JsonProperty("vpcid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Vpcid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("publicip", NullValueHandling = NullValueHandling.Ignore)]
        public PublicIp Publicip { get; set; }

        /// <summary>
        /// 创建裸金属服务器的数量。约束：不传该字段时默认取值为1。租户的配额足够时，最大值为100。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("root_volume", NullValueHandling = NullValueHandling.Ignore)]
        public RootVolume RootVolume { get; set; }

        /// <summary>
        /// 裸金属服务器对应数据盘相关配置。每一个数据结构代表一个待创建的数据盘。详情请参见表 data_volumes字段数据结构说明。约束：目前裸金属服务器最多可挂载60块云硬盘（包括系统盘和数据盘）。
        /// </summary>
        [JsonProperty("data_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataVolumes> DataVolumes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extendparam", NullValueHandling = NullValueHandling.Ignore)]
        public ExtendParam Extendparam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("schedulerHints", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSchedulerHints SchedulerHints { get; set; }

        /// <summary>
        /// 裸金属服务器的标签。详情请参见表 server_tags字段数据结构说明。 说明：创建裸金属服务器时，一台裸金属服务器最多可以添加10个标签。其中，__type_baremetal为系统内部标签，因此实际能添加的标签为9个。
        /// </summary>
        [JsonProperty("server_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<SystemTags> ServerTags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata_options", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateBaremetalServerMetadataOptionsRequestBody MetadataOptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateServers {\n");
            sb.Append("  imageRef: ").Append(ImageRef).Append("\n");
            sb.Append("  flavorRef: ").Append(FlavorRef).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("  adminPass: ").Append(AdminPass).Append("\n");
            sb.Append("  keyName: ").Append(KeyName).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  nics: ").Append(Nics).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  vpcid: ").Append(Vpcid).Append("\n");
            sb.Append("  publicip: ").Append(Publicip).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  rootVolume: ").Append(RootVolume).Append("\n");
            sb.Append("  dataVolumes: ").Append(DataVolumes).Append("\n");
            sb.Append("  extendparam: ").Append(Extendparam).Append("\n");
            sb.Append("  schedulerHints: ").Append(SchedulerHints).Append("\n");
            sb.Append("  serverTags: ").Append(ServerTags).Append("\n");
            sb.Append("  metadataOptions: ").Append(MetadataOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateServers);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateServers input)
        {
            if (input == null) return false;
            if (this.ImageRef != input.ImageRef || (this.ImageRef != null && !this.ImageRef.Equals(input.ImageRef))) return false;
            if (this.FlavorRef != input.FlavorRef || (this.FlavorRef != null && !this.FlavorRef.Equals(input.FlavorRef))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && !this.Metadata.Equals(input.Metadata))) return false;
            if (this.UserData != input.UserData || (this.UserData != null && !this.UserData.Equals(input.UserData))) return false;
            if (this.AdminPass != input.AdminPass || (this.AdminPass != null && !this.AdminPass.Equals(input.AdminPass))) return false;
            if (this.KeyName != input.KeyName || (this.KeyName != null && !this.KeyName.Equals(input.KeyName))) return false;
            if (this.SecurityGroups != input.SecurityGroups || (this.SecurityGroups != null && input.SecurityGroups != null && !this.SecurityGroups.SequenceEqual(input.SecurityGroups))) return false;
            if (this.Nics != input.Nics || (this.Nics != null && input.Nics != null && !this.Nics.SequenceEqual(input.Nics))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.Vpcid != input.Vpcid || (this.Vpcid != null && !this.Vpcid.Equals(input.Vpcid))) return false;
            if (this.Publicip != input.Publicip || (this.Publicip != null && !this.Publicip.Equals(input.Publicip))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.RootVolume != input.RootVolume || (this.RootVolume != null && !this.RootVolume.Equals(input.RootVolume))) return false;
            if (this.DataVolumes != input.DataVolumes || (this.DataVolumes != null && input.DataVolumes != null && !this.DataVolumes.SequenceEqual(input.DataVolumes))) return false;
            if (this.Extendparam != input.Extendparam || (this.Extendparam != null && !this.Extendparam.Equals(input.Extendparam))) return false;
            if (this.SchedulerHints != input.SchedulerHints || (this.SchedulerHints != null && !this.SchedulerHints.Equals(input.SchedulerHints))) return false;
            if (this.ServerTags != input.ServerTags || (this.ServerTags != null && input.ServerTags != null && !this.ServerTags.SequenceEqual(input.ServerTags))) return false;
            if (this.MetadataOptions != input.MetadataOptions || (this.MetadataOptions != null && !this.MetadataOptions.Equals(input.MetadataOptions))) return false;

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
                if (this.ImageRef != null) hashCode = hashCode * 59 + this.ImageRef.GetHashCode();
                if (this.FlavorRef != null) hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.UserData != null) hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.AdminPass != null) hashCode = hashCode * 59 + this.AdminPass.GetHashCode();
                if (this.KeyName != null) hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.SecurityGroups != null) hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.Nics != null) hashCode = hashCode * 59 + this.Nics.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.Vpcid != null) hashCode = hashCode * 59 + this.Vpcid.GetHashCode();
                if (this.Publicip != null) hashCode = hashCode * 59 + this.Publicip.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.RootVolume != null) hashCode = hashCode * 59 + this.RootVolume.GetHashCode();
                if (this.DataVolumes != null) hashCode = hashCode * 59 + this.DataVolumes.GetHashCode();
                if (this.Extendparam != null) hashCode = hashCode * 59 + this.Extendparam.GetHashCode();
                if (this.SchedulerHints != null) hashCode = hashCode * 59 + this.SchedulerHints.GetHashCode();
                if (this.ServerTags != null) hashCode = hashCode * 59 + this.ServerTags.GetHashCode();
                if (this.MetadataOptions != null) hashCode = hashCode * 59 + this.MetadataOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
