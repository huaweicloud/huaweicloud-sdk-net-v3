using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 创建节点时的扩展参数。
    /// </summary>
    public class NodeExtendParam 
    {
        /// <summary>
        /// **参数解释**： 指定节点安全加固类型，当前仅支持HCE2.0镜像等保2.0三级安全加固。 等保加固会对身份鉴别、访问控制、安全审计、入侵防范、恶意代码防范进行检查并加固。[详情请参见[Huawei Cloud EulerOS 2.0等保2.0三级版镜像概述](https://support.huaweicloud.com/productdesc-hce/hce_sec_0001.html)。](tag:hws) 若未指定此参数，则尝试用原有的值补全。如：原先HCE2.0镜像已配置安全加固，更新节点池时未指定此参数，则仍旧保持安全加固配置，若要取消，需显式指定参数值为\&quot;null\&quot;。 **约束限制**： 不涉及 **取值范围**： - 空值：表示不开启等保加固 - cybersecurity：表示开启等保加固  **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 指定节点安全加固类型，当前仅支持HCE2.0镜像等保2.0三级安全加固。 等保加固会对身份鉴别、访问控制、安全审计、入侵防范、恶意代码防范进行检查并加固。[详情请参见[Huawei Cloud EulerOS 2.0等保2.0三级版镜像概述](https://support.huaweicloud.com/productdesc-hce/hce_sec_0001.html)。](tag:hws) 若未指定此参数，则尝试用原有的值补全。如：原先HCE2.0镜像已配置安全加固，更新节点池时未指定此参数，则仍旧保持安全加固配置，若要取消，需显式指定参数值为\&quot;null\&quot;。 **约束限制**： 不涉及 **取值范围**： - 空值：表示不开启等保加固 - cybersecurity：表示开启等保加固  **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<SecurityReinforcementTypeEnum>))]
        public class SecurityReinforcementTypeEnum
        {
            /// <summary>
            /// Enum NULL for value: null
            /// </summary>
            public static readonly SecurityReinforcementTypeEnum NULL = new SecurityReinforcementTypeEnum("null");

            /// <summary>
            /// Enum CYBERSECURITY for value: cybersecurity
            /// </summary>
            public static readonly SecurityReinforcementTypeEnum CYBERSECURITY = new SecurityReinforcementTypeEnum("cybersecurity");

            private static readonly Dictionary<string, SecurityReinforcementTypeEnum> StaticFields =
            new Dictionary<string, SecurityReinforcementTypeEnum>()
            {
                { "null", NULL },
                { "cybersecurity", CYBERSECURITY },
            };

            private string _value;

            public SecurityReinforcementTypeEnum()
            {

            }

            public SecurityReinforcementTypeEnum(string value)
            {
                _value = value;
            }

            public static SecurityReinforcementTypeEnum FromValue(string value)
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

            public string GetValue()
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

                if (this.Equals(obj as SecurityReinforcementTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SecurityReinforcementTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SecurityReinforcementTypeEnum a, SecurityReinforcementTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(SecurityReinforcementTypeEnum a, SecurityReinforcementTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 云服务器规格的分类。响应中会返回此字段。
        /// </summary>
        [JsonProperty("ecs:performancetype", NullValueHandling = NullValueHandling.Ignore)]
        public string Ecsperformancetype { get; set; }

        /// <summary>
        /// **参数解释**： 订单ID。 **约束限制**： 节点付费类型为自动付费包周期类型时，响应中会返回此字段(仅创建场景涉及)，节点池场景响应返回中无该参数。 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("orderID", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderID { get; set; }

        /// <summary>
        /// **参数解释**： 产品ID。 **约束限制**： 节点付费类型为自动付费包周期类型或者节点池类型是包周期节点池时，响应中会返回此字段。 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("productID", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductID { get; set; }

        /// <summary>
        /// 节点最大允许创建的实例数(Pod)，该数量包含系统默认实例，取值范围为16~256。  该设置的目的为防止节点因管理过多实例而负载过重，请根据您的业务需要进行设置。  节点可以创建多少个Pod，受多个参数影响，具体请参见[节点最多可以创建多少Pod](maxPods.xml)。 
        /// </summary>
        [JsonProperty("maxPods", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxPods { get; set; }

        /// <summary>
        /// - month：月 - year：年 &gt; 作为请求参数，billingMode为1（包周期）或2（已废弃：自动付费包周期）时生效，且为必选。 &gt; 作为响应参数，仅在创建包周期节点时返回。 
        /// </summary>
        [JsonProperty("periodType", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodType { get; set; }

        /// <summary>
        /// 订购周期数，取值范围： - periodType&#x3D;month（周期类型为月）时，取值为[1-9]。 - periodType&#x3D;year（周期类型为年）时，取值为1。 &gt; 作为请求参数，billingMode为1或2（已废弃）时生效，且为必选。 &gt; 作为响应参数，仅在创建包周期节点时返回。 
        /// </summary>
        [JsonProperty("periodNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        /// <summary>
        /// 是否自动续订 - “true”：自动续订 - “false”：不自动续订 &gt; billingMode为1或2（已废弃）时生效，不填写此参数时默认不会自动续费。 
        /// </summary>
        [JsonProperty("isAutoRenew", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAutoRenew { get; set; }

        /// <summary>
        /// 是否自动扣款  - “true”：自动扣款 - “false”：不自动扣款  &gt; billingMode为1或2（已废弃）时生效，billingMode为1时不填写此参数时默认不会自动扣款。（已废弃：billingMode为2时不填写此参数时默认会自动扣款） 
        /// </summary>
        [JsonProperty("isAutoPay", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAutoPay { get; set; }

        /// <summary>
        /// Docker数据盘配置项（已废弃，请使用storage字段）。默认配置示例如下：  &#x60;&#x60;&#x60; \&quot;DockerLVMConfigOverride\&quot;:\&quot;dockerThinpool&#x3D;vgpaas/90%VG;kubernetesLV&#x3D;vgpaas/10%VG;diskType&#x3D;evs;lvType&#x3D;linear\&quot; &#x60;&#x60;&#x60;  默认配置在无VD类型磁盘时，会由于数据盘查找失败而出错，请根据真实盘符类型填写diskType。 包含如下字段：   - userLV（可选）：用户空间的大小，示例格式：vgpaas/20%VG   - userPath（可选）：用户空间挂载路径，示例格式：/home/wqt-test   - diskType：磁盘类型，目前只有evs、hdd和ssd三种格式   - lvType：逻辑卷的类型，目前支持linear和striped两种，示例格式：striped   - dockerThinpool：Docker盘的空间大小，示例格式：vgpaas/60%VG   - kubernetesLV：Kubelet空间大小，示例格式：vgpaas/20%VG 
        /// </summary>
        [JsonProperty("DockerLVMConfigOverride", NullValueHandling = NullValueHandling.Ignore)]
        public string DockerLVMConfigOverride { get; set; }

        /// <summary>
        /// **参数解释**： 节点上单容器的可用磁盘空间大小（已废弃，请优先使用containerBaseSize参数），单位G。 CCE节点容器运行时空间配置请参考[数据盘空间分配说明](cce_01_0341.xml)。 **约束限制**： - Devicemapper模式下建议dockerBaseSize配置不超过80G，设置过大时可能会导致容器运行时初始化时间过长而启动失败，若对容器磁盘大小有特殊要求，可考虑使用挂载外部或本地存储方式代替。 - dockerBaseSize设置仅在EulerOS[/HCEOS2.0](tag:hws,hws_hk,ctc,cmcc)节点上生效。  **取值范围**： 10-500。 **默认取值**： 不配置该值或值为0时将使用默认值： - Devicemapper模式下默认值为10； - OverlayFS模式默认不限制单容器可用空间大小。 
        /// </summary>
        [JsonProperty("dockerBaseSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? DockerBaseSize { get; set; }

        /// <summary>
        /// **参数解释**： 节点的公钥，应用于ssh密钥登录。 **约束限制**： - 当选择使用密钥对方式登录节点时该配置无效 - 创建、更新节点池场景不支持该参数  **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("publicKey", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicKey { get; set; }

        /// <summary>
        /// 安装前执行脚本 &gt; 输入的值需要经过Base64编码，方法为echo -n \&quot;待编码内容\&quot; | base64 
        /// </summary>
        [JsonProperty("alpha.cce/preInstall", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaCcePreInstall { get; set; }

        /// <summary>
        /// 安装后执行脚本 &gt; 输入的值需要经过Base64编码，方法为echo -n \&quot;待编码内容\&quot; | base64。 
        /// </summary>
        [JsonProperty("alpha.cce/postInstall", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaCcePostInstall { get; set; }

        /// <summary>
        /// **参数解释**： 节点自定义镜像ID，从IMS控制台获取，需要使用自定义镜像时使用此参数。 **约束限制**： 不涉及 [&gt; - 若指定了extendParam中的securityReinforcementType参数为cybersecurity，节点将开启安全等保加固功能，则节点的操作系统类型必须使用HCE2.0。](tag:hws)  **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("alpha.cce/NodeImageID", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaCceNodeImageID { get; set; }

        /// <summary>
        /// 节点的计费模式。已废弃，请使用NodeSpec中的billingMode字段。 
        /// </summary>
        [JsonProperty("chargingMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargingMode { get; set; }

        /// <summary>
        /// 委托的名称。  委托是由租户管理员在统一身份认证服务（Identity and Access Management，IAM）上创建的，可以为CCE节点提供访问云服务器的临时凭证。 作为响应参数仅在创建节点传入时返回该字段。 
        /// </summary>
        [JsonProperty("agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyName { get; set; }

        /// <summary>
        /// 节点内存预留，Kubernetes相关组件预留值。[随节点规格变动，具体请参见[节点预留资源策略说明](https://support.huaweicloud.com/usermanual-cce/cce_10_0178.html)。](tag:hws) 
        /// </summary>
        [JsonProperty("kubeReservedMem", NullValueHandling = NullValueHandling.Ignore)]
        public int? KubeReservedMem { get; set; }

        /// <summary>
        /// 节点内存预留，系统组件预留值。[随节点规格变动，具体请参见[节点预留资源策略说明](https://support.huaweicloud.com/usermanual-cce/cce_10_0178.html)。](tag:hws) 
        /// </summary>
        [JsonProperty("systemReservedMem", NullValueHandling = NullValueHandling.Ignore)]
        public int? SystemReservedMem { get; set; }

        /// <summary>
        /// **参数解释**： 节点密码，仅作为响应参数时，固定展示星号，节点池场景响应返回中无该参数。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("init-node-password", NullValueHandling = NullValueHandling.Ignore)]
        public string InitNodePassword { get; set; }

        /// <summary>
        /// **参数解释**： 指定节点安全加固类型，当前仅支持HCE2.0镜像等保2.0三级安全加固。 等保加固会对身份鉴别、访问控制、安全审计、入侵防范、恶意代码防范进行检查并加固。[详情请参见[Huawei Cloud EulerOS 2.0等保2.0三级版镜像概述](https://support.huaweicloud.com/productdesc-hce/hce_sec_0001.html)。](tag:hws) 若未指定此参数，则尝试用原有的值补全。如：原先HCE2.0镜像已配置安全加固，更新节点池时未指定此参数，则仍旧保持安全加固配置，若要取消，需显式指定参数值为\&quot;null\&quot;。 **约束限制**： 不涉及 **取值范围**： - 空值：表示不开启等保加固 - cybersecurity：表示开启等保加固  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("securityReinforcementType", NullValueHandling = NullValueHandling.Ignore)]
        public SecurityReinforcementTypeEnum SecurityReinforcementType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeExtendParam {\n");
            sb.Append("  ecsperformancetype: ").Append(Ecsperformancetype).Append("\n");
            sb.Append("  orderID: ").Append(OrderID).Append("\n");
            sb.Append("  productID: ").Append(ProductID).Append("\n");
            sb.Append("  maxPods: ").Append(MaxPods).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  isAutoRenew: ").Append(IsAutoRenew).Append("\n");
            sb.Append("  isAutoPay: ").Append(IsAutoPay).Append("\n");
            sb.Append("  dockerLVMConfigOverride: ").Append(DockerLVMConfigOverride).Append("\n");
            sb.Append("  dockerBaseSize: ").Append(DockerBaseSize).Append("\n");
            sb.Append("  publicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  alphaCcePreInstall: ").Append(AlphaCcePreInstall).Append("\n");
            sb.Append("  alphaCcePostInstall: ").Append(AlphaCcePostInstall).Append("\n");
            sb.Append("  alphaCceNodeImageID: ").Append(AlphaCceNodeImageID).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  agencyName: ").Append(AgencyName).Append("\n");
            sb.Append("  kubeReservedMem: ").Append(KubeReservedMem).Append("\n");
            sb.Append("  systemReservedMem: ").Append(SystemReservedMem).Append("\n");
            sb.Append("  initNodePassword: ").Append(InitNodePassword).Append("\n");
            sb.Append("  securityReinforcementType: ").Append(SecurityReinforcementType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeExtendParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeExtendParam input)
        {
            if (input == null) return false;
            if (this.Ecsperformancetype != input.Ecsperformancetype || (this.Ecsperformancetype != null && !this.Ecsperformancetype.Equals(input.Ecsperformancetype))) return false;
            if (this.OrderID != input.OrderID || (this.OrderID != null && !this.OrderID.Equals(input.OrderID))) return false;
            if (this.ProductID != input.ProductID || (this.ProductID != null && !this.ProductID.Equals(input.ProductID))) return false;
            if (this.MaxPods != input.MaxPods || (this.MaxPods != null && !this.MaxPods.Equals(input.MaxPods))) return false;
            if (this.PeriodType != input.PeriodType || (this.PeriodType != null && !this.PeriodType.Equals(input.PeriodType))) return false;
            if (this.PeriodNum != input.PeriodNum || (this.PeriodNum != null && !this.PeriodNum.Equals(input.PeriodNum))) return false;
            if (this.IsAutoRenew != input.IsAutoRenew || (this.IsAutoRenew != null && !this.IsAutoRenew.Equals(input.IsAutoRenew))) return false;
            if (this.IsAutoPay != input.IsAutoPay || (this.IsAutoPay != null && !this.IsAutoPay.Equals(input.IsAutoPay))) return false;
            if (this.DockerLVMConfigOverride != input.DockerLVMConfigOverride || (this.DockerLVMConfigOverride != null && !this.DockerLVMConfigOverride.Equals(input.DockerLVMConfigOverride))) return false;
            if (this.DockerBaseSize != input.DockerBaseSize || (this.DockerBaseSize != null && !this.DockerBaseSize.Equals(input.DockerBaseSize))) return false;
            if (this.PublicKey != input.PublicKey || (this.PublicKey != null && !this.PublicKey.Equals(input.PublicKey))) return false;
            if (this.AlphaCcePreInstall != input.AlphaCcePreInstall || (this.AlphaCcePreInstall != null && !this.AlphaCcePreInstall.Equals(input.AlphaCcePreInstall))) return false;
            if (this.AlphaCcePostInstall != input.AlphaCcePostInstall || (this.AlphaCcePostInstall != null && !this.AlphaCcePostInstall.Equals(input.AlphaCcePostInstall))) return false;
            if (this.AlphaCceNodeImageID != input.AlphaCceNodeImageID || (this.AlphaCceNodeImageID != null && !this.AlphaCceNodeImageID.Equals(input.AlphaCceNodeImageID))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && !this.ChargingMode.Equals(input.ChargingMode))) return false;
            if (this.AgencyName != input.AgencyName || (this.AgencyName != null && !this.AgencyName.Equals(input.AgencyName))) return false;
            if (this.KubeReservedMem != input.KubeReservedMem || (this.KubeReservedMem != null && !this.KubeReservedMem.Equals(input.KubeReservedMem))) return false;
            if (this.SystemReservedMem != input.SystemReservedMem || (this.SystemReservedMem != null && !this.SystemReservedMem.Equals(input.SystemReservedMem))) return false;
            if (this.InitNodePassword != input.InitNodePassword || (this.InitNodePassword != null && !this.InitNodePassword.Equals(input.InitNodePassword))) return false;
            if (this.SecurityReinforcementType != input.SecurityReinforcementType) return false;

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
                if (this.Ecsperformancetype != null) hashCode = hashCode * 59 + this.Ecsperformancetype.GetHashCode();
                if (this.OrderID != null) hashCode = hashCode * 59 + this.OrderID.GetHashCode();
                if (this.ProductID != null) hashCode = hashCode * 59 + this.ProductID.GetHashCode();
                if (this.MaxPods != null) hashCode = hashCode * 59 + this.MaxPods.GetHashCode();
                if (this.PeriodType != null) hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNum != null) hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.IsAutoRenew != null) hashCode = hashCode * 59 + this.IsAutoRenew.GetHashCode();
                if (this.IsAutoPay != null) hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                if (this.DockerLVMConfigOverride != null) hashCode = hashCode * 59 + this.DockerLVMConfigOverride.GetHashCode();
                if (this.DockerBaseSize != null) hashCode = hashCode * 59 + this.DockerBaseSize.GetHashCode();
                if (this.PublicKey != null) hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
                if (this.AlphaCcePreInstall != null) hashCode = hashCode * 59 + this.AlphaCcePreInstall.GetHashCode();
                if (this.AlphaCcePostInstall != null) hashCode = hashCode * 59 + this.AlphaCcePostInstall.GetHashCode();
                if (this.AlphaCceNodeImageID != null) hashCode = hashCode * 59 + this.AlphaCceNodeImageID.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.AgencyName != null) hashCode = hashCode * 59 + this.AgencyName.GetHashCode();
                if (this.KubeReservedMem != null) hashCode = hashCode * 59 + this.KubeReservedMem.GetHashCode();
                if (this.SystemReservedMem != null) hashCode = hashCode * 59 + this.SystemReservedMem.GetHashCode();
                if (this.InitNodePassword != null) hashCode = hashCode * 59 + this.InitNodePassword.GetHashCode();
                hashCode = hashCode * 59 + this.SecurityReinforcementType.GetHashCode();
                return hashCode;
            }
        }
    }
}
