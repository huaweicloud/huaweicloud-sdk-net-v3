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
    public class DeleteTerminalsBindingDesktopsRequestBody 
    {

        /// <summary>
        /// 绑定策略ID列表
        /// </summary>
        [JsonProperty("id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IdList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteTerminalsBindingDesktopsRequestBody {\n");
            sb.Append("  idList: ").Append(IdList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteTerminalsBindingDesktopsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteTerminalsBindingDesktopsRequestBody input)
        {
            if (input == null) return false;
            if (this.IdList != input.IdList || (this.IdList != null && input.IdList != null && !this.IdList.SequenceEqual(input.IdList))) return false;

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
                if (this.IdList != null) hashCode = hashCode * 59 + this.IdList.GetHashCode();
                return hashCode;
            }
        }
    }
}
