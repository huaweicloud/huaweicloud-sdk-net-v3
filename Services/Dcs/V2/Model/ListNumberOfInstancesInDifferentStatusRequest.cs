using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListNumberOfInstancesInDifferentStatusRequest 
    {

        /// <summary>
        /// 是否返回创建失败的实例数。   - 当参数值为“true”时，返回的统计包括创建失败的实例数。   - 参数值为“false”或者其他值，返回的统计不包括创建失败的实例数。 
        /// </summary>
        [SDKProperty("include_failure", IsQuery = true)]
        [JsonProperty("include_failure", NullValueHandling = NullValueHandling.Ignore)]
        public string IncludeFailure { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNumberOfInstancesInDifferentStatusRequest {\n");
            sb.Append("  includeFailure: ").Append(IncludeFailure).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNumberOfInstancesInDifferentStatusRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNumberOfInstancesInDifferentStatusRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IncludeFailure == input.IncludeFailure ||
                    (this.IncludeFailure != null &&
                    this.IncludeFailure.Equals(input.IncludeFailure))
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
                if (this.IncludeFailure != null)
                    hashCode = hashCode * 59 + this.IncludeFailure.GetHashCode();
                return hashCode;
            }
        }
    }
}
