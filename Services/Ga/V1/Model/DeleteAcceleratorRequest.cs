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
    public class DeleteAcceleratorRequest 
    {

        /// <summary>
        /// 全球加速器ID。
        /// </summary>
        [SDKProperty("accelerator_id", IsPath = true)]
        [JsonProperty("accelerator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceleratorId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAcceleratorRequest {\n");
            sb.Append("  acceleratorId: ").Append(AcceleratorId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAcceleratorRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAcceleratorRequest input)
        {
            if (input == null) return false;
            if (this.AcceleratorId != input.AcceleratorId || (this.AcceleratorId != null && !this.AcceleratorId.Equals(input.AcceleratorId))) return false;

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
                return hashCode;
            }
        }
    }
}
