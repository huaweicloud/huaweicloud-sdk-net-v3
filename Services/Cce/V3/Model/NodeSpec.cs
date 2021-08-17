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
        /// 节点的规格，CCE支持的节点规格请参考[[节点规格说明](https://support.huaweicloud.com/api-cce/cce_02_0368.html)](tag:hws)[[节点规格说明](https://support.huaweicloud.com/intl/zh-cn/api-cce/cce_02_0368.html)](tag:hws_hk)获取。 
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// 待创建节点所在的可用区，需要指定可用区（AZ）的名称。CCE支持的可用区请参考[[地区和终端节点](https://developer.huaweicloud.com/endpoint?CCE)](tag:hws)[[地区和终端节点](https://developer.huaweicloud.com/intl/zh-cn/endpoint?CCE)](tag:hws_hk)获取。 
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
        public Volume RootVolume { get; set; }

        /// <summary>
        /// 节点的数据盘参数（目前已支持通过控制台为CCE节点添加第二块数据盘）。  针对专属云节点，参数解释与rootVolume一致
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
        /// 节点的计费模式：取值为 0（按需付费）、1（包周期）、2（自动付费包周期）
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
        /// 指定DeH主机的ID，将节点调度到自己的DeH上。\\n&gt;创建节点池添加节点时不支持该参数。 
        /// </summary>
        [JsonProperty("dedicatedHostId", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedHostId { get; set; }

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
        /// 
        /// </summary>
        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public NodeExtendParam ExtendParam { get; set; }


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
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
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
                    this.Storage == input.Storage ||
                    (this.Storage != null &&
                    this.Storage.Equals(input.Storage))
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
                    this.DedicatedHostId == input.DedicatedHostId ||
                    (this.DedicatedHostId != null &&
                    this.DedicatedHostId.Equals(input.DedicatedHostId))
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
                    (this.ExtendParam != null &&
                    this.ExtendParam.Equals(input.ExtendParam))
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
                if (this.Storage != null)
                    hashCode = hashCode * 59 + this.Storage.GetHashCode();
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
                if (this.DedicatedHostId != null)
                    hashCode = hashCode * 59 + this.DedicatedHostId.GetHashCode();
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
