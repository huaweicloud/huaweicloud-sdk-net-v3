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
        [JsonProperty("before_conf", NullValueHandling = NullValueHandling.Ignore)]
        public Object BeforeConf { get; set; }

        /// <summary>
        /// **参数解释**: 修改后的hba配置信息。 **约束限制**: 不涉及。
        /// </summary>
        [JsonProperty("after_conf", NullValueHandling = NullValueHandling.Ignore)]
        public Object AfterConf { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyHbaConfRequestBody {\n");
            sb.Append("  beforeConf: ").Append(BeforeConf).Append("\n");
            sb.Append("  afterConf: ").Append(AfterConf).Append("\n");
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
            if (this.BeforeConf != input.BeforeConf || (this.BeforeConf != null && !this.BeforeConf.Equals(input.BeforeConf))) return false;
            if (this.AfterConf != input.AfterConf || (this.AfterConf != null && !this.AfterConf.Equals(input.AfterConf))) return false;

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
                if (this.BeforeConf != null) hashCode = hashCode * 59 + this.BeforeConf.GetHashCode();
                if (this.AfterConf != null) hashCode = hashCode * 59 + this.AfterConf.GetHashCode();
                return hashCode;
            }
        }
    }
}
