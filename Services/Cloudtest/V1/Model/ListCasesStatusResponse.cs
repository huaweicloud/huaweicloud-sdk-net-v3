using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListCasesStatusResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public CommonResponseErrorOfobject Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public QueryCasesStatusResponseV2 Result { get; set; }

        /// <summary>
        /// 状态值，如success、error
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCasesStatusResponse {\n");
            sb.Append("  error: ").Append(Error).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCasesStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCasesStatusResponse input)
        {
            if (input == null) return false;
            if (this.Error != input.Error || (this.Error != null && !this.Error.Equals(input.Error))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.Error != null) hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
