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
        /// 云服务器规格的分类。裸金属节点无该字段。
        /// </summary>
        [JsonProperty("ecs:performancetype", NullValueHandling = NullValueHandling.Ignore)]
        public string Ecsperformancetype { get; set; }

        /// <summary>
        /// 订单ID，节点付费类型为自动付费包周期类型时，响应中会返回此字段。
        /// </summary>
        [JsonProperty("orderID", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderID { get; set; }

        /// <summary>
        /// 产品ID，节点付费类型为自动付费包周期类型时，响应中会返回此字段。
        /// </summary>
        [JsonProperty("productID", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductID { get; set; }

        /// <summary>
        /// 节点最大允许创建的实例数(Pod)，该数量包含系统默认实例，取值范围为16~256。 该设置的目的为防止节点因管理过多实例而负载过重，请根据您的业务需要进行设置。 
        /// </summary>
        [JsonProperty("maxPods", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxPods { get; set; }

        /// <summary>
        /// 订购周期类型，取值范围： - month：月 - year：年 &gt; billingMode为2（自动付费包周期）时生效，且为必选。 
        /// </summary>
        [JsonProperty("periodType", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodType { get; set; }

        /// <summary>
        /// 订购周期数，取值范围： - periodType&#x3D;month（周期类型为月）时，取值为[1-9]。 - periodType&#x3D;year（周期类型为年）时，取值为1。 &gt; billingMode为2时生效，且为必选。 
        /// </summary>
        [JsonProperty("periodNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        /// <summary>
        /// 是否自动续订 - “true”：自动续订 - “false”：不自动续订 &gt; billingMode为2时生效，且为必选。 
        /// </summary>
        [JsonProperty("isAutoRenew", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAutoRenew { get; set; }

        /// <summary>
        /// 是否自动扣款 - “true”：自动扣款 - “false”：不自动扣款 &gt; billingMode为2时生效，不填写此参数时默认会自动扣款。 
        /// </summary>
        [JsonProperty("isAutoPay", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAutoPay { get; set; }

        /// <summary>
        /// Docker数据盘配置项。默认配置示例如下： &#x60;&#x60;&#x60; \&quot;DockerLVMConfigOverride\&quot;:\&quot;dockerThinpool&#x3D;vgpaas/90%VG;kubernetesLV&#x3D;vgpaas/10%VG;diskType&#x3D;evs;lvType&#x3D;linear\&quot; &#x60;&#x60;&#x60; 包含如下字段：   - userLV：用户空间的大小，示例格式：vgpaas/20%VG   - userPath：用户空间挂载路径，示例格式：/home/wqt-test   - diskType：磁盘类型，目前只有evs、hdd和ssd三种格式   - lvType：逻辑卷的类型，目前支持linear和striped两种，示例格式：striped   - dockerThinpool：Docker盘的空间大小，示例格式：vgpaas/60%VG   - kubernetesLV：Kubelet空间大小，示例格式：vgpaas/20%VG 
        /// </summary>
        [JsonProperty("DockerLVMConfigOverride", NullValueHandling = NullValueHandling.Ignore)]
        public string DockerLVMConfigOverride { get; set; }

        /// <summary>
        /// Device mapper模式下，节点上Docker单容器的可用磁盘空间大小，OverlayFS模式(CCE Turbo集群中CentOS 7.6和Ubuntu 18.04节点，以及混合集群中Ubuntu 18.04节点)下不支持此字段。Device mapper模式下建议dockerBaseSize配置不超过80G，设置过大时可能会导致docker初始化时间过长而启动失败，若对容器磁盘大小有特殊要求，可考虑使用挂载外部或本地存储方式代替。 
        /// </summary>
        [JsonProperty("dockerBaseSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? DockerBaseSize { get; set; }

        /// <summary>
        /// 是否为CCE Turbo集群节点。
        /// </summary>
        [JsonProperty("offloadNode", NullValueHandling = NullValueHandling.Ignore)]
        public string OffloadNode { get; set; }

        /// <summary>
        /// 节点的公钥。
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
        /// 如果创建裸金属节点，需要使用自定义镜像时用此参数。 
        /// </summary>
        [JsonProperty("alpha.cce/NodeImageID", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaCceNodeImageID { get; set; }

        /// <summary>
        /// - 弹性网卡队列数配置，默认配置示例如下： &#x60;&#x60;&#x60; \&quot;[{\\\&quot;queue\\\&quot;:4}]\&quot; &#x60;&#x60;&#x60; 包含如下字段：   - queue: 弹性网卡队列数。 - 仅在turbo集群的BMS节点时，该字段才可配置。 - 当前支持可配置队列数以及弹性网卡数：{\&quot;1\&quot;:128, \&quot;2\&quot;:92, \&quot;4\&quot;:92, \&quot;8\&quot;:32, \&quot;16\&quot;:16, \&quot;28\&quot;:9}, 既1弹性网卡队列可绑定128张弹性网卡，2队列弹性网卡可绑定92张，以此类推。 - 弹性网卡队列数越多，性能越强，但可绑定弹性网卡数越少，请根据您的需求进行配置（创建后不可修改）。 
        /// </summary>
        [JsonProperty("nicMultiqueue", NullValueHandling = NullValueHandling.Ignore)]
        public string NicMultiqueue { get; set; }

        /// <summary>
        /// - 弹性网卡预绑定比例配置，默认配置示例如下： &#x60;&#x60;&#x60; \&quot;0.3:0.6\&quot; &#x60;&#x60;&#x60;   - 第一位小数：预绑定低水位，弹性网卡预绑定的最低比例（最小预绑定弹性网卡数 &#x3D; ⌊节点的总弹性网卡数 * 预绑定低水位⌋）   - 第二位小数：预绑定高水位，弹性网卡预绑定的最高比例（最大预绑定弹性网卡数 &#x3D; ⌊节点的总弹性网卡数 * 预绑定高水位⌋）   - BMS节点上绑定的弹性网卡数：Pod正在使用的弹性网卡数 + 最小预绑定弹性网卡数 &lt; BMS节点上绑定的弹性网卡数 &lt; Pod正在使用的弹性网卡数 + 最大预绑定弹性网卡数   - BMS节点上当预绑定弹性网卡数 &lt; 最小预绑定弹性网卡数时：会绑定弹性网卡，使得预绑定弹性网卡数 &#x3D; 最小预绑定弹性网卡数   - BMS节点上当预绑定弹性网卡数 &gt; 最大预绑定弹性网卡数时：会定时解绑弹性网卡（约2分钟一次），直到预绑定弹性网卡数 &#x3D; 最大预绑定弹性网卡数   - 取值范围：[0.0, 1.0]; 一位小数; 低水位 &lt;&#x3D; 高水位 - 仅在turbo集群的BMS节点时，该字段才可配置。 - 弹性网卡预绑定能加快工作负载的创建，但会占用IP，请根据您的需求进行配置。 
        /// </summary>
        [JsonProperty("nicThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public string NicThreshold { get; set; }


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
            sb.Append("  offloadNode: ").Append(OffloadNode).Append("\n");
            sb.Append("  publicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  alphaCcePreInstall: ").Append(AlphaCcePreInstall).Append("\n");
            sb.Append("  alphaCcePostInstall: ").Append(AlphaCcePostInstall).Append("\n");
            sb.Append("  alphaCceNodeImageID: ").Append(AlphaCceNodeImageID).Append("\n");
            sb.Append("  nicMultiqueue: ").Append(NicMultiqueue).Append("\n");
            sb.Append("  nicThreshold: ").Append(NicThreshold).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.Ecsperformancetype == input.Ecsperformancetype ||
                    (this.Ecsperformancetype != null &&
                    this.Ecsperformancetype.Equals(input.Ecsperformancetype))
                ) && 
                (
                    this.OrderID == input.OrderID ||
                    (this.OrderID != null &&
                    this.OrderID.Equals(input.OrderID))
                ) && 
                (
                    this.ProductID == input.ProductID ||
                    (this.ProductID != null &&
                    this.ProductID.Equals(input.ProductID))
                ) && 
                (
                    this.MaxPods == input.MaxPods ||
                    (this.MaxPods != null &&
                    this.MaxPods.Equals(input.MaxPods))
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
                    this.DockerLVMConfigOverride == input.DockerLVMConfigOverride ||
                    (this.DockerLVMConfigOverride != null &&
                    this.DockerLVMConfigOverride.Equals(input.DockerLVMConfigOverride))
                ) && 
                (
                    this.DockerBaseSize == input.DockerBaseSize ||
                    (this.DockerBaseSize != null &&
                    this.DockerBaseSize.Equals(input.DockerBaseSize))
                ) && 
                (
                    this.OffloadNode == input.OffloadNode ||
                    (this.OffloadNode != null &&
                    this.OffloadNode.Equals(input.OffloadNode))
                ) && 
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
                ) && 
                (
                    this.AlphaCcePreInstall == input.AlphaCcePreInstall ||
                    (this.AlphaCcePreInstall != null &&
                    this.AlphaCcePreInstall.Equals(input.AlphaCcePreInstall))
                ) && 
                (
                    this.AlphaCcePostInstall == input.AlphaCcePostInstall ||
                    (this.AlphaCcePostInstall != null &&
                    this.AlphaCcePostInstall.Equals(input.AlphaCcePostInstall))
                ) && 
                (
                    this.AlphaCceNodeImageID == input.AlphaCceNodeImageID ||
                    (this.AlphaCceNodeImageID != null &&
                    this.AlphaCceNodeImageID.Equals(input.AlphaCceNodeImageID))
                ) && 
                (
                    this.NicMultiqueue == input.NicMultiqueue ||
                    (this.NicMultiqueue != null &&
                    this.NicMultiqueue.Equals(input.NicMultiqueue))
                ) && 
                (
                    this.NicThreshold == input.NicThreshold ||
                    (this.NicThreshold != null &&
                    this.NicThreshold.Equals(input.NicThreshold))
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
                if (this.Ecsperformancetype != null)
                    hashCode = hashCode * 59 + this.Ecsperformancetype.GetHashCode();
                if (this.OrderID != null)
                    hashCode = hashCode * 59 + this.OrderID.GetHashCode();
                if (this.ProductID != null)
                    hashCode = hashCode * 59 + this.ProductID.GetHashCode();
                if (this.MaxPods != null)
                    hashCode = hashCode * 59 + this.MaxPods.GetHashCode();
                if (this.PeriodType != null)
                    hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNum != null)
                    hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.IsAutoRenew != null)
                    hashCode = hashCode * 59 + this.IsAutoRenew.GetHashCode();
                if (this.IsAutoPay != null)
                    hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                if (this.DockerLVMConfigOverride != null)
                    hashCode = hashCode * 59 + this.DockerLVMConfigOverride.GetHashCode();
                if (this.DockerBaseSize != null)
                    hashCode = hashCode * 59 + this.DockerBaseSize.GetHashCode();
                if (this.OffloadNode != null)
                    hashCode = hashCode * 59 + this.OffloadNode.GetHashCode();
                if (this.PublicKey != null)
                    hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
                if (this.AlphaCcePreInstall != null)
                    hashCode = hashCode * 59 + this.AlphaCcePreInstall.GetHashCode();
                if (this.AlphaCcePostInstall != null)
                    hashCode = hashCode * 59 + this.AlphaCcePostInstall.GetHashCode();
                if (this.AlphaCceNodeImageID != null)
                    hashCode = hashCode * 59 + this.AlphaCceNodeImageID.GetHashCode();
                if (this.NicMultiqueue != null)
                    hashCode = hashCode * 59 + this.NicMultiqueue.GetHashCode();
                if (this.NicThreshold != null)
                    hashCode = hashCode * 59 + this.NicThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
