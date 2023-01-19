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
    /// 修改设备影子预期数据结构体。
    /// </summary>
    public class UpdateDesireds 
    {

        /// <summary>
        /// **参数说明**：设备影子期望值构体。
        /// </summary>
        [JsonProperty("shadow", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpdateDesired> Shadow { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDesireds {\n");
            sb.Append("  shadow: ").Append(Shadow).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDesireds);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDesireds input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Shadow == input.Shadow ||
                    this.Shadow != null &&
                    input.Shadow != null &&
                    this.Shadow.SequenceEqual(input.Shadow)
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
                if (this.Shadow != null)
                    hashCode = hashCode * 59 + this.Shadow.GetHashCode();
                return hashCode;
            }
        }
    }
}
