using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchResizeServersReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resize", NullValueHandling = NullValueHandling.Ignore)]
        public BatchResizeServersOption Resize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchResizeServersReq {\n");
            sb.Append("  resize: ").Append(Resize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchResizeServersReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchResizeServersReq input)
        {
            if (input == null) return false;
            if (this.Resize != input.Resize || (this.Resize != null && !this.Resize.Equals(input.Resize))) return false;

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
                if (this.Resize != null) hashCode = hashCode * 59 + this.Resize.GetHashCode();
                return hashCode;
            }
        }
    }
}
