using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Rest请求的响应结果body
    /// </summary>
    public class RestResponse 
    {

        /// <summary>
        /// 结果码。
        /// </summary>
        [JsonProperty("returnCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReturnCode { get; set; }

        /// <summary>
        /// 结果描述。
        /// </summary>
        [JsonProperty("returnDesc", NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnDesc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestResponse {\n");
            sb.Append("  returnCode: ").Append(ReturnCode).Append("\n");
            sb.Append("  returnDesc: ").Append(ReturnDesc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestResponse input)
        {
            if (input == null) return false;
            if (this.ReturnCode != input.ReturnCode || (this.ReturnCode != null && !this.ReturnCode.Equals(input.ReturnCode))) return false;
            if (this.ReturnDesc != input.ReturnDesc || (this.ReturnDesc != null && !this.ReturnDesc.Equals(input.ReturnDesc))) return false;

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
                if (this.ReturnCode != null) hashCode = hashCode * 59 + this.ReturnCode.GetHashCode();
                if (this.ReturnDesc != null) hashCode = hashCode * 59 + this.ReturnDesc.GetHashCode();
                return hashCode;
            }
        }
    }
}
