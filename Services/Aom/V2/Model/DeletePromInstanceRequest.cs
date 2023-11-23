using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeletePromInstanceRequest 
    {

        /// <summary>
        /// 普罗实例id。
        /// </summary>
        [SDKProperty("prom_id", IsQuery = true)]
        [JsonProperty("prom_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PromId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeletePromInstanceRequest {\n");
            sb.Append("  promId: ").Append(PromId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeletePromInstanceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeletePromInstanceRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PromId == input.PromId ||
                    (this.PromId != null &&
                    this.PromId.Equals(input.PromId))
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
                if (this.PromId != null)
                    hashCode = hashCode * 59 + this.PromId.GetHashCode();
                return hashCode;
            }
        }
    }
}
