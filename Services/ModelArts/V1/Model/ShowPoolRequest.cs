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
    /// Request Object
    /// </summary>
    public class ShowPoolRequest 
    {

        /// <summary>
        /// **参数解释**：资源池的ID，取值自资源池详情的metadata.name字段。 **约束限制**：不涉及。 **取值范围**：只能以小写字母开头，数字、中划线组成，不能以中划线结尾，且长度为36-63。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("pool_name", IsPath = true)]
        [JsonProperty("pool_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolName { get; set; }

        /// <summary>
        /// **参数解释**：租户ID，传递该参数鉴权以该租户ID为准。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("X-ModelArts-User-ID", IsHeader = true)]
        [JsonProperty("X-ModelArts-User-ID", NullValueHandling = NullValueHandling.Ignore)]
        public string XModelArtsUserID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPoolRequest {\n");
            sb.Append("  poolName: ").Append(PoolName).Append("\n");
            sb.Append("  xModelArtsUserID: ").Append(XModelArtsUserID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPoolRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPoolRequest input)
        {
            if (input == null) return false;
            if (this.PoolName != input.PoolName || (this.PoolName != null && !this.PoolName.Equals(input.PoolName))) return false;
            if (this.XModelArtsUserID != input.XModelArtsUserID || (this.XModelArtsUserID != null && !this.XModelArtsUserID.Equals(input.XModelArtsUserID))) return false;

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
                if (this.PoolName != null) hashCode = hashCode * 59 + this.PoolName.GetHashCode();
                if (this.XModelArtsUserID != null) hashCode = hashCode * 59 + this.XModelArtsUserID.GetHashCode();
                return hashCode;
            }
        }
    }
}
