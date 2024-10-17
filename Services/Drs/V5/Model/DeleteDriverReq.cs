using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteDriverReq 
    {

        /// <summary>
        /// jdbc驱动文件列表，列表长度1-20，driver_name的长度5-64，结尾以.jar结尾。
        /// </summary>
        [JsonProperty("driver_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DriverNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteDriverReq {\n");
            sb.Append("  driverNames: ").Append(DriverNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteDriverReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteDriverReq input)
        {
            if (input == null) return false;
            if (this.DriverNames != input.DriverNames || (this.DriverNames != null && input.DriverNames != null && !this.DriverNames.SequenceEqual(input.DriverNames))) return false;

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
                if (this.DriverNames != null) hashCode = hashCode * 59 + this.DriverNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
