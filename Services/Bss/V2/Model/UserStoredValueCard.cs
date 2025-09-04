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
    public class UserStoredValueCard 
    {

        /// <summary>
        /// 储值卡ID。
        /// </summary>
        [JsonProperty("card_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CardId { get; set; }

        /// <summary>
        /// 储值卡名称。
        /// </summary>
        [JsonProperty("card_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CardName { get; set; }

        /// <summary>
        /// 状态： 1：可使用 2：已用完
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 储值卡面值。
        /// </summary>
        [JsonProperty("face_value", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceValue { get; set; }

        /// <summary>
        /// 储值卡余额。
        /// </summary>
        [JsonProperty("balance", NullValueHandling = NullValueHandling.Ignore)]
        public string Balance { get; set; }

        /// <summary>
        /// 生效时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。
        /// </summary>
        [JsonProperty("effective_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 失效时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserStoredValueCard {\n");
            sb.Append("  cardId: ").Append(CardId).Append("\n");
            sb.Append("  cardName: ").Append(CardName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  faceValue: ").Append(FaceValue).Append("\n");
            sb.Append("  balance: ").Append(Balance).Append("\n");
            sb.Append("  effectiveTime: ").Append(EffectiveTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserStoredValueCard);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserStoredValueCard input)
        {
            if (input == null) return false;
            if (this.CardId != input.CardId || (this.CardId != null && !this.CardId.Equals(input.CardId))) return false;
            if (this.CardName != input.CardName || (this.CardName != null && !this.CardName.Equals(input.CardName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.FaceValue != input.FaceValue || (this.FaceValue != null && !this.FaceValue.Equals(input.FaceValue))) return false;
            if (this.Balance != input.Balance || (this.Balance != null && !this.Balance.Equals(input.Balance))) return false;
            if (this.EffectiveTime != input.EffectiveTime || (this.EffectiveTime != null && !this.EffectiveTime.Equals(input.EffectiveTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;

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
                if (this.CardId != null) hashCode = hashCode * 59 + this.CardId.GetHashCode();
                if (this.CardName != null) hashCode = hashCode * 59 + this.CardName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.FaceValue != null) hashCode = hashCode * 59 + this.FaceValue.GetHashCode();
                if (this.Balance != null) hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.EffectiveTime != null) hashCode = hashCode * 59 + this.EffectiveTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
