using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 强制倒换请求参数对象。
    /// </summary>
    public class FailoverRequest 
    {

        /// <summary>
        /// 是否强制倒换；true：强制倒换；false和默认null为不强制。
        /// </summary>
        [JsonProperty("force", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FailoverRequest {\n");
            sb.Append("  force: ").Append(Force).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FailoverRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FailoverRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Force == input.Force ||
                    (this.Force != null &&
                    this.Force.Equals(input.Force))
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
                if (this.Force != null)
                    hashCode = hashCode * 59 + this.Force.GetHashCode();
                return hashCode;
            }
        }
    }
}
