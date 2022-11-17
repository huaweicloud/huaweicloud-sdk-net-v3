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
    public class ClusterExtendParam 
    {

        /// <summary>
        /// 集群控制节点可用区配置。 [CCE支持的可用区请参考[地区和终端节点](https://developer.huaweicloud.com/endpoint?CCE)](tag:hws) [CCE支持的可用区请参考[地区和终端节点](https://developer.huaweicloud.com/intl/zh-cn/endpoint?CCE)](tag:hws_hk)    - multi_az：多可用区，可选。仅使用高可用集群时才可以配置多可用区。 - 专属云计算池可用区：用于指定专属云可用区部署集群控制节点。如果需配置专属CCE集群，该字段为必选。 
        /// </summary>
        [JsonProperty("clusterAZ", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterAZ { get; set; }

        /// <summary>
        /// 用于指定控制节点的系统盘和数据盘使用专属分布式存储，未指定或者值为空时，默认使用EVS云硬盘。 如果配置专属CCE集群，该字段为必选，请按照如下格式设置： &#x60;&#x60;&#x60; &lt;rootVol.dssPoolID&gt;.&lt;rootVol.volType&gt;;&lt;dataVol.dssPoolID&gt;.&lt;dataVol.volType&gt; &#x60;&#x60;&#x60; 字段说明： - rootVol为系统盘；dataVol为数据盘； - dssPoolID为专属分布式存储池ID； - volType为专属分布式存储池的存储类型，如SAS、SSD。  样例：c950ee97-587c-4f24-8a74-3367e3da570f.sas;6edbc2f4-1507-44f8-ac0d-eed1d2608d38.ssd &gt; 非专属CCE集群不支持配置该字段。 
        /// </summary>
        [JsonProperty("dssMasterVolumes", NullValueHandling = NullValueHandling.Ignore)]
        public string DssMasterVolumes { get; set; }

        /// <summary>
        /// 集群所属的企业项目ID。 &gt;   - 需要开通企业项目功能后才可配置企业项目。 &gt;   - 集群所属的企业项目与集群下所关联的其他云服务资源所属的企业项目必须保持一致。 
        /// </summary>
        [JsonProperty("enterpriseProjectId", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 服务转发模式，支持以下两种实现： - iptables：社区传统的kube-proxy模式，完全以iptables规则的方式来实现service负载均衡。该方式最主要的问题是在服务多的时候产生太多的iptables规则，非增量式更新会引入一定的时延，大规模情况下有明显的性能问题 - ipvs：主导开发并在社区获得广泛支持的kube-proxy模式，采用增量式更新，吞吐更高，速度更快，并可以保证service更新期间连接保持不断开，适用于大规模场景。 &gt; 此参数已废弃，若同时指定此参数和ClusterSpec下的kubeProxyMode，以ClusterSpec下的为准。 
        /// </summary>
        [JsonProperty("kubeProxyMode", NullValueHandling = NullValueHandling.Ignore)]
        public string KubeProxyMode { get; set; }

        /// <summary>
        /// master 弹性公网IP
        /// </summary>
        [JsonProperty("clusterExternalIP", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterExternalIP { get; set; }

        /// <summary>
        /// 容器网络固定IP池掩码位数，仅vpc-router网络支持。  该参数决定节点可分配容器IP数量，与创建节点时设置的maxPods参数共同决定节点最多可以创建多少个Pod， 具体请参见[节点最多可以创建多少Pod](maxPods.xml)。   整数字符传取值范围: 24 ~ 28 
        /// </summary>
        [JsonProperty("alpha.cce/fixPoolMask", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaCceFixPoolMask { get; set; }

        /// <summary>
        /// 专属CCE集群指定可控制节点的规格。
        /// </summary>
        [JsonProperty("decMasterFlavor", NullValueHandling = NullValueHandling.Ignore)]
        public string DecMasterFlavor { get; set; }

        /// <summary>
        /// 集群默认Docker的UmaskMode配置，可取值为secure或normal，不指定时默认为normal。 
        /// </summary>
        [JsonProperty("dockerUmaskMode", NullValueHandling = NullValueHandling.Ignore)]
        public string DockerUmaskMode { get; set; }

        /// <summary>
        /// 集群CPU管理策略。取值为none或static，默认为none。 - none：关闭工作负载实例独占CPU核的功能，优点是CPU共享池的可分配核数较多 - static：支持给节点上的工作负载实例配置CPU独占，适用于对CPU缓存和调度延迟敏感的工作负载[，Turbo集群下仅对普通容器节点有效，安全容器节点无效](tag:hws,hws_hk,dt)。 
        /// </summary>
        [JsonProperty("kubernetes.io/cpuManagerPolicy", NullValueHandling = NullValueHandling.Ignore)]
        public string KubernetesIoCpuManagerPolicy { get; set; }

        /// <summary>
        /// 订单ID，集群付费类型为自动付费包周期类型时，响应中会返回此字段。
        /// </summary>
        [JsonProperty("orderID", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderID { get; set; }

        /// <summary>
        /// - month：月 - year：年 &gt; billingMode为1（包周期）时生效，且为必选。 
        /// </summary>
        [JsonProperty("periodType", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodType { get; set; }

        /// <summary>
        /// 订购周期数，取值范围： - periodType&#x3D;month（周期类型为月）时，取值为[1-9]。 - periodType&#x3D;year（周期类型为年）时，取值为1-3。 &gt; billingMode为1时生效，且为必选。 
        /// </summary>
        [JsonProperty("periodNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        /// <summary>
        /// 是否自动续订 - “true”：自动续订 - “false”：不自动续订 &gt; billingMode为1时生效，不填写此参数时默认不会自动续费。 
        /// </summary>
        [JsonProperty("isAutoRenew", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAutoRenew { get; set; }

        /// <summary>
        /// 是否自动扣款 - “true”：自动扣款 - “false”：不自动扣款 &gt; billingMode为1时生效，不填写此参数时默认不会自动扣款。 
        /// </summary>
        [JsonProperty("isAutoPay", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAutoPay { get; set; }

        /// <summary>
        /// 记录集群通过何种升级方式升级到当前版本。 
        /// </summary>
        [JsonProperty("upgradefrom", NullValueHandling = NullValueHandling.Ignore)]
        public string Upgradefrom { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterExtendParam {\n");
            sb.Append("  clusterAZ: ").Append(ClusterAZ).Append("\n");
            sb.Append("  dssMasterVolumes: ").Append(DssMasterVolumes).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  kubeProxyMode: ").Append(KubeProxyMode).Append("\n");
            sb.Append("  clusterExternalIP: ").Append(ClusterExternalIP).Append("\n");
            sb.Append("  alphaCceFixPoolMask: ").Append(AlphaCceFixPoolMask).Append("\n");
            sb.Append("  decMasterFlavor: ").Append(DecMasterFlavor).Append("\n");
            sb.Append("  dockerUmaskMode: ").Append(DockerUmaskMode).Append("\n");
            sb.Append("  kubernetesIoCpuManagerPolicy: ").Append(KubernetesIoCpuManagerPolicy).Append("\n");
            sb.Append("  orderID: ").Append(OrderID).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  isAutoRenew: ").Append(IsAutoRenew).Append("\n");
            sb.Append("  isAutoPay: ").Append(IsAutoPay).Append("\n");
            sb.Append("  upgradefrom: ").Append(Upgradefrom).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterExtendParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterExtendParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterAZ == input.ClusterAZ ||
                    (this.ClusterAZ != null &&
                    this.ClusterAZ.Equals(input.ClusterAZ))
                ) && 
                (
                    this.DssMasterVolumes == input.DssMasterVolumes ||
                    (this.DssMasterVolumes != null &&
                    this.DssMasterVolumes.Equals(input.DssMasterVolumes))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.KubeProxyMode == input.KubeProxyMode ||
                    (this.KubeProxyMode != null &&
                    this.KubeProxyMode.Equals(input.KubeProxyMode))
                ) && 
                (
                    this.ClusterExternalIP == input.ClusterExternalIP ||
                    (this.ClusterExternalIP != null &&
                    this.ClusterExternalIP.Equals(input.ClusterExternalIP))
                ) && 
                (
                    this.AlphaCceFixPoolMask == input.AlphaCceFixPoolMask ||
                    (this.AlphaCceFixPoolMask != null &&
                    this.AlphaCceFixPoolMask.Equals(input.AlphaCceFixPoolMask))
                ) && 
                (
                    this.DecMasterFlavor == input.DecMasterFlavor ||
                    (this.DecMasterFlavor != null &&
                    this.DecMasterFlavor.Equals(input.DecMasterFlavor))
                ) && 
                (
                    this.DockerUmaskMode == input.DockerUmaskMode ||
                    (this.DockerUmaskMode != null &&
                    this.DockerUmaskMode.Equals(input.DockerUmaskMode))
                ) && 
                (
                    this.KubernetesIoCpuManagerPolicy == input.KubernetesIoCpuManagerPolicy ||
                    (this.KubernetesIoCpuManagerPolicy != null &&
                    this.KubernetesIoCpuManagerPolicy.Equals(input.KubernetesIoCpuManagerPolicy))
                ) && 
                (
                    this.OrderID == input.OrderID ||
                    (this.OrderID != null &&
                    this.OrderID.Equals(input.OrderID))
                ) && 
                (
                    this.PeriodType == input.PeriodType ||
                    (this.PeriodType != null &&
                    this.PeriodType.Equals(input.PeriodType))
                ) && 
                (
                    this.PeriodNum == input.PeriodNum ||
                    (this.PeriodNum != null &&
                    this.PeriodNum.Equals(input.PeriodNum))
                ) && 
                (
                    this.IsAutoRenew == input.IsAutoRenew ||
                    (this.IsAutoRenew != null &&
                    this.IsAutoRenew.Equals(input.IsAutoRenew))
                ) && 
                (
                    this.IsAutoPay == input.IsAutoPay ||
                    (this.IsAutoPay != null &&
                    this.IsAutoPay.Equals(input.IsAutoPay))
                ) && 
                (
                    this.Upgradefrom == input.Upgradefrom ||
                    (this.Upgradefrom != null &&
                    this.Upgradefrom.Equals(input.Upgradefrom))
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
                if (this.ClusterAZ != null)
                    hashCode = hashCode * 59 + this.ClusterAZ.GetHashCode();
                if (this.DssMasterVolumes != null)
                    hashCode = hashCode * 59 + this.DssMasterVolumes.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.KubeProxyMode != null)
                    hashCode = hashCode * 59 + this.KubeProxyMode.GetHashCode();
                if (this.ClusterExternalIP != null)
                    hashCode = hashCode * 59 + this.ClusterExternalIP.GetHashCode();
                if (this.AlphaCceFixPoolMask != null)
                    hashCode = hashCode * 59 + this.AlphaCceFixPoolMask.GetHashCode();
                if (this.DecMasterFlavor != null)
                    hashCode = hashCode * 59 + this.DecMasterFlavor.GetHashCode();
                if (this.DockerUmaskMode != null)
                    hashCode = hashCode * 59 + this.DockerUmaskMode.GetHashCode();
                if (this.KubernetesIoCpuManagerPolicy != null)
                    hashCode = hashCode * 59 + this.KubernetesIoCpuManagerPolicy.GetHashCode();
                if (this.OrderID != null)
                    hashCode = hashCode * 59 + this.OrderID.GetHashCode();
                if (this.PeriodType != null)
                    hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNum != null)
                    hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.IsAutoRenew != null)
                    hashCode = hashCode * 59 + this.IsAutoRenew.GetHashCode();
                if (this.IsAutoPay != null)
                    hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                if (this.Upgradefrom != null)
                    hashCode = hashCode * 59 + this.Upgradefrom.GetHashCode();
                return hashCode;
            }
        }
    }
}
