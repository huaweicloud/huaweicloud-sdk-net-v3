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
    /// 节点重装配置参数
    /// </summary>
    public class ReinstallNodeSpec 
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
        /// 操作系统。指定自定义镜像场景将以IMS镜像的实际操作系统版本为准。请选择当前集群支持的操作系统版本，例如EulerOS 2.5、CentOS 7.6、EulerOS 2.8。 
        /// </summary>
        [JsonProperty("os", NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("login", NullValueHandling = NullValueHandling.Ignore)]
        public Login Login { get; set; }

        /// <summary>
        /// 节点名称 &gt; 重装时指定将修改节点名称，且服务器名称会同步修改。默认以服务器当前名称作为节点名称。 &gt; 命名规则：以小写字母开头，由小写字母、数字、中划线(-)组成，长度范围1-56位。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("serverConfig", NullValueHandling = NullValueHandling.Ignore)]
        public ReinstallServerConfig ServerConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volumeConfig", NullValueHandling = NullValueHandling.Ignore)]
        public ReinstallVolumeConfig VolumeConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("runtimeConfig", NullValueHandling = NullValueHandling.Ignore)]
        public ReinstallRuntimeConfig RuntimeConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("k8sOptions", NullValueHandling = NullValueHandling.Ignore)]
        public ReinstallK8sOptionsConfig K8sOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lifecycle", NullValueHandling = NullValueHandling.Ignore)]
        public NodeLifecycleConfig Lifecycle { get; set; }

        /// <summary>
        /// 自定义初始化标记。  CCE节点在初始化完成之前，会打上初始化未完成污点（node.cloudprovider.kubernetes.io/uninitialized）防止pod调度到节点上。  cce支持自定义初始化标记，在接收到initializedConditions参数后，会将参数值转换成节点标签，随节点下发，例如：cloudprovider.openvessel.io/inject-initialized-conditions&#x3D;CCEInitial_CustomedInitial。  当节点上设置了此标签，会轮询节点的status.Conditions，查看conditions的type是否存在标记名，如CCEInitial、CustomedInitial标记，如果存在所有传入的标记，且状态为True，认为节点初始化完成，则移除初始化污点。  - 必须以字母、数字组成，长度范围1-20位。 - 标记数量不超过2个 
        /// </summary>
        [JsonProperty("initializedConditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InitializedConditions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public ReinstallExtendParam ExtendParam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hostnameConfig", NullValueHandling = NullValueHandling.Ignore)]
        public HostnameConfig HostnameConfig { get; set; }

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
            sb.Append("class ReinstallNodeSpec {\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("  login: ").Append(Login).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  serverConfig: ").Append(ServerConfig).Append("\n");
            sb.Append("  volumeConfig: ").Append(VolumeConfig).Append("\n");
            sb.Append("  runtimeConfig: ").Append(RuntimeConfig).Append("\n");
            sb.Append("  k8sOptions: ").Append(K8sOptions).Append("\n");
            sb.Append("  lifecycle: ").Append(Lifecycle).Append("\n");
            sb.Append("  initializedConditions: ").Append(InitializedConditions).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("  hostnameConfig: ").Append(HostnameConfig).Append("\n");
            sb.Append("  securityReinforcementType: ").Append(SecurityReinforcementType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReinstallNodeSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReinstallNodeSpec input)
        {
            if (input == null) return false;
            if (this.Os != input.Os || (this.Os != null && !this.Os.Equals(input.Os))) return false;
            if (this.Login != input.Login || (this.Login != null && !this.Login.Equals(input.Login))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ServerConfig != input.ServerConfig || (this.ServerConfig != null && !this.ServerConfig.Equals(input.ServerConfig))) return false;
            if (this.VolumeConfig != input.VolumeConfig || (this.VolumeConfig != null && !this.VolumeConfig.Equals(input.VolumeConfig))) return false;
            if (this.RuntimeConfig != input.RuntimeConfig || (this.RuntimeConfig != null && !this.RuntimeConfig.Equals(input.RuntimeConfig))) return false;
            if (this.K8sOptions != input.K8sOptions || (this.K8sOptions != null && !this.K8sOptions.Equals(input.K8sOptions))) return false;
            if (this.Lifecycle != input.Lifecycle || (this.Lifecycle != null && !this.Lifecycle.Equals(input.Lifecycle))) return false;
            if (this.InitializedConditions != input.InitializedConditions || (this.InitializedConditions != null && input.InitializedConditions != null && !this.InitializedConditions.SequenceEqual(input.InitializedConditions))) return false;
            if (this.ExtendParam != input.ExtendParam || (this.ExtendParam != null && !this.ExtendParam.Equals(input.ExtendParam))) return false;
            if (this.HostnameConfig != input.HostnameConfig || (this.HostnameConfig != null && !this.HostnameConfig.Equals(input.HostnameConfig))) return false;
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
                if (this.Os != null) hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.Login != null) hashCode = hashCode * 59 + this.Login.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ServerConfig != null) hashCode = hashCode * 59 + this.ServerConfig.GetHashCode();
                if (this.VolumeConfig != null) hashCode = hashCode * 59 + this.VolumeConfig.GetHashCode();
                if (this.RuntimeConfig != null) hashCode = hashCode * 59 + this.RuntimeConfig.GetHashCode();
                if (this.K8sOptions != null) hashCode = hashCode * 59 + this.K8sOptions.GetHashCode();
                if (this.Lifecycle != null) hashCode = hashCode * 59 + this.Lifecycle.GetHashCode();
                if (this.InitializedConditions != null) hashCode = hashCode * 59 + this.InitializedConditions.GetHashCode();
                if (this.ExtendParam != null) hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                if (this.HostnameConfig != null) hashCode = hashCode * 59 + this.HostnameConfig.GetHashCode();
                hashCode = hashCode * 59 + this.SecurityReinforcementType.GetHashCode();
                return hashCode;
            }
        }
    }
}
