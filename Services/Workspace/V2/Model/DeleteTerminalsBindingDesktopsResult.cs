using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteTerminalsBindingDesktopsResult 
    {

        /// <summary>
        /// 需删除的策略ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 删除操作的结果码。
        /// </summary>
        [JsonProperty("delete_result_code", NullValueHandling = NullValueHandling.Ignore)]
        public string DeleteResultCode { get; set; }

        /// <summary>
        /// 删除操作的结果信息。
        /// </summary>
        [JsonProperty("delete_result_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string DeleteResultMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteTerminalsBindingDesktopsResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  deleteResultCode: ").Append(DeleteResultCode).Append("\n");
            sb.Append("  deleteResultMsg: ").Append(DeleteResultMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteTerminalsBindingDesktopsResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteTerminalsBindingDesktopsResult input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.DeleteResultCode != input.DeleteResultCode || (this.DeleteResultCode != null && !this.DeleteResultCode.Equals(input.DeleteResultCode))) return false;
            if (this.DeleteResultMsg != input.DeleteResultMsg || (this.DeleteResultMsg != null && !this.DeleteResultMsg.Equals(input.DeleteResultMsg))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DeleteResultCode != null) hashCode = hashCode * 59 + this.DeleteResultCode.GetHashCode();
                if (this.DeleteResultMsg != null) hashCode = hashCode * 59 + this.DeleteResultMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
