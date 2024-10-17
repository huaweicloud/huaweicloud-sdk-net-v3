using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateLtsConfigRequestBody 
    {

        /// <summary>
        /// 每个Item是实例需要设置的LTS策略。
        /// </summary>
        [JsonProperty("lts_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpdateLtsConfigRequestBodyLtsConfigs> LtsConfigs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLtsConfigRequestBody {\n");
            sb.Append("  ltsConfigs: ").Append(LtsConfigs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLtsConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateLtsConfigRequestBody input)
        {
            if (input == null) return false;
            if (this.LtsConfigs != input.LtsConfigs || (this.LtsConfigs != null && input.LtsConfigs != null && !this.LtsConfigs.SequenceEqual(input.LtsConfigs))) return false;

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
                if (this.LtsConfigs != null) hashCode = hashCode * 59 + this.LtsConfigs.GetHashCode();
                return hashCode;
            }
        }
    }
}
