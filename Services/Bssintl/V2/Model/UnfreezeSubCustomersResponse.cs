using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UnfreezeSubCustomersResponse : SdkResponse
    {

        /// <summary>
        /// 错误原因，只有部分失败的时候才返回。 具体请参见表1。
        /// </summary>
        [JsonProperty("error_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomerErrorDetail> ErrorDetails { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnfreezeSubCustomersResponse {\n");
            sb.Append("  errorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UnfreezeSubCustomersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UnfreezeSubCustomersResponse input)
        {
            if (input == null) return false;
            if (this.ErrorDetails != input.ErrorDetails || (this.ErrorDetails != null && input.ErrorDetails != null && !this.ErrorDetails.SequenceEqual(input.ErrorDetails))) return false;

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
                if (this.ErrorDetails != null) hashCode = hashCode * 59 + this.ErrorDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}
