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
        /// 
        /// </summary>
        [SDKProperty("Content-Type", IsHeader = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("include_failure", IsQuery = true)]
        public bool? IncludeFailure { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNumberOfInstancesInDifferentStatusRequest {\n");
            sb.Append("  contentType: ").Append(ContentType).Append("\n");
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
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
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
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.IncludeFailure != null)
                    hashCode = hashCode * 59 + this.IncludeFailure.GetHashCode();
                return hashCode;
            }
        }
    }
}
