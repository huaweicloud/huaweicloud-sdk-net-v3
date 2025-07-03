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
    public class DeleteAppResponse : SdkResponse
    {

        /// <summary>
        /// 返回ok的结果，表示删除成功。
        /// </summary>
        [JsonProperty("ok", NullValueHandling = NullValueHandling.Ignore)]
        public string Ok { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAppResponse {\n");
            sb.Append("  ok: ").Append(Ok).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAppResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAppResponse input)
        {
            if (input == null) return false;
            if (this.Ok != input.Ok || (this.Ok != null && !this.Ok.Equals(input.Ok))) return false;

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
                if (this.Ok != null) hashCode = hashCode * 59 + this.Ok.GetHashCode();
                return hashCode;
            }
        }
    }
}
