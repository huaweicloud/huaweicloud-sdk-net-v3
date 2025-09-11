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
    /// Response Object
    /// </summary>
    public class ShowSlowSqlStackResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 堆栈信息。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("gs_stack", NullValueHandling = NullValueHandling.Ignore)]
        public string GsStack { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSlowSqlStackResponse {\n");
            sb.Append("  gsStack: ").Append(GsStack).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSlowSqlStackResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSlowSqlStackResponse input)
        {
            if (input == null) return false;
            if (this.GsStack != input.GsStack || (this.GsStack != null && !this.GsStack.Equals(input.GsStack))) return false;

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
                if (this.GsStack != null) hashCode = hashCode * 59 + this.GsStack.GetHashCode();
                return hashCode;
            }
        }
    }
}
