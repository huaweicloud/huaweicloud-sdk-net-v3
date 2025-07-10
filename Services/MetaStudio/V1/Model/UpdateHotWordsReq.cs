using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 修改热词记录请求。
    /// </summary>
    public class UpdateHotWordsReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hot_words_type", NullValueHandling = NullValueHandling.Ignore)]
        public HotWordsTypeEnum HotWordsType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sis_hot_words", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateSisHotWords SisHotWords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mobvoi_hot_words", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateMobvoiHotWords MobvoiHotWords { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateHotWordsReq {\n");
            sb.Append("  hotWordsType: ").Append(HotWordsType).Append("\n");
            sb.Append("  sisHotWords: ").Append(SisHotWords).Append("\n");
            sb.Append("  mobvoiHotWords: ").Append(MobvoiHotWords).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateHotWordsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateHotWordsReq input)
        {
            if (input == null) return false;
            if (this.HotWordsType != input.HotWordsType) return false;
            if (this.SisHotWords != input.SisHotWords || (this.SisHotWords != null && !this.SisHotWords.Equals(input.SisHotWords))) return false;
            if (this.MobvoiHotWords != input.MobvoiHotWords || (this.MobvoiHotWords != null && !this.MobvoiHotWords.Equals(input.MobvoiHotWords))) return false;

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
                hashCode = hashCode * 59 + this.HotWordsType.GetHashCode();
                if (this.SisHotWords != null) hashCode = hashCode * 59 + this.SisHotWords.GetHashCode();
                if (this.MobvoiHotWords != null) hashCode = hashCode * 59 + this.MobvoiHotWords.GetHashCode();
                return hashCode;
            }
        }
    }
}
