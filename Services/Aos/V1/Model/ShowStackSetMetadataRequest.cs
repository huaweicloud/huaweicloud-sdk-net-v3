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
    /// Request Object
    /// </summary>
    public class ShowStackSetMetadataRequest 
    {

        /// <summary>
        /// 用户指定的，对于此请求的唯一ID，用于定位某个请求，推荐使用UUID
        /// </summary>
        [SDKProperty("Client-Request-Id", IsHeader = true)]
        [JsonProperty("Client-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// 资源栈集的名称。此名字在domain_id+region下应唯一，可以使用中文、大小写英文、数字、下划线、中划线。首字符需为中文或者英文，区分大小写。
        /// </summary>
        [SDKProperty("stack_set_name", IsPath = true)]
        [JsonProperty("stack_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StackSetName { get; set; }

        /// <summary>
        /// 资源栈集（stack_set）的唯一ID。  此ID由资源编排服务在生成资源栈集的时候生成，为UUID。  由于资源栈集名称仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的资源栈集，删除，再重新创建一个同名资源栈集。  对于团队并行开发，用户可能希望确保，当前我操作的资源栈集就是我认为的那个，而不是其他队友删除后创建的同名资源栈集。因此，使用ID就可以做到强匹配。  资源编排服务保证每次创建的资源栈集所对应的ID都不相同，更新不会影响ID。如果给与的stack_set_id和当前资源栈集的ID不一致，则返回400
        /// </summary>
        [SDKProperty("stack_set_id", IsQuery = true)]
        [JsonProperty("stack_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackSetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStackSetMetadataRequest {\n");
            sb.Append("  clientRequestId: ").Append(ClientRequestId).Append("\n");
            sb.Append("  stackSetName: ").Append(StackSetName).Append("\n");
            sb.Append("  stackSetId: ").Append(StackSetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStackSetMetadataRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStackSetMetadataRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientRequestId == input.ClientRequestId ||
                    (this.ClientRequestId != null &&
                    this.ClientRequestId.Equals(input.ClientRequestId))
                ) && 
                (
                    this.StackSetName == input.StackSetName ||
                    (this.StackSetName != null &&
                    this.StackSetName.Equals(input.StackSetName))
                ) && 
                (
                    this.StackSetId == input.StackSetId ||
                    (this.StackSetId != null &&
                    this.StackSetId.Equals(input.StackSetId))
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
                if (this.ClientRequestId != null)
                    hashCode = hashCode * 59 + this.ClientRequestId.GetHashCode();
                if (this.StackSetName != null)
                    hashCode = hashCode * 59 + this.StackSetName.GetHashCode();
                if (this.StackSetId != null)
                    hashCode = hashCode * 59 + this.StackSetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
