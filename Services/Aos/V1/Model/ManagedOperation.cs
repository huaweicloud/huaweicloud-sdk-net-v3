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
    /// 用于定义管理资源栈集操作的一系列属性。
    /// </summary>
    public class ManagedOperation 
    {

        /// <summary>
        /// 资源栈集（stack_set）是否可以并发地创建多个资源栈集操作。该参数作为资源栈集属性，可以通过创建资源栈集API（CreateStackSet）指定，通过更新资源栈集API（UpdateStackSet）更新该参数。  该参数默认为false，资源栈集只允许以串行的方式生成并执行资源栈集操作。同一时刻，资源栈集中只会存在一个处于运行态，即QUEUE_IN_PROGRESS或OPERATION_IN_PROGRESS状态的资源栈集操作，该操作执行完成后，下一个资源栈集操作才允许被创建。  该参数如果设定为true，资源栈集允许并发地生成多个资源栈集操作，执行非冲突操作，并将冲突操作进行排队处理。当冲突操作执行完毕，资源栈集按请求顺序继续执行排队操作。当前同一资源栈集下最多允许创建10个并发的资源栈集操作。  注：冲突操作指资源栈集允许多个操作同时执行的条件下，如果超过一个以上的操作包含了同一资源栈实例，此时在该资源栈实例上的多个操作被称为冲突操作。  当资源栈集状态为OPERATION_IN_PROGRESS时，不允许用户通过更新资源栈集（UpdateStackSet）来更新该参数。  * 当前，一个资源栈集下仅允许同时最多存在10个处于运行态的资源栈集操作*
        /// </summary>
        [JsonProperty("enable_parallel_operation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableParallelOperation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagedOperation {\n");
            sb.Append("  enableParallelOperation: ").Append(EnableParallelOperation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ManagedOperation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ManagedOperation input)
        {
            if (input == null) return false;
            if (this.EnableParallelOperation != input.EnableParallelOperation || (this.EnableParallelOperation != null && !this.EnableParallelOperation.Equals(input.EnableParallelOperation))) return false;

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
                if (this.EnableParallelOperation != null) hashCode = hashCode * 59 + this.EnableParallelOperation.GetHashCode();
                return hashCode;
            }
        }
    }
}
