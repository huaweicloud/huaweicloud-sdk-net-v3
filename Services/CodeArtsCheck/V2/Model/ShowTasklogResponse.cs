using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowTasklogResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("param_info", NullValueHandling = NullValueHandling.Ignore)]
        public ParamInfo ParamInfo { get; set; }

        /// <summary>
        /// 日志信息
        /// </summary>
        [JsonProperty("log_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<LogInfo> LogInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTasklogResponse {\n");
            sb.Append("  paramInfo: ").Append(ParamInfo).Append("\n");
            sb.Append("  logInfo: ").Append(LogInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTasklogResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTasklogResponse input)
        {
            if (input == null) return false;
            if (this.ParamInfo != input.ParamInfo || (this.ParamInfo != null && !this.ParamInfo.Equals(input.ParamInfo))) return false;
            if (this.LogInfo != input.LogInfo || (this.LogInfo != null && input.LogInfo != null && !this.LogInfo.SequenceEqual(input.LogInfo))) return false;

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
                if (this.ParamInfo != null) hashCode = hashCode * 59 + this.ParamInfo.GetHashCode();
                if (this.LogInfo != null) hashCode = hashCode * 59 + this.LogInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
