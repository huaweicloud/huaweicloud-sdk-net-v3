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
    /// 新增ak-sk入参。
    /// </summary>
    public class CreateAkskModel 
    {

        /// <summary>
        /// 描述信息。
        /// </summary>
        [JsonProperty("descp", NullValueHandling = NullValueHandling.Ignore)]
        public string Descp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAkskModel {\n");
            sb.Append("  descp: ").Append(Descp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAkskModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAkskModel input)
        {
            if (input == null) return false;
            if (this.Descp != input.Descp || (this.Descp != null && !this.Descp.Equals(input.Descp))) return false;

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
                if (this.Descp != null) hashCode = hashCode * 59 + this.Descp.GetHashCode();
                return hashCode;
            }
        }
    }
}
