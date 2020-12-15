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
    /// Detailed cluster parameters.
    /// </summary>
    public class V3ClusterSpec 
    {
        /// <summary>
        /// 服务转发模式，支持以下两种实现：  iptables：社区传统的kube-proxy模式，完全以iptables规则的方式来实现service负载均衡。该方式最主要的问题是在服务多的时候产生太多的iptables规则，非增量式更新会引入一定的时延，大规模情况下有明显的性能问题。  ipvs：主导开发并在社区获得广泛支持的kube-proxy模式，采用增量式更新，吞吐更高，速度更快，并可以保证service更新期间连接保持不断开，适用于大规模场景。   &gt;此参数目前仅在响应中体现，创建集群时请在**extendParam**中配置此参数。 
        /// </summary>
        /// <value>服务转发模式，支持以下两种实现：  iptables：社区传统的kube-proxy模式，完全以iptables规则的方式来实现service负载均衡。该方式最主要的问题是在服务多的时候产生太多的iptables规则，非增量式更新会引入一定的时延，大规模情况下有明显的性能问题。  ipvs：主导开发并在社区获得广泛支持的kube-proxy模式，采用增量式更新，吞吐更高，速度更快，并可以保证service更新期间连接保持不断开，适用于大规模场景。   &gt;此参数目前仅在响应中体现，创建集群时请在**extendParam**中配置此参数。 </value>
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
        /// 集群类型：  - VirtualMachine：混合集群  基于Kubernetes来管理一组节点资源，支持虚拟机和裸金属的管理，Kubernetes将自动调度容器运行在可用节点上。在创建容器工作负载前，您需要存在一个可用集群。  - BareMetal：裸金属集群  基于裸金属服务提供高计算和高网络性能的kubernetes容器集群，如需使用，请[创建裸金属服务器](https://support.huaweicloud.com/usermanual-bms/zh-cn_topic_0035100414.html)。裸金属集群为保证高速的容器网络性能，要求您在创建裸金属服务器时，添加一块高速网卡。添加步骤请参见[管理高速网络](https://support.huaweicloud.com/usermanual-bms/zh-cn_topic_0053537013.html)。  - ARM64: 鲲鹏集群  鲲鹏容器集群（ARM指令集）提供了容器在鲲鹏（ARM架构）服务器上的运行能力，提供与X86服务器相同的调度伸缩和快速部署能力。 
        /// </summary>
        /// <value>集群类型：  - VirtualMachine：混合集群  基于Kubernetes来管理一组节点资源，支持虚拟机和裸金属的管理，Kubernetes将自动调度容器运行在可用节点上。在创建容器工作负载前，您需要存在一个可用集群。  - BareMetal：裸金属集群  基于裸金属服务提供高计算和高网络性能的kubernetes容器集群，如需使用，请[创建裸金属服务器](https://support.huaweicloud.com/usermanual-bms/zh-cn_topic_0035100414.html)。裸金属集群为保证高速的容器网络性能，要求您在创建裸金属服务器时，添加一块高速网卡。添加步骤请参见[管理高速网络](https://support.huaweicloud.com/usermanual-bms/zh-cn_topic_0053537013.html)。  - ARM64: 鲲鹏集群  鲲鹏容器集群（ARM指令集）提供了容器在鲲鹏（ARM架构）服务器上的运行能力，提供与X86服务器相同的调度伸缩和快速部署能力。 </value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum VIRTUALMACHINE for value: VirtualMachine
            /// </summary>
            public static readonly TypeEnum VIRTUALMACHINE = new TypeEnum("VirtualMachine");

            /// <summary>
            /// Enum BAREMETAL for value: BareMetal
            /// </summary>
            public static readonly TypeEnum BAREMETAL = new TypeEnum("BareMetal");

            /// <summary>
            /// Enum ARM64 for value: ARM64
            /// </summary>
            public static readonly TypeEnum ARM64 = new TypeEnum("ARM64");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "VirtualMachine", VIRTUALMACHINE },
                { "BareMetal", BAREMETAL },
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
        /// 
        /// </summary>
        [JsonProperty("authentication", NullValueHandling = NullValueHandling.Ignore)]
        public Authentication Authentication { get; set; }

        /// <summary>
        /// 可用区（仅查询返回字段）
        /// </summary>
        [JsonProperty("az", NullValueHandling = NullValueHandling.Ignore)]
        public string Az { get; set; }

        /// <summary>
        /// 集群的计费方式，当前接口只支持创建“按需计费”的集群。计费方式为“按需计费”时，取值为“0”。若不填，则默认为“0”。
        /// </summary>
        [JsonProperty("billingMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillingMode { get; set; }

        /// <summary>
        /// 集群资源标签
        /// </summary>
        [JsonProperty("clusterTags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTag> ClusterTags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("containerNetwork", NullValueHandling = NullValueHandling.Ignore)]
        public ContainerNetwork ContainerNetwork { get; set; }

        /// <summary>
        /// 集群描述，对于集群使用目的的描述，可根据实际情况自定义，默认为空。集群创建成功后可通过接口[更新指定的集群](https://support.huaweicloud.com/api-cce/cce_02_0240.html)来做出修改，也可在CCE控制台中对应集群的“集群详情”下的“描述”处进行修改。仅支持utf-8编码。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("eniNetwork", NullValueHandling = NullValueHandling.Ignore)]
        public ENINetwork EniNetwork { get; set; }

        /// <summary>
        /// 扩展字段，key/value对格式。可配置多可用区集群、专属混合集群，以及将集群创建在特定的企业项目下。可配置的key/value对如下： - clusterAZ: 集群控制节点可用区配置。   - multi_az：多可用区，可选。仅使用高可用集群时才可以配置多可用区。   - 专属云计算池可用区：用于指定专属云可用区部署集群控制节点。   如果需配置专属混合集群，该字段为必选。例如“华北四-可用区一”取值为：cn-north-4a。更多信息请参见[什么是专属计算集群？](https://support.huaweicloud.com/productdesc-dcc/zh-cn_topic_0016310838.html) - dssMasterVolumes: 用于指定控制节点的系统盘和数据盘使用专属分布式存储，未指定或者值为空时，默认使用EVS云硬盘。   如果配置专属混合集群，该字段为必选，请按照如下格式设置：   &#x60;&#x60;&#x60;   &lt;rootVol.dssPoolID&gt;.&lt;rootVol.volType&gt;;&lt;dataVol.dssPoolID&gt;.&lt;dataVol.volType&gt;   &#x60;&#x60;&#x60;   字段说明：   rootVol为系统盘；dataVol为数据盘；   dssPoolID为专属分布式存储池ID；   volType为专属分布式存储池的存储类型，如SAS、SSD。   样例：c950ee97-587c-4f24-8a74-3367e3da570f.sas;6edbc2f4-1507-44f8-ac0d-eed1d2608d38.ssd   非专属混合集群不支持配置该字段。 - enterpriseProjectId:   如果需要将集群创建在特定的企业项目下，请设置{\&quot;enterpriseProjectId\&quot;:\&quot;xxx\&quot;}的key/value对。   &gt;   - 需要开通企业项目功能后才可配置企业项目，详情请参见 [如何进入企业管理页面](https://support.huaweicloud.com/usermanual-em/zh-cn_topic_0108763975.html)。   &gt;   - 集群所属的企业项目与集群下所关联的其他云服务资源所属的企业项目必须保持一致。 - kubeProxyMode:   服务转发模式，支持以下两种实现：   - iptables：社区传统的kube-proxy模式，完全以iptables规则的方式来实现service负载均衡。该方式最主要的问题是在服务多的时候产生太多的iptables规则，非增量式更新会引入一定的时延，大规模情况下有明显的性能问题   - ipvs：主导开发并在社区获得广泛支持的kube-proxy模式，采用增量式更新，吞吐更高，速度更快，并可以保证service更新期间连接保持不断开，适用于大规模场景。 - clusterExternalIP: master 弹性公网IP - alpha.cce/fixPoolMask:    容器网络固定IP池掩码位数，仅vpc-router支持。   整数字符传取值范围: 24 ~ 28 - decMasterFlavor: 专属混合集群指定可控制节点的规格。最大长度255。 - dockerUmaskMode: 集群默认Docker的UmaskMode配置，可取值为secure或normal，不指定时默认为normal。 - kubernetes.io/cpuManagerPolicy:    集群CPU管理策略。取值为none或static，默认为none。   - none：关闭工作负载实例独占CPU核的功能，优点是CPU共享池的可分配核数较多   - static：支持给工作负载实例配置CPU独占，适用于对CPU缓存和调度延迟敏感的工作负载。 
        /// </summary>
        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> ExtendParam { get; set; }

        /// <summary>
        /// 字段默认值：创建混合集群或鲲鹏集群时，如果是非专属云为 cce.s1.small，专属云则为 cce.dec.s1.small；  集群规格，集群创建完成后规格不可再变更，请按实际业务需求进行选择：  - cce.s1.small: 小规模单控制节点混合集群（最大50节点） - cce.s1.medium: 中等规模单控制节点混合集群（最大200节点） - cce.s2.small: 小规模多控制节点混合集群（最大50节点） - cce.s2.medium: 中等规模多控制节点混合集群（最大200节点） - cce.s2.large: 大规模多控制节点混合集群（最大1000节点） - cce.s2.xlarge: 超大规模多控制节点混合集群（最大2000节点）  &gt; s1：单控制节点混合集群。 &gt;  &gt; s2：多控制节点混合集群。 &gt;  &gt; dec：专属混合集群规格。如cce.dec.s1.small为小规模单控制节点专属混合集群（最大50节点）。 &gt;  &gt; 最大节点数：当前集群支持管理的最大节点规模，请根据业务需求选择。 &gt;  &gt; 单控制节点集群：普通集群是单控制节点，控制节点故障后，集群将不可用，但已运行工作负载不受影响。 &gt;  &gt; 多控制节点集群：即高可用集群，当某个控制节点故障时，集群仍然可用。查看集群模式请参见[如何排查已创建的集群是否为高可用集群？](https://support.huaweicloud.com/cce_faq/cce_faq_00155.html)
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hostNetwork", NullValueHandling = NullValueHandling.Ignore)]
        public HostNetwork HostNetwork { get; set; }

        /// <summary>
        /// 集群是否使用IPv6模式，1.15版本及以上支持。
        /// </summary>
        [JsonProperty("ipv6enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ipv6enable { get; set; }

        /// <summary>
        /// 服务转发模式，支持以下两种实现：  iptables：社区传统的kube-proxy模式，完全以iptables规则的方式来实现service负载均衡。该方式最主要的问题是在服务多的时候产生太多的iptables规则，非增量式更新会引入一定的时延，大规模情况下有明显的性能问题。  ipvs：主导开发并在社区获得广泛支持的kube-proxy模式，采用增量式更新，吞吐更高，速度更快，并可以保证service更新期间连接保持不断开，适用于大规模场景。   &gt;此参数目前仅在响应中体现，创建集群时请在**extendParam**中配置此参数。 
        /// </summary>
        [JsonProperty("kubeProxyMode", NullValueHandling = NullValueHandling.Ignore)]
        public KubeProxyModeEnum KubeProxyMode { get; set; }
        /// <summary>
        /// 服务网段参数，kubernetes clusterIp取值范围，1.11.7版本及以上支持。 
        /// </summary>
        [JsonProperty("kubernetesSvcIpRange", NullValueHandling = NullValueHandling.Ignore)]
        public string KubernetesSvcIpRange { get; set; }

        /// <summary>
        /// 控制节点的高级配置
        /// </summary>
        [JsonProperty("masters", NullValueHandling = NullValueHandling.Ignore)]
        public List<MasterSpec> Masters { get; set; }

        /// <summary>
        /// 支持Istio
        /// </summary>
        [JsonProperty("supportIstio", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportIstio { get; set; }

        /// <summary>
        /// 集群类型：  - VirtualMachine：混合集群  基于Kubernetes来管理一组节点资源，支持虚拟机和裸金属的管理，Kubernetes将自动调度容器运行在可用节点上。在创建容器工作负载前，您需要存在一个可用集群。  - BareMetal：裸金属集群  基于裸金属服务提供高计算和高网络性能的kubernetes容器集群，如需使用，请[创建裸金属服务器](https://support.huaweicloud.com/usermanual-bms/zh-cn_topic_0035100414.html)。裸金属集群为保证高速的容器网络性能，要求您在创建裸金属服务器时，添加一块高速网卡。添加步骤请参见[管理高速网络](https://support.huaweicloud.com/usermanual-bms/zh-cn_topic_0053537013.html)。  - ARM64: 鲲鹏集群  鲲鹏容器集群（ARM指令集）提供了容器在鲲鹏（ARM架构）服务器上的运行能力，提供与X86服务器相同的调度伸缩和快速部署能力。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 集群版本，与Kubernetes社区基线版本保持一致，建议选择最新版本。  在CCE控制台中支持创建两种最新版本的集群。可登录CCE控制台，单击“总览 &gt; 购买Kubernetes集群”，在“版本”处获取到集群版本。 其它集群版本，当前仍可通过api创建，但后续会逐渐下线，具体下线策略请关注CCE官方公告。  &gt;    - 若不配置，默认创建最新版本的集群。 &gt;    - 若指定集群基线版本但是不指定具体r版本，则系统默认选择对应集群版本的最新r版本。建议不指定具体r版本由系统选择最新版本。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3ClusterSpec {\n");
            sb.Append("  authentication: ").Append(Authentication).Append("\n");
            sb.Append("  az: ").Append(Az).Append("\n");
            sb.Append("  billingMode: ").Append(BillingMode).Append("\n");
            sb.Append("  clusterTags: ").Append(ClusterTags).Append("\n");
            sb.Append("  containerNetwork: ").Append(ContainerNetwork).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  eniNetwork: ").Append(EniNetwork).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  hostNetwork: ").Append(HostNetwork).Append("\n");
            sb.Append("  ipv6enable: ").Append(Ipv6enable).Append("\n");
            sb.Append("  kubeProxyMode: ").Append(KubeProxyMode).Append("\n");
            sb.Append("  kubernetesSvcIpRange: ").Append(KubernetesSvcIpRange).Append("\n");
            sb.Append("  masters: ").Append(Masters).Append("\n");
            sb.Append("  supportIstio: ").Append(SupportIstio).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as V3ClusterSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(V3ClusterSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Authentication == input.Authentication ||
                    (this.Authentication != null &&
                    this.Authentication.Equals(input.Authentication))
                ) && 
                (
                    this.Az == input.Az ||
                    (this.Az != null &&
                    this.Az.Equals(input.Az))
                ) && 
                (
                    this.BillingMode == input.BillingMode ||
                    (this.BillingMode != null &&
                    this.BillingMode.Equals(input.BillingMode))
                ) && 
                (
                    this.ClusterTags == input.ClusterTags ||
                    this.ClusterTags != null &&
                    input.ClusterTags != null &&
                    this.ClusterTags.SequenceEqual(input.ClusterTags)
                ) && 
                (
                    this.ContainerNetwork == input.ContainerNetwork ||
                    (this.ContainerNetwork != null &&
                    this.ContainerNetwork.Equals(input.ContainerNetwork))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EniNetwork == input.EniNetwork ||
                    (this.EniNetwork != null &&
                    this.EniNetwork.Equals(input.EniNetwork))
                ) && 
                (
                    this.ExtendParam == input.ExtendParam ||
                    this.ExtendParam != null &&
                    input.ExtendParam != null &&
                    this.ExtendParam.SequenceEqual(input.ExtendParam)
                ) && 
                (
                    this.Flavor == input.Flavor ||
                    (this.Flavor != null &&
                    this.Flavor.Equals(input.Flavor))
                ) && 
                (
                    this.HostNetwork == input.HostNetwork ||
                    (this.HostNetwork != null &&
                    this.HostNetwork.Equals(input.HostNetwork))
                ) && 
                (
                    this.Ipv6enable == input.Ipv6enable ||
                    (this.Ipv6enable != null &&
                    this.Ipv6enable.Equals(input.Ipv6enable))
                ) && 
                (
                    this.KubeProxyMode == input.KubeProxyMode ||
                    (this.KubeProxyMode != null &&
                    this.KubeProxyMode.Equals(input.KubeProxyMode))
                ) && 
                (
                    this.KubernetesSvcIpRange == input.KubernetesSvcIpRange ||
                    (this.KubernetesSvcIpRange != null &&
                    this.KubernetesSvcIpRange.Equals(input.KubernetesSvcIpRange))
                ) && 
                (
                    this.Masters == input.Masters ||
                    this.Masters != null &&
                    input.Masters != null &&
                    this.Masters.SequenceEqual(input.Masters)
                ) && 
                (
                    this.SupportIstio == input.SupportIstio ||
                    (this.SupportIstio != null &&
                    this.SupportIstio.Equals(input.SupportIstio))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Authentication != null)
                    hashCode = hashCode * 59 + this.Authentication.GetHashCode();
                if (this.Az != null)
                    hashCode = hashCode * 59 + this.Az.GetHashCode();
                if (this.BillingMode != null)
                    hashCode = hashCode * 59 + this.BillingMode.GetHashCode();
                if (this.ClusterTags != null)
                    hashCode = hashCode * 59 + this.ClusterTags.GetHashCode();
                if (this.ContainerNetwork != null)
                    hashCode = hashCode * 59 + this.ContainerNetwork.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EniNetwork != null)
                    hashCode = hashCode * 59 + this.EniNetwork.GetHashCode();
                if (this.ExtendParam != null)
                    hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                if (this.Flavor != null)
                    hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.HostNetwork != null)
                    hashCode = hashCode * 59 + this.HostNetwork.GetHashCode();
                if (this.Ipv6enable != null)
                    hashCode = hashCode * 59 + this.Ipv6enable.GetHashCode();
                if (this.KubeProxyMode != null)
                    hashCode = hashCode * 59 + this.KubeProxyMode.GetHashCode();
                if (this.KubernetesSvcIpRange != null)
                    hashCode = hashCode * 59 + this.KubernetesSvcIpRange.GetHashCode();
                if (this.Masters != null)
                    hashCode = hashCode * 59 + this.Masters.GetHashCode();
                if (this.SupportIstio != null)
                    hashCode = hashCode * 59 + this.SupportIstio.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }
}
