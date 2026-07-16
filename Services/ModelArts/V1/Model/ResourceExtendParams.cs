using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// **参数解释**：自定义配置。 **约束限制**：不涉及。
    /// </summary>
    public class ResourceExtendParams 
    {

        /// <summary>
        /// **参数解释**：节点的容器镜像空间大小。 **取值范围**：可选值如下： - 指定大小：dockerBaseSize的大小范围默认为50-500，但实际上限受到节点的容器数据盘大小约束。 - 不限制：dockerBaseSize&#x3D;\\\&quot;0\\\&quot;，表示不限制容器镜像空间大小。
        /// </summary>
        [JsonProperty("dockerBaseSize", NullValueHandling = NullValueHandling.Ignore)]
        public string DockerBaseSize { get; set; }

        /// <summary>
        /// **参数解释**：安装后执行脚本，输入的值需要经过Base64编码。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("postInstall", NullValueHandling = NullValueHandling.Ignore)]
        public string PostInstall { get; set; }

        /// <summary>
        /// **参数解释**：容器运行时。 **取值范围**：可选值如下： - docker：容器运行时，是目前最常用的容器化引擎，基于容器镜像创建和管理容器实例。 - containerd：工业级的容器运行时，专注于容器的生命周期管理，是 Docker 底层核心组件之一，也可独立部署使用。
        /// </summary>
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public string Runtime { get; set; }

        /// <summary>
        /// **参数解释**：存量节点k8s标签更新策略，值为空时默认更新存量节点。 **取值范围**：可选值如下： - refresh：更新。 - ignore：不更新。
        /// </summary>
        [JsonProperty("labelPolicyOnExistingNodes", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelPolicyOnExistingNodes { get; set; }

        /// <summary>
        /// **参数解释**：存量节点k8s污点更新策略，值为空时默认更新存量节点。 **取值范围**：可选值如下： - refresh：更新。 - ignore：不更新。
        /// </summary>
        [JsonProperty("taintPolicyOnExistingNodes", NullValueHandling = NullValueHandling.Ignore)]
        public string TaintPolicyOnExistingNodes { get; set; }

        /// <summary>
        /// **参数解释**：存量节点资源标签更新策略，值为空时默认更新存量节点。 **取值范围**：可选值如下： - refresh：更新。 - ignore：不更新。
        /// </summary>
        [JsonProperty("tagPolicyOnExistingNodes", NullValueHandling = NullValueHandling.Ignore)]
        public string TagPolicyOnExistingNodes { get; set; }

        /// <summary>
        /// **参数解释**：跨物理集群之间进行参数面数据传输使用的子网id。不可与节点子网和容器子网重复。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("XParameterPlaneSubnet", NullValueHandling = NullValueHandling.Ignore)]
        public string XParameterPlaneSubnet { get; set; }

        /// <summary>
        /// **参数解释**：用户指定的节点池名称。最小长度为2，最大长度为50的小写字母、中划线-、数字组成，由小写字母开头，不能以-，-default结尾。 **取值范围**：不涉及
        /// </summary>
        [JsonProperty("nodePoolName", NullValueHandling = NullValueHandling.Ignore)]
        public string NodePoolName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceExtendParams {\n");
            sb.Append("  dockerBaseSize: ").Append(DockerBaseSize).Append("\n");
            sb.Append("  postInstall: ").Append(PostInstall).Append("\n");
            sb.Append("  runtime: ").Append(Runtime).Append("\n");
            sb.Append("  labelPolicyOnExistingNodes: ").Append(LabelPolicyOnExistingNodes).Append("\n");
            sb.Append("  taintPolicyOnExistingNodes: ").Append(TaintPolicyOnExistingNodes).Append("\n");
            sb.Append("  tagPolicyOnExistingNodes: ").Append(TagPolicyOnExistingNodes).Append("\n");
            sb.Append("  xParameterPlaneSubnet: ").Append(XParameterPlaneSubnet).Append("\n");
            sb.Append("  nodePoolName: ").Append(NodePoolName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceExtendParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceExtendParams input)
        {
            if (input == null) return false;
            if (this.DockerBaseSize != input.DockerBaseSize || (this.DockerBaseSize != null && !this.DockerBaseSize.Equals(input.DockerBaseSize))) return false;
            if (this.PostInstall != input.PostInstall || (this.PostInstall != null && !this.PostInstall.Equals(input.PostInstall))) return false;
            if (this.Runtime != input.Runtime || (this.Runtime != null && !this.Runtime.Equals(input.Runtime))) return false;
            if (this.LabelPolicyOnExistingNodes != input.LabelPolicyOnExistingNodes || (this.LabelPolicyOnExistingNodes != null && !this.LabelPolicyOnExistingNodes.Equals(input.LabelPolicyOnExistingNodes))) return false;
            if (this.TaintPolicyOnExistingNodes != input.TaintPolicyOnExistingNodes || (this.TaintPolicyOnExistingNodes != null && !this.TaintPolicyOnExistingNodes.Equals(input.TaintPolicyOnExistingNodes))) return false;
            if (this.TagPolicyOnExistingNodes != input.TagPolicyOnExistingNodes || (this.TagPolicyOnExistingNodes != null && !this.TagPolicyOnExistingNodes.Equals(input.TagPolicyOnExistingNodes))) return false;
            if (this.XParameterPlaneSubnet != input.XParameterPlaneSubnet || (this.XParameterPlaneSubnet != null && !this.XParameterPlaneSubnet.Equals(input.XParameterPlaneSubnet))) return false;
            if (this.NodePoolName != input.NodePoolName || (this.NodePoolName != null && !this.NodePoolName.Equals(input.NodePoolName))) return false;

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
                if (this.DockerBaseSize != null) hashCode = hashCode * 59 + this.DockerBaseSize.GetHashCode();
                if (this.PostInstall != null) hashCode = hashCode * 59 + this.PostInstall.GetHashCode();
                if (this.Runtime != null) hashCode = hashCode * 59 + this.Runtime.GetHashCode();
                if (this.LabelPolicyOnExistingNodes != null) hashCode = hashCode * 59 + this.LabelPolicyOnExistingNodes.GetHashCode();
                if (this.TaintPolicyOnExistingNodes != null) hashCode = hashCode * 59 + this.TaintPolicyOnExistingNodes.GetHashCode();
                if (this.TagPolicyOnExistingNodes != null) hashCode = hashCode * 59 + this.TagPolicyOnExistingNodes.GetHashCode();
                if (this.XParameterPlaneSubnet != null) hashCode = hashCode * 59 + this.XParameterPlaneSubnet.GetHashCode();
                if (this.NodePoolName != null) hashCode = hashCode * 59 + this.NodePoolName.GetHashCode();
                return hashCode;
            }
        }
    }
}
