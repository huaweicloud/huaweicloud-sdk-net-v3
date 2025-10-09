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
    public class ConfigurationItem 
    {

        /// <summary>
        /// **参数解释：** 组件配置参数名称。  [当前集群支持的可配置组件及其参数详见[修改CCE集群配置](https://support.huaweicloud.com/usermanual-cce/cce_10_0213.html)，当前节点池支持的可配置组件及其参数详见[修改节点池配置](https://support.huaweicloud.com/usermanual-cce/cce_10_0652.html)。](tag:hws) [当前集群支持的可配置组件及其参数详见[修改CCE集群配置](https://support.huaweicloud.com/intl/zh-cn/usermanual-cce/cce_10_0213.html)，当前节点池支持的可配置组件及其参数详见[修改节点池配置](https://support.huaweicloud.com/intl/zh-cn/usermanual-cce/cce_10_0652.html)。](tag:hws_hk) **约束限制：** 若指定了不支持的组件或组件不支持的参数，该配置项将被忽略。 **取值范围：** 不涉及 **默认取值：** 不涉及 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 组件配置参数值。  [当前集群支持的可配置组件及其参数详见[修改CCE集群配置](https://support.huaweicloud.com/usermanual-cce/cce_10_0213.html)，当前节点池支持的可配置组件及其参数详见[修改节点池配置](https://support.huaweicloud.com/usermanual-cce/cce_10_0652.html)。](tag:hws) [当前集群支持的可配置组件及其参数详见[修改CCE集群配置](https://support.huaweicloud.com/intl/zh-cn/usermanual-cce/cce_10_0213.html)，当前节点池支持的可配置组件及其参数详见[修改节点池配置](https://support.huaweicloud.com/intl/zh-cn/usermanual-cce/cce_10_0652.html)。](tag:hws_hk) **约束限制：** 若指定了不支持的组件或组件不支持的参数，该配置项将被忽略。 **取值范围：** 不涉及 **默认取值：** 不涉及 
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public Object Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationItem {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigurationItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigurationItem input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
