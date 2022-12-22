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
    public class ExecutionPlanSummary 
    {

        /// <summary>
        /// 新增资源数
        /// </summary>
        [JsonProperty("resource_add", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceAdd { get; set; }

        /// <summary>
        /// 更新资源数
        /// </summary>
        [JsonProperty("resource_update", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceUpdate { get; set; }

        /// <summary>
        /// 删除资源数
        /// </summary>
        [JsonProperty("resource_delete", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceDelete { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecutionPlanSummary {\n");
            sb.Append("  resourceAdd: ").Append(ResourceAdd).Append("\n");
            sb.Append("  resourceUpdate: ").Append(ResourceUpdate).Append("\n");
            sb.Append("  resourceDelete: ").Append(ResourceDelete).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecutionPlanSummary);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecutionPlanSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceAdd == input.ResourceAdd ||
                    (this.ResourceAdd != null &&
                    this.ResourceAdd.Equals(input.ResourceAdd))
                ) && 
                (
                    this.ResourceUpdate == input.ResourceUpdate ||
                    (this.ResourceUpdate != null &&
                    this.ResourceUpdate.Equals(input.ResourceUpdate))
                ) && 
                (
                    this.ResourceDelete == input.ResourceDelete ||
                    (this.ResourceDelete != null &&
                    this.ResourceDelete.Equals(input.ResourceDelete))
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
                if (this.ResourceAdd != null)
                    hashCode = hashCode * 59 + this.ResourceAdd.GetHashCode();
                if (this.ResourceUpdate != null)
                    hashCode = hashCode * 59 + this.ResourceUpdate.GetHashCode();
                if (this.ResourceDelete != null)
                    hashCode = hashCode * 59 + this.ResourceDelete.GetHashCode();
                return hashCode;
            }
        }
    }
}
