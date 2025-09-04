using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GroupBy 
    {

        /// <summary>
        /// tag：按照成本标签过滤cost_unit：按照成本单元过滤dimension：默认取值
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 如果type为tag，此处取值为tag的key。如果type为cost_unit，此处取值为cost_unit的key。如果type为dimension，此处取值如下：CLOUD_SERVICE_TYPE 产品类型RESOURCE_TYPE 产品ASSOCIATED_ACCOUNT 关联账号（企业主名下的所有企业子账号）REGION_CODE 区域AZ_CODE 可用区ENTERPRISE_PROJECT_ID 企业项目RES_SPEC_CODE 产品规格CHARGING_MODE 计费模式USAGE_TYPE 使用量类型BILL_TYPE 账单大类（billtype，前台需转换billdetailtype）BE_ID 运营实体（beid）PAYER_ACCOUNT_ID 支付账号RESOURCE_ID 资源 
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupBy {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GroupBy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GroupBy input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                return hashCode;
            }
        }
    }
}
