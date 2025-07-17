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
    /// 
    /// </summary>
    public class RestCancelSingleRecordCycleConfListReqBody 
    {

        /// <summary>
        /// 待删除的子会议UUID列表。
        /// </summary>
        [JsonProperty("cycleSubConfIDs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CycleSubConfIDs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestCancelSingleRecordCycleConfListReqBody {\n");
            sb.Append("  cycleSubConfIDs: ").Append(CycleSubConfIDs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestCancelSingleRecordCycleConfListReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestCancelSingleRecordCycleConfListReqBody input)
        {
            if (input == null) return false;
            if (this.CycleSubConfIDs != input.CycleSubConfIDs || (this.CycleSubConfIDs != null && input.CycleSubConfIDs != null && !this.CycleSubConfIDs.SequenceEqual(input.CycleSubConfIDs))) return false;

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
                if (this.CycleSubConfIDs != null) hashCode = hashCode * 59 + this.CycleSubConfIDs.GetHashCode();
                return hashCode;
            }
        }
    }
}
