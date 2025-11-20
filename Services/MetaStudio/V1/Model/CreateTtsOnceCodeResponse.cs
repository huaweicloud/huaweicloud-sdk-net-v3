using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateTtsOnceCodeResponse : SdkResponse
    {

        /// <summary>
        /// 获取到的一次性token
        /// </summary>
        [JsonProperty("once_code", NullValueHandling = NullValueHandling.Ignore)]
        public string OnceCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTtsOnceCodeResponse {\n");
            sb.Append("  onceCode: ").Append(OnceCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTtsOnceCodeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTtsOnceCodeResponse input)
        {
            if (input == null) return false;
            if (this.OnceCode != input.OnceCode || (this.OnceCode != null && !this.OnceCode.Equals(input.OnceCode))) return false;

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
                if (this.OnceCode != null) hashCode = hashCode * 59 + this.OnceCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
