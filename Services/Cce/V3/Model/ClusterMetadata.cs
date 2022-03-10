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
    /// 可以通过 annotations[\&quot;cluster.install.addons/install\&quot;] 来指定创建集群时需要安装的插件，格式形如 &#x60;&#x60;&#x60; [   {     \&quot;addonTemplateName\&quot;: \&quot;autoscaler\&quot;,     \&quot;version\&quot;: \&quot;1.15.3\&quot;,     \&quot;values\&quot;: {       \&quot;flavor\&quot;: {         \&quot;description\&quot;: \&quot;Has only one instance\&quot;,         \&quot;name\&quot;: \&quot;Single\&quot;,         \&quot;replicas\&quot;: 1,         \&quot;resources\&quot;: [           {             \&quot;limitsCpu\&quot;: \&quot;100m\&quot;,             \&quot;limitsMem\&quot;: \&quot;300Mi\&quot;,             \&quot;name\&quot;: \&quot;autoscaler\&quot;,             \&quot;requestsCpu\&quot;: \&quot;100m\&quot;,             \&quot;requestsMem\&quot;: \&quot;300Mi\&quot;           }         ]       },       \&quot;custom\&quot;: {         \&quot;coresTotal\&quot;: 32000,         \&quot;maxEmptyBulkDeleteFlag\&quot;: 10,         \&quot;maxNodesTotal\&quot;: 1000,         \&quot;memoryTotal\&quot;: 128000,         \&quot;scaleDownDelayAfterAdd\&quot;: 10,         \&quot;scaleDownDelayAfterDelete\&quot;: 10,         \&quot;scaleDownDelayAfterFailure\&quot;: 3,         \&quot;scaleDownEnabled\&quot;: false,         \&quot;scaleDownUnneededTime\&quot;: 10,         \&quot;scaleDownUtilizationThreshold\&quot;: 0.5,         \&quot;scaleUpCpuUtilizationThreshold\&quot;: 1,         \&quot;scaleUpMemUtilizationThreshold\&quot;: 1,         \&quot;scaleUpUnscheduledPodEnabled\&quot;: true,         \&quot;scaleUpUtilizationEnabled\&quot;: true,         \&quot;tenant_id\&quot;: \&quot;47eb1d64cbeb45cfa01ae20af4f4b563\&quot;,         \&quot;unremovableNodeRecheckTimeout\&quot;: 5       }     }   } ] &#x60;&#x60;&#x60;
    /// </summary>
    public class ClusterMetadata 
    {

        /// <summary>
        /// 集群名称。  命名规则：以小写字母开头，由小写字母、数字、中划线(-)组成，长度范围4-128位，且不能以中划线(-)结尾。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 资源唯一标识，创建成功后自动生成，填写无效
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// 集群注解，由key/value组成：   &#x60;&#x60;&#x60;  \&quot;annotations\&quot;: {    \&quot;key1\&quot; : \&quot;value1\&quot;,    \&quot;key2\&quot; : \&quot;value2\&quot; }  &#x60;&#x60;&#x60;   &gt;    - Annotations不用于标识和选择对象。Annotations中的元数据可以是small 或large，structured 或unstructured，并且可以包括标签不允许使用的字符。 &gt;    - 该字段不会被数据库保存，当前仅用于指定集群待安装插件。 &gt;    - 可通过加入\&quot;cluster.install.addons.external/install\&quot;: \&quot;[{\&quot;addonTemplateName\&quot;:\&quot;icagent\&quot;}]\&quot;的键值对在创建集群时安装ICAgent。 
        /// </summary>
        [JsonProperty("annotations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// 集群标签，key/value对格式。  &gt;  该字段值由系统自动生成，用于升级时前端识别集群支持的特性开关，用户指定无效。
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// 集群创建时间
        /// </summary>
        [JsonProperty("creationTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationTimestamp { get; set; }

        /// <summary>
        /// 集群更新时间
        /// </summary>
        [JsonProperty("updateTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTimestamp { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterMetadata {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  annotations: ").Append(Annotations).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  creationTimestamp: ").Append(CreationTimestamp).Append("\n");
            sb.Append("  updateTimestamp: ").Append(UpdateTimestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
                ) && 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.CreationTimestamp == input.CreationTimestamp ||
                    (this.CreationTimestamp != null &&
                    this.CreationTimestamp.Equals(input.CreationTimestamp))
                ) && 
                (
                    this.UpdateTimestamp == input.UpdateTimestamp ||
                    (this.UpdateTimestamp != null &&
                    this.UpdateTimestamp.Equals(input.UpdateTimestamp))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Uid != null)
                    hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.CreationTimestamp != null)
                    hashCode = hashCode * 59 + this.CreationTimestamp.GetHashCode();
                if (this.UpdateTimestamp != null)
                    hashCode = hashCode * 59 + this.UpdateTimestamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
