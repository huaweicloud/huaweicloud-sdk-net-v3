using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 创建实例请求体。
    /// </summary>
    public class CreateInstanceByEngineReq 
    {

        /// <summary>
        /// **参数解释**： 实例名称。 **约束限制**： 由英文字符开头，只能由英文字母、数字、中划线、下划线组成，长度为4~64的字符。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 实例的描述信息。 **约束限制**： 长度不超过1024的字符串。[且字符串不能包含\&quot;&gt;\&quot;与\&quot;&lt;\&quot;，字符串首字符不能为\&quot;&#x3D;\&quot;,\&quot;+\&quot;,\&quot;-\&quot;,\&quot;@\&quot;的全角和半角字符。](tag:hcs)  &gt; \\与\&quot;在json报文中属于特殊字符，如果参数值中需要显示\\或者\&quot;字符，请在字符前增加转义字符\\，比如\\\\或者\\\&quot;。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 消息引擎类型。 **约束限制**： 不涉及。 **取值范围**： - rocketmq：RocketMQ消息引擎。 - reliability：RocketMQ消息引擎别称。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public string Engine { get; set; }

        /// <summary>
        /// **参数解释**： 消息引擎的版本。 **约束限制**： 不涉及。 **取值范围**： [- 4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,cmcc,ax,srg) [- 5.x](tag:hws,hws_eu,hws_hk,ctc,tm,sbc,hk_sbc,hk_tm,hcs,fcs,dt,hcs_oemout,srg) **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// **参数解释**： 存储空间，单位：GB。 **取值范围**： 不同的实例规格支持不同的存储配置。 [- RocketMQ 5.x 单机存储取值范围：100-30000。](tag:dt) [- RocketMQ 5.x 集群存储取值范围：200-60000。](tag:dt)
        /// </summary>
        [JsonProperty("storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? StorageSpace { get; set; }

        /// <summary>
        /// **参数解释**： 虚拟私有云ID。获取方法如下：参考《虚拟私有云 API参考》，调用“查询VPC列表”接口，从响应体中获取VPC ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// **参数解释**： 子网信息。获取方法如下：参考《虚拟私有云 API参考》，调用“查询子网列表”接口，从响应体中获取子网ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// **参数解释**： 指定实例所属的安全组。获取方法如下：参考《虚拟私有云 API参考》，调用“查询安全组列表”接口，从响应体中获取安全组ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// **参数解释**： 创建节点到指定且有资源的可用区ID。请参考[查询可用区信息](ListAvailableZones.xml)获取可用区ID。 **约束限制**： 该参数不能为空数组或者数组的值为空， 请注意查看该可用区是否有资源。  创建RocketMQ实例，支持节点部署在1个或3个及3个以上的可用区。在为节点指定可用区时，用逗号分隔开。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// **参数解释**： RocketMQ实例规格。[x86环境后缀为.x86，arm环境为.arm。single表示单机，cluster表示集群。](tag:hcs,fcs,hcs_oemout)  **约束限制**： 不涉及。  **取值范围**：  [当“type”为“single.basic”选择单机规格；当“type”为“cluster.basic”选择集群规格。](tag:dt) [- c6.2u8g.cluster.x86或c6.2u8g.cluster.arm：单个代理最大分区数50，单个代理最大消费组数100](tag:fcs) [- c6.4u8g.cluster.small：单个代理最大Topic数2000，单个代理最大消费组数2000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,cmcc,ax,srg) [- c6.4u8g.cluster：单个代理最大Topic数4000，单个代理最大消费组数4000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,cmcc,ax,srg) [- c6.4u16g.cluster.x86或c6.4u16g.cluster.arm：单个代理最大分区数100，单个代理最大消费组数200](tag:hcs,hcs_oemout) [- c6.8u16g.cluster：单个代理最大Topic数8000，单个代理最大消费组数8000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,cmcc,ax,srg) [- c6.8u32g.cluster.x86或c6.8u32g.cluster.arm：单个代理最大Topic数200，单个代理最大消费组数400](tag:hcs,fcs,hcs_oemout) [- c6.12u24g.cluster：单个代理最大Topic数12000，单个代理最大消费组数12000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,cmcc,ax,srg) [- c6.16u64g.cluster.x86或c6.16u64g.cluster.arm：单个代理最大Topic数300，单个代理最大消费组数600](tag:hcs,fcs,hcs_oemout) [- c6.16u32g.cluster：单个代理最大Topic数16000，单个代理最大消费组数16000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,cmcc,ax,srg) [- c6.32u128g.cluster.x86或c6.32u128g.cluster.arm：单个代理最大Topic数400，单个代理最大消费组数800](tag:hcs,fcs,hcs_oemout) [- rocketmq.b1.large.1：RocketMQ 5.x 基础版单机规格，实例TPS 500](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt,ax,srg) [- rocketmq.b2.large.4：RocketMQ 5.x 基础版集群规格，实例TPS 2000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt,ax,srg) [- rocketmq.b2.large.8：RocketMQ 5.x 基础版集群规格，实例TPS 4000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt,ax,srg) [- rocketmq.b2.large.12：RocketMQ 5.x 基础版集群规格，实例TPS 6000](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,dt,ax,srg) [- rocketmq.p1.large.1：RocketMQ 5.x 专业版单机规格，实例TPS 500](tag:hws,hws_eu,hws_hk,ctc,srg) [- rocketmq.p2.large.8：RocketMQ 5.x 专业版集群规格，实例TPS 4000](tag:hws,hws_eu,hws_hk,ctc,srg) [- rocketmq.p2.large.12：RocketMQ 5.x 专业版集群规格，实例TPS 6000](tag:hws,hws_eu,hws_hk,ctc,srg) [- rocketmq.p2.large.20：RocketMQ 5.x 专业版集群规格，实例TPS 10000](tag:hws,hws_eu,hws_hk,ctc,srg) [- rocketmq.p2.large.40：RocketMQ 5.x 专业版集群规格，实例TPS 20000](tag:hws,hws_eu,hws_hk,ctc,srg) [- rocketmq.p2.large.100：RocketMQ 5.x 专业版集群规格，实例TPS 50000](tag:hws,hws_eu,hws_hk,ctc,srg) [- rocketmq.p2.large.150：RocketMQ 5.x 专业版集群规格，实例TPS 75000](tag:hws,hws_eu,hws_hk,ctc,srg) [- rocketmq.p2.large.200：RocketMQ 5.x 专业版集群规格，实例TPS 100000](tag:hws,hws_eu,hws_hk,ctc,srg) [- rocketmq.p2.large.300：RocketMQ 5.x 专业版集群规格，实例TPS 150000](tag:hws,hws_eu,hws_hk,ctc,srg)  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// **参数解释**： 是否打开SSL加密访问。 **约束限制**： 不涉及。 **取值范围**： - true：打开SSL加密访问。 - false：不打开SSL加密访问。 **默认取值**： false。
        /// </summary>
        [JsonProperty("ssl_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslEnable { get; set; }

        /// <summary>
        /// **参数解释**： 存储IO规格。 **约束限制**： 不涉及。 **取值范围**： - dms.physical.storage.high.v2：高IO类型磁盘 - dms.physical.storage.ultra.v2：超高IO类型磁盘 [- dms.physical.storage.general：使用通用型SSD的磁盘类型。](tag:hws,hws_hk,dt,ctc,ax) [- dms.physical.storage.extreme：使用极速型SSD的磁盘类型。](tag:hws,hws_hk,dt,ctc,ax) **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("storage_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageSpecCode { get; set; }

        /// <summary>
        /// **参数解释**： 企业项目ID。若为企业项目账号，该参数必填。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启访问控制列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("enable_acl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAcl { get; set; }

        /// <summary>
        /// **参数解释**： 是否支持IPv6。[华为云Stack不支持此参数。](tag:hcs,hcs_oemout) **约束限制**： 不涉及。 **取值范围**： - true：支持 - false：不支持 **默认取值**： false。
        /// </summary>
        [JsonProperty("ipv6_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ipv6Enable { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启Proxy功能。 **约束限制**： 不涉及。 **取值范围**： - true：支持 - false：不支持 **默认取值**： false。
        /// </summary>
        [JsonProperty("proxy_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProxyEnable { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启公网访问功能。默认不开启公网。 **约束限制**： 不涉及。 **取值范围**： - true：开启 - false：不开启 **默认取值**： false。
        /// </summary>
        [JsonProperty("enable_publicip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePublicip { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启磁盘加密。 **约束限制**： 不涉及。 **取值范围**： - true：开启。 - false：不开启。 **默认取值**： false。
        /// </summary>
        [JsonProperty("disk_encrypted_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DiskEncryptedEnable { get; set; }

        /// <summary>
        /// **参数解释**： 磁盘加密key，未开启磁盘加密时为空。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("disk_encrypted_key", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskEncryptedKey { get; set; }

        /// <summary>
        /// **参数解释**： 实例绑定的弹性IP地址的ID。 **约束限制**： 以英文逗号隔开多个弹性IP地址的ID。  如果开启了公网访问功能（即enable_publicip为true），该字段为必选。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("publicip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipId { get; set; }

        /// <summary>
        /// **参数解释**： 代理个数。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("broker_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? BrokerNum { get; set; }

        /// <summary>
        /// **参数解释**： 架构类型。 **约束限制**： 不涉及。 **取值范围**： - X86：复杂指令集计算。 - ARM：精简指令集计算。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("arch_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ArchType { get; set; }

        /// <summary>
        /// **参数解释**： 实例使用的安全协议。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("tls_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string TlsMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bss_param", NullValueHandling = NullValueHandling.Ignore)]
        public BssParam BssParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateInstanceByEngineReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  storageSpace: ").Append(StorageSpace).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  sslEnable: ").Append(SslEnable).Append("\n");
            sb.Append("  storageSpecCode: ").Append(StorageSpecCode).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  enableAcl: ").Append(EnableAcl).Append("\n");
            sb.Append("  ipv6Enable: ").Append(Ipv6Enable).Append("\n");
            sb.Append("  proxyEnable: ").Append(ProxyEnable).Append("\n");
            sb.Append("  enablePublicip: ").Append(EnablePublicip).Append("\n");
            sb.Append("  diskEncryptedEnable: ").Append(DiskEncryptedEnable).Append("\n");
            sb.Append("  diskEncryptedKey: ").Append(DiskEncryptedKey).Append("\n");
            sb.Append("  publicipId: ").Append(PublicipId).Append("\n");
            sb.Append("  brokerNum: ").Append(BrokerNum).Append("\n");
            sb.Append("  archType: ").Append(ArchType).Append("\n");
            sb.Append("  tlsMode: ").Append(TlsMode).Append("\n");
            sb.Append("  bssParam: ").Append(BssParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateInstanceByEngineReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateInstanceByEngineReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Engine != input.Engine || (this.Engine != null && !this.Engine.Equals(input.Engine))) return false;
            if (this.EngineVersion != input.EngineVersion || (this.EngineVersion != null && !this.EngineVersion.Equals(input.EngineVersion))) return false;
            if (this.StorageSpace != input.StorageSpace || (this.StorageSpace != null && !this.StorageSpace.Equals(input.StorageSpace))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.SecurityGroupId != input.SecurityGroupId || (this.SecurityGroupId != null && !this.SecurityGroupId.Equals(input.SecurityGroupId))) return false;
            if (this.AvailableZones != input.AvailableZones || (this.AvailableZones != null && input.AvailableZones != null && !this.AvailableZones.SequenceEqual(input.AvailableZones))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.SslEnable != input.SslEnable || (this.SslEnable != null && !this.SslEnable.Equals(input.SslEnable))) return false;
            if (this.StorageSpecCode != input.StorageSpecCode || (this.StorageSpecCode != null && !this.StorageSpecCode.Equals(input.StorageSpecCode))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.EnableAcl != input.EnableAcl || (this.EnableAcl != null && !this.EnableAcl.Equals(input.EnableAcl))) return false;
            if (this.Ipv6Enable != input.Ipv6Enable || (this.Ipv6Enable != null && !this.Ipv6Enable.Equals(input.Ipv6Enable))) return false;
            if (this.ProxyEnable != input.ProxyEnable || (this.ProxyEnable != null && !this.ProxyEnable.Equals(input.ProxyEnable))) return false;
            if (this.EnablePublicip != input.EnablePublicip || (this.EnablePublicip != null && !this.EnablePublicip.Equals(input.EnablePublicip))) return false;
            if (this.DiskEncryptedEnable != input.DiskEncryptedEnable || (this.DiskEncryptedEnable != null && !this.DiskEncryptedEnable.Equals(input.DiskEncryptedEnable))) return false;
            if (this.DiskEncryptedKey != input.DiskEncryptedKey || (this.DiskEncryptedKey != null && !this.DiskEncryptedKey.Equals(input.DiskEncryptedKey))) return false;
            if (this.PublicipId != input.PublicipId || (this.PublicipId != null && !this.PublicipId.Equals(input.PublicipId))) return false;
            if (this.BrokerNum != input.BrokerNum || (this.BrokerNum != null && !this.BrokerNum.Equals(input.BrokerNum))) return false;
            if (this.ArchType != input.ArchType || (this.ArchType != null && !this.ArchType.Equals(input.ArchType))) return false;
            if (this.TlsMode != input.TlsMode || (this.TlsMode != null && !this.TlsMode.Equals(input.TlsMode))) return false;
            if (this.BssParam != input.BssParam || (this.BssParam != null && !this.BssParam.Equals(input.BssParam))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Engine != null) hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.EngineVersion != null) hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.StorageSpace != null) hashCode = hashCode * 59 + this.StorageSpace.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.SecurityGroupId != null) hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.AvailableZones != null) hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.SslEnable != null) hashCode = hashCode * 59 + this.SslEnable.GetHashCode();
                if (this.StorageSpecCode != null) hashCode = hashCode * 59 + this.StorageSpecCode.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.EnableAcl != null) hashCode = hashCode * 59 + this.EnableAcl.GetHashCode();
                if (this.Ipv6Enable != null) hashCode = hashCode * 59 + this.Ipv6Enable.GetHashCode();
                if (this.ProxyEnable != null) hashCode = hashCode * 59 + this.ProxyEnable.GetHashCode();
                if (this.EnablePublicip != null) hashCode = hashCode * 59 + this.EnablePublicip.GetHashCode();
                if (this.DiskEncryptedEnable != null) hashCode = hashCode * 59 + this.DiskEncryptedEnable.GetHashCode();
                if (this.DiskEncryptedKey != null) hashCode = hashCode * 59 + this.DiskEncryptedKey.GetHashCode();
                if (this.PublicipId != null) hashCode = hashCode * 59 + this.PublicipId.GetHashCode();
                if (this.BrokerNum != null) hashCode = hashCode * 59 + this.BrokerNum.GetHashCode();
                if (this.ArchType != null) hashCode = hashCode * 59 + this.ArchType.GetHashCode();
                if (this.TlsMode != null) hashCode = hashCode * 59 + this.TlsMode.GetHashCode();
                if (this.BssParam != null) hashCode = hashCode * 59 + this.BssParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
