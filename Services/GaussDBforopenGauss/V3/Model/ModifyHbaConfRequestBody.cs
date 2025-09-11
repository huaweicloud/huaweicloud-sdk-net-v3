using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ModifyHbaConfRequestBody 
    {

        /// <summary>
        /// **参数解释**: 需要修改的hba配置信息。 **约束限制**: 不涉及。
        /// </summary>
        [JsonProperty("before_confs", NullValueHandling = NullValueHandling.Ignore)]
        public Object BeforeConfs { get; set; }

        /// <summary>
        /// **参数解释**: 修改后的hba配置信息。 **约束限制**: 不涉及。
        /// </summary>
        [JsonProperty("after_confs", NullValueHandling = NullValueHandling.Ignore)]
        public Object AfterConfs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyHbaConfRequestBody {\n");
            sb.Append("  beforeConfs: ").Append(BeforeConfs).Append("\n");
            sb.Append("  afterConfs: ").Append(AfterConfs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyHbaConfRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyHbaConfRequestBody input)
        {
            if (input == null) return false;
            if (this.BeforeConfs != input.BeforeConfs || (this.BeforeConfs != null && !this.BeforeConfs.Equals(input.BeforeConfs))) return false;
            if (this.AfterConfs != input.AfterConfs || (this.AfterConfs != null && !this.AfterConfs.Equals(input.AfterConfs))) return false;

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
                if (this.BeforeConfs != null) hashCode = hashCode * 59 + this.BeforeConfs.GetHashCode();
                if (this.AfterConfs != null) hashCode = hashCode * 59 + this.AfterConfs.GetHashCode();
                return hashCode;
            }
        }
    }
}
