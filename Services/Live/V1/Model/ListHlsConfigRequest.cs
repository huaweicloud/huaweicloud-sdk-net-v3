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
    /// Request Object
    /// </summary>
    public class ListHlsConfigRequest 
    {

        /// <summary>
        /// 推流域名
        /// </summary>
        [SDKProperty("push_domain", IsQuery = true)]
        [JsonProperty("push_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PushDomain { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHlsConfigRequest {\n");
            sb.Append("  pushDomain: ").Append(PushDomain).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHlsConfigRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHlsConfigRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PushDomain == input.PushDomain ||
                    (this.PushDomain != null &&
                    this.PushDomain.Equals(input.PushDomain))
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
                if (this.PushDomain != null)
                    hashCode = hashCode * 59 + this.PushDomain.GetHashCode();
                return hashCode;
            }
        }
    }
}
