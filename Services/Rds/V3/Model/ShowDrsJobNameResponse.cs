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
    /// Response Object
    /// </summary>
    public class ShowDrsJobNameResponse : SdkResponse
    {

        /// <summary>
        /// 参数解释： 任务名字。
        /// </summary>
        [JsonProperty("drs_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DrsName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDrsJobNameResponse {\n");
            sb.Append("  drsName: ").Append(DrsName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDrsJobNameResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDrsJobNameResponse input)
        {
            if (input == null) return false;
            if (this.DrsName != input.DrsName || (this.DrsName != null && !this.DrsName.Equals(input.DrsName))) return false;

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
                if (this.DrsName != null) hashCode = hashCode * 59 + this.DrsName.GetHashCode();
                return hashCode;
            }
        }
    }
}
