using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdatePropertiesResponse : SdkResponse
    {

        /// <summary>
        /// 设备上报的属性执行结果。Json格式，具体格式需要应用和设备约定。
        /// </summary>
        [JsonProperty("response", NullValueHandling = NullValueHandling.Ignore)]
        public Object Response { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePropertiesResponse {\n");
            sb.Append("  response: ").Append(Response).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePropertiesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePropertiesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Response == input.Response ||
                    (this.Response != null &&
                    this.Response.Equals(input.Response))
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
                if (this.Response != null)
                    hashCode = hashCode * 59 + this.Response.GetHashCode();
                return hashCode;
            }
        }
    }
}
