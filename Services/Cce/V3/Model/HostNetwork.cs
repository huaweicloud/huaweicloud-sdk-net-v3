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
    /// Node network parameters.
    /// </summary>
    public class HostNetwork 
    {

        /// <summary>
        /// **参数解释：** 用于创建节点的VPC的ID。 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及  获取方法如下： - 方法1：登录虚拟私有云服务的控制台界面，在虚拟私有云的详情页面查找VPC ID。 - 方法2：通过虚拟私有云服务的API接口查询。   [链接请参见[查询VPC列表](https://support.huaweicloud.com/api-vpc/vpc_api01_0003.html)。](tag:hws)   [链接请参见[查询VPC列表](https://support.huaweicloud.com/intl/zh-cn/api-vpc/vpc_api01_0003.html)。](tag:hws_hk)  
        /// </summary>
        [JsonProperty("vpc", NullValueHandling = NullValueHandling.Ignore)]
        public string Vpc { get; set; }

        /// <summary>
        /// **参数解释：** 用于创建节点的子网的网络ID。 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及  获取方法如下： - 方法1：登录虚拟私有云服务的控制台界面，单击VPC下的子网，进入子网详情页面，查找网络ID。 - 方法2：通过虚拟私有云服务的查询子网列表接口查询，获取响应中neutron_network_id字段的值。   [链接请参见[查询子网列表](https://support.huaweicloud.com/api-vpc/vpc_subnet01_0003.html)。](tag:hws)   [链接请参见[查询子网列表](https://support.huaweicloud.com/intl/zh-cn/api-vpc/vpc_subnet01_0003.html)。](tag:hws_hk)  
        /// </summary>
        [JsonProperty("subnet", NullValueHandling = NullValueHandling.Ignore)]
        public string Subnet { get; set; }

        /// <summary>
        /// 集群默认的Node节点安全组ID，不指定该字段系统将自动为用户创建默认Node节点安全组，指定该字段时集群将绑定指定的安全组。Node节点安全组需要放通部分端口来保证正常通信。[详细设置请参考[集群安全组规则配置](https://support.huaweicloud.com/cce_faq/cce_faq_00265.html)。](tag:hws)[详细设置请参考[集群安全组规则配置](https://support.huaweicloud.com/intl/zh-cn/cce_faq/cce_faq_00265.html)。](tag:hws_hk) 
        /// </summary>
        [JsonProperty("SecurityGroup", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroup { get; set; }

        /// <summary>
        /// **参数解释：** 集群控制面节点安全组ID。 **约束限制：** 创建成功后自动生成，填写无效。 **取值范围：** 不涉及 **默认取值：** 不涉及 
        /// </summary>
        [JsonProperty("controlPlaneSecurityGroup", NullValueHandling = NullValueHandling.Ignore)]
        public string ControlPlaneSecurityGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("autoGenerateSecurityGroupHardeningConfig", NullValueHandling = NullValueHandling.Ignore)]
        public AutoGenerateSecurityGroupHardeningConfigSpec AutoGenerateSecurityGroupHardeningConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HostNetwork {\n");
            sb.Append("  vpc: ").Append(Vpc).Append("\n");
            sb.Append("  subnet: ").Append(Subnet).Append("\n");
            sb.Append("  securityGroup: ").Append(SecurityGroup).Append("\n");
            sb.Append("  controlPlaneSecurityGroup: ").Append(ControlPlaneSecurityGroup).Append("\n");
            sb.Append("  autoGenerateSecurityGroupHardeningConfig: ").Append(AutoGenerateSecurityGroupHardeningConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HostNetwork);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HostNetwork input)
        {
            if (input == null) return false;
            if (this.Vpc != input.Vpc || (this.Vpc != null && !this.Vpc.Equals(input.Vpc))) return false;
            if (this.Subnet != input.Subnet || (this.Subnet != null && !this.Subnet.Equals(input.Subnet))) return false;
            if (this.SecurityGroup != input.SecurityGroup || (this.SecurityGroup != null && !this.SecurityGroup.Equals(input.SecurityGroup))) return false;
            if (this.ControlPlaneSecurityGroup != input.ControlPlaneSecurityGroup || (this.ControlPlaneSecurityGroup != null && !this.ControlPlaneSecurityGroup.Equals(input.ControlPlaneSecurityGroup))) return false;
            if (this.AutoGenerateSecurityGroupHardeningConfig != input.AutoGenerateSecurityGroupHardeningConfig || (this.AutoGenerateSecurityGroupHardeningConfig != null && !this.AutoGenerateSecurityGroupHardeningConfig.Equals(input.AutoGenerateSecurityGroupHardeningConfig))) return false;

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
                if (this.Vpc != null) hashCode = hashCode * 59 + this.Vpc.GetHashCode();
                if (this.Subnet != null) hashCode = hashCode * 59 + this.Subnet.GetHashCode();
                if (this.SecurityGroup != null) hashCode = hashCode * 59 + this.SecurityGroup.GetHashCode();
                if (this.ControlPlaneSecurityGroup != null) hashCode = hashCode * 59 + this.ControlPlaneSecurityGroup.GetHashCode();
                if (this.AutoGenerateSecurityGroupHardeningConfig != null) hashCode = hashCode * 59 + this.AutoGenerateSecurityGroupHardeningConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
