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
    /// 修改热点问题请求。
    /// </summary>
    public class UpdateHotQuestionReq 
    {

        /// <summary>
        /// 热点问题。
        /// </summary>
        [JsonProperty("hot_question", NullValueHandling = NullValueHandling.Ignore)]
        public string HotQuestion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateHotQuestionReq {\n");
            sb.Append("  hotQuestion: ").Append(HotQuestion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateHotQuestionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateHotQuestionReq input)
        {
            if (input == null) return false;
            if (this.HotQuestion != input.HotQuestion || (this.HotQuestion != null && !this.HotQuestion.Equals(input.HotQuestion))) return false;

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
                if (this.HotQuestion != null) hashCode = hashCode * 59 + this.HotQuestion.GetHashCode();
                return hashCode;
            }
        }
    }
}
