using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 创建云日志请求体
    /// </summary>
    public class CreateLogtankRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("logtank", NullValueHandling = NullValueHandling.Ignore)]
        public CreateLogtankOption Logtank { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLogtankRequestBody {\n");
            sb.Append("  logtank: ").Append(Logtank).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateLogtankRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateLogtankRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Logtank == input.Logtank ||
                    (this.Logtank != null &&
                    this.Logtank.Equals(input.Logtank))
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
                if (this.Logtank != null)
                    hashCode = hashCode * 59 + this.Logtank.GetHashCode();
                return hashCode;
            }
        }
    }
}
