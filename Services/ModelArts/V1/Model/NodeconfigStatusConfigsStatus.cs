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
    /// **参数解释**：各配置项的执行状态。 **约束限制**：仅在请求体/插件中存在对应配置项时返回。 **取值范围**：不涉及。 **默认取值**：不涉及。
    /// </summary>
    public class NodeconfigStatusConfigsStatus 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image_warm_up", NullValueHandling = NullValueHandling.Ignore)]
        public NodeconfigStatusConfigsStatusImageWarmUp ImageWarmUp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeconfigStatusConfigsStatus {\n");
            sb.Append("  imageWarmUp: ").Append(ImageWarmUp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeconfigStatusConfigsStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeconfigStatusConfigsStatus input)
        {
            if (input == null) return false;
            if (this.ImageWarmUp != input.ImageWarmUp || (this.ImageWarmUp != null && !this.ImageWarmUp.Equals(input.ImageWarmUp))) return false;

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
                if (this.ImageWarmUp != null) hashCode = hashCode * 59 + this.ImageWarmUp.GetHashCode();
                return hashCode;
            }
        }
    }
}
