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
    /// 节点重装场景Kubernetes节点配置
    /// </summary>
    public class ReinstallK8sOptionsConfig 
    {

        /// <summary>
        /// 格式为key/value键值对。键值对个数不超过20条。  - Key：必须以字母或数字开头，可以包含字母、数字、连字符、下划线和点，最长63个字符；另外可以使用DNS子域作为前缀，例如example.com/my-key， DNS子域最长253个字符。 - Value：可以为空或者非空字符串，非空字符串必须以字符或数字开头，可以包含字母、数字、连字符、下划线和点，最长63个字符。  示例：  &#x60;&#x60;&#x60; \&quot;k8sTags\&quot;: {  \&quot;key\&quot;: \&quot;value\&quot; } &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// 支持给创建出来的节点加Taints来设置反亲和性，taints配置不超过20条。每条Taints包含以下3个参数：  - Key：必须以字母或数字开头，可以包含字母、数字、连字符、下划线和点，最长63个字符；另外可以使用DNS子域作为前缀。 - Value：必须以字符或数字开头，可以包含字母、数字、连字符、下划线和点，最长63个字符。 - Effect：只可选NoSchedule，PreferNoSchedule或NoExecute。  示例：  &#x60;&#x60;&#x60; \&quot;taints\&quot;: [{  \&quot;key\&quot;: \&quot;status\&quot;,  \&quot;value\&quot;: \&quot;unavailable\&quot;,  \&quot;effect\&quot;: \&quot;NoSchedule\&quot; }, {  \&quot;key\&quot;: \&quot;looks\&quot;,  \&quot;value\&quot;: \&quot;bad\&quot;,  \&quot;effect\&quot;: \&quot;NoSchedule\&quot; }] &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("taints", NullValueHandling = NullValueHandling.Ignore)]
        public List<Taint> Taints { get; set; }

        /// <summary>
        /// 节点最大允许创建的实例数(Pod)，该数量包含系统默认实例，取值范围为16~256。 该设置的目的为防止节点因管理过多实例而负载过重，请根据您的业务需要进行设置。 
        /// </summary>
        [JsonProperty("maxPods", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxPods { get; set; }

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
            sb.Append("class ReinstallK8sOptionsConfig {\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  taints: ").Append(Taints).Append("\n");
            sb.Append("  maxPods: ").Append(MaxPods).Append("\n");
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
            return this.Equals(input as ReinstallK8sOptionsConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReinstallK8sOptionsConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.Taints == input.Taints ||
                    this.Taints != null &&
                    input.Taints != null &&
                    this.Taints.SequenceEqual(input.Taints)
                ) && 
                (
                    this.MaxPods == input.MaxPods ||
                    (this.MaxPods != null &&
                    this.MaxPods.Equals(input.MaxPods))
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
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Taints != null)
                    hashCode = hashCode * 59 + this.Taints.GetHashCode();
                if (this.MaxPods != null)
                    hashCode = hashCode * 59 + this.MaxPods.GetHashCode();
                if (this.NicMultiqueue != null)
                    hashCode = hashCode * 59 + this.NicMultiqueue.GetHashCode();
                if (this.NicThreshold != null)
                    hashCode = hashCode * 59 + this.NicThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
