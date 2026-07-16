using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 委托凭据所属的ServiceAccount归属信息
    /// </summary>
    public class PodIdentitySubject 
    {

        /// <summary>
        /// **参数解释**： ServiceAccount所属的命名空间 **约束限制**： 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// **参数解释：** ServiceAccount名称 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("serviceAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceAccount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PodIdentitySubject {\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  serviceAccount: ").Append(ServiceAccount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PodIdentitySubject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PodIdentitySubject input)
        {
            if (input == null) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.ServiceAccount != input.ServiceAccount || (this.ServiceAccount != null && !this.ServiceAccount.Equals(input.ServiceAccount))) return false;

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
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.ServiceAccount != null) hashCode = hashCode * 59 + this.ServiceAccount.GetHashCode();
                return hashCode;
            }
        }
    }
}
