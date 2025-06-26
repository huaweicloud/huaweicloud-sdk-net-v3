using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowControlOperateResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("control_operation", NullValueHandling = NullValueHandling.Ignore)]
        public ControlOperation ControlOperation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowControlOperateResponse {\n");
            sb.Append("  controlOperation: ").Append(ControlOperation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowControlOperateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowControlOperateResponse input)
        {
            if (input == null) return false;
            if (this.ControlOperation != input.ControlOperation || (this.ControlOperation != null && !this.ControlOperation.Equals(input.ControlOperation))) return false;

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
                if (this.ControlOperation != null) hashCode = hashCode * 59 + this.ControlOperation.GetHashCode();
                return hashCode;
            }
        }
    }
}
