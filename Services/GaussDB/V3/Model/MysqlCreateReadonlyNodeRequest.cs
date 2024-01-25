using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 只读节点信息
    /// </summary>
    public class MysqlCreateReadonlyNodeRequest 
    {

        /// <summary>
        /// 指定创建的只读节点故障倒换优先级。  故障倒换优先级的取值范围为1~16，数字越小，优先级越大，即故障倒换时，主节点会优先倒换到优先级高的只读节点上，优先级相同的只读节点选为主节点的概率相同。最多支持9个只读节点设置故障倒换优先级，超过9个的只读节点优先级默认为-1，表示不会参与倒换。可通过修改节点的故障倒换优先级来进行调整。
        /// </summary>
        [JsonProperty("priorities", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Priorities { get; set; }

        /// <summary>
        /// 创建包周期时可指定，表示是否自动从客户的账户中支付，此字段不影响自动续订的支付方式。  - true，为自动支付，默认该方式。 - false，为手动支付。
        /// </summary>
        [JsonProperty("is_auto_pay", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAutoPay { get; set; }

        /// <summary>
        /// 可用区。可指定可用区创建只读节点，不传该参数时默认为自动选择可用区。  调用[查询数据库规格](https://support.huaweicloud.com/api-gaussdbformysql/ShowGaussMySqlFlavors.html)获取，其中az_status中的key为availability_zone。  注：指定可用区创建只读节点，可能由于资源不足创建失败。
        /// </summary>
        [JsonProperty("availability_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZones { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlCreateReadonlyNodeRequest {\n");
            sb.Append("  priorities: ").Append(Priorities).Append("\n");
            sb.Append("  isAutoPay: ").Append(IsAutoPay).Append("\n");
            sb.Append("  availabilityZones: ").Append(AvailabilityZones).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlCreateReadonlyNodeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlCreateReadonlyNodeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Priorities == input.Priorities ||
                    this.Priorities != null &&
                    input.Priorities != null &&
                    this.Priorities.SequenceEqual(input.Priorities)
                ) && 
                (
                    this.IsAutoPay == input.IsAutoPay ||
                    (this.IsAutoPay != null &&
                    this.IsAutoPay.Equals(input.IsAutoPay))
                ) && 
                (
                    this.AvailabilityZones == input.AvailabilityZones ||
                    this.AvailabilityZones != null &&
                    input.AvailabilityZones != null &&
                    this.AvailabilityZones.SequenceEqual(input.AvailabilityZones)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Priorities != null)
                    hashCode = hashCode * 59 + this.Priorities.GetHashCode();
                if (this.IsAutoPay != null)
                    hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                if (this.AvailabilityZones != null)
                    hashCode = hashCode * 59 + this.AvailabilityZones.GetHashCode();
                return hashCode;
            }
        }
    }
}
