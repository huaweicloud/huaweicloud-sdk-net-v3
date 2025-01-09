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
    public class ListTerminalsBindingDesktopsResponse : SdkResponse
    {

        /// <summary>
        /// MAC绑定VM信息列表
        /// </summary>
        [JsonProperty("bind_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TerminalsBindingDesktopsInfo> BindList { get; set; }

        /// <summary>
        /// 返回结果总条数
        /// </summary>
        [JsonProperty("total_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTerminalsBindingDesktopsResponse {\n");
            sb.Append("  bindList: ").Append(BindList).Append("\n");
            sb.Append("  totalNum: ").Append(TotalNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTerminalsBindingDesktopsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTerminalsBindingDesktopsResponse input)
        {
            if (input == null) return false;
            if (this.BindList != input.BindList || (this.BindList != null && input.BindList != null && !this.BindList.SequenceEqual(input.BindList))) return false;
            if (this.TotalNum != input.TotalNum || (this.TotalNum != null && !this.TotalNum.Equals(input.TotalNum))) return false;

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
                if (this.TotalNum != null) hashCode = hashCode * 59 + this.TotalNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
