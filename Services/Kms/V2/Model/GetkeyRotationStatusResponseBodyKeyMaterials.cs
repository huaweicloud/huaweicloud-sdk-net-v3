using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GetkeyRotationStatusResponseBodyKeyMaterials 
    {

        /// <summary>
        /// **参数解释：** 密钥材料ID **取值范围：** uuid格式
        /// </summary>
        [JsonProperty("material_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MaterialId { get; set; }

        /// <summary>
        /// **参数解释：** 计费ID **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("charge_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeId { get; set; }

        /// <summary>
        /// **参数解释：** 密钥材料创建时间 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// **参数解释：** 密钥材料过期时间 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("expiration_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationTime { get; set; }

        /// <summary>
        /// **参数解释：** 密钥材料状态 **取值范围：** 0：等待轮转状态；2：启用状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public int? State { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetkeyRotationStatusResponseBodyKeyMaterials {\n");
            sb.Append("  materialId: ").Append(MaterialId).Append("\n");
            sb.Append("  chargeId: ").Append(ChargeId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  expirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetkeyRotationStatusResponseBodyKeyMaterials);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetkeyRotationStatusResponseBodyKeyMaterials input)
        {
            if (input == null) return false;
            if (this.MaterialId != input.MaterialId || (this.MaterialId != null && !this.MaterialId.Equals(input.MaterialId))) return false;
            if (this.ChargeId != input.ChargeId || (this.ChargeId != null && !this.ChargeId.Equals(input.ChargeId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.ExpirationTime != input.ExpirationTime || (this.ExpirationTime != null && !this.ExpirationTime.Equals(input.ExpirationTime))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;

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
                if (this.MaterialId != null) hashCode = hashCode * 59 + this.MaterialId.GetHashCode();
                if (this.ChargeId != null) hashCode = hashCode * 59 + this.ChargeId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ExpirationTime != null) hashCode = hashCode * 59 + this.ExpirationTime.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }
    }
}
