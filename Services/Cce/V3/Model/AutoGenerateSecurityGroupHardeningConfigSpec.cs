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
    public class AutoGenerateSecurityGroupHardeningConfigSpec 
    {

        /// <summary>
        /// **参数解释：** 自动创建安全组时可选择不开放node节点相关端口，支持单端口和端口段两种形式。示例如下： &#x60;&#x60;&#x60; \&quot;portsToDisable\&quot;: [\&quot;22\&quot;, \&quot;4090-4099\&quot;] &#x60;&#x60;&#x60; **约束限制：** 若指定了节点安全组SecurityGroup，该配置项将被忽略。 只针对CCE Standard和Turbo集群的node安全组生效，不支持master安全组，不支持eni安全组。 **取值范围：** 端口号仅支持整数，范围[1-65535] **默认取值：** 不涉及 
        /// </summary>
        [JsonProperty("portsToDisable", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PortsToDisable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoGenerateSecurityGroupHardeningConfigSpec {\n");
            sb.Append("  portsToDisable: ").Append(PortsToDisable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutoGenerateSecurityGroupHardeningConfigSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AutoGenerateSecurityGroupHardeningConfigSpec input)
        {
            if (input == null) return false;
            if (this.PortsToDisable != input.PortsToDisable || (this.PortsToDisable != null && input.PortsToDisable != null && !this.PortsToDisable.SequenceEqual(input.PortsToDisable))) return false;

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
                if (this.PortsToDisable != null) hashCode = hashCode * 59 + this.PortsToDisable.GetHashCode();
                return hashCode;
            }
        }
    }
}
