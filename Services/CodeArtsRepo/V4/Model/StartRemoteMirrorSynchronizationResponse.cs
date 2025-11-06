using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class StartRemoteMirrorSynchronizationResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 同步任务Id。
        /// </summary>
        [JsonProperty("jid", NullValueHandling = NullValueHandling.Ignore)]
        public string Jid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartRemoteMirrorSynchronizationResponse {\n");
            sb.Append("  jid: ").Append(Jid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartRemoteMirrorSynchronizationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StartRemoteMirrorSynchronizationResponse input)
        {
            if (input == null) return false;
            if (this.Jid != input.Jid || (this.Jid != null && !this.Jid.Equals(input.Jid))) return false;

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
                if (this.Jid != null) hashCode = hashCode * 59 + this.Jid.GetHashCode();
                return hashCode;
            }
        }
    }
}
