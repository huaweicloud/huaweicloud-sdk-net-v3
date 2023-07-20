using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ValidateParaGroupNameResponse : SdkResponse
    {

        /// <summary>
        /// 校验结果。true为已存在，false为不存在。
        /// </summary>
        [JsonProperty("exist", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exist { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateParaGroupNameResponse {\n");
            sb.Append("  exist: ").Append(Exist).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ValidateParaGroupNameResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ValidateParaGroupNameResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Exist == input.Exist ||
                    (this.Exist != null &&
                    this.Exist.Equals(input.Exist))
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
                if (this.Exist != null)
                    hashCode = hashCode * 59 + this.Exist.GetHashCode();
                return hashCode;
            }
        }
    }
}
