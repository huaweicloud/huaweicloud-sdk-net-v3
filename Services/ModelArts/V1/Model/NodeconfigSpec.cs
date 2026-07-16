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
    /// 
    /// </summary>
    public class NodeconfigSpec 
    {

        /// <summary>
        /// **参数解释**： 节点自定义配置；当前支持节点绑核、是否启用缓存清理、是否启用透明大页。 \&quot;configs\&quot;: {    \&quot;cpu_manager\&quot;: {     \&quot;mode\&quot;: \&quot;static/none\&quot; //static为启用绑核, none为不启用绑核    },    \&quot;drop_cache\&quot;: {     \&quot;mode\&quot;: \&quot;enable/disable\&quot; // enable启用缓存清理    },    \&quot;transparent_hugepage\&quot;: {     \&quot;mode\&quot;: \&quot;always/madvise/never\&quot; // always为启用透明大页，never为关闭透明大页，madvice交给系统选择。    } }
        /// </summary>
        [JsonProperty("configs", NullValueHandling = NullValueHandling.Ignore)]
        public Object Configs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeconfigSpec {\n");
            sb.Append("  configs: ").Append(Configs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeconfigSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeconfigSpec input)
        {
            if (input == null) return false;
            if (this.Configs != input.Configs || (this.Configs != null && !this.Configs.Equals(input.Configs))) return false;

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
                if (this.Configs != null) hashCode = hashCode * 59 + this.Configs.GetHashCode();
                return hashCode;
            }
        }
    }
}
