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
    /// **参数解释**： 节点池更新时支持的扩展参数。 **约束限制**： 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
    /// </summary>
    public class NodePoolUpdateExtendParam 
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
        /// **参数解释**： 委托的名称。 委托是由租户管理员在统一身份认证服务（Identity and AccessManagement，IAM）上创建的，可以为CCE节点提供访问云服务器的临时凭证。 **约束限制**： 作为响应参数仅在创建节点传入时返回该字段。 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyName { get; set; }

        /// <summary>
        /// **参数解释**： 安装前执行脚本。 输入的值需要经过Base64编码，方法如下：   &#x60;&#x60;&#x60;   echo -n \&quot;待编码内容\&quot; | base64   &#x60;&#x60;&#x60;   **约束限制**：  安装前/后执行脚本统一计算字符，转码后的字符总数不能超过10240。  **取值范围：**  不涉及  **默认取值：**  不涉及
        /// </summary>
        [JsonProperty("alpha.cce/preInstall", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaCcePreInstall { get; set; }

        /// <summary>
        /// **参数解释**： 安装后执行脚本。 输入的值需要经过Base64编码，方法如下：   &#x60;&#x60;&#x60;   echo -n \&quot;待编码内容\&quot; | base64   &#x60;&#x60;&#x60;  **约束限制**： 安装前/后执行脚本统一计算字符，转码后的字符总数不能超过10240。 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("alpha.cce/postInstall", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaCcePostInstall { get; set; }

        /// <summary>
        /// **参数解释**： 用户愿意为竞价实例每小时支付的最高价格。 **约束限制**： - 仅billingMode&#x3D;0且marketType&#x3D;spot时，该参数设置后生效。 - 当billingMode&#x3D;0且marketType&#x3D;spot时，如果不传递spotPrice，默认使用按需购买的价格作为竞价。 - spotPrice需要小于等于按需价格并大于等于云服务器市场价格。  **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("spotPrice", NullValueHandling = NullValueHandling.Ignore)]
        public string SpotPrice { get; set; }

        /// <summary>
        /// **参数解释**： 指定节点安全加固类型，当前仅支持HCE2.0镜像等保2.0三级安全加固。 等保加固会对身份鉴别、访问控制、安全审计、入侵防范、恶意代码防范进行检查并加固。[详情请参见[Huawei Cloud EulerOS 2.0等保2.0三级版镜像概述](https://support.huaweicloud.com/productdesc-hce/hce_sec_0001.html)。](tag:hws) 若未指定此参数，则尝试用原有的值补全。如：原先HCE2.0镜像已配置安全加固，更新节点池时未指定此参数，则仍旧保持安全加固配置，若要取消，需显式指定参数值为\&quot;null\&quot;。 **约束限制**： 不涉及 **取值范围**： - 空值：表示不开启等保加固 - cybersecurity：表示开启等保加固  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("securityReinforcementType", NullValueHandling = NullValueHandling.Ignore)]
        public SecurityReinforcementTypeEnum SecurityReinforcementType { get; set; }
        /// <summary>
        /// **参数解释**： 节点自定义镜像ID，从IMS控制台获取，需要使用自定义镜像时用此参数。 **约束限制**： 不涉及 [&gt; - 若指定了extendParam中的securityReinforcementType参数为cybersecurity，节点将开启安全等保加固功能，则节点的操作系统类型必须使用HCE2.0。](tag:hws)  **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("alpha.cce/NodeImageID", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaCceNodeImageID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodePoolUpdateExtendParam {\n");
            sb.Append("  agencyName: ").Append(AgencyName).Append("\n");
            sb.Append("  alphaCcePreInstall: ").Append(AlphaCcePreInstall).Append("\n");
            sb.Append("  alphaCcePostInstall: ").Append(AlphaCcePostInstall).Append("\n");
            sb.Append("  spotPrice: ").Append(SpotPrice).Append("\n");
            sb.Append("  securityReinforcementType: ").Append(SecurityReinforcementType).Append("\n");
            sb.Append("  alphaCceNodeImageID: ").Append(AlphaCceNodeImageID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodePoolUpdateExtendParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodePoolUpdateExtendParam input)
        {
            if (input == null) return false;
            if (this.AgencyName != input.AgencyName || (this.AgencyName != null && !this.AgencyName.Equals(input.AgencyName))) return false;
            if (this.AlphaCcePreInstall != input.AlphaCcePreInstall || (this.AlphaCcePreInstall != null && !this.AlphaCcePreInstall.Equals(input.AlphaCcePreInstall))) return false;
            if (this.AlphaCcePostInstall != input.AlphaCcePostInstall || (this.AlphaCcePostInstall != null && !this.AlphaCcePostInstall.Equals(input.AlphaCcePostInstall))) return false;
            if (this.SpotPrice != input.SpotPrice || (this.SpotPrice != null && !this.SpotPrice.Equals(input.SpotPrice))) return false;
            if (this.SecurityReinforcementType != input.SecurityReinforcementType) return false;
            if (this.AlphaCceNodeImageID != input.AlphaCceNodeImageID || (this.AlphaCceNodeImageID != null && !this.AlphaCceNodeImageID.Equals(input.AlphaCceNodeImageID))) return false;

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
                if (this.AgencyName != null) hashCode = hashCode * 59 + this.AgencyName.GetHashCode();
                if (this.AlphaCcePreInstall != null) hashCode = hashCode * 59 + this.AlphaCcePreInstall.GetHashCode();
                if (this.AlphaCcePostInstall != null) hashCode = hashCode * 59 + this.AlphaCcePostInstall.GetHashCode();
                if (this.SpotPrice != null) hashCode = hashCode * 59 + this.SpotPrice.GetHashCode();
                hashCode = hashCode * 59 + this.SecurityReinforcementType.GetHashCode();
                if (this.AlphaCceNodeImageID != null) hashCode = hashCode * 59 + this.AlphaCceNodeImageID.GetHashCode();
                return hashCode;
            }
        }
    }
}
