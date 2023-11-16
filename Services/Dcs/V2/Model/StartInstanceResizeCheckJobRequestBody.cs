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
    /// 规格变更前置检查任务检查请求体
    /// </summary>
    public class StartInstanceResizeCheckJobRequestBody 
    {

        /// <summary>
        /// 新规格的容量，单位GB
        /// </summary>
        [JsonProperty("new_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewCapacity { get; set; }

        /// <summary>
        /// 新的规格编码
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartInstanceResizeCheckJobRequestBody {\n");
            sb.Append("  newCapacity: ").Append(NewCapacity).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartInstanceResizeCheckJobRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StartInstanceResizeCheckJobRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewCapacity == input.NewCapacity ||
                    (this.NewCapacity != null &&
                    this.NewCapacity.Equals(input.NewCapacity))
                ) && 
                (
                    this.SpecCode == input.SpecCode ||
                    (this.SpecCode != null &&
                    this.SpecCode.Equals(input.SpecCode))
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
                if (this.NewCapacity != null)
                    hashCode = hashCode * 59 + this.NewCapacity.GetHashCode();
                if (this.SpecCode != null)
                    hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
