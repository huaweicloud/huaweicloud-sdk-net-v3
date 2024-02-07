using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListProjectGeipBindingsResponse : SdkResponse
    {

        /// <summary>
        /// geip绑定关系对象
        /// </summary>
        [JsonProperty("geip_bindings", NullValueHandling = NullValueHandling.Ignore)]
        public List<GeipBindingsInternalResp> GeipBindings { get; set; }

        /// <summary>
        /// 本次请求编号
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListProjectGeipBindingsResponse {\n");
            sb.Append("  geipBindings: ").Append(GeipBindings).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListProjectGeipBindingsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListProjectGeipBindingsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GeipBindings == input.GeipBindings ||
                    this.GeipBindings != null &&
                    input.GeipBindings != null &&
                    this.GeipBindings.SequenceEqual(input.GeipBindings)
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
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
                if (this.GeipBindings != null)
                    hashCode = hashCode * 59 + this.GeipBindings.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
