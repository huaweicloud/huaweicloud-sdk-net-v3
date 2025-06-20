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
    public class ShowRegisterServiceResponse : SdkResponse
    {

        /// <summary>
        /// 注册服务信息
        /// </summary>
        [JsonProperty("services", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServicesInfo> Services { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRegisterServiceResponse {\n");
            sb.Append("  services: ").Append(Services).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRegisterServiceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRegisterServiceResponse input)
        {
            if (input == null) return false;
            if (this.Services != input.Services || (this.Services != null && input.Services != null && !this.Services.SequenceEqual(input.Services))) return false;

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
                if (this.Services != null) hashCode = hashCode * 59 + this.Services.GetHashCode();
                return hashCode;
            }
        }
    }
}
