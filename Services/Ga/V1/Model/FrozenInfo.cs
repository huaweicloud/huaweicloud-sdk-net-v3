using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ga.V1.Model
{
    /// <summary>
    /// 云服务或资源实例冻结信息。
    /// </summary>
    public class FrozenInfo 
    {

        /// <summary>
        /// 云服务或资源实例状态，取值： - 0：解冻/正常（云服务恢复正常）。 - 1：冻结（资源和数据会保留，但租户无法再正常使用云服务）。 - 2：删除/终止（资源和数据将清除）。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 在冻结/解冻操作下，取值： - 1（默认值）：冻结可释放。 - 2：冻结不可释放。 - 3：冻结后不可续费。
        /// </summary>
        [JsonProperty("effect", NullValueHandling = NullValueHandling.Ignore)]
        public int? Effect { get; set; }

        /// <summary>
        /// 更新云服务状态的业务场景列表，取值： - ARREAR（默认值）：欠费场景。为正常的运营业务场景，包括包周期资源到期、按需资源扣费失败。 - POLICE：公安冻结场景。 - ILLEGAL：违规冻结场景。 - VERIFY：客户未实名认证冻结场景。 - PARTNER：合作伙伴冻结（合作伙伴冻结子客户资源）。
        /// </summary>
        [JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Scene { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FrozenInfo {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  effect: ").Append(Effect).Append("\n");
            sb.Append("  scene: ").Append(Scene).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FrozenInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FrozenInfo input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Effect != input.Effect || (this.Effect != null && !this.Effect.Equals(input.Effect))) return false;
            if (this.Scene != input.Scene || (this.Scene != null && input.Scene != null && !this.Scene.SequenceEqual(input.Scene))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Effect != null) hashCode = hashCode * 59 + this.Effect.GetHashCode();
                if (this.Scene != null) hashCode = hashCode * 59 + this.Scene.GetHashCode();
                return hashCode;
            }
        }
    }
}
