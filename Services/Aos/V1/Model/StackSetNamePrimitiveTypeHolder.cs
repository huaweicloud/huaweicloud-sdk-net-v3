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
    public class StackSetNamePrimitiveTypeHolder 
    {

        /// <summary>
        /// 资源栈集（stack_set）的名字。此名字在domain_id+region下应唯一，可以使用中文、大小写英文、数字、下划线、中划线。首字符需为中文或者英文，区分大小写。
        /// </summary>
        [JsonProperty("stack_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StackSetName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StackSetNamePrimitiveTypeHolder {\n");
            sb.Append("  stackSetName: ").Append(StackSetName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StackSetNamePrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StackSetNamePrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StackSetName == input.StackSetName ||
                    (this.StackSetName != null &&
                    this.StackSetName.Equals(input.StackSetName))
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
                if (this.StackSetName != null)
                    hashCode = hashCode * 59 + this.StackSetName.GetHashCode();
                return hashCode;
            }
        }
    }
}
