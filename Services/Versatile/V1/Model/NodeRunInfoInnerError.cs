using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Versatile.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NodeRunInfoInnerError 
    {

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonProperty("is_success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_body", NullValueHandling = NullValueHandling.Ignore)]
        public NodeRunInfoInnerErrorErrorBody ErrorBody { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeRunInfoInnerError {\n");
            sb.Append("  isSuccess: ").Append(IsSuccess).Append("\n");
            sb.Append("  errorBody: ").Append(ErrorBody).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeRunInfoInnerError);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeRunInfoInnerError input)
        {
            if (input == null) return false;
            if (this.IsSuccess != input.IsSuccess || (this.IsSuccess != null && !this.IsSuccess.Equals(input.IsSuccess))) return false;
            if (this.ErrorBody != input.ErrorBody || (this.ErrorBody != null && !this.ErrorBody.Equals(input.ErrorBody))) return false;

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
                if (this.IsSuccess != null) hashCode = hashCode * 59 + this.IsSuccess.GetHashCode();
                if (this.ErrorBody != null) hashCode = hashCode * 59 + this.ErrorBody.GetHashCode();
                return hashCode;
            }
        }
    }
}
