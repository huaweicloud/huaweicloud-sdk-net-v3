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
    /// 
    /// </summary>
    public class NodeSpecUpdate 
    {
        /// <summary>
        /// **参数解释**： 指定节点安全加固类型，当前仅支持HCE2.0镜像等保2.0三级安全加固。 等保加固会对身份鉴别、访问控制、安全审计、入侵防范、恶意代码防范进行检查并加固。详情请参见[Huawei Cloud EulerOS 2.0等保2.0三级版镜像概述](https://support.huaweicloud.com/productdesc-hce/hce_sec_0001.html)。 若未指定此参数，则尝试用原有的值补全。如：原先HCE2.0镜像已配置安全加固，更新节点池时未指定此参数，则仍旧保持安全加固配置，若要取消，需显式指定参数值为\&quot;null\&quot;。 **约束限制**： 不涉及 **取值范围**： 取值范围：[&#39;null&#39;, cybersecurity]; **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 指定节点安全加固类型，当前仅支持HCE2.0镜像等保2.0三级安全加固。 等保加固会对身份鉴别、访问控制、安全审计、入侵防范、恶意代码防范进行检查并加固。详情请参见[Huawei Cloud EulerOS 2.0等保2.0三级版镜像概述](https://support.huaweicloud.com/productdesc-hce/hce_sec_0001.html)。 若未指定此参数，则尝试用原有的值补全。如：原先HCE2.0镜像已配置安全加固，更新节点池时未指定此参数，则仍旧保持安全加固配置，若要取消，需显式指定参数值为\&quot;null\&quot;。 **约束限制**： 不涉及 **取值范围**： 取值范围：[&#39;null&#39;, cybersecurity]; **默认取值**： 不涉及</value>
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

            public static bool operator !=(SecurityReinforcementTypeEnum a, SecurityReinforcementTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 支持给创建出来的节点加Taints来设置反亲和性，taints配置不超过20条。默认值为空。每条Taints包含以下3个参数：  - Key：必须以字母或数字开头，可以包含字母、数字、连字符、下划线和点，最长63个字符；另外可以使用DNS子域作为前缀。 - Value：必须以字符或数字开头，可以包含字母、数字、连字符、下划线和点，最长63个字符。 - Effect：只可选NoSchedule，PreferNoSchedule或NoExecute。  示例：  &#x60;&#x60;&#x60; \&quot;taints\&quot;: [{   \&quot;key\&quot;: \&quot;status\&quot;,   \&quot;value\&quot;: \&quot;unavailable\&quot;,   \&quot;effect\&quot;: \&quot;NoSchedule\&quot; }, {   \&quot;key\&quot;: \&quot;looks\&quot;,   \&quot;value\&quot;: \&quot;bad\&quot;,   \&quot;effect\&quot;: \&quot;NoSchedule\&quot; }] &#x60;&#x60;&#x60; &gt; 参数未指定或者为空数组时将删除节点池的自定义Taints 
        /// </summary>
        [JsonProperty("taints", NullValueHandling = NullValueHandling.Ignore)]
        public List<Taint> Taints { get; set; }

        /// <summary>
        /// 格式为key/value键值对。键值对个数不超过20条。默认值为空。 - Key：必须以字母或数字开头，可以包含字母、数字、连字符、下划线和点，最长63个字符；另外可以使用DNS子域作为前缀，例如example.com/my-key，DNS子域最长253个字符。 - Value：可以为空或者非空字符串，非空字符串必须以字符或数字开头，可以包含字母、数字、连字符、下划线和点，最长63个字符。  示例： &#x60;&#x60;&#x60; \&quot;k8sTags\&quot;: {   \&quot;key\&quot;: \&quot;value\&quot; } &#x60;&#x60;&#x60; &gt; 参数未指定或者为空对象时将删除节点池的自定义K8s标签 
        /// </summary>
        [JsonProperty("k8sTags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> K8sTags { get; set; }

        /// <summary>
        /// 云服务器标签，键必须唯一，CCE支持的最大用户自定义标签数量依region而定，自定义标签数上限为8个。默认值为空。 &gt; 参数未指定或者为空数组时将删除节点池的自定义云服务器标签 
        /// </summary>
        [JsonProperty("userTags", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserTag> UserTags { get; set; }

        /// <summary>
        /// 自定义初始化标记。  CCE节点在初始化完成之前，会打上初始化未完成污点（node.cloudprovider.kubernetes.io/uninitialized）防止pod调度到节点上。  cce支持自定义初始化标记，在接收到initializedConditions参数后，会将参数值转换成节点标签，随节点下发，例如：cloudprovider.openvessel.io/inject-initialized-conditions&#x3D;CCEInitial_CustomedInitial。  当节点上设置了此标签，会轮询节点的status.Conditions，查看conditions的type是否存在标记名，如CCEInitial、CustomedInitial标记，如果存在所有传入的标记，且状态为True，认为节点初始化完成，则移除初始化污点。  默认值为空。  - 必须以字母、数字组成，长度范围1-20位。 - 标记数量不超过2个 
        /// </summary>
        [JsonProperty("initializedConditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InitializedConditions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("login", NullValueHandling = NullValueHandling.Ignore)]
        public Login Login { get; set; }

        /// <summary>
        /// 服务器企业项目ID。CCE服务不实现EPS相关特性，该字段仅用于同步服务器企业项目ID。 创建节点/节点池场景：可指定已存在企业项目，当取值为空时，该字段继承集群企业项目属性。 更新节点池场景：配置修改后仅会对新增节点的服务器生效，存量节点需前往EPS界面迁移。 如果更新时不指定值，不会更新该字段。 当该字段为空时，返回集群企业项目。
        /// </summary>
        [JsonProperty("serverEnterpriseProjectID", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerEnterpriseProjectID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nodeNicSpecUpdate", NullValueHandling = NullValueHandling.Ignore)]
        public NodeSpecUpdateNodeNicSpecUpdate NodeNicSpecUpdate { get; set; }

        /// <summary>
        /// **参数解释**： 指定节点安全加固类型，当前仅支持HCE2.0镜像等保2.0三级安全加固。 等保加固会对身份鉴别、访问控制、安全审计、入侵防范、恶意代码防范进行检查并加固。详情请参见[Huawei Cloud EulerOS 2.0等保2.0三级版镜像概述](https://support.huaweicloud.com/productdesc-hce/hce_sec_0001.html)。 若未指定此参数，则尝试用原有的值补全。如：原先HCE2.0镜像已配置安全加固，更新节点池时未指定此参数，则仍旧保持安全加固配置，若要取消，需显式指定参数值为\&quot;null\&quot;。 **约束限制**： 不涉及 **取值范围**： 取值范围：[&#39;null&#39;, cybersecurity]; **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("securityReinforcementType", NullValueHandling = NullValueHandling.Ignore)]
        public SecurityReinforcementTypeEnum SecurityReinforcementType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeSpecUpdate {\n");
            sb.Append("  taints: ").Append(Taints).Append("\n");
            sb.Append("  k8sTags: ").Append(K8sTags).Append("\n");
            sb.Append("  userTags: ").Append(UserTags).Append("\n");
            sb.Append("  initializedConditions: ").Append(InitializedConditions).Append("\n");
            sb.Append("  login: ").Append(Login).Append("\n");
            sb.Append("  serverEnterpriseProjectID: ").Append(ServerEnterpriseProjectID).Append("\n");
            sb.Append("  nodeNicSpecUpdate: ").Append(NodeNicSpecUpdate).Append("\n");
            sb.Append("  securityReinforcementType: ").Append(SecurityReinforcementType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeSpecUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeSpecUpdate input)
        {
            if (input == null) return false;
            if (this.Taints != input.Taints || (this.Taints != null && input.Taints != null && !this.Taints.SequenceEqual(input.Taints))) return false;
            if (this.K8sTags != input.K8sTags || (this.K8sTags != null && input.K8sTags != null && !this.K8sTags.SequenceEqual(input.K8sTags))) return false;
            if (this.UserTags != input.UserTags || (this.UserTags != null && input.UserTags != null && !this.UserTags.SequenceEqual(input.UserTags))) return false;
            if (this.InitializedConditions != input.InitializedConditions || (this.InitializedConditions != null && input.InitializedConditions != null && !this.InitializedConditions.SequenceEqual(input.InitializedConditions))) return false;
            if (this.Login != input.Login || (this.Login != null && !this.Login.Equals(input.Login))) return false;
            if (this.ServerEnterpriseProjectID != input.ServerEnterpriseProjectID || (this.ServerEnterpriseProjectID != null && !this.ServerEnterpriseProjectID.Equals(input.ServerEnterpriseProjectID))) return false;
            if (this.NodeNicSpecUpdate != input.NodeNicSpecUpdate || (this.NodeNicSpecUpdate != null && !this.NodeNicSpecUpdate.Equals(input.NodeNicSpecUpdate))) return false;
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
                if (this.Taints != null) hashCode = hashCode * 59 + this.Taints.GetHashCode();
                if (this.K8sTags != null) hashCode = hashCode * 59 + this.K8sTags.GetHashCode();
                if (this.UserTags != null) hashCode = hashCode * 59 + this.UserTags.GetHashCode();
                if (this.InitializedConditions != null) hashCode = hashCode * 59 + this.InitializedConditions.GetHashCode();
                if (this.Login != null) hashCode = hashCode * 59 + this.Login.GetHashCode();
                if (this.ServerEnterpriseProjectID != null) hashCode = hashCode * 59 + this.ServerEnterpriseProjectID.GetHashCode();
                if (this.NodeNicSpecUpdate != null) hashCode = hashCode * 59 + this.NodeNicSpecUpdate.GetHashCode();
                hashCode = hashCode * 59 + this.SecurityReinforcementType.GetHashCode();
                return hashCode;
            }
        }
    }
}
