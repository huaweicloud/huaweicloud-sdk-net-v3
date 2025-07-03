using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ChangeAgentStatusResponse : SdkResponse
    {

        /// <summary>
        /// 返回结果ok表示成功。
        /// </summary>
        [JsonProperty("flag", NullValueHandling = NullValueHandling.Ignore)]
        public string Flag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeAgentStatusResponse {\n");
            sb.Append("  flag: ").Append(Flag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeAgentStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeAgentStatusResponse input)
        {
            if (input == null) return false;
            if (this.Flag != input.Flag || (this.Flag != null && !this.Flag.Equals(input.Flag))) return false;

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
                if (this.Flag != null) hashCode = hashCode * 59 + this.Flag.GetHashCode();
                return hashCode;
            }
        }
    }
}
