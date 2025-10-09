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
    /// **参数解释**： 节点名称固定前后缀配置参数。假设集群内不同节点池被用户所在公司不同部门使用，可以通过前后缀的名称区分部门和使用方式，如设置nodeNamePrefix为finance-，代表部门名称，nodeNameSuffix为-product，代表生产使用，节点池名称为gpu，代表业务类型，则最终的节点名称为finance-gpu(五位随机数)-product **约束限制**： 仅 v1.28.1/v1.27.3/v1.25.6/v1.23.11/v1.21.12 及以上集群支持配置节点名称固定前后缀 **取值范围**： 不涉及 **默认取值**： 不涉及
    /// </summary>
    public class NodeSpecUpdateNodeNameTemplate 
    {

        /// <summary>
        /// **参数解释**： 节点名称前缀。如果用户填写为空串或缺省，则节点名称不会增加前缀。 **约束限制**： 仅支持小写字母、数字、连字符（-）和点（.），必须以小写字母开头，并且符合[FRC 1123](https://tools.ietf.org/html/rfc1123)中定义的DNS子域名命名规范。 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("nodeNamePrefix", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeNamePrefix { get; set; }

        /// <summary>
        /// **参数解释**： 节点名称后缀。如果用户填写为空串或缺省，则节点名称不会增加后缀。 **约束限制**： 仅支持小写字母、数字、连字符（-）和点（.），后缀结尾必须为小写字母或者数字，并且符合[FRC 1123](https://tools.ietf.org/html/rfc1123)中定义的DNS子域名命名规范。 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("nodeNameSuffix", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeNameSuffix { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeSpecUpdateNodeNameTemplate {\n");
            sb.Append("  nodeNamePrefix: ").Append(NodeNamePrefix).Append("\n");
            sb.Append("  nodeNameSuffix: ").Append(NodeNameSuffix).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeSpecUpdateNodeNameTemplate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeSpecUpdateNodeNameTemplate input)
        {
            if (input == null) return false;
            if (this.NodeNamePrefix != input.NodeNamePrefix || (this.NodeNamePrefix != null && !this.NodeNamePrefix.Equals(input.NodeNamePrefix))) return false;
            if (this.NodeNameSuffix != input.NodeNameSuffix || (this.NodeNameSuffix != null && !this.NodeNameSuffix.Equals(input.NodeNameSuffix))) return false;

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
                if (this.NodeNamePrefix != null) hashCode = hashCode * 59 + this.NodeNamePrefix.GetHashCode();
                if (this.NodeNameSuffix != null) hashCode = hashCode * 59 + this.NodeNameSuffix.GetHashCode();
                return hashCode;
            }
        }
    }
}
