using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListLifeCycleHooksResponse : SdkResponse
    {

        /// <summary>
        /// 生命周期挂钩列表。
        /// </summary>
        [JsonProperty("lifecycle_hooks", NullValueHandling = NullValueHandling.Ignore)]
        public List<LifecycleHookList> LifecycleHooks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLifeCycleHooksResponse {\n");
            sb.Append("  lifecycleHooks: ").Append(LifecycleHooks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListLifeCycleHooksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListLifeCycleHooksResponse input)
        {
            if (input == null) return false;
            if (this.LifecycleHooks != input.LifecycleHooks || (this.LifecycleHooks != null && input.LifecycleHooks != null && !this.LifecycleHooks.SequenceEqual(input.LifecycleHooks))) return false;

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
                if (this.LifecycleHooks != null) hashCode = hashCode * 59 + this.LifecycleHooks.GetHashCode();
                return hashCode;
            }
        }
    }
}
