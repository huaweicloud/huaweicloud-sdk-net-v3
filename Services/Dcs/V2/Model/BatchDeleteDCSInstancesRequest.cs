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
    public class BatchDeleteDCSInstancesRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("all_failure", IsQuery = true)]
        [JsonProperty("all_failure", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllFailure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public BatchDeleteBody Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteDCSInstancesRequest {\n");
            sb.Append("  allFailure: ").Append(AllFailure).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteDCSInstancesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteDCSInstancesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllFailure == input.AllFailure ||
                    (this.AllFailure != null &&
                    this.AllFailure.Equals(input.AllFailure))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.AllFailure != null)
                    hashCode = hashCode * 59 + this.AllFailure.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
