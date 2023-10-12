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
    public class InitialStackDescriptionPrimitiveTypeHolder 
    {

        /// <summary>
        /// 初始化资源栈描述。可用于客户识别被资源栈集所管理的资源栈。  资源栈集下的资源栈仅在创建时统一使用该描述。客户想要更新初始化资源栈描述，可以通过UpdateStackSet API。  后续更新资源栈集描述将不会同步更新已管理的资源栈描述。
        /// </summary>
        [JsonProperty("initial_stack_description", NullValueHandling = NullValueHandling.Ignore)]
        public string InitialStackDescription { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InitialStackDescriptionPrimitiveTypeHolder {\n");
            sb.Append("  initialStackDescription: ").Append(InitialStackDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InitialStackDescriptionPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InitialStackDescriptionPrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InitialStackDescription == input.InitialStackDescription ||
                    (this.InitialStackDescription != null &&
                    this.InitialStackDescription.Equals(input.InitialStackDescription))
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
                if (this.InitialStackDescription != null)
                    hashCode = hashCode * 59 + this.InitialStackDescription.GetHashCode();
                return hashCode;
            }
        }
    }
}
