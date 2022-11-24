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
    /// 集群参数定义。
    /// </summary>
    public class ClusterSpec 
    {
        /// <summary>
        /// 集群类别：   - CCE：CCE集群    CCE集群支持虚拟机与裸金属服务器混合、GPU、NPU等异构节点的混合部署，基于高性能网络模型提供全方位、多场景、安全稳定的容器运行环境。  [- Turbo: CCE Turbo集群。全面基于云原生基础设施构建的云原生2.0的容器引擎服务，具备软硬协同、网络无损、安全可靠、调度智能的优势，为用户提供一站式、高性价比的全新容器服务体验。](tag:hws,hws_hk,dt) 
        /// </summary>
        /// <value>集群类别：   - CCE：CCE集群    CCE集群支持虚拟机与裸金属服务器混合、GPU、NPU等异构节点的混合部署，基于高性能网络模型提供全方位、多场景、安全稳定的容器运行环境。  [- Turbo: CCE Turbo集群。全面基于云原生基础设施构建的云原生2.0的容器引擎服务，具备软硬协同、网络无损、安全可靠、调度智能的优势，为用户提供一站式、高性价比的全新容器服务体验。](tag:hws,hws_hk,dt) </value>
        [JsonConverter(typeof(EnumClassConverter<CategoryEnum>))]
        public class CategoryEnum
        {
            /// <summary>
            /// Enum CCE for value: CCE
            /// </summary>
            public static readonly CategoryEnum CCE = new CategoryEnum("CCE");

            /// <summary>
            /// Enum TURBO for value: Turbo
            /// </summary>
            public static readonly CategoryEnum TURBO = new CategoryEnum("Turbo");

            private static readonly Dictionary<string, CategoryEnum> StaticFields =
            new Dictionary<string, CategoryEnum>()
            {
                { "CCE", CCE },
                { "Turbo", TURBO },
            };

            private string Value;

            public CategoryEnum(string value)
            {
                Value = value;
            }

            public static CategoryEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as CategoryEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CategoryEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(CategoryEnum a, CategoryEnum b)
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

            public static bool operator !=(CategoryEnum a, CategoryEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 集群Master节点架构：  - VirtualMachine：Master节点为x86架构服务器 [- ARM64: Master节点为鲲鹏（ARM架构）服务器](tag:hws,hws_hk) 
        /// </summary>
        /// <value>集群Master节点架构：  - VirtualMachine：Master节点为x86架构服务器 [- ARM64: Master节点为鲲鹏（ARM架构）服务器](tag:hws,hws_hk) </value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum VIRTUALMACHINE for value: VirtualMachine
            /// </summary>
            public static readonly TypeEnum VIRTUALMACHINE = new TypeEnum("VirtualMachine");

            /// <summary>
            /// Enum ARM64 for value: ARM64
            /// </summary>
            public static readonly TypeEnum ARM64 = new TypeEnum("ARM64");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "VirtualMachine", VIRTUALMACHINE },
                { "ARM64", ARM64 },
            };

            private string Value;

            public TypeEnum(string value)
            {
                Value = value;
            }

            public static TypeEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 服务转发模式，支持以下两种实现： - iptables：社区传统的kube-proxy模式，完全以iptables规则的方式来实现service负载均衡。该方式最主要的问题是在服务多的时候产生太多的iptables规则，非增量式更新会引入一定的时延，大规模情况下有明显的性能问题。 - ipvs：主导开发并在社区获得广泛支持的kube-proxy模式，采用增量式更新，吞吐更高，速度更快，并可以保证service更新期间连接保持不断开，适用于大规模场景。 
        /// </summary>
        /// <value>服务转发模式，支持以下两种实现： - iptables：社区传统的kube-proxy模式，完全以iptables规则的方式来实现service负载均衡。该方式最主要的问题是在服务多的时候产生太多的iptables规则，非增量式更新会引入一定的时延，大规模情况下有明显的性能问题。 - ipvs：主导开发并在社区获得广泛支持的kube-proxy模式，采用增量式更新，吞吐更高，速度更快，并可以保证service更新期间连接保持不断开，适用于大规模场景。 </value>
        [JsonConverter(typeof(EnumClassConverter<KubeProxyModeEnum>))]
        public class KubeProxyModeEnum
        {
            /// <summary>
            /// Enum IPTABLES for value: iptables
            /// </summary>
            public static readonly KubeProxyModeEnum IPTABLES = new KubeProxyModeEnum("iptables");

            /// <summary>
            /// Enum IPVS for value: ipvs
            /// </summary>
            public static readonly KubeProxyModeEnum IPVS = new KubeProxyModeEnum("ipvs");

            private static readonly Dictionary<string, KubeProxyModeEnum> StaticFields =
            new Dictionary<string, KubeProxyModeEnum>()
            {
                { "iptables", IPTABLES },
                { "ipvs", IPVS },
            };

            private string Value;

            public KubeProxyModeEnum(string value)
            {
                Value = value;
            }

            public static KubeProxyModeEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as KubeProxyModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(KubeProxyModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(KubeProxyModeEnum a, KubeProxyModeEnum b)
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

            public static bool operator !=(KubeProxyModeEnum a, KubeProxyModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 集群类别：   - CCE：CCE集群    CCE集群支持虚拟机与裸金属服务器混合、GPU、NPU等异构节点的混合部署，基于高性能网络模型提供全方位、多场景、安全稳定的容器运行环境。  [- Turbo: CCE Turbo集群。全面基于云原生基础设施构建的云原生2.0的容器引擎服务，具备软硬协同、网络无损、安全可靠、调度智能的优势，为用户提供一站式、高性价比的全新容器服务体验。](tag:hws,hws_hk,dt) 
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// 集群Master节点架构：  - VirtualMachine：Master节点为x86架构服务器 [- ARM64: Master节点为鲲鹏（ARM架构）服务器](tag:hws,hws_hk) 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 字段默认值：创建CCE集群[或鲲鹏集群](tag:hws,hws_hk)时，如果是非专属云为 cce.s1.small，专属云则为cce.dec.s1.small；   集群规格，集群创建完成后规格不可再变更，请按实际业务需求进行选择：   - cce.s1.small: 小规模单控制节点CCE集群（最大50节点）  - cce.s1.medium: 中等规模单控制节点CCE集群（最大200节点）  - cce.s2.small: 小规模多控制节点CCE集群（最大50节点）  - cce.s2.medium: 中等规模多控制节点CCE集群（最大200节点）  - cce.s2.large: 大规模多控制节点CCE集群（最大1000节点）  - cce.s2.xlarge: 超大规模多控制节点CCE集群（最大2000节点）   &gt;    - s1：单控制节点CCE集群。 &gt;    - s2：多控制节点CCE集群。 &gt;    - dec：专属CCE集群规格。如cce.dec.s1.small为小规模单控制节点专属CCE集群（最大50节点）。 &gt;    - 最大节点数：当前集群支持管理的最大节点规模，请根据业务需求选择。 &gt;    - 单控制节点集群：普通集群是单控制节点，控制节点故障后，集群将不可用，但已运行工作负载不受影响。 &gt;    - 多控制节点集群：即高可用集群，当某个控制节点故障时，集群仍然可用。 
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// 集群版本，与Kubernetes社区基线版本保持一致，建议选择最新版本。  在CCE控制台支持创建两种最新版本的集群。可登录CCE控制台创建集群，在“版本”处获取到集群版本。 其它集群版本，当前仍可通过api创建，但后续会逐渐下线，具体下线策略请关注CCE官方公告。  &gt;    - 若不配置，默认创建最新版本的集群。 &gt;    - 若指定集群基线版本但是不指定具体r版本，则系统默认选择对应集群版本的最新r版本。建议不指定具体r版本由系统选择最新版本。 &gt;    - Turbo集群支持1.19及以上版本商用。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// CCE集群平台版本号，表示集群版本(version)下的内部版本。用于跟踪某一集群版本内的迭代，集群版本内唯一，跨集群版本重新计数。不支持用户指定，集群创建时自动选择对应集群版本的最新平台版本。   platformVersion格式为：cce.X.Y   - X: 表示内部特性版本。集群版本中特性或者补丁修复，或者OS支持等变更场景。其值从1开始单调递增。  - Y: 表示内部特性版本的补丁版本。仅用于特性版本上线后的软件包更新，不涉及其他修改。其值从0开始单调递增。
        /// </summary>
        [JsonProperty("platformVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string PlatformVersion { get; set; }

        /// <summary>
        /// 集群描述，对于集群使用目的的描述，可根据实际情况自定义，默认为空。集群创建成功后可通过接口[更新指定的集群](cce_02_0240.xml)来做出修改，也可在CCE控制台中对应集群的“集群详情”下的“描述”处进行修改。仅支持utf-8编码。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 集群的API Server服务端证书中的自定义SAN（Subject Alternative Name）字段，遵从SSL标准X509定义的格式规范。  1. 不允许出现同名重复。 2. 格式符合IP和域名格式。  示例: &#x60;&#x60;&#x60; SAN 1: DNS Name&#x3D;example.com SAN 2: DNS Name&#x3D;www.example.com SAN 3: DNS Name&#x3D;example.net SAN 4: IP Address&#x3D;93.184.216.34 &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("customSan", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CustomSan { get; set; }

        /// <summary>
        /// 集群是否使用IPv6模式，1.15版本及以上支持。
        /// </summary>
        [JsonProperty("ipv6enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ipv6enable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hostNetwork", NullValueHandling = NullValueHandling.Ignore)]
        public HostNetwork HostNetwork { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("containerNetwork", NullValueHandling = NullValueHandling.Ignore)]
        public ContainerNetwork ContainerNetwork { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("eniNetwork", NullValueHandling = NullValueHandling.Ignore)]
        public EniNetwork EniNetwork { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("authentication", NullValueHandling = NullValueHandling.Ignore)]
        public Authentication Authentication { get; set; }

        /// <summary>
        /// 集群的计费方式。 - 0: 按需计费 [- 1: 包周期](tag:hws,hws_hk)  默认为“按需计费”。 
        /// </summary>
        [JsonProperty("billingMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillingMode { get; set; }

        /// <summary>
        /// 控制节点的高级配置
        /// </summary>
        [JsonProperty("masters", NullValueHandling = NullValueHandling.Ignore)]
        public List<MasterSpec> Masters { get; set; }

        /// <summary>
        /// 服务网段参数，kubernetes clusterIp取值范围，1.11.7版本及以上支持。 
        /// </summary>
        [JsonProperty("kubernetesSvcIpRange", NullValueHandling = NullValueHandling.Ignore)]
        public string KubernetesSvcIpRange { get; set; }

        /// <summary>
        /// 集群资源标签
        /// </summary>
        [JsonProperty("clusterTags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTag> ClusterTags { get; set; }

        /// <summary>
        /// 服务转发模式，支持以下两种实现： - iptables：社区传统的kube-proxy模式，完全以iptables规则的方式来实现service负载均衡。该方式最主要的问题是在服务多的时候产生太多的iptables规则，非增量式更新会引入一定的时延，大规模情况下有明显的性能问题。 - ipvs：主导开发并在社区获得广泛支持的kube-proxy模式，采用增量式更新，吞吐更高，速度更快，并可以保证service更新期间连接保持不断开，适用于大规模场景。 
        /// </summary>
        [JsonProperty("kubeProxyMode", NullValueHandling = NullValueHandling.Ignore)]
        public KubeProxyModeEnum KubeProxyMode { get; set; }
        /// <summary>
        /// 可用区（仅查询返回字段）。 [CCE支持的可用区请参考[地区和终端节点](https://developer.huaweicloud.com/endpoint?CCE)](tag:hws) [CCE支持的可用区请参考[地区和终端节点](https://developer.huaweicloud.com/intl/zh-cn/endpoint?CCE)](tag:hws_hk) 
        /// </summary>
        [JsonProperty("az", NullValueHandling = NullValueHandling.Ignore)]
        public string Az { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public ClusterExtendParam ExtendParam { get; set; }

        /// <summary>
        /// 支持Istio
        /// </summary>
        [JsonProperty("supportIstio", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportIstio { get; set; }

        /// <summary>
        /// 覆盖集群默认组件配置  若指定了不支持的组件或组件不支持的参数，该配置项将被忽略。  当前支持的可配置组件及其参数详见 [[配置管理](https://support.huaweicloud.com/usermanual-cce/cce_10_0213.html)](tag:hws) [[配置管理](https://support.huaweicloud.com/intl/zh-cn/usermanual-cce/cce_10_0213.html)](tag:hws_hk)
        /// </summary>
        [JsonProperty("configurationsOverride", NullValueHandling = NullValueHandling.Ignore)]
        public List<PackageConfiguration> ConfigurationsOverride { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterSpec {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  platformVersion: ").Append(PlatformVersion).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  customSan: ").Append(CustomSan).Append("\n");
            sb.Append("  ipv6enable: ").Append(Ipv6enable).Append("\n");
            sb.Append("  hostNetwork: ").Append(HostNetwork).Append("\n");
            sb.Append("  containerNetwork: ").Append(ContainerNetwork).Append("\n");
            sb.Append("  eniNetwork: ").Append(EniNetwork).Append("\n");
            sb.Append("  authentication: ").Append(Authentication).Append("\n");
            sb.Append("  billingMode: ").Append(BillingMode).Append("\n");
            sb.Append("  masters: ").Append(Masters).Append("\n");
            sb.Append("  kubernetesSvcIpRange: ").Append(KubernetesSvcIpRange).Append("\n");
            sb.Append("  clusterTags: ").Append(ClusterTags).Append("\n");
            sb.Append("  kubeProxyMode: ").Append(KubeProxyMode).Append("\n");
            sb.Append("  az: ").Append(Az).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("  supportIstio: ").Append(SupportIstio).Append("\n");
            sb.Append("  configurationsOverride: ").Append(ConfigurationsOverride).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Flavor == input.Flavor ||
                    (this.Flavor != null &&
                    this.Flavor.Equals(input.Flavor))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.PlatformVersion == input.PlatformVersion ||
                    (this.PlatformVersion != null &&
                    this.PlatformVersion.Equals(input.PlatformVersion))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CustomSan == input.CustomSan ||
                    this.CustomSan != null &&
                    input.CustomSan != null &&
                    this.CustomSan.SequenceEqual(input.CustomSan)
                ) && 
                (
                    this.Ipv6enable == input.Ipv6enable ||
                    (this.Ipv6enable != null &&
                    this.Ipv6enable.Equals(input.Ipv6enable))
                ) && 
                (
                    this.HostNetwork == input.HostNetwork ||
                    (this.HostNetwork != null &&
                    this.HostNetwork.Equals(input.HostNetwork))
                ) && 
                (
                    this.ContainerNetwork == input.ContainerNetwork ||
                    (this.ContainerNetwork != null &&
                    this.ContainerNetwork.Equals(input.ContainerNetwork))
                ) && 
                (
                    this.EniNetwork == input.EniNetwork ||
                    (this.EniNetwork != null &&
                    this.EniNetwork.Equals(input.EniNetwork))
                ) && 
                (
                    this.Authentication == input.Authentication ||
                    (this.Authentication != null &&
                    this.Authentication.Equals(input.Authentication))
                ) && 
                (
                    this.BillingMode == input.BillingMode ||
                    (this.BillingMode != null &&
                    this.BillingMode.Equals(input.BillingMode))
                ) && 
                (
                    this.Masters == input.Masters ||
                    this.Masters != null &&
                    input.Masters != null &&
                    this.Masters.SequenceEqual(input.Masters)
                ) && 
                (
                    this.KubernetesSvcIpRange == input.KubernetesSvcIpRange ||
                    (this.KubernetesSvcIpRange != null &&
                    this.KubernetesSvcIpRange.Equals(input.KubernetesSvcIpRange))
                ) && 
                (
                    this.ClusterTags == input.ClusterTags ||
                    this.ClusterTags != null &&
                    input.ClusterTags != null &&
                    this.ClusterTags.SequenceEqual(input.ClusterTags)
                ) && 
                (
                    this.KubeProxyMode == input.KubeProxyMode ||
                    (this.KubeProxyMode != null &&
                    this.KubeProxyMode.Equals(input.KubeProxyMode))
                ) && 
                (
                    this.Az == input.Az ||
                    (this.Az != null &&
                    this.Az.Equals(input.Az))
                ) && 
                (
                    this.ExtendParam == input.ExtendParam ||
                    (this.ExtendParam != null &&
                    this.ExtendParam.Equals(input.ExtendParam))
                ) && 
                (
                    this.SupportIstio == input.SupportIstio ||
                    (this.SupportIstio != null &&
                    this.SupportIstio.Equals(input.SupportIstio))
                ) && 
                (
                    this.ConfigurationsOverride == input.ConfigurationsOverride ||
                    this.ConfigurationsOverride != null &&
                    input.ConfigurationsOverride != null &&
                    this.ConfigurationsOverride.SequenceEqual(input.ConfigurationsOverride)
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Flavor != null)
                    hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.PlatformVersion != null)
                    hashCode = hashCode * 59 + this.PlatformVersion.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CustomSan != null)
                    hashCode = hashCode * 59 + this.CustomSan.GetHashCode();
                if (this.Ipv6enable != null)
                    hashCode = hashCode * 59 + this.Ipv6enable.GetHashCode();
                if (this.HostNetwork != null)
                    hashCode = hashCode * 59 + this.HostNetwork.GetHashCode();
                if (this.ContainerNetwork != null)
                    hashCode = hashCode * 59 + this.ContainerNetwork.GetHashCode();
                if (this.EniNetwork != null)
                    hashCode = hashCode * 59 + this.EniNetwork.GetHashCode();
                if (this.Authentication != null)
                    hashCode = hashCode * 59 + this.Authentication.GetHashCode();
                if (this.BillingMode != null)
                    hashCode = hashCode * 59 + this.BillingMode.GetHashCode();
                if (this.Masters != null)
                    hashCode = hashCode * 59 + this.Masters.GetHashCode();
                if (this.KubernetesSvcIpRange != null)
                    hashCode = hashCode * 59 + this.KubernetesSvcIpRange.GetHashCode();
                if (this.ClusterTags != null)
                    hashCode = hashCode * 59 + this.ClusterTags.GetHashCode();
                if (this.KubeProxyMode != null)
                    hashCode = hashCode * 59 + this.KubeProxyMode.GetHashCode();
                if (this.Az != null)
                    hashCode = hashCode * 59 + this.Az.GetHashCode();
                if (this.ExtendParam != null)
                    hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                if (this.SupportIstio != null)
                    hashCode = hashCode * 59 + this.SupportIstio.GetHashCode();
                if (this.ConfigurationsOverride != null)
                    hashCode = hashCode * 59 + this.ConfigurationsOverride.GetHashCode();
                return hashCode;
            }
        }
    }
}
