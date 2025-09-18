using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowUserPrivilegesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**:  请求成功、失败状态。 **取值范围**: success: 请求成功。 error: 请求失败。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**:  请求id，当前请求唯一标识。 **取值范围**: 数字及中划线(-)组成的字符串。 
        /// </summary>
        [JsonProperty("traceId", NullValueHandling = NullValueHandling.Ignore)]
        public string TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public PrivilegesResponseResult Result { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowUserPrivilegesResponse {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  traceId: ").Append(TraceId).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowUserPrivilegesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUserPrivilegesResponse input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.TraceId != input.TraceId || (this.TraceId != null && !this.TraceId.Equals(input.TraceId))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TraceId != null) hashCode = hashCode * 59 + this.TraceId.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                return hashCode;
            }
        }
    }
}
