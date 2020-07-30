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
    /// Request Object
    /// </summary>
    public class ShowLifeCycleHookRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("scaling_group_id", IsPath = true)]
        [JsonProperty("scaling_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("lifecycle_hook_name", IsPath = true)]
        [JsonProperty("lifecycle_hook_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LifecycleHookName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowLifeCycleHookRequest {\n");
            sb.Append("  scalingGroupId: ").Append(ScalingGroupId).Append("\n");
            sb.Append("  lifecycleHookName: ").Append(LifecycleHookName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowLifeCycleHookRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowLifeCycleHookRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScalingGroupId == input.ScalingGroupId ||
                    (this.ScalingGroupId != null &&
                    this.ScalingGroupId.Equals(input.ScalingGroupId))
                ) && 
                (
                    this.LifecycleHookName == input.LifecycleHookName ||
                    (this.LifecycleHookName != null &&
                    this.LifecycleHookName.Equals(input.LifecycleHookName))
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
                if (this.ScalingGroupId != null)
                    hashCode = hashCode * 59 + this.ScalingGroupId.GetHashCode();
                if (this.LifecycleHookName != null)
                    hashCode = hashCode * 59 + this.LifecycleHookName.GetHashCode();
                return hashCode;
            }
        }
    }
}
