using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 创建交互任务
    /// </summary>
    public class SmartChatJobsReq 
    {

        /// <summary>
        /// 扩展参数，按照Json格式携带。 * city：所在城市 * client_id：客户端ID
        /// </summary>
        [JsonProperty("extend_param", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartChatJobsReq {\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartChatJobsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartChatJobsReq input)
        {
            if (input == null) return false;
            if (this.ExtendParam != input.ExtendParam || (this.ExtendParam != null && !this.ExtendParam.Equals(input.ExtendParam))) return false;

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
                if (this.ExtendParam != null) hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
