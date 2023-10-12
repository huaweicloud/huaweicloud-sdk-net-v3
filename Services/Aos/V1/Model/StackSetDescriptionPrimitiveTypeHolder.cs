using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class StackSetDescriptionPrimitiveTypeHolder 
    {

        /// <summary>
        /// 资源栈集的描述。可用于客户识别自己的资源栈集。
        /// </summary>
        [JsonProperty("stack_set_description", NullValueHandling = NullValueHandling.Ignore)]
        public string StackSetDescription { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StackSetDescriptionPrimitiveTypeHolder {\n");
            sb.Append("  stackSetDescription: ").Append(StackSetDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StackSetDescriptionPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StackSetDescriptionPrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StackSetDescription == input.StackSetDescription ||
                    (this.StackSetDescription != null &&
                    this.StackSetDescription.Equals(input.StackSetDescription))
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
                if (this.StackSetDescription != null)
                    hashCode = hashCode * 59 + this.StackSetDescription.GetHashCode();
                return hashCode;
            }
        }
    }
}
