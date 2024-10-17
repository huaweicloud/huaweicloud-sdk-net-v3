using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateHlsConfigResponse : SdkResponse
    {

        /// <summary>
        /// 推流域名
        /// </summary>
        [JsonProperty("push_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PushDomain { get; set; }

        /// <summary>
        /// 推流域名APP配置
        /// </summary>
        [JsonProperty("application", NullValueHandling = NullValueHandling.Ignore)]
        public List<PushDomainApplication> Application { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateHlsConfigResponse {\n");
            sb.Append("  pushDomain: ").Append(PushDomain).Append("\n");
            sb.Append("  application: ").Append(Application).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateHlsConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateHlsConfigResponse input)
        {
            if (input == null) return false;
            if (this.PushDomain != input.PushDomain || (this.PushDomain != null && !this.PushDomain.Equals(input.PushDomain))) return false;
            if (this.Application != input.Application || (this.Application != null && input.Application != null && !this.Application.SequenceEqual(input.Application))) return false;

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
                if (this.PushDomain != null) hashCode = hashCode * 59 + this.PushDomain.GetHashCode();
                if (this.Application != null) hashCode = hashCode * 59 + this.Application.GetHashCode();
                return hashCode;
            }
        }
    }
}
