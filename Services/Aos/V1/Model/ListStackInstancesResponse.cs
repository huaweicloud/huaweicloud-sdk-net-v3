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
    /// Response Object
    /// </summary>
    public class ListStackInstancesResponse : SdkResponse
    {

        /// <summary>
        /// 资源栈实例列表
        /// </summary>
        [JsonProperty("stack_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<StackInstance> StackInstances { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStackInstancesResponse {\n");
            sb.Append("  stackInstances: ").Append(StackInstances).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStackInstancesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStackInstancesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StackInstances == input.StackInstances ||
                    this.StackInstances != null &&
                    input.StackInstances != null &&
                    this.StackInstances.SequenceEqual(input.StackInstances)
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
                if (this.StackInstances != null)
                    hashCode = hashCode * 59 + this.StackInstances.GetHashCode();
                return hashCode;
            }
        }
    }
}
