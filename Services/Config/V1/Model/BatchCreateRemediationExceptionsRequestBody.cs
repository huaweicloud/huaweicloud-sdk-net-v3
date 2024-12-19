using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 批量创建合规规则修正例外的详情。
    /// </summary>
    public class BatchCreateRemediationExceptionsRequestBody 
    {

        /// <summary>
        /// 批量创建合规规则修正例外的详情。
        /// </summary>
        [JsonProperty("exceptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<RemediationExceptionRequest> Exceptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCreateRemediationExceptionsRequestBody {\n");
            sb.Append("  exceptions: ").Append(Exceptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCreateRemediationExceptionsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCreateRemediationExceptionsRequestBody input)
        {
            if (input == null) return false;
            if (this.Exceptions != input.Exceptions || (this.Exceptions != null && input.Exceptions != null && !this.Exceptions.SequenceEqual(input.Exceptions))) return false;

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
                if (this.Exceptions != null) hashCode = hashCode * 59 + this.Exceptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
