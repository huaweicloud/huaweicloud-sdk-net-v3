using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDeviceAuthorizersResponse : SdkResponse
    {

        /// <summary>
        /// **参数说明**：自定义鉴权列表。
        /// </summary>
        [JsonProperty("authorizers", NullValueHandling = NullValueHandling.Ignore)]
        public List<DeviceAuthorizerSimple> Authorizers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public Page Page { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDeviceAuthorizersResponse {\n");
            sb.Append("  authorizers: ").Append(Authorizers).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDeviceAuthorizersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDeviceAuthorizersResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Authorizers == input.Authorizers ||
                    this.Authorizers != null &&
                    input.Authorizers != null &&
                    this.Authorizers.SequenceEqual(input.Authorizers)
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
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
                if (this.Authorizers != null)
                    hashCode = hashCode * 59 + this.Authorizers.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                return hashCode;
            }
        }
    }
}
