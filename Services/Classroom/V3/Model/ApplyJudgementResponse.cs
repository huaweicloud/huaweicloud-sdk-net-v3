using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Classroom.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ApplyJudgementResponse : SdkResponse
    {

        /// <summary>
        /// 判题任务ID
        /// </summary>
        [JsonProperty("judgement_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JudgementId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyJudgementResponse {\n");
            sb.Append("  judgementId: ").Append(JudgementId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplyJudgementResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplyJudgementResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JudgementId == input.JudgementId ||
                    (this.JudgementId != null &&
                    this.JudgementId.Equals(input.JudgementId))
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
                if (this.JudgementId != null)
                    hashCode = hashCode * 59 + this.JudgementId.GetHashCode();
                return hashCode;
            }
        }
    }
}
