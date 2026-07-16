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
    public class BatchChangeNodeToPeriodReqBody 
    {

        /// <summary>
        /// **参数解释**： API类型 **约束限制**： 该值不可修改 **取值范围**： 不涉及 **默认取值**： Node 
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// **参数解释**： API版本 **约束限制**： 该值不可修改 **取值范围**： 不涉及 **默认取值**： v3 
        /// </summary>
        [JsonProperty("apiVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// **参数解释**： 要进行按需转包的CCE节点ID列表，示例如下： &#x60;&#x60;&#x60; \&quot;nodeList\&quot;: [\&quot;xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx\&quot;, \&quot;xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx\&quot;] &#x60;&#x60;&#x60; **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("nodeList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("periodOrderParam", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodOrderParam PeriodOrderParam { get; set; }

        /// <summary>
        /// **参数解释**： 需要一起转包周期的资源类型列表，示例如下： &#x60;&#x60;&#x60; \&quot;includeResources\&quot;: [\&quot;eip\&quot;] &#x60;&#x60;&#x60; **约束限制**： 当前仅支持eip（弹性公网IP）资源 **取值范围**： - \&quot;eip\&quot;：弹性公网IP **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("includeResources", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IncludeResources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchChangeNodeToPeriodReqBody {\n");
            sb.Append("  kind: ").Append(Kind).Append("\n");
            sb.Append("  apiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  nodeList: ").Append(NodeList).Append("\n");
            sb.Append("  periodOrderParam: ").Append(PeriodOrderParam).Append("\n");
            sb.Append("  includeResources: ").Append(IncludeResources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchChangeNodeToPeriodReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchChangeNodeToPeriodReqBody input)
        {
            if (input == null) return false;
            if (this.Kind != input.Kind || (this.Kind != null && !this.Kind.Equals(input.Kind))) return false;
            if (this.ApiVersion != input.ApiVersion || (this.ApiVersion != null && !this.ApiVersion.Equals(input.ApiVersion))) return false;
            if (this.NodeList != input.NodeList || (this.NodeList != null && input.NodeList != null && !this.NodeList.SequenceEqual(input.NodeList))) return false;
            if (this.PeriodOrderParam != input.PeriodOrderParam || (this.PeriodOrderParam != null && !this.PeriodOrderParam.Equals(input.PeriodOrderParam))) return false;
            if (this.IncludeResources != input.IncludeResources || (this.IncludeResources != null && input.IncludeResources != null && !this.IncludeResources.SequenceEqual(input.IncludeResources))) return false;

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
                if (this.Kind != null) hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.ApiVersion != null) hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.NodeList != null) hashCode = hashCode * 59 + this.NodeList.GetHashCode();
                if (this.PeriodOrderParam != null) hashCode = hashCode * 59 + this.PeriodOrderParam.GetHashCode();
                if (this.IncludeResources != null) hashCode = hashCode * 59 + this.IncludeResources.GetHashCode();
                return hashCode;
            }
        }
    }
}
