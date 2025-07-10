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
    public class CreateTerminalsBindingDesktopsRequestBody 
    {

        /// <summary>
        /// 需要新增的MAC绑定VM策略信息列表。
        /// </summary>
        [JsonProperty("bind_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateTerminalsBindingDesktopsInfo> BindList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTerminalsBindingDesktopsRequestBody {\n");
            sb.Append("  bindList: ").Append(BindList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTerminalsBindingDesktopsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTerminalsBindingDesktopsRequestBody input)
        {
            if (input == null) return false;
            if (this.BindList != input.BindList || (this.BindList != null && input.BindList != null && !this.BindList.SequenceEqual(input.BindList))) return false;

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
                if (this.BindList != null) hashCode = hashCode * 59 + this.BindList.GetHashCode();
                return hashCode;
            }
        }
    }
}
