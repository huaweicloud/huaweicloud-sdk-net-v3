using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 是否具有创建应用的权限结果
    /// </summary>
    public class CheckCanCreateResponseBodyResult 
    {

        /// <summary>
        /// 是否具有创建应用的权限
        /// </summary>
        [JsonProperty("creatable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Creatable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckCanCreateResponseBodyResult {\n");
            sb.Append("  creatable: ").Append(Creatable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckCanCreateResponseBodyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckCanCreateResponseBodyResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Creatable == input.Creatable ||
                    (this.Creatable != null &&
                    this.Creatable.Equals(input.Creatable))
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
                if (this.Creatable != null)
                    hashCode = hashCode * 59 + this.Creatable.GetHashCode();
                return hashCode;
            }
        }
    }
}
