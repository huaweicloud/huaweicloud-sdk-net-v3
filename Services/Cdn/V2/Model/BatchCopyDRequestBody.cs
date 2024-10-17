using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// 域名复制请求体。
    /// </summary>
    public class BatchCopyDRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("configs", NullValueHandling = NullValueHandling.Ignore)]
        public BatchCopyConfigs Configs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCopyDRequestBody {\n");
            sb.Append("  configs: ").Append(Configs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCopyDRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCopyDRequestBody input)
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
