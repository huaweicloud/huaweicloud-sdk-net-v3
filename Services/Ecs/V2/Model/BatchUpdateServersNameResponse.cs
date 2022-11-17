using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchUpdateServersNameResponse : SdkResponse
    {

        /// <summary>
        /// 提交请求成功后返回的响应列表。
        /// </summary>
        [JsonProperty("response", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerId> Response { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateServersNameResponse {\n");
            sb.Append("  response: ").Append(Response).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateServersNameResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateServersNameResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Response == input.Response ||
                    this.Response != null &&
                    input.Response != null &&
                    this.Response.SequenceEqual(input.Response)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Response != null)
                    hashCode = hashCode * 59 + this.Response.GetHashCode();
                return hashCode;
            }
        }
    }
}
