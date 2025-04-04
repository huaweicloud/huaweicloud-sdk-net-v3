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
    /// 创建东西向防火墙body体
    /// </summary>
    public class CreateEastWestFirewallRequestBody 
    {

        /// <summary>
        /// 出方向关联ER ID,可通过ER服务查询企业路由器列表接口获得，返回值中instances.id即为erid（.表示各对象之间层级的区分）
        /// </summary>
        [JsonProperty("er_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ErId { get; set; }

        /// <summary>
        /// 创建引流VPC时使用的网段
        /// </summary>
        [JsonProperty("inspection_cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string InspectionCidr { get; set; }

        /// <summary>
        /// 东西向防火墙模式，填写er
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateEastWestFirewallRequestBody {\n");
            sb.Append("  erId: ").Append(ErId).Append("\n");
            sb.Append("  inspectionCidr: ").Append(InspectionCidr).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateEastWestFirewallRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateEastWestFirewallRequestBody input)
        {
            if (input == null) return false;
            if (this.ErId != input.ErId || (this.ErId != null && !this.ErId.Equals(input.ErId))) return false;
            if (this.InspectionCidr != input.InspectionCidr || (this.InspectionCidr != null && !this.InspectionCidr.Equals(input.InspectionCidr))) return false;
            if (this.Mode != input.Mode || (this.Mode != null && !this.Mode.Equals(input.Mode))) return false;

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
                if (this.ErId != null) hashCode = hashCode * 59 + this.ErId.GetHashCode();
                if (this.InspectionCidr != null) hashCode = hashCode * 59 + this.InspectionCidr.GetHashCode();
                if (this.Mode != null) hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }
    }
}
