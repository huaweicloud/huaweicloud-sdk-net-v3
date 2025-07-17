using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 重命名与会者请求。
    /// </summary>
    public class RestRenamePartReqBody 
    {

        /// <summary>
        /// 与会者标识。 已入会的必须填写该字段。
        /// </summary>
        [JsonProperty("participantID", NullValueHandling = NullValueHandling.Ignore)]
        public string ParticipantID { get; set; }

        /// <summary>
        /// 与会者号码。
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 新名称。
        /// </summary>
        [JsonProperty("newName", NullValueHandling = NullValueHandling.Ignore)]
        public string NewName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestRenamePartReqBody {\n");
            sb.Append("  participantID: ").Append(ParticipantID).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  newName: ").Append(NewName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestRenamePartReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestRenamePartReqBody input)
        {
            if (input == null) return false;
            if (this.ParticipantID != input.ParticipantID || (this.ParticipantID != null && !this.ParticipantID.Equals(input.ParticipantID))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.NewName != input.NewName || (this.NewName != null && !this.NewName.Equals(input.NewName))) return false;

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
                if (this.ParticipantID != null) hashCode = hashCode * 59 + this.ParticipantID.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.NewName != null) hashCode = hashCode * 59 + this.NewName.GetHashCode();
                return hashCode;
            }
        }
    }
}
