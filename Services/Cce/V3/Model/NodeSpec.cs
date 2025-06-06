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
    public class NodeSpec 
    {

        /// <summary>
        /// 节点的规格，CCE支持的节点规格请参考[节点规格说明](https://support.huaweicloud.com/api-cce/cce_02_0368.html)获取。 
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// 待创建节点所在的可用区，需要指定可用区（AZ）的名称，不填或者填random选择随机可用区。 [CCE支持的可用区请参考[地区和终端节点](https://developer.huaweicloud.com/endpoint?CCE)](tag:hws) [CCE支持的可用区请参考[地区和终端节点](https://developer.huaweicloud.com/intl/zh-cn/endpoint?CCE)](tag:hws_hk) 
        /// </summary>
        [JsonProperty("az", NullValueHandling = NullValueHandling.Ignore)]
        public string Az { get; set; }

        /// <summary>
        /// [节点的操作系统类型。具体支持的操作系统请参见[节点操作系统说明](https://support.huaweicloud.com/api-cce/node-os.html)。](tag:hws) [节点的操作系统类型。具体支持的操作系统请参见[节点操作系统说明](https://support.huaweicloud.com/intl/zh-cn/api-cce/node-os.html)。](tag:hws_hk) &gt; - 系统会根据集群版本自动选择支持的系统版本。当前集群版本不支持该系统类型，则会报错。 &gt; - 若在创建节点时指定了extendParam中的alpha.cce/NodeImageID参数，可以不填写此参数。 &gt; - 创建节点池时，该参数为必选。 &gt; - 若创建节点时使用共享磁盘空间，即磁盘初始化配置管理参数使用storage，且StorageGroups中virtualSpaces的name字段指定为share，该参数为必选。 
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
        public Volume RootVolume { get; set; }

        /// <summary>
        /// 节点的数据盘参数（目前已支持通过控制台为CCE节点添加第二块数据盘）。 如果数据盘正供容器运行时和Kubelet组件使用，则不可被卸载，否则将导致节点不可用。 针对专属云节点，参数解释与rootVolume一致
        /// </summary>
        [JsonProperty("dataVolumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Volume> DataVolumes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("storage", NullValueHandling = NullValueHandling.Ignore)]
        public Storage Storage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("publicIP", NullValueHandling = NullValueHandling.Ignore)]
        public NodePublicIP PublicIP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nodeNicSpec", NullValueHandling = NullValueHandling.Ignore)]
        public NodeNicSpec NodeNicSpec { get; set; }

        /// <summary>
        /// 批量创建时节点的个数，必须为大于等于1，小于等于最大限额的正整数。作用于节点池时该项可以不填写。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 节点的计费模式： -  0: 按需付费 [- 1: 包周期](tag:hws,hws_hk) [- 2: 已废弃：自动付费包周期](tag:hws,hws_hk) 
        /// </summary>
        [JsonProperty("billingMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillingMode { get; set; }

        /// <summary>
        /// 支持给创建出来的节点加Taints来设置反亲和性，taints配置不超过20条。每条Taints包含以下3个参数：  - Key：必须以字母或数字开头，可以包含字母、数字、连字符、下划线和点，最长63个字符；另外可以使用DNS子域作为前缀。 - Value：必须以字符或数字开头，可以包含字母、数字、连字符、下划线和点，最长63个字符。 - Effect：只可选NoSchedule，PreferNoSchedule或NoExecute。 字段使用场景：在节点创建场景下，支持指定初始值，查询时不返回该字段；在节点池场景下，其中节点模板中支持指定初始值，查询时支持返回该字段；在其余场景下，查询时都不会返回该字段。  示例：  &#x60;&#x60;&#x60; \&quot;taints\&quot;: [{   \&quot;key\&quot;: \&quot;status\&quot;,   \&quot;value\&quot;: \&quot;unavailable\&quot;,   \&quot;effect\&quot;: \&quot;NoSchedule\&quot; }, {   \&quot;key\&quot;: \&quot;looks\&quot;,   \&quot;value\&quot;: \&quot;bad\&quot;,   \&quot;effect\&quot;: \&quot;NoSchedule\&quot; }] &#x60;&#x60;&#x60; 
        /// </summary>
        [JsonProperty("taints", NullValueHandling = NullValueHandling.Ignore)]
        public List<Taint> Taints { get; set; }

        /// <summary>
        /// 格式为key/value键值对。键值对个数不超过20条。 - Key：必须以字母或数字开头，可以包含字母、数字、连字符、下划线和点，最长63个字符；另外可以使用DNS子域作为前缀，例如example.com/my-key，DNS子域最长253个字符。 - Value：可以为空或者非空字符串，非空字符串必须以字符或数字开头，可以包含字母、数字、连字符、下划线和点，最长63个字符。 字段使用场景：在节点创建场景下，支持指定初始值，查询时不返回该字段；在节点池场景下，其中节点模板中支持指定初始值，查询时支持返回该字段；在其余场景下，查询时都不会返回该字段。   示例： &#x60;&#x60;&#x60; \&quot;k8sTags\&quot;: {   \&quot;key\&quot;: \&quot;value\&quot; } &#x60;&#x60;&#x60; 
        /// </summary>
        [JsonProperty("k8sTags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> K8sTags { get; set; }

        /// <summary>
        /// 云服务器组ID，若指定，将节点创建在该云服务器组下 &gt; 创建节点池时该配置不会生效，若要保持节点池中的节点都在同一个云服务器组内，请在节点池 nodeManagement 字段中配置
        /// </summary>
        [JsonProperty("ecsGroupId", NullValueHandling = NullValueHandling.Ignore)]
        public string EcsGroupId { get; set; }

        /// <summary>
        /// 指定DeH主机的ID，将节点调度到自己的DeH上。 &gt;创建节点池添加节点时不支持该参数。 
        /// </summary>
        [JsonProperty("dedicatedHostId", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// 云服务器标签，键必须唯一，CCE支持的最大用户自定义标签数量依region而定，自定义标签数上限为8个。 字段使用场景：在节点创建场景下，支持指定初始值，查询时不返回该字段；在节点池场景下，其中节点模板中支持指定初始值，查询时支持返回该字段；在其余场景下，查询时都不会返回该字段。 &gt; 标签键只能包含大写字母.小写字母、数字和特殊字符(-_)以及Unicode字符，长度不超过36个字符。 
        /// </summary>
        [JsonProperty("userTags", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserTag> UserTags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// 自定义初始化标记。  CCE节点在初始化完成之前，会打上初始化未完成污点（node.cloudprovider.kubernetes.io/uninitialized）防止pod调度到节点上。  cce支持自定义初始化标记，在接收到initializedConditions参数后，会将参数值转换成节点标签，随节点下发，例如：cloudprovider.openvessel.io/inject-initialized-conditions&#x3D;CCEInitial_CustomedInitial。  当节点上设置了此标签，会轮询节点的status.Conditions，查看conditions的type是否存在标记名，如CCEInitial、CustomedInitial标记，如果存在所有传入的标记，且状态为True，认为节点初始化完成，则移除初始化污点。  - 必须以字母、数字组成，长度范围1-20位。 - 标记数量不超过2个 
        /// </summary>
        [JsonProperty("initializedConditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InitializedConditions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public NodeExtendParam ExtendParam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hostnameConfig", NullValueHandling = NullValueHandling.Ignore)]
        public HostnameConfig HostnameConfig { get; set; }

        /// <summary>
        /// 服务器企业项目ID。CCE服务不实现EPS相关特性，该字段仅用于同步服务器企业项目ID。 创建节点/节点池场景：可指定已存在企业项目，当取值为空时，该字段继承集群企业项目属性。 更新节点池场景：配置修改后仅会对新增节点的服务器生效，存量节点需前往EPS界面迁移。 如果更新时不指定值，不会更新该字段。 当该字段为空时，返回集群企业项目。
        /// </summary>
        [JsonProperty("serverEnterpriseProjectID", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerEnterpriseProjectID { get; set; }

        /// <summary>
        /// **参数解释**： 表示节点所属分区。分区可以选择中心云[或者[边缘小站](https://support.huaweicloud.com/usermanual-cloudpond/ies_02_0401.html)。](tag:hws)[或者[边缘小站](https://support.huaweicloud.com/intl/zh-cn/usermanual-cloudpond/ies_02_0401.html)。](tag:hws_hk) **约束限制**： 仅开启了对分布式云支持的Turbo集群支持指定该字段。 **取值范围**： - center: 中心云 - 边缘小站的可用区ID  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("partition", NullValueHandling = NullValueHandling.Ignore)]
        public string Partition { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeSpec {\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  az: ").Append(Az).Append("\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("  login: ").Append(Login).Append("\n");
            sb.Append("  rootVolume: ").Append(RootVolume).Append("\n");
            sb.Append("  dataVolumes: ").Append(DataVolumes).Append("\n");
            sb.Append("  storage: ").Append(Storage).Append("\n");
            sb.Append("  publicIP: ").Append(PublicIP).Append("\n");
            sb.Append("  nodeNicSpec: ").Append(NodeNicSpec).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  billingMode: ").Append(BillingMode).Append("\n");
            sb.Append("  taints: ").Append(Taints).Append("\n");
            sb.Append("  k8sTags: ").Append(K8sTags).Append("\n");
            sb.Append("  ecsGroupId: ").Append(EcsGroupId).Append("\n");
            sb.Append("  dedicatedHostId: ").Append(DedicatedHostId).Append("\n");
            sb.Append("  userTags: ").Append(UserTags).Append("\n");
            sb.Append("  runtime: ").Append(Runtime).Append("\n");
            sb.Append("  initializedConditions: ").Append(InitializedConditions).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("  hostnameConfig: ").Append(HostnameConfig).Append("\n");
            sb.Append("  serverEnterpriseProjectID: ").Append(ServerEnterpriseProjectID).Append("\n");
            sb.Append("  partition: ").Append(Partition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeSpec input)
        {
            if (input == null) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.Az != input.Az || (this.Az != null && !this.Az.Equals(input.Az))) return false;
            if (this.Os != input.Os || (this.Os != null && !this.Os.Equals(input.Os))) return false;
            if (this.Login != input.Login || (this.Login != null && !this.Login.Equals(input.Login))) return false;
            if (this.RootVolume != input.RootVolume || (this.RootVolume != null && !this.RootVolume.Equals(input.RootVolume))) return false;
            if (this.DataVolumes != input.DataVolumes || (this.DataVolumes != null && input.DataVolumes != null && !this.DataVolumes.SequenceEqual(input.DataVolumes))) return false;
            if (this.Storage != input.Storage || (this.Storage != null && !this.Storage.Equals(input.Storage))) return false;
            if (this.PublicIP != input.PublicIP || (this.PublicIP != null && !this.PublicIP.Equals(input.PublicIP))) return false;
            if (this.NodeNicSpec != input.NodeNicSpec || (this.NodeNicSpec != null && !this.NodeNicSpec.Equals(input.NodeNicSpec))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.BillingMode != input.BillingMode || (this.BillingMode != null && !this.BillingMode.Equals(input.BillingMode))) return false;
            if (this.Taints != input.Taints || (this.Taints != null && input.Taints != null && !this.Taints.SequenceEqual(input.Taints))) return false;
            if (this.K8sTags != input.K8sTags || (this.K8sTags != null && input.K8sTags != null && !this.K8sTags.SequenceEqual(input.K8sTags))) return false;
            if (this.EcsGroupId != input.EcsGroupId || (this.EcsGroupId != null && !this.EcsGroupId.Equals(input.EcsGroupId))) return false;
            if (this.DedicatedHostId != input.DedicatedHostId || (this.DedicatedHostId != null && !this.DedicatedHostId.Equals(input.DedicatedHostId))) return false;
            if (this.UserTags != input.UserTags || (this.UserTags != null && input.UserTags != null && !this.UserTags.SequenceEqual(input.UserTags))) return false;
            if (this.Runtime != input.Runtime || (this.Runtime != null && !this.Runtime.Equals(input.Runtime))) return false;
            if (this.InitializedConditions != input.InitializedConditions || (this.InitializedConditions != null && input.InitializedConditions != null && !this.InitializedConditions.SequenceEqual(input.InitializedConditions))) return false;
            if (this.ExtendParam != input.ExtendParam || (this.ExtendParam != null && !this.ExtendParam.Equals(input.ExtendParam))) return false;
            if (this.HostnameConfig != input.HostnameConfig || (this.HostnameConfig != null && !this.HostnameConfig.Equals(input.HostnameConfig))) return false;
            if (this.ServerEnterpriseProjectID != input.ServerEnterpriseProjectID || (this.ServerEnterpriseProjectID != null && !this.ServerEnterpriseProjectID.Equals(input.ServerEnterpriseProjectID))) return false;
            if (this.Partition != input.Partition || (this.Partition != null && !this.Partition.Equals(input.Partition))) return false;

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
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.Az != null) hashCode = hashCode * 59 + this.Az.GetHashCode();
                if (this.Os != null) hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.Login != null) hashCode = hashCode * 59 + this.Login.GetHashCode();
                if (this.RootVolume != null) hashCode = hashCode * 59 + this.RootVolume.GetHashCode();
                if (this.DataVolumes != null) hashCode = hashCode * 59 + this.DataVolumes.GetHashCode();
                if (this.Storage != null) hashCode = hashCode * 59 + this.Storage.GetHashCode();
                if (this.PublicIP != null) hashCode = hashCode * 59 + this.PublicIP.GetHashCode();
                if (this.NodeNicSpec != null) hashCode = hashCode * 59 + this.NodeNicSpec.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.BillingMode != null) hashCode = hashCode * 59 + this.BillingMode.GetHashCode();
                if (this.Taints != null) hashCode = hashCode * 59 + this.Taints.GetHashCode();
                if (this.K8sTags != null) hashCode = hashCode * 59 + this.K8sTags.GetHashCode();
                if (this.EcsGroupId != null) hashCode = hashCode * 59 + this.EcsGroupId.GetHashCode();
                if (this.DedicatedHostId != null) hashCode = hashCode * 59 + this.DedicatedHostId.GetHashCode();
                if (this.UserTags != null) hashCode = hashCode * 59 + this.UserTags.GetHashCode();
                if (this.Runtime != null) hashCode = hashCode * 59 + this.Runtime.GetHashCode();
                if (this.InitializedConditions != null) hashCode = hashCode * 59 + this.InitializedConditions.GetHashCode();
                if (this.ExtendParam != null) hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                if (this.HostnameConfig != null) hashCode = hashCode * 59 + this.HostnameConfig.GetHashCode();
                if (this.ServerEnterpriseProjectID != null) hashCode = hashCode * 59 + this.ServerEnterpriseProjectID.GetHashCode();
                if (this.Partition != null) hashCode = hashCode * 59 + this.Partition.GetHashCode();
                return hashCode;
            }
        }
    }
}
