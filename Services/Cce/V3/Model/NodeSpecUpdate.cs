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
        /// **参数解释：** 节点的规格。  **约束限制**： 不涉及 **取值范围：** CCE支持的节点规格请参考[节点规格说明](cce_02_0368.xml)获取。 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// **参数解释**： 节点的操作系统类型。具体支持的操作系统请参见[节点操作系统说明](node-os.xml)。 **约束限制**： - 若当前集群版本不支持该OS类型，则会自动替换为当前集群版本支持的同系列OS类型。 - 若在创建节点时指定了extendParam中的alpha.cce/NodeImageID参数，可以不填写此参数。 - 该参数缺省时，CCE会根据集群版本自动选择支持的OS版本。 - 创建节点池时，该参数为必选。 - 若创建节点时使用共享磁盘空间，即磁盘初始化配置管理参数使用storage，且StorageGroups中virtualSpaces的name字段指定为share，该参数为必选。  **取值范围**： 不涉及 **默认取值**： 不涉及
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
        [JsonProperty("rootVolumeUpdate", NullValueHandling = NullValueHandling.Ignore)]
        public Volume RootVolumeUpdate { get; set; }

        /// <summary>
        /// **参数解释**： 节点的数据盘参数。针对专属云节点，参数解释与rootVolume一致。 **约束限制**： 磁盘挂载上限为虚拟机不超过16块，裸金属不超过10块。在此基础上还受限于虚拟机/裸金属规格可挂载磁盘数上限。（目前支持通过控制台和API为CCE节点添加多块数据盘）。 如果数据盘正供容器运行时和Kubelet组件使用，则不可被卸载，否则将导致节点不可用。
        /// </summary>
        [JsonProperty("dataVolumesUpdate", NullValueHandling = NullValueHandling.Ignore)]
        public List<Volume> DataVolumesUpdate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("storage", NullValueHandling = NullValueHandling.Ignore)]
        public Storage Storage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// **参数解释**： 支持给创建出来的节点加Taints来设置反亲和性。每条Taints包含以下3个参数：  - Key：必须以字母或数字开头和结尾，可以包含字母、数字、连字符、下划线和点，最长63个字符；另外可以使用DNS子域作为前缀。 - Value：必须以字符或数字开头和结尾，可以包含字母、数字、连字符、下划线和点，最长63个字符。 - Effect：只可选NoSchedule，PreferNoSchedule或NoExecute。 字段使用场景：在节点创建场景下，支持指定初始值，查询时不返回该字段；在节点池场景下，其中节点模板中支持指定初始值，查询时支持返回该字段；在其余场景下，查询时都不会返回该字段。  示例：  &#x60;&#x60;&#x60; \&quot;taints\&quot;: [{   \&quot;key\&quot;: \&quot;status\&quot;,   \&quot;value\&quot;: \&quot;unavailable\&quot;,   \&quot;effect\&quot;: \&quot;NoSchedule\&quot; }, {   \&quot;key\&quot;: \&quot;looks\&quot;,   \&quot;value\&quot;: \&quot;bad\&quot;,   \&quot;effect\&quot;: \&quot;NoSchedule\&quot; }] &#x60;&#x60;&#x60;  **约束限制**： - taints配置不超过20条。 - 参数未指定或者为空数组时将删除节点池的自定义Taints。 - 更新节点池时，此字段为非必填字段。
        /// </summary>
        [JsonProperty("taints", NullValueHandling = NullValueHandling.Ignore)]
        public List<Taint> Taints { get; set; }

        /// <summary>
        /// **参数解释**： 格式为key/value键值对。 - Key：必须以字母或数字开头和结尾，可以包含字母、数字、连字符、下划线和点，最长63个字符；另外可以使用DNS子域作为前缀，例如example.com/my-key，DNS子域最长253个字符。 - Value：可以为空或者非空字符串，非空字符串必须以字符或数字开头和结尾，可以包含字母、数字、连字符、下划线和点，最长63个字符。 字段使用场景：在节点创建场景下，支持指定初始值，查询时不返回该字段；在节点池场景下，其中节点模板中支持指定初始值，查询时支持返回该字段；在其余场景下，查询时都不会返回该字段。   示例： &#x60;&#x60;&#x60; \&quot;k8sTags\&quot;: {   \&quot;key\&quot;: \&quot;value\&quot; } &#x60;&#x60;&#x60;  **约束限制**： - 键值对个数不超过20条。 - 参数未指定或者为空对象时将删除节点池的自定义K8s标签。 - 更新节点池时，此字段为非必填字段。
        /// </summary>
        [JsonProperty("k8sTags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> K8sTags { get; set; }

        /// <summary>
        /// **参数解释**： 云服务器组ID，若指定，将节点创建在该云服务器组下。 **约束限制**： 创建节点池时该配置不会生效，若要保持节点池中的节点都在同一个云服务器组内，请在节点池 nodeManagement 字段中配置。 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("ecsGroupId", NullValueHandling = NullValueHandling.Ignore)]
        public string EcsGroupId { get; set; }

        /// <summary>
        /// **参数解释**： 云服务器标签（资源标签）。 **约束限制**： - 键必须唯一，CCE支持的最大用户自定义标签数量依region而定，自定义标签数上限为8个。 - 参数未指定或者为空数组时将删除节点池的自定义云服务器标签。 - 更新节点池时，此字段为非必填字段。  **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("userTags", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserTag> UserTags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nodeNameTemplate", NullValueHandling = NullValueHandling.Ignore)]
        public NodeSpecUpdateNodeNameTemplate NodeNameTemplate { get; set; }

        /// <summary>
        /// **参数解释**： 自定义初始化标记，默认值为空。  CCE节点在初始化完成之前，会打上初始化未完成污点（node.cloudprovider.kubernetes.io/uninitialized）防止pod调度到节点上。用户在创建节点时，可以通过设置initializedConditions参数，控制污点的移除时间（默认不设置超时时间）。  使用示例如下： 1. 创建节点，传入参数 \&quot;initializedConditions\&quot;: [\&quot;CCEInitial\&quot;, \&quot;CustomedInitial\&quot;]； 2. 更新节点，传入参数 \&quot;initializedConditions\&quot;: [\&quot;NodeInitial\&quot;]，节点池新建的节点注册到集群时默认会被设置为不可调度； 3. 用户在执行完自定义初始化操作后，调用k8s接口（例如PATCH /v1/nodes/{node_ip}/status）更新节点的conditions，插入type为CCEInitial、CustomedInitial的两个标记，状态为True，如下所示：   &#x60;&#x60;&#x60;   status:     conditions:     - type: CCEInitial       status: &#39;True&#39;     - type: CustomedInitial       status: &#39;True&#39;   &#x60;&#x60;&#x60; 4. CCE组件轮询节点的status.Conditions，查看是否存在type为CCEInitial、CustomedInitial的condition，若存在且status字段值为True，认为节点初始化完成，则移除初始化污点； 5. initializedConditions支持设置超时时间，用户可以在创节点时传入，如：\&quot;initializedConditions\&quot;: [\&quot;CCEInitial:15m\&quot;, \&quot;CustomedInitial:15m\&quot;]，表示超时时间为15分钟，达到超时时间后，当CCE组件轮询到节点时会自动忽略初始化condition，移除初始化污点。  **约束限制**： - initializedConditions中超时时间取值范围为[1-99]秒 - 必须以字母、数字组成，长度范围1-20位。 - 标记数量不超过2个。 - 超时时间仅支持分钟(m)单位。
        /// </summary>
        [JsonProperty("initializedConditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InitializedConditions { get; set; }

        /// <summary>
        /// **参数解释**： 服务器企业项目ID。CCE服务不实现EPS相关特性，该字段仅用于同步服务器企业项目ID。 **约束限制**： 创建节点/节点池场景：可指定已存在企业项目，当取值为空时，该字段继承集群企业项目属性。 更新节点池场景：配置修改后仅会对新增节点的服务器生效，存量节点需前往EPS界面迁移。 **取值范围**： 不涉及 **默认取值**： 如果更新时不指定值，不会更新该字段。 当该字段为空时，返回集群企业项目。
        /// </summary>
        [JsonProperty("serverEnterpriseProjectID", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerEnterpriseProjectID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nodeNicSpecUpdate", NullValueHandling = NullValueHandling.Ignore)]
        public NodeSpecUpdateNodeNicSpecUpdate NodeNicSpecUpdate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public NodePoolUpdateExtendParam ExtendParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeSpecUpdate {\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("  login: ").Append(Login).Append("\n");
            sb.Append("  rootVolumeUpdate: ").Append(RootVolumeUpdate).Append("\n");
            sb.Append("  dataVolumesUpdate: ").Append(DataVolumesUpdate).Append("\n");
            sb.Append("  storage: ").Append(Storage).Append("\n");
            sb.Append("  runtime: ").Append(Runtime).Append("\n");
            sb.Append("  taints: ").Append(Taints).Append("\n");
            sb.Append("  k8sTags: ").Append(K8sTags).Append("\n");
            sb.Append("  ecsGroupId: ").Append(EcsGroupId).Append("\n");
            sb.Append("  userTags: ").Append(UserTags).Append("\n");
            sb.Append("  nodeNameTemplate: ").Append(NodeNameTemplate).Append("\n");
            sb.Append("  initializedConditions: ").Append(InitializedConditions).Append("\n");
            sb.Append("  serverEnterpriseProjectID: ").Append(ServerEnterpriseProjectID).Append("\n");
            sb.Append("  nodeNicSpecUpdate: ").Append(NodeNicSpecUpdate).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
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
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.Os != input.Os || (this.Os != null && !this.Os.Equals(input.Os))) return false;
            if (this.Login != input.Login || (this.Login != null && !this.Login.Equals(input.Login))) return false;
            if (this.RootVolumeUpdate != input.RootVolumeUpdate || (this.RootVolumeUpdate != null && !this.RootVolumeUpdate.Equals(input.RootVolumeUpdate))) return false;
            if (this.DataVolumesUpdate != input.DataVolumesUpdate || (this.DataVolumesUpdate != null && input.DataVolumesUpdate != null && !this.DataVolumesUpdate.SequenceEqual(input.DataVolumesUpdate))) return false;
            if (this.Storage != input.Storage || (this.Storage != null && !this.Storage.Equals(input.Storage))) return false;
            if (this.Runtime != input.Runtime || (this.Runtime != null && !this.Runtime.Equals(input.Runtime))) return false;
            if (this.Taints != input.Taints || (this.Taints != null && input.Taints != null && !this.Taints.SequenceEqual(input.Taints))) return false;
            if (this.K8sTags != input.K8sTags || (this.K8sTags != null && input.K8sTags != null && !this.K8sTags.SequenceEqual(input.K8sTags))) return false;
            if (this.EcsGroupId != input.EcsGroupId || (this.EcsGroupId != null && !this.EcsGroupId.Equals(input.EcsGroupId))) return false;
            if (this.UserTags != input.UserTags || (this.UserTags != null && input.UserTags != null && !this.UserTags.SequenceEqual(input.UserTags))) return false;
            if (this.NodeNameTemplate != input.NodeNameTemplate || (this.NodeNameTemplate != null && !this.NodeNameTemplate.Equals(input.NodeNameTemplate))) return false;
            if (this.InitializedConditions != input.InitializedConditions || (this.InitializedConditions != null && input.InitializedConditions != null && !this.InitializedConditions.SequenceEqual(input.InitializedConditions))) return false;
            if (this.ServerEnterpriseProjectID != input.ServerEnterpriseProjectID || (this.ServerEnterpriseProjectID != null && !this.ServerEnterpriseProjectID.Equals(input.ServerEnterpriseProjectID))) return false;
            if (this.NodeNicSpecUpdate != input.NodeNicSpecUpdate || (this.NodeNicSpecUpdate != null && !this.NodeNicSpecUpdate.Equals(input.NodeNicSpecUpdate))) return false;
            if (this.ExtendParam != input.ExtendParam || (this.ExtendParam != null && !this.ExtendParam.Equals(input.ExtendParam))) return false;

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
                if (this.Os != null) hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.Login != null) hashCode = hashCode * 59 + this.Login.GetHashCode();
                if (this.RootVolumeUpdate != null) hashCode = hashCode * 59 + this.RootVolumeUpdate.GetHashCode();
                if (this.DataVolumesUpdate != null) hashCode = hashCode * 59 + this.DataVolumesUpdate.GetHashCode();
                if (this.Storage != null) hashCode = hashCode * 59 + this.Storage.GetHashCode();
                if (this.Runtime != null) hashCode = hashCode * 59 + this.Runtime.GetHashCode();
                if (this.Taints != null) hashCode = hashCode * 59 + this.Taints.GetHashCode();
                if (this.K8sTags != null) hashCode = hashCode * 59 + this.K8sTags.GetHashCode();
                if (this.EcsGroupId != null) hashCode = hashCode * 59 + this.EcsGroupId.GetHashCode();
                if (this.UserTags != null) hashCode = hashCode * 59 + this.UserTags.GetHashCode();
                if (this.NodeNameTemplate != null) hashCode = hashCode * 59 + this.NodeNameTemplate.GetHashCode();
                if (this.InitializedConditions != null) hashCode = hashCode * 59 + this.InitializedConditions.GetHashCode();
                if (this.ServerEnterpriseProjectID != null) hashCode = hashCode * 59 + this.ServerEnterpriseProjectID.GetHashCode();
                if (this.NodeNicSpecUpdate != null) hashCode = hashCode * 59 + this.NodeNicSpecUpdate.GetHashCode();
                if (this.ExtendParam != null) hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
