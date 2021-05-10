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
    public class V3NodeSpec 
    {

        /// <summary>
        /// 节点的规格
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        ///   节点所在的可用区名. 底层实际存在，位于该用户物理可用区组之内的可用区
        /// </summary>
        [JsonProperty("az", NullValueHandling = NullValueHandling.Ignore)]
        public string Az { get; set; }

        /// <summary>
        /// 节点的操作系统类型。  - 对于虚拟机节点，可以配置为“EulerOS”、“CentOS”、“Debian”、“Ubuntu”。默认为\&quot;EulerOS\&quot;。  &gt; 系统会根据集群版本自动选择支持的系统版本。当前集群版本不支持该系统类型，则会报错。  - 对于自动付费包周期的裸金属节点，只支持EulerOS 2.3、EulerOS 2.5、EulerOS 2.8。  - 若在创建节点时指定了extendParam中的alpha.cce/NodeImageID参数，可以不填写此参数。
        /// </summary>
        [JsonProperty("os", NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("login", NullValueHandling = NullValueHandling.Ignore)]
        public Login Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rootVolume", NullValueHandling = NullValueHandling.Ignore)]
        public V3Volume RootVolume { get; set; }

        /// <summary>
        /// 节点的数据盘参数（目前已支持通过控制台为CCE节点添加第二块数据盘）。  针对专属云节点，参数解释与rootVolume一致
        /// </summary>
        [JsonProperty("dataVolumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<V3Volume> DataVolumes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("publicIP", NullValueHandling = NullValueHandling.Ignore)]
        public V3NodePublicIP PublicIP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nodeNicSpec", NullValueHandling = NullValueHandling.Ignore)]
        public NodeNicSpec NodeNicSpec { get; set; }

        /// <summary>
        /// 批量创建时节点的个数，必须为大于等于1，小于等于最大限额的正整数。作用于节点池时该项允许为0
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 节点的计费模式：取值为 0（按需付费）、2（自动付费包周期）  自动付费包周期支持普通用户token。 &gt;创建按需节点不影响集群状态；创建包周期节点时，集群状态会转换为“扩容中”。
        /// </summary>
        [JsonProperty("billingMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillingMode { get; set; }

        /// <summary>
        /// 支持给创建出来的节点加Taints来设置反亲和性，每条Taints包含以下3个参数：  - Key：必须以字母或数字开头，可以包含字母、数字、连字符、下划线和点，最长63个字符；另外可以使用DNS子域作为前缀。 - Value：必须以字符或数字开头，可以包含字母、数字、连字符、下划线和点，最长63个字符。 - Effect：只可选NoSchedule，PreferNoSchedule或NoExecute。  示例：  &#x60;&#x60;&#x60; \&quot;taints\&quot;: [{  \&quot;key\&quot;: \&quot;status\&quot;,  \&quot;value\&quot;: \&quot;unavailable\&quot;,  \&quot;effect\&quot;: \&quot;NoSchedule\&quot; }, {  \&quot;key\&quot;: \&quot;looks\&quot;,  \&quot;value\&quot;: \&quot;bad\&quot;,  \&quot;effect\&quot;: \&quot;NoSchedule\&quot; }] &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("taints", NullValueHandling = NullValueHandling.Ignore)]
        public List<Taint> Taints { get; set; }

        /// <summary>
        /// 格式为key/value键值对。键值对个数不超过20条。  - Key：必须以字母或数字开头，可以包含字母、数字、连字符、下划线和点，最长63个字符；另外可以使用DNS子域作为前缀，例如example.com/my-key， DNS子域最长253个字符。 - Value：可以为空或者非空字符串，非空字符串必须以字符或数字开头，可以包含字母、数字、连字符、下划线和点，最长63个字符。  示例：  &#x60;&#x60;&#x60; \&quot;k8sTags\&quot;: {  \&quot;key\&quot;: \&quot;value\&quot; } &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("k8sTags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> K8sTags { get; set; }

        /// <summary>
        /// 云服务器组ID，若指定，将节点创建在该云服务器组下
        /// </summary>
        [JsonProperty("ecsGroupId", NullValueHandling = NullValueHandling.Ignore)]
        public string EcsGroupId { get; set; }

        /// <summary>
        /// 云服务器故障域，将节点创建在指定故障域下。\\n &gt;必须同时指定故障域策略的云服务器ID，且需要开启故障域特性开关 
        /// </summary>
        [JsonProperty("faultDomain", NullValueHandling = NullValueHandling.Ignore)]
        public string FaultDomain { get; set; }

        /// <summary>
        /// 指定DeH主机的ID，将节点调度到自己的DeH上。\\n&gt;创建节点池添加节点时不支持该参数。 
        /// </summary>
        [JsonProperty("dedicatedHostId", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// 是否CCE Turbo集群节点 &gt;创建节点池添加节点时不支持该参数。
        /// </summary>
        [JsonProperty("offloadNode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OffloadNode { get; set; }

        /// <summary>
        /// 云服务器标签，键必须唯一，CCE支持的最大用户自定义标签数量依region而定，自定义标签数上限最少为5个。
        /// </summary>
        [JsonProperty("userTags", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserTag> UserTags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// 创建节点时的扩展参数，可选参数如下： - chargingMode: 节点的计费模式。按需计费，取值为“0”，若不填，则默认为“0”。 - ecs:performancetype：云服务器规格的分类。裸金属节点无该字段。 - orderID: 订单ID，节点付费类型为自动付费包周期类型时，响应中会返回此字段。 - productID: 产品ID。 - maxPods: 节点最大允许创建的实例数(Pod)，该数量包含系统默认实例，取值范围为16~256。   该设置的目的为防止节点因管理过多实例而负载过重，请根据您的业务需要进行设置。 - periodType:   订购周期类型，取值范围：     - month：月     - year：年   &gt; billingMode为2（自动付费包周期）时生效，且为必选。 - periodNum:   订购周期数，取值范围：     - periodType&#x3D;month（周期类型为月）时，取值为[1-9]。     - periodType&#x3D;year（周期类型为年）时，取值为1。   &gt; billingMode为2时生效，且为必选。 - isAutoRenew:   是否自动续订     - “true”：自动续订     - “false”：不自动续订   &gt; billingMode为2时生效，且为必选。 - isAutoPay:   是否自动扣款     - “true”：自动扣款     - “false”：不自动扣款   &gt; billingMode为2时生效，不填写此参数时默认会自动扣款。 - DockerLVMConfigOverride:   Docker数据盘配置项。默认配置示例如下：   &#x60;&#x60;&#x60;   \&quot;DockerLVMConfigOverride\&quot;:\&quot;dockerThinpool&#x3D;vgpaas/90%VG;kubernetesLV&#x3D;vgpaas/10%VG;diskType&#x3D;evs;lvType&#x3D;linear\&quot;   &#x60;&#x60;&#x60;   包含如下字段：     - userLV：用户空间的大小，示例格式：vgpaas/20%VG     - userPath：用户空间挂载路径，示例格式：/home/wqt-test     - diskType：磁盘类型，目前只有evs、hdd和ssd三种格式     - lvType：逻辑卷的类型，目前支持linear和striped两种，示例格式：striped     - dockerThinpool：Docker盘的空间大小，示例格式：vgpaas/60%VG     - kubernetesLV：Kubelet空间大小，示例格式：vgpaas/20%VG - dockerBaseSize:   Device mapper模式下，节点上Docker单容器的可用磁盘空间大小，OverlayFS模式(CCE Turbo集群中CentOS 7.6和Ubuntu 18.04节点，以及混合集群中Ubuntu 18.04节点)下不支持此字段。Device mapper模式下建议dockerBaseSize配置不超过80G，设置过大时可能会导致docker初始化时间过长而启动失败，若对容器磁盘大小有特殊要求，可考虑使用挂载外部或本地存储方式代替。 - init-node-password: 节点初始密码 - offloadNode: 是否为CCE Turbo集群节点 - publicKey: 节点的公钥。 - alpha.cce/preInstall:   安装前执行脚本   &gt; 输入的值需要经过Base64编码，方法为echo -n \&quot;待编码内容\&quot; | base64。 - alpha.cce/postInstall:   安装后执行脚本   &gt; 输入的值需要经过Base64编码，方法为echo -n \&quot;待编码内容\&quot; | base64。 - alpha.cce/NodeImageID: 如果创建裸金属节点，需要使用自定义镜像时用此参数。 - nicMultiqueue:   - 弹性网卡队列数配置，默认配置示例如下：   &#x60;&#x60;&#x60;   \&quot;[{\\\&quot;queue\\\&quot;:4}]\&quot;   &#x60;&#x60;&#x60;   包含如下字段：     - queue: 弹性网卡队列数。   - 仅在turbo集群的BMS节点时，该字段才可配置。   - 当前支持可配置队列数以及弹性网卡数：{\&quot;1\&quot;:128, \&quot;2\&quot;:92, \&quot;4\&quot;:92, \&quot;8\&quot;:32, \&quot;16\&quot;:16, \&quot;28\&quot;:9}, 既1弹性网卡队列可绑定128张弹性网卡，2队列弹性网卡可绑定92张，以此类推。   - 弹性网卡队列数越多，性能越强，但可绑定弹性网卡数越少，请根据您的需求进行配置（创建后不可修改）。 - nicThreshold:   - 弹性网卡预绑定比例配置，默认配置示例如下：   &#x60;&#x60;&#x60;   \&quot;0.3:0.6\&quot;   &#x60;&#x60;&#x60;     - 第一位小数：预绑定低水位，弹性网卡预绑定的最低比例（最小预绑定弹性网卡数 &#x3D; ⌊节点的总弹性网卡数 * 预绑定低水位⌋）     - 第二位小数：预绑定高水位，弹性网卡预绑定的最高比例（最大预绑定弹性网卡数 &#x3D; ⌊节点的总弹性网卡数 * 预绑定高水位⌋）     - BMS节点上绑定的弹性网卡数：Pod正在使用的弹性网卡数 + 最小预绑定弹性网卡数 &lt; BMS节点上绑定的弹性网卡数 &lt; Pod正在使用的弹性网卡数 + 最大预绑定弹性网卡数     - BMS节点上当预绑定弹性网卡数 &lt; 最小预绑定弹性网卡数时：会绑定弹性网卡，使得预绑定弹性网卡数 &#x3D; 最小预绑定弹性网卡数     - BMS节点上当预绑定弹性网卡数 &gt; 最大预绑定弹性网卡数时：会定时解绑弹性网卡（约2分钟一次），直到预绑定弹性网卡数 &#x3D; 最大预绑定弹性网卡数     - 取值范围：[0.0, 1.0]; 一位小数; 低水位 &lt;&#x3D; 高水位   - 仅在turbo集群的BMS节点时，该字段才可配置。   - 弹性网卡预绑定能加快工作负载的创建，但会占用IP，请根据您的需求进行配置。 
        /// </summary>
        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> ExtendParam { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3NodeSpec {\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  az: ").Append(Az).Append("\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("  login: ").Append(Login).Append("\n");
            sb.Append("  rootVolume: ").Append(RootVolume).Append("\n");
            sb.Append("  dataVolumes: ").Append(DataVolumes).Append("\n");
            sb.Append("  publicIP: ").Append(PublicIP).Append("\n");
            sb.Append("  nodeNicSpec: ").Append(NodeNicSpec).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  billingMode: ").Append(BillingMode).Append("\n");
            sb.Append("  taints: ").Append(Taints).Append("\n");
            sb.Append("  k8sTags: ").Append(K8sTags).Append("\n");
            sb.Append("  ecsGroupId: ").Append(EcsGroupId).Append("\n");
            sb.Append("  faultDomain: ").Append(FaultDomain).Append("\n");
            sb.Append("  dedicatedHostId: ").Append(DedicatedHostId).Append("\n");
            sb.Append("  offloadNode: ").Append(OffloadNode).Append("\n");
            sb.Append("  userTags: ").Append(UserTags).Append("\n");
            sb.Append("  runtime: ").Append(Runtime).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as V3NodeSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(V3NodeSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Flavor == input.Flavor ||
                    (this.Flavor != null &&
                    this.Flavor.Equals(input.Flavor))
                ) && 
                (
                    this.Az == input.Az ||
                    (this.Az != null &&
                    this.Az.Equals(input.Az))
                ) && 
                (
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
                ) && 
                (
                    this.Login == input.Login ||
                    (this.Login != null &&
                    this.Login.Equals(input.Login))
                ) && 
                (
                    this.RootVolume == input.RootVolume ||
                    (this.RootVolume != null &&
                    this.RootVolume.Equals(input.RootVolume))
                ) && 
                (
                    this.DataVolumes == input.DataVolumes ||
                    this.DataVolumes != null &&
                    input.DataVolumes != null &&
                    this.DataVolumes.SequenceEqual(input.DataVolumes)
                ) && 
                (
                    this.PublicIP == input.PublicIP ||
                    (this.PublicIP != null &&
                    this.PublicIP.Equals(input.PublicIP))
                ) && 
                (
                    this.NodeNicSpec == input.NodeNicSpec ||
                    (this.NodeNicSpec != null &&
                    this.NodeNicSpec.Equals(input.NodeNicSpec))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.BillingMode == input.BillingMode ||
                    (this.BillingMode != null &&
                    this.BillingMode.Equals(input.BillingMode))
                ) && 
                (
                    this.Taints == input.Taints ||
                    this.Taints != null &&
                    input.Taints != null &&
                    this.Taints.SequenceEqual(input.Taints)
                ) && 
                (
                    this.K8sTags == input.K8sTags ||
                    this.K8sTags != null &&
                    input.K8sTags != null &&
                    this.K8sTags.SequenceEqual(input.K8sTags)
                ) && 
                (
                    this.EcsGroupId == input.EcsGroupId ||
                    (this.EcsGroupId != null &&
                    this.EcsGroupId.Equals(input.EcsGroupId))
                ) && 
                (
                    this.FaultDomain == input.FaultDomain ||
                    (this.FaultDomain != null &&
                    this.FaultDomain.Equals(input.FaultDomain))
                ) && 
                (
                    this.DedicatedHostId == input.DedicatedHostId ||
                    (this.DedicatedHostId != null &&
                    this.DedicatedHostId.Equals(input.DedicatedHostId))
                ) && 
                (
                    this.OffloadNode == input.OffloadNode ||
                    (this.OffloadNode != null &&
                    this.OffloadNode.Equals(input.OffloadNode))
                ) && 
                (
                    this.UserTags == input.UserTags ||
                    this.UserTags != null &&
                    input.UserTags != null &&
                    this.UserTags.SequenceEqual(input.UserTags)
                ) && 
                (
                    this.Runtime == input.Runtime ||
                    (this.Runtime != null &&
                    this.Runtime.Equals(input.Runtime))
                ) && 
                (
                    this.ExtendParam == input.ExtendParam ||
                    this.ExtendParam != null &&
                    input.ExtendParam != null &&
                    this.ExtendParam.SequenceEqual(input.ExtendParam)
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
                if (this.Flavor != null)
                    hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.Az != null)
                    hashCode = hashCode * 59 + this.Az.GetHashCode();
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.Login != null)
                    hashCode = hashCode * 59 + this.Login.GetHashCode();
                if (this.RootVolume != null)
                    hashCode = hashCode * 59 + this.RootVolume.GetHashCode();
                if (this.DataVolumes != null)
                    hashCode = hashCode * 59 + this.DataVolumes.GetHashCode();
                if (this.PublicIP != null)
                    hashCode = hashCode * 59 + this.PublicIP.GetHashCode();
                if (this.NodeNicSpec != null)
                    hashCode = hashCode * 59 + this.NodeNicSpec.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.BillingMode != null)
                    hashCode = hashCode * 59 + this.BillingMode.GetHashCode();
                if (this.Taints != null)
                    hashCode = hashCode * 59 + this.Taints.GetHashCode();
                if (this.K8sTags != null)
                    hashCode = hashCode * 59 + this.K8sTags.GetHashCode();
                if (this.EcsGroupId != null)
                    hashCode = hashCode * 59 + this.EcsGroupId.GetHashCode();
                if (this.FaultDomain != null)
                    hashCode = hashCode * 59 + this.FaultDomain.GetHashCode();
                if (this.DedicatedHostId != null)
                    hashCode = hashCode * 59 + this.DedicatedHostId.GetHashCode();
                if (this.OffloadNode != null)
                    hashCode = hashCode * 59 + this.OffloadNode.GetHashCode();
                if (this.UserTags != null)
                    hashCode = hashCode * 59 + this.UserTags.GetHashCode();
                if (this.Runtime != null)
                    hashCode = hashCode * 59 + this.Runtime.GetHashCode();
                if (this.ExtendParam != null)
                    hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
