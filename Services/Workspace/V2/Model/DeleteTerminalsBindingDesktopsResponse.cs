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
    /// Response Object
    /// </summary>
    public class DeleteTerminalsBindingDesktopsResponse : SdkResponse
    {

        /// <summary>
        /// 需删除的策略ID列表
        /// </summary>
        [JsonProperty("result_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DeleteTerminalsBindingDesktopsResult> ResultList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteTerminalsBindingDesktopsResponse {\n");
            sb.Append("  resultList: ").Append(ResultList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteTerminalsBindingDesktopsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteTerminalsBindingDesktopsResponse input)
        {
            if (input == null) return false;
            if (this.ResultList != input.ResultList || (this.ResultList != null && input.ResultList != null && !this.ResultList.SequenceEqual(input.ResultList))) return false;

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
                if (this.ResultList != null) hashCode = hashCode * 59 + this.ResultList.GetHashCode();
                return hashCode;
            }
        }
    }
}
