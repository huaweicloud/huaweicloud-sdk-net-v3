using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryResourceResultDTO 
    {

        /// <summary>
        /// 唯一标识若携带则以携带为准，企业内保证唯一，否则后台自动生成UUID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 资源类型。 - VMR        - 云会议室 - CONF_CALL  - 会议并发数 - HARD_1080P - 1080P硬终端 - HARD_720P  - 720P硬终端 - SOFT       - 软终端用户数 - ROOM       - 大屏软终端 - LIVE       - 直播推流 - RECORD     - 录播空间 - HARD_THIRD_PARTY - 第三方硬终端帐号 - HUAWEI_VISION -智慧屏 - IDEA_HUB   - ideahub
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 资源标识，比如资源类型为VMR，则该参数为vmrPkgId。
        /// </summary>
        [JsonProperty("typeId", NullValueHandling = NullValueHandling.Ignore)]
        public string TypeId { get; set; }

        /// <summary>
        /// 资源标识对应的回显描述,比如资源类型为VMR，则该参数为vmrPkgName。
        /// </summary>
        [JsonProperty("typeDesc", NullValueHandling = NullValueHandling.Ignore)]
        public string TypeDesc { get; set; }

        /// <summary>
        /// VMR模式。 - 0：个人会议ID - 1：云会议室 - 2：网络研讨会
        /// </summary>
        [JsonProperty("vmrMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? VmrMode { get; set; }

        /// <summary>
        /// 资源数量。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 到期时间,utc时间戳。
        /// </summary>
        [JsonProperty("expireDate", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpireDate { get; set; }

        /// <summary>
        /// 资源对应的订单id。
        /// </summary>
        [JsonProperty("orderId", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 资源状态: - 0：正常 - 1：到期 - 2：停用
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 标识资源是否可以编辑或删除。
        /// </summary>
        [JsonProperty("editable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Editable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryResourceResultDTO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  typeId: ").Append(TypeId).Append("\n");
            sb.Append("  typeDesc: ").Append(TypeDesc).Append("\n");
            sb.Append("  vmrMode: ").Append(VmrMode).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  expireDate: ").Append(ExpireDate).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  editable: ").Append(Editable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryResourceResultDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryResourceResultDTO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.TypeId != input.TypeId || (this.TypeId != null && !this.TypeId.Equals(input.TypeId))) return false;
            if (this.TypeDesc != input.TypeDesc || (this.TypeDesc != null && !this.TypeDesc.Equals(input.TypeDesc))) return false;
            if (this.VmrMode != input.VmrMode || (this.VmrMode != null && !this.VmrMode.Equals(input.VmrMode))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.ExpireDate != input.ExpireDate || (this.ExpireDate != null && !this.ExpireDate.Equals(input.ExpireDate))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Editable != input.Editable || (this.Editable != null && !this.Editable.Equals(input.Editable))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TypeId != null) hashCode = hashCode * 59 + this.TypeId.GetHashCode();
                if (this.TypeDesc != null) hashCode = hashCode * 59 + this.TypeDesc.GetHashCode();
                if (this.VmrMode != null) hashCode = hashCode * 59 + this.VmrMode.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.ExpireDate != null) hashCode = hashCode * 59 + this.ExpireDate.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Editable != null) hashCode = hashCode * 59 + this.Editable.GetHashCode();
                return hashCode;
            }
        }
    }
}
