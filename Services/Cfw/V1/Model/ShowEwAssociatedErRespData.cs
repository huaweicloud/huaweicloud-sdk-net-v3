using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// **参数解释**： 查询VPC间防火墙使用的企业路由器信息返回体 **取值范围**： 不涉及
    /// </summary>
    public class ShowEwAssociatedErRespData 
    {

        /// <summary>
        /// **参数解释**： 企业路由器列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("er_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ErInfo> ErList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowEwAssociatedErRespData {\n");
            sb.Append("  erList: ").Append(ErList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowEwAssociatedErRespData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowEwAssociatedErRespData input)
        {
            if (input == null) return false;
            if (this.ErList != input.ErList || (this.ErList != null && input.ErList != null && !this.ErList.SequenceEqual(input.ErList))) return false;

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
                if (this.ErList != null) hashCode = hashCode * 59 + this.ErList.GetHashCode();
                return hashCode;
            }
        }
    }
}
