using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Tms.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DeleteAssociatedResourceRuleResponse : SdkResponse
    {

        /// <summary>
        /// 操作失败的错误信息
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public List<ErrorInfo> Errors { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAssociatedResourceRuleResponse {\n");
            sb.Append("  errors: ").Append(Errors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAssociatedResourceRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAssociatedResourceRuleResponse input)
        {
            if (input == null) return false;
            if (this.Errors != input.Errors || (this.Errors != null && input.Errors != null && !this.Errors.SequenceEqual(input.Errors))) return false;

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
                if (this.Errors != null) hashCode = hashCode * 59 + this.Errors.GetHashCode();
                return hashCode;
            }
        }
    }
}
