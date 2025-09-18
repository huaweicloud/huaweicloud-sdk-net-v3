using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ga.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class UpdateAcceleratorRequest 
    {

        /// <summary>
        /// 全球加速器ID。
        /// </summary>
        [SDKProperty("accelerator_id", IsPath = true)]
        [JsonProperty("accelerator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateAcceleratorRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAcceleratorRequest {\n");
            sb.Append("  acceleratorId: ").Append(AcceleratorId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAcceleratorRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAcceleratorRequest input)
        {
            if (input == null) return false;
            if (this.AcceleratorId != input.AcceleratorId || (this.AcceleratorId != null && !this.AcceleratorId.Equals(input.AcceleratorId))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.AcceleratorId != null) hashCode = hashCode * 59 + this.AcceleratorId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
