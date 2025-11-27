using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rfs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteStackEnhancedRequestBody 
    {

        /// <summary>
        /// 资源栈（stack）的唯一ID。  此ID由资源编排服务在生成资源栈的时候生成，为UUID。  由于资源栈名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的资源栈，删除，再重新创建一个同名资源栈。  对于团队并行开发，用户可能希望确保，当前我操作的资源栈就是我认为的那个，而不是其他队友删除后创建的同名资源栈。因此，使用ID就可以做到强匹配。  资源编排服务保证每次创建的资源栈所对应的ID都不相同，更新不会影响ID。如果给予的stack_id和当前资源栈的ID不一致，则返回400
        /// </summary>
        [JsonProperty("stack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackId { get; set; }

        /// <summary>
        /// 删除资源栈是否保留资源的标志位，如果不传默认为false，即默认不保留资源（删除资源栈后会删除资源栈中的资源）  DeleteStackEnhanced API中，如果该参数未在RequestBody中给予，则删除时不会保留资源栈中的资源
        /// </summary>
        [JsonProperty("retain_all_resources", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RetainAllResources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteStackEnhancedRequestBody {\n");
            sb.Append("  stackId: ").Append(StackId).Append("\n");
            sb.Append("  retainAllResources: ").Append(RetainAllResources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteStackEnhancedRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteStackEnhancedRequestBody input)
        {
            if (input == null) return false;
            if (this.StackId != input.StackId || (this.StackId != null && !this.StackId.Equals(input.StackId))) return false;
            if (this.RetainAllResources != input.RetainAllResources || (this.RetainAllResources != null && !this.RetainAllResources.Equals(input.RetainAllResources))) return false;

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
                if (this.StackId != null) hashCode = hashCode * 59 + this.StackId.GetHashCode();
                if (this.RetainAllResources != null) hashCode = hashCode * 59 + this.RetainAllResources.GetHashCode();
                return hashCode;
            }
        }
    }
}
