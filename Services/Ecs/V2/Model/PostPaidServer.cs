using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 创建弹性云服务器（按需）接口Body体。
    /// </summary>
    public class PostPaidServer 
    {

        /// <summary>
        /// 如果需要使用密码方式登录云服务器，可使用adminPass字段指定云服务器管理员帐户初始登录密码。其中，Linux管理员帐户为root，Windows管理员帐户为Administrator。具体使用方法请参见接口描述信息（设置登录鉴权方式）。  密码复杂度要求：   - 长度为8-26位。  - 密码至少必须包含大写字母、小写字母、数字和特殊字符（!@$%^-_&#x3D;+[{}]:,./?）中的三种。 - 密码不能包含用户名或用户名的逆序。  - Windows系统密码不能包含用户名或用户名的逆序，不能包含用户名中超过两个连续字符的部分。
        /// </summary>
        [JsonProperty("adminPass", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminPass { get; set; }

        /// <summary>
        /// 待创建云服务器所在的可用分区，需要指定可用分区（AZ）的名称。  请参考[地区和终端节点](https://developer.huaweicloud.com/endpoint)获取。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 创建云服务器数量。  约束：  - 不传该字段时默认取值为1。 - 租户的配额足够时，最大值为500。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 云服务器对应数据盘相关配置。每一个数据结构代表一块待创建的数据盘。 约束：目前新创建的弹性云服务器最多可挂载23块数据盘。
        /// </summary>
        [JsonProperty("data_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<PostPaidServerDataVolume> DataVolumes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extendparam", NullValueHandling = NullValueHandling.Ignore)]
        public PostPaidServerExtendParam Extendparam { get; set; }

        /// <summary>
        /// 待创建云服务器的系统规格的ID。  已上线的规格请参见《[弹性云服务器产品介绍](https://support.huaweicloud.com/ecs/index.html)》的“实例类型与规格”章节。
        /// </summary>
        [JsonProperty("flavorRef", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// 待创建云服务器的系统镜像，需要指定已创建镜像的ID，ID格式为通用唯一识别码（Universally Unique Identifier，简称UUID）。
        /// </summary>
        [JsonProperty("imageRef", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageRef { get; set; }

        /// <summary>
        /// 当批量创建弹性云服务器时，云服务器名称是否允许重名，当count大于1的时候该参数生效。默认为True。  - True，表示允许重名。 - False，表示不允许重名。
        /// </summary>
        [JsonProperty("isAutoRename", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAutoRename { get; set; }

        /// <summary>
        /// 如果需要使用SSH密钥方式登录云服务器，请指定已创建密钥的名称。  密钥可以通过密钥创建接口进行创建 [创建和导入SSH密钥](https://support.huaweicloud.com/api-ecs/zh-cn_topic_0020212678.html)（请参见），或使用SSH密钥查询接口查询已有的密钥（请参见[查询SSH密钥列表](https://support.huaweicloud.com/api-ecs/zh-cn_topic_0020212676.html) ）。
        /// </summary>
        [JsonProperty("key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyName { get; set; }

        /// <summary>
        /// 用户自定义字段键值对。  &gt; 说明： &gt;  &gt; - 最多可注入10对键值（Key/Value）。 &gt; - 主键（Key）只能由大写字母（A-Z）、小写字母（a-z）、数字（0-9）、中划线（-）、下划线（_）、冒号（:）和小数点（.）组成，长度为[1-255]个字符。 &gt; - 值（value）最大长度为255个字符。  系统预留字段  1. op_svc_userid : 用户ID       2. agency_name  :  委托的名称   委托是由租户管理员在统一身份认证服务（Identity and Access Management，IAM）上创建的，可以为弹性云服务器提供访问云服务的临时凭证。  &gt; 说明： &gt;  &gt; 委托获取、更新请参考如下步骤： &gt;  &gt; 1. 使用IAM服务提供的[查询委托列表](https://support.huaweicloud.com/api-iam/zh-cn_topic_0079467614.html)接口，获取有效可用的委托名称。 &gt; 2. 使用[更新云服务器元数](https://support.huaweicloud.com/api-ecs/zh-cn_topic_0025560298.html)据接口，更新metadata中agency_name字段为新的委托名称。  3. __support_agent_list: 云服务器是否支持企业主机安全、主机监控。 - \&quot;hss\&quot;：企业主机安全 - \&quot;ces\&quot;：主机监控  取值样例： __support_agent_list: \&quot;hss,ces\&quot;  可以通过查询[镜像详情](https://support.huaweicloud.com/api-ims/ims_03_0702.html)判断创建云服务器使用的镜像是否支持企业主机安全或主机监控。
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// 云服务器名称。  取值范围：  - 只能由中文字符、英文字母、数字及“_”、“-”、“.”组成，且长度为[1-64]个字符。 - 创建的云服务器器数量（count字段对应的值）大于1时，为区分不同云服务器，创建过程中系统会自动在名称后加“-0000”的类似标记。故此时名称的长度为[1-59]个字符。  &gt; 说明： &gt;  &gt; 云服务器虚拟机内部(hostname)命名规则遵循 RFC 952和RFC 1123命名规范，建议使用a-zA-z或0-9以及中划线\&quot;-\&quot;组成的名称命名，\&quot;_\&quot;将在弹性云服务器内部默认转化为\&quot;-\&quot;。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 待创建云服务器的网卡信息。  约束：  - 网卡对应的子网（subnet）必须属于vpcid对应的VPC。 - 当前单个云服务器支持最多挂载12张网卡。
        /// </summary>
        [JsonProperty("nics", NullValueHandling = NullValueHandling.Ignore)]
        public List<PostPaidServerNic> Nics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os:scheduler_hints", NullValueHandling = NullValueHandling.Ignore)]
        public PostPaidServerSchedulerHints OsschedulerHints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("publicip", NullValueHandling = NullValueHandling.Ignore)]
        public PostPaidServerPublicip Publicip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("root_volume", NullValueHandling = NullValueHandling.Ignore)]
        public PostPaidServerRootVolume RootVolume { get; set; }

        /// <summary>
        /// 云服务器对应安全组信息。  约束：当该值指定为空时，默认给云服务器绑定default安全组。
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<PostPaidServerSecurityGroup> SecurityGroups { get; set; }

        /// <summary>
        /// 弹性云服务器的标签。  &gt; 说明： &gt;  &gt; 创建弹性云服务器时，一台弹性云服务器最多可以添加10个标签。 &gt; 公有云新增server_tags字段，该字段与tags字段功能相同，支持的key、value取值范围更广，建议使用server_tags字段。
        /// </summary>
        [JsonProperty("server_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<PostPaidServerTag> ServerTags { get; set; }

        /// <summary>
        /// 弹性云服务器的标签。  标签的格式为“key.value”。其中，key的长度不超过36个字符，value的长度不超过43个字符。  标签命名时，需满足如下要求：  - 标签的key值只能包含大写字母（A~Z）、小写字母（a~z）、数字（0-9）、下划线（_）、中划线（-）以及中文字符。 - 标签的value值只能包含大写字母（A~Z）、小写字母（a~z）、数字（0-9）、下划线（_）、中划线（-）、小数点（.）以及中文字符。  &gt; 说明： &gt;  &gt; 创建弹性云服务器时，一台弹性云服务器最多可以添加10个标签。 &gt; 公有云新增server_tags字段，该字段与tags字段功能相同，支持的key、value取值范围更广，建议使用server_tags字段。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 创建云服务器过程中待注入用户数据。支持注入文本、文本文件或gzip文件。  更多关于待注入用户数据的信息，请参见《弹性云服务器用户指南 》的“用户数据注入”章节。  约束：  - 注入内容，需要进行base64格式编码。注入内容（编码之前的内容）最大长度32KB。 - 创建密码方式鉴权的Linux弹性云服务器时，该字段可为root用户注入自定义初始化密码，具体注入密码的使用方法请参见接口描述（设置登录鉴权方式）。 示例（base64编码前）：  - Linux弹性云服务器  &#x60;&#x60;&#x60; #! /bin/bash echo user_test &gt;&gt; /home/user.txt  &#x60;&#x60;&#x60;  - Windows弹性云服务器  &#x60;&#x60;&#x60; rem cmd echo 111 &gt; c:\\aaa.tx &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }

        /// <summary>
        /// 待创建云服务器所属虚拟私有云（简称VPC），需要指定已创建VPC的ID，UUID格式。
        /// </summary>
        [JsonProperty("vpcid", NullValueHandling = NullValueHandling.Ignore)]
        public string Vpcid { get; set; }

        /// <summary>
        /// 云服务器描述信息，默认为空字符串。  - 长度最多允许85个字符。 - 不能包含“&lt;” 和 “&gt;”。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostPaidServer {\n");
            sb.Append("  adminPass: ").Append(AdminPass).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  dataVolumes: ").Append(DataVolumes).Append("\n");
            sb.Append("  extendparam: ").Append(Extendparam).Append("\n");
            sb.Append("  flavorRef: ").Append(FlavorRef).Append("\n");
            sb.Append("  imageRef: ").Append(ImageRef).Append("\n");
            sb.Append("  isAutoRename: ").Append(IsAutoRename).Append("\n");
            sb.Append("  keyName: ").Append(KeyName).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nics: ").Append(Nics).Append("\n");
            sb.Append("  osschedulerHints: ").Append(OsschedulerHints).Append("\n");
            sb.Append("  publicip: ").Append(Publicip).Append("\n");
            sb.Append("  rootVolume: ").Append(RootVolume).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  serverTags: ").Append(ServerTags).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("  vpcid: ").Append(Vpcid).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostPaidServer);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PostPaidServer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdminPass == input.AdminPass ||
                    (this.AdminPass != null &&
                    this.AdminPass.Equals(input.AdminPass))
                ) && 
                (
                    this.AvailabilityZone == input.AvailabilityZone ||
                    (this.AvailabilityZone != null &&
                    this.AvailabilityZone.Equals(input.AvailabilityZone))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.DataVolumes == input.DataVolumes ||
                    this.DataVolumes != null &&
                    input.DataVolumes != null &&
                    this.DataVolumes.SequenceEqual(input.DataVolumes)
                ) && 
                (
                    this.Extendparam == input.Extendparam ||
                    (this.Extendparam != null &&
                    this.Extendparam.Equals(input.Extendparam))
                ) && 
                (
                    this.FlavorRef == input.FlavorRef ||
                    (this.FlavorRef != null &&
                    this.FlavorRef.Equals(input.FlavorRef))
                ) && 
                (
                    this.ImageRef == input.ImageRef ||
                    (this.ImageRef != null &&
                    this.ImageRef.Equals(input.ImageRef))
                ) && 
                (
                    this.IsAutoRename == input.IsAutoRename ||
                    (this.IsAutoRename != null &&
                    this.IsAutoRename.Equals(input.IsAutoRename))
                ) && 
                (
                    this.KeyName == input.KeyName ||
                    (this.KeyName != null &&
                    this.KeyName.Equals(input.KeyName))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Nics == input.Nics ||
                    this.Nics != null &&
                    input.Nics != null &&
                    this.Nics.SequenceEqual(input.Nics)
                ) && 
                (
                    this.OsschedulerHints == input.OsschedulerHints ||
                    (this.OsschedulerHints != null &&
                    this.OsschedulerHints.Equals(input.OsschedulerHints))
                ) && 
                (
                    this.Publicip == input.Publicip ||
                    (this.Publicip != null &&
                    this.Publicip.Equals(input.Publicip))
                ) && 
                (
                    this.RootVolume == input.RootVolume ||
                    (this.RootVolume != null &&
                    this.RootVolume.Equals(input.RootVolume))
                ) && 
                (
                    this.SecurityGroups == input.SecurityGroups ||
                    this.SecurityGroups != null &&
                    input.SecurityGroups != null &&
                    this.SecurityGroups.SequenceEqual(input.SecurityGroups)
                ) && 
                (
                    this.ServerTags == input.ServerTags ||
                    this.ServerTags != null &&
                    input.ServerTags != null &&
                    this.ServerTags.SequenceEqual(input.ServerTags)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.UserData == input.UserData ||
                    (this.UserData != null &&
                    this.UserData.Equals(input.UserData))
                ) && 
                (
                    this.Vpcid == input.Vpcid ||
                    (this.Vpcid != null &&
                    this.Vpcid.Equals(input.Vpcid))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.AdminPass != null)
                    hashCode = hashCode * 59 + this.AdminPass.GetHashCode();
                if (this.AvailabilityZone != null)
                    hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.DataVolumes != null)
                    hashCode = hashCode * 59 + this.DataVolumes.GetHashCode();
                if (this.Extendparam != null)
                    hashCode = hashCode * 59 + this.Extendparam.GetHashCode();
                if (this.FlavorRef != null)
                    hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.ImageRef != null)
                    hashCode = hashCode * 59 + this.ImageRef.GetHashCode();
                if (this.IsAutoRename != null)
                    hashCode = hashCode * 59 + this.IsAutoRename.GetHashCode();
                if (this.KeyName != null)
                    hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Nics != null)
                    hashCode = hashCode * 59 + this.Nics.GetHashCode();
                if (this.OsschedulerHints != null)
                    hashCode = hashCode * 59 + this.OsschedulerHints.GetHashCode();
                if (this.Publicip != null)
                    hashCode = hashCode * 59 + this.Publicip.GetHashCode();
                if (this.RootVolume != null)
                    hashCode = hashCode * 59 + this.RootVolume.GetHashCode();
                if (this.SecurityGroups != null)
                    hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.ServerTags != null)
                    hashCode = hashCode * 59 + this.ServerTags.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.Vpcid != null)
                    hashCode = hashCode * 59 + this.Vpcid.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
